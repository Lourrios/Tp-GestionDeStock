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
        public LoginUsuario(IPasswordHasher passwordHasher, IUsuarioRepository usuarioRepository) {
            _passwordHasher = passwordHasher;
            _usuarioRepository = usuarioRepository;
        }

        public bool RegistrarUsuario(Usuario usuario, string password) // usuario proveniente del formulario
        {
            if (_usuarioRepository.GetUsuarioByNombre(usuario.Nombre) != null)
            {
                return false;
            }
            
            // genero salt en bytes
            byte[] saltBytes = _passwordHasher.GenerateSalt();
            // hasheo la contraseña + salt
            var passwordHashed= _passwordHasher.GenerateHashPassword(password, saltBytes);
            string base64Salt = Convert.ToBase64String(saltBytes); // salt string a guardar

            // guradando los datos criptograficos
            usuario.Hash = Convert.ToBase64String(passwordHashed);
            usuario.Salt = base64Salt;

            _usuarioRepository.Add(usuario);
            //return "Usuario guardado correctamente.";
            return true;
        }

      
        public int VerificarUsuario(string usuarioNombre, string password) // usuario proveniente del form
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

                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            return 3;

        }
    }
}
