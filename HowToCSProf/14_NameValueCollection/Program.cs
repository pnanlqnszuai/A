using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NameValueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var nv = new NameValueCollection
                         {
                             {"Key", "Some Text"},
                             {"Key", "More Text"}
                         };

            foreach (string s in nv.GetValues("Key"))
                Console.WriteLine(s);

            Console.WriteLine(new string('-', 20));

            // Использование индексатора отличается от использования метода Add()
            // Индексатор не добавляет новое значение а заменяет существующее.
            nv["First"] = "1st";
            nv["First"] = "FIRST";

            Console.WriteLine(nv.GetValues("First").Length); // 1

            foreach (string s in nv.GetValues("First"))
                Console.WriteLine(s);

            Console.WriteLine(new string('-', 20));

            // Метод Add добавляет новое значение в коллекцию.
            nv.Add("Second", "2nd");
            nv.Add("Second", "SECOND");
            Console.WriteLine(nv.GetValues("Second").Length); // 2

            foreach (string s in nv.GetValues("Second"))
                Console.WriteLine(s);

            // Delay.
            Console.ReadKey();
        }
    }
}
