//using GestionDeStock.Data.Interfaces;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GestionDeStock.Data.Implements
//{ // clase gerica que heredaran los demas repositorios
//    public class Repository<T> : IRepository<T> where T : class
//    {
//        protected readonly GestionDeStockContext _stockContext;
//        protected readonly DbSet<T> _dbSet; 
//        public Repository(GestionDeStockContext gestionDeStockContext) { 
//            _stockContext = gestionDeStockContext;
//            _dbSet = _stockContext.Set<T>(); // settea el DbSet con la correspondiente clase
//        }
//        public void Add(T entity)
//        {
//            _dbSet.Add(entity); // agrega a la tabla 
//            _stockContext.SaveChanges(); // confirma cambios
            
//        }

//        public void DeleteById(int id)
//        {
//            var entity = GetById(id);
//            if (entity != null)
//            {
//                _dbSet.Remove(entity);
//                _stockContext.SaveChanges(); // confirma cambios
//            }
//        }

//        public IEnumerable<T> GetAll()
//        {
//           return _dbSet.ToList(); // retorna toda la tabla
//        }

//        public T GetById(int id)
//        {
//            var entity = _dbSet.Find(id);
//            if (entity == null)
//            {
//                throw new Exception("Objeto no encontrado");
//            }
//            return entity;
//        }

//        public void Update( T entity)
//        {
//               _dbSet.Update(entity);  // considera modificados todos los campos 
//        //    _dbSet.Attach(entity); // seguimiento, no cambia el estado de la entidad a modificado 
//        //    _stockContext.Entry(entity).State = EntityState.Modified; 
//            _stockContext.SaveChangesAsync(); // confirma cambios
//        }
//    }
//}
