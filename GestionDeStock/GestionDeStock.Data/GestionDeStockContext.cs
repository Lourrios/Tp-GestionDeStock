using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionDeStock.Data
{
    public class GestionDeStockContext : DbContext
    {
       
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public GestionDeStockContext(DbContextOptions<GestionDeStockContext> options) : base(options)
        {
        }

        public object Include(string v)
        {
            throw new NotImplementedException();
        }
    }        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Compra>().ToTable("Compra"); // el nombre que deseemos
        //}
}
