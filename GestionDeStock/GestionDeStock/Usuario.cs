using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GestionDeStock
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key] // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string? Nombre {  get; set; }
        [JsonIgnore]
        public string? Hash { get; set; }
        [JsonIgnore]
        public string? Salt { get; set; }
        [JsonIgnore]
        public IEnumerable<Compra>? Compras { get; set; }
        [JsonIgnore]
        public IEnumerable<Venta>? Ventas { get; set; }




    }
}
