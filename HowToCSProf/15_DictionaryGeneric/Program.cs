using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            dict[3] = "Three";
            dict[4] = "Four";
            dict[1] = "One";
            dict[2] = "Two";
            dict[2] = "Twooooo";
            string str = dict[3];

            foreach (var i in dict)
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }

            Console.WriteLine(new string('-', 25));

            foreach (var value in dict)
            {
                Console.WriteLine(value);
            }

            // ----------------------------------------------------------------------------

            Dictionary<int, Contact> phoneBook = new Dictionary<int, Contact>();
            phoneBook.Add(123456, new Contact { FirstName = "Luk", LastName = "Skywalker" });
            phoneBook.Add(654321, new Contact { FirstName = "Obivan", LastName = "Kenobi" });

            PhoneBook pb = new PhoneBook
            {
                {123123, "Padme", "Amidala" },
                {321321, "Leia", "Organa" }
            };


            foreach (var phone in pb)
            {
                Console.WriteLine(phone);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
