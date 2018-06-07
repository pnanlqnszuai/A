using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем две строки.
            // Эти строковые переменные ссылаются на одно место в памяти.
            string string1 = "c:\\windows\\system32";
            string string2 = @"c:\windows\system32";


            // Демонстрация того, что ссылки действительно совпадают.
            Console.WriteLine("string1 = " + string1);
            Console.WriteLine("string2 = " + string2);
            Console.WriteLine("Object.ReferenceEqual(string1, string2): {0}", Object.ReferenceEquals(string1, string2));
                     
            // Метод String.Intern() - извлекает системную ссылку на указанный строковой литерал из пула интернирования.
            string stringNew = String.Intern(Console.ReadLine());
            // Сравнение.
            Console.WriteLine("Object.ReferenceEqual(string1, stringNew): {0}", ReferenceEquals(string1, stringNew));

            // -------------------------------------------------------------------------------------

            var builder = new StringBuilder();

            builder.Append("StringBuilder ").Append("является ").Append("очень ... ");

            string build1 = builder.ToString();

            builder.Append("быстрым");

            string build2 = builder.ToString();

            Console.WriteLine(build1);
            Console.WriteLine(build2);

            // Delay.
            Console.ReadKey();
        }
    }
}
