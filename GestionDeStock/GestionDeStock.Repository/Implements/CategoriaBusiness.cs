using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Business.Implements
{
    public class CategoriaBusiness : ICategoriaBusiness
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaBusiness(ICategoriaRepository categoriaRepository) {
            _categoriaRepository = categoriaRepository;
        }
        public void AddCategoria(Categoria categoria)
        {
            _categoriaRepository.Add(categoria);
        }

        public Categoria GetCategoriaById(int id)
        {
            return _categoriaRepository.GetById(id);
        }

        public IEnumerable<Categoria> GetAllCategorias()
        {
            return _categoriaRepository.GetAll();
        }
    }
}
