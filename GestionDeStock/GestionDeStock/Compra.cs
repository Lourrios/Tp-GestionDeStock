using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace GestionDeStock
{
    [Table("Compra")]
    public class Compra
    {
        [Key] // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // incremental
        public int CompraId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        [ForeignKey(nameof(Producto))]
        public int ProductoId { get; set; }

        [JsonIgnore]
       
        public Producto? Producto { get; set; }
        public int Cantidad { get; set; }
        [ForeignKey(nameof(Usuario))]
        public int UsuarioId { get; set; }

        [JsonIgnore] 
        public Usuario? Usuario { get; set; }

        
        
    }
}
