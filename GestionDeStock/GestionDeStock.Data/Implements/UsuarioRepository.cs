using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly GestionDeStockContext _stockContext;
        public UsuarioRepository(GestionDeStockContext context) { 
            _stockContext = context;
        }

        public Usuario GetById(int id)
        {
            return _stockContext.Usuarios.FirstOrDefault(usu => usu.UsuarioId == id);
        }
        public Usuario GetUsuarioByNombre(string nombre)
        {
            return _stockContext.Usuarios.FirstOrDefault(u => u.Nombre == nombre);
        }
        public void Add(Usuario usuario)
        {
            _stockContext.Usuarios.Add(usuario);
            _stockContext.SaveChanges();
        }
    }
}
