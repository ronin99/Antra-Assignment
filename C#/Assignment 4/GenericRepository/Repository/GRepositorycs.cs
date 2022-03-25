using GenericRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Repository
{
    public class GRepositorycs : IRepository<Department>
    {
        List<Department> _list;

        public GRepositorycs()
        {
            _list = new List<Department>();
        }

        public void Add(Department entity)
        {
           _list.Add(entity);
        }

        public IEnumerable<Department> GetAll()
        {
            return _list;
        }

        public Department GetById(int id)
        {
            foreach(Department d in _list)
            {
                if(d.Id == id) { return d; }
                
            }
            return null;
        }

        public void Remove(Department entity)
        {
            Department d = GetById(entity.Id);
            if(d != null) { _list.Remove(d); }
        }

        public void Save(Department entity)
        {
            Department d = GetById(entity.Id);
            if(d != null)
            {
               
                d.Name = entity.Name;
            }
        }
        public void Print()
        {
            foreach(Department d in _list)
            {
                Console.WriteLine($"{d.Id} {d.Name}");
            }
        }
    }
}
