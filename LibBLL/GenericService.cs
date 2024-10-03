using LibDAL;
using System.Collections.Generic;

namespace LibBLL
{
    public class GenericService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> Search(string search)
        {
            return _repository.Search(search);
        }
        public string Name()
        {
            return _repository.Name();
        }
        public T GetById(int id)
        {
            return _repository.GetByID(id);
        }

        public int Add(T entity)
        {
            return _repository.Add(entity);
        }

        public int Update(T entity)
        {
            return _repository.Update(entity);
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }

    }

}
