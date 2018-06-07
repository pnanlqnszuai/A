using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // OrderedDictionary - Размещение элементов соответствует порядку их добавления в коллекцию, 
            // что позволяет автоматически сохранять элементы в хронологическом порядке. 

            var emailLookup1 = new OrderedDictionary
                                  {
                                      {"sbishop@contoso.com", "Bishop, Scott"},
                                      {"chess@contoso.com", "Hell, Christian"},
                                      {"djump@contoso.com", "Jump, Dan"}
                                  };

            foreach (DictionaryEntry entry in emailLookup1)
            {
                Console.WriteLine(entry.Value);
            }


            // ListDictionary - Подходит для хранения небольшого количества элементов, 
            // поскольку организована по принципу обычного списка.
            
            var emailLookup2 = new ListDictionary();

            emailLookup2["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup2["chess@contoso.com"] = "Hell, Christian";
            emailLookup2["djump@contoso.com"] = "Jump, Dan";

            foreach (DictionaryEntry entry in emailLookup2)
            {
                Console.WriteLine(entry.Value);
            }

            // HybridDictionary - Рекомендуется к использованию в тех случаях, когда невозможно 
            // определить размер коллекции заранее.

            var emailLookup3 = new HybridDictionary();

            emailLookup3["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup3["chess@contoso.com"] = "Hell, Christian";
            emailLookup3["djump@contoso.com"] = "Jump, Dan";

            foreach (DictionaryEntry entry in emailLookup3)
            {
                Console.WriteLine(entry.Value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
