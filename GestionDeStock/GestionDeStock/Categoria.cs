using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestionDeStock
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key] // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }
        public string? Nombre { get; set; }
       [JsonIgnore] // evita ReferenceLoop (bucle de referencia)
        public IEnumerable<Producto>? Productos { get; set; }

       
    }
}
