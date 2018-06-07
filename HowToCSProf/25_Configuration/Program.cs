using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in ConfigurationManager.AppSettings)
            {
                Console.WriteLine(item + " - " + ConfigurationManager.AppSettings[item]);
            }
            // Delay.
            Console.ReadKey();
        }
    }
}
