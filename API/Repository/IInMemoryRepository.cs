using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public interface IInMemoryRepository<T> where T : class, IEntity
    {
        // Define os métodos CRUD básicos
        T Create(T entity);
        T Update(T entity);
        void DeleteById(string id);
        IEnumerable<T> GetAll();
        T GetById(string id);
        
    }
}
