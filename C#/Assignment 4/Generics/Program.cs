namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) { 
            Mystack<int> mstack = new Mystack<int>();
            mstack.push(1);
            mstack.push(2);
            mstack.push(3);
            mstack.push(4);
            Console.WriteLine(mstack.Count());
            
        }
    }
}
