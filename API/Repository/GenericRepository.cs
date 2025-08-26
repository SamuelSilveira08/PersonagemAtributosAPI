using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<T> : IInMemoryRepository<T> where T : class, IEntity
    {

        private static readonly List<T> _repository = new List<T>();

        public static List<T> GetRepository()
        {
            return _repository;
        }

        T IInMemoryRepository<T>.Create(T entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _repository.Add(entity);
            return entity;
        }

        void IInMemoryRepository<T>.DeleteById(string id)
        {
            T toDelete = _repository.Find(e => e.Id == id);
            if (toDelete != null)
            {
                _repository.Remove(toDelete);
                return;
            }
            throw new EntityNotFoundException($"Entity with given Id ({id}) was not found.");
        }

        IEnumerable<T> IInMemoryRepository<T>.GetAll()
        {
            return _repository;
        }

        T IInMemoryRepository<T>.GetById(string id)
        {
            T entity = _repository.Find(e => e.Id == id);
            if(entity != null)
            {
                return entity;
            }
            throw new EntityNotFoundException($"Entity with given Id ({id} was not found.");
        }

        T IInMemoryRepository<T>.Update(T entity)
        {
            int index = _repository.FindIndex(e => e.Id == entity.Id);
            if (index != -1)
            {
                _repository[index] = entity;
                return entity;
            }
            throw new EntityNotFoundException($"Entity with given Id ({entity.Id} was not found.");
        }
    }
}
