using GenericRepository.Entities;
using GenericRepository.Repository;
using Generics;

namespace GenericRepository
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IRepository<Department> _repository = new GRepositorycs();
            Department d1 = new Department();
            Department d2 = new Department();
            Department d3 = new Department();
            d1.Id = 1;
            d2.Name = "K";
            d1.Name = "A";
            d2.Id = 2;
            d3.Id = 3;
            d3.Name = "B";

            _repository.Add(d1);
            _repository.Add(d2);
            _repository.Add(d3);
            _repository.Remove(d1);
            _repository.GetAll();
            _repository.Print();
           

        }
    }
}
