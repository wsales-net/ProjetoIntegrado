using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado.Dados.Repositorios
{

    public interface IBaseRepository<T>
    {
        int Count();
        void Delete(T entity);
        void Evict(T obj);
        IList<T> FindAll(object properties, params Order[] orders);
        IList<T> FindAll(object properties, int firstResult, int maxResults, params Order[] orders);
        IList<T> FindAll<T>(object properties, params Order[] orders);
        T FindOne(object properties);
        T FindOne<T>(object properties);
        IList<T> GetAll(params Order[] orders);
        T GetById(object id);
        void Save(T entity);
        void SaveOrUpdate(T entity);
        void Update(T entity);
    }
}
}
