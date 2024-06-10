using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // interfaz generica con todos lo metodos crud. Útil para cualquier entidad
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void DeleteById(int id);
        void Update(T entity);
    }
}
