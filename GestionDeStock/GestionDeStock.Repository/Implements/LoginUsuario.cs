using GestionDeStock.Business.Autenticacion;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    public class LoginUsuario : ILoginUsuario
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUsuarioRepository _usuarioRepository;
        public LoginUsuario(IPasswordHasher passwordHasher, IUsuarioRepository usuarioRepository)
        {
            _passwordHasher = passwordHasher;
            _usuarioRepository = usuarioRepository;
        }

        public string RegistrarUsuario(Usuario usuario, string password) // usuario proveniente del formulario
        {

            // genero salt en bytes
            byte[] saltBytes = _passwordHasher.GenerateSalt();
            // hasheo la contraseña + salt
            var passwordHashed = _passwordHasher.GenerateHashPassword(password, saltBytes);
            string base64Salt = Convert.ToBase64String(saltBytes); // salt string a guardar

            // guradando los datos criptograficos
            usuario.Hash = Convert.ToBase64String(passwordHashed);
            usuario.Salt = base64Salt;

            _usuarioRepository.Add(usuario);
            return "Usuario guardado correctamente.";
        }

        public bool VerificarUsuario(string usuarioNombre, string password) // usuario proveniente del form
        {
            var usuarioDB = _usuarioRepository.GetUsuarioByNombre(usuarioNombre);
            if (usuarioDB != null)
            {
                // contraseña almacenada
                string passwordDB = usuarioDB.Hash;
                // salt almacenado
                string saltDB = usuarioDB.Salt;
                // lo pasamos a byte[]
                byte[] saltDbBytes = Convert.FromBase64String(saltDB);

                // hasheamos contraseña actual + salto de la base de datos 
                string passwordActualHashed = Convert.ToBase64String(_passwordHasher.GenerateHashPassword(password, saltDbBytes));
                // Compare the entered password hash with the stored hash
                if (passwordActualHashed == passwordDB)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }
    }

}