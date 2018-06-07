using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Finalization
{
    public class ResourceWrapper
    {
        ~ResourceWrapper()
        {
            Console.WriteLine("Finalize!!!!!!!!!!!!!!");
            for (int i = 0; i < 1000; i++)
                Console.Write(".");
        }
    }

    class Program
    {
        static void Main()
        {
            ResourceWrapper resource =  // Так как имеется сильная ссылка, сразу финализация не происходит.
                new ResourceWrapper();
            GC.Collect();


            Console.WriteLine("\n\nНажмите любую клавишу для завершения работы");
            Console.WriteLine("и вызова (Деструктора) Finalize() сборщиком мусора");
            Console.WriteLine("для объектов предусматривающих финализацию в AppDomain.");

            Console.WriteLine(resource);
            resource = null;
            // Задержка.
            Console.ReadKey();
        }
    }
}
