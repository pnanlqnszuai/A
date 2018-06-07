using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ICollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection col1 = new Collection();
            Console.WriteLine("Count: " + col1.Count);

            foreach (var item in col1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));

            GenericCollection<int> col2 = new GenericCollection<int>() { 1, 2, 3 };
            col2.Add(4);
            col2.Add(5);

            col2.Remove(4);

            foreach (var item in col2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
