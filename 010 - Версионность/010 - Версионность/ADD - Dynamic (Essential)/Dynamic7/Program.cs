using System;

// Динамические типы данных. (Динамические типы в делегатах)

namespace Dynamic
{
    delegate dynamic MyDelegate(dynamic argument);

    class Program
    {
        static dynamic Method(dynamic argument)
        {
            return argument;
        }

        static void Main()
        {
            dynamic myDelegate = new MyDelegate(Method);

            string @string = myDelegate.Invoke("Hello world!");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
