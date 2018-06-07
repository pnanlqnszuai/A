using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();

            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            emailLookup.Add("amark@contoso.com", "Alexander Mark");

            foreach (object name in emailLookup)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new string('-', 20));

            foreach (DictionaryEntry name in emailLookup)
            {
                Console.WriteLine(name.Value);
            }

            Console.WriteLine(new string('-', 20));

            foreach (object name in emailLookup.Values)
            {
                Console.WriteLine(name);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
