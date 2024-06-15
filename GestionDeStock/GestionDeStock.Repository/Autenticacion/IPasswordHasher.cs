using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Autenticacion
{
    public interface IPasswordHasher
    {
        byte[] GenerateHashPassword(string password, byte[] salt);
        string HashPassword2Hex(string password, byte[] salt);
        byte[] GenerateSalt();
    }
}
