using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Коллекция – это класс, предназначенный для группировки связанных объектов, 
            // управления ими и обработки их в циклах.

            // Коллекции стоит применять, если:
            //    - Отдельные элементы используются для одинаковых целей и одинаково важны.
            //    - На момент компиляции число элементов не известно или не зафиксировано.
            //    - Необходима поддержка операции перебора всех элементов.
            //    - Необходима поддержка упорядочивания элементов.
            //    - Необходимо использовать элементы из библиотеки, от которой потребитель ожидает наличия типа коллекции.

            List<int> col1 = new List<int>();
            col1.Add(2);
            col1.Add(4);
            col1.Add(6);
            col1.Add(8);

            foreach (var item in col1)
            {
                Console.WriteLine(item);
            }

            //----------------------------------------------------------------

            List<string> col2 = new List<string>
            {
                "Hello ",
                "World"
            };

            foreach (var item in col2)
            {
                Console.WriteLine(item);
            }

            //----------------------------------------------------------------

            Dictionary<int, string> col3 = new Dictionary<int, string>()
            {
                {1, "John" },
                {2, "Alex" },
                {3, "Sarah" }
            };
            col3.Add(4, "Max");

            foreach (var item in col3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
