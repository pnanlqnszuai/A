using System;
using System.IO;
using System.Xml;

// Task_1

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 45);

            FileStream stream = new FileStream("TelephoneBook.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}",
                    xmlReader.NodeType,
                    xmlReader.Name,
                    xmlReader.Value);
            }

            xmlReader.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
