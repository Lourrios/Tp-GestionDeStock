using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface IUsuarioRepository 
    {
        // agregar metodos espeficos
        Usuario GetById(int id);

        Usuario GetUsuarioByNombre(string nombre);
        void Add(Usuario usuario);
    }
}
