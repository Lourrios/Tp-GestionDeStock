using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace GestionDeStock
{
    [Table("Producto")]
    public class Producto
    {
        [Key] // llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId {  get; set; }
        public string? Nombre { get; set; }
        
        public int CategoriaId {  get; set; }
        
        [ForeignKey(nameof(CategoriaId))]
        [JsonIgnore]
        public Categoria? Categoria { get; set; }

        public bool Habilitado {  get; set; }

        public decimal Precio { get; set; }

        

    }
}
