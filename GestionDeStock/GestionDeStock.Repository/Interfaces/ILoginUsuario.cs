﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Interfaces
{
    public interface ILoginUsuario
    {
        bool RegistrarUsuario(Usuario usuario, string password);
        public int VerificarUsuario(string usuario, string password);
    }
}
