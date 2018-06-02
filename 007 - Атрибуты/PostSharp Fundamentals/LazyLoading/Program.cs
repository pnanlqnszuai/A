using System;
using System.Diagnostics;
using LazyLoading.Model;

namespace LazyLoading
{
    class Program
    {
        static void Main()
        {
            var b = new B();
            
            var a = b.GetA();

            Debug.Assert(a != null);

            Console.ReadKey();
        }
    }
}
