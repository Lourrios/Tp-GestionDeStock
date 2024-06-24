using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface ILoginUsuario
    {
        //string RegistrarUsuario(Usuario usuario, string password);
        bool RegistrarUsuario(Usuario usuario, string password);
       int VerificarUsuario(string usuario, string password);
        //public string VerificarUsuario(string usuario, string password);
    }
}
