using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface IUsuarioBusiness
    {
        Usuario GetUsuarioById(int id);
        Usuario GetUsuarioByNombre(string nombre);
        void AddUsuario(Usuario usuario);
    }
}
