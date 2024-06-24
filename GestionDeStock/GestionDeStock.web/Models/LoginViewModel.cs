using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;

namespace GestionDeStock.web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Nombre de usuario obligatorio")]
        public string User { get; set; }

        [Required(ErrorMessage = "contraseña obligatoria")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
