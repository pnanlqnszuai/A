using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CollectionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection col = new Collection();

            foreach (var item in col)
            {
                Console.WriteLine(item);
            }
        }
    }
}
