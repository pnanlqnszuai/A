using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new SortedList<string, string>();

            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            emailLookup.Add("amark@contoso.com", "Alexander Mark");

            foreach (object name in emailLookup)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new string('-', 20));

            foreach (KeyValuePair<string, string> name in emailLookup)
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
