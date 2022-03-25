using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Mystack<T>
    {
        Stack<T> stack = new Stack<T>();
        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
           return stack.Pop();
        }
        public void push(T n)
        {
            stack.Push(n);
        }

    }
}
