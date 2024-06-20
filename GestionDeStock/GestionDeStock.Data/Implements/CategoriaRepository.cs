using GestionDeStock.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Implements
{
    public class CategoriaRespository : ICategoriaRepository
    {
        private readonly GestionDeStockContext _stockContext;
        public CategoriaRespository(GestionDeStockContext context){
            _stockContext = context;   
        }

        public void Add(Categoria categoria)
        {
            _stockContext.Categorias.Add(categoria);
            _stockContext.SaveChanges();
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _stockContext.Categorias.Include("Productos").ToList();
        }

        public Categoria GetById(int id) // verificar
        {
            return _stockContext.Categorias.Where(cat => cat.CategoriaId == id).Include("Productos").FirstOrDefault();
        }
    }
}
