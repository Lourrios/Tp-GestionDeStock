using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GestionDeStock.web.Models
{
    public class RegistroViewModel 
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        public string User { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Password)]
        public string SecondPassword { get; set; }
    }
}
