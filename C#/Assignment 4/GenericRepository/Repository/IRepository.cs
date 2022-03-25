using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Repository
{
     interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Remove(T entity);

        void Save(T entity);

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Print();
    }
}
