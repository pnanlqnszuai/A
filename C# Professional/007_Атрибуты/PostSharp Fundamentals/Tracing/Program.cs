using System;
using Tracing.Model;

namespace Tracing
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();

            int result = calculator.Add(1, 2);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
