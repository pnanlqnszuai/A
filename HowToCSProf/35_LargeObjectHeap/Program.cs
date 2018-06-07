using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_LargeObjectHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] obj = new long[100000000];
            
            Console.WriteLine(obj.ToString());


            Console.WriteLine(GC.GetGeneration(obj));
        }
    }
}
