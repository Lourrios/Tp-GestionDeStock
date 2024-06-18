using GestionDeStock.Data.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class CompraRespository :  ICompraRepository
    {
        private readonly GestionDeStockContext _stockContext;
        public CompraRespository(GestionDeStockContext context) {
            _stockContext = context;        
        }

        public void Add(Compra compra)
        {
            _stockContext.Add(compra);
            _stockContext.SaveChanges();
        }
        public Compra GetById(int id)
        {
            //return _stockContext.Compras.Where(comp => comp.CompraId == id)
            //    .Include(x=> x.Usuario).Include(x=> x.Producto).FirstOrDefault();

            return _stockContext.Compras.Include(c => c.Producto).Include(c => c.Usuario).FirstOrDefault(c => c.CompraId == id);
        }

        public IEnumerable<Compra> GetAllCompras()
        {
            return _stockContext.Compras.Include(c => c.Producto).Include(c => c.Usuario).ToList();
        }

        public( IEnumerable<Compra>, int ) GetComprasPaginado(int paginaIndex,  int paginaTamanio, string textoBusqueda) {
         
            var compras = new List<Compra>();
            var total = 0;

            using (var cmd = _stockContext.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Listar_Compras2";

                cmd.Parameters.Add(new SqlParameter("@PageIndex", paginaIndex));
                cmd.Parameters.Add(new SqlParameter("@PageSize", paginaTamanio));
                cmd.Parameters.Add(new SqlParameter("@SearchText", textoBusqueda ?? (object)DBNull.Value));
                try
                {
                    _stockContext.Database.OpenConnection();
                    
                    using(var result = cmd.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            compras.Add(new Compra
                            {
                                CompraId = result.GetInt32(0),
                                Fecha = result.GetDateTime(1),
                                ProductoId = result.GetInt32(2),
                                Cantidad = result.GetInt32(3),
                                UsuarioId = result.GetInt32(4),
                                Producto = new Producto
                                {
                                    Nombre = result.GetString(result.GetOrdinal("ProductoNombre"))
                                },
                                Usuario = new Usuario
                                {
                                    Nombre = result.GetString(result.GetOrdinal("UsuarioNombre"))
                                }
                            });
                        }
                        if ( result.NextResult())
                        {
                            if ( result.Read())
                            {
                                total = result.GetInt32(0);
                            }
                        }  
                    }
                    return (compras, total);
                }
                catch(SqlException ex)
                {
                    throw new Exception("Error al listar productos");
                }catch(Exception ex) { 
                        throw new Exception("Error de conexion");
                }

            }
             
        }
    }
}
