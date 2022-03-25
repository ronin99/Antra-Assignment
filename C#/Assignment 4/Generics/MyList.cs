using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
         List<T> List = new List<T>();
        
        public void Add(T element)
        {
            List.Add(element);
        }

        //public T Remove(int index)
        //{
           
            
        //    return List.RemoveAt(index);

        //}

        public bool Contains(T element)
        {
            return List.Contains(element);
        }

        public void InsertAt(T element, int index)
        {
            List.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            List.RemoveAt(index);
        }

        public T Find(int index)
        {
            T element = List[index];
            return element;
        }

    }
}
