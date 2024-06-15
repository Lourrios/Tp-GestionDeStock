using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioBusiness(IUsuarioRepository usuarioRepository) { 
            _usuarioRepository = usuarioRepository;
        }
        public void AddUsuario(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }

        public Usuario GetUsuarioById(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public Usuario GetUsuarioByNombre(string nombre)
        {
            return _usuarioRepository.GetUsuarioByNombre(nombre);
        }
    }
}
