using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _24_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("books.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}",
                    xmlReader.NodeType,
                    xmlReader.Name,
                    xmlReader.Value);
            }

            xmlReader.Close();
            //stream.Close();

            // Delay.
            Console.ReadKey();

            // -----------------------------------------------------------------

            var document = new XmlDocument();
            document.Load("books.xml");

            XmlNode root = document.DocumentElement;

            // Напечатает "document.DocumentElement=ListOfBooks"
            Console.WriteLine("document.DocumentElement = {0}", root.LocalName);

            foreach (XmlNode books in root.ChildNodes)
            {
                Console.WriteLine("Found Book:");
                foreach (XmlNode book in books.ChildNodes)
                {
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                }
                Console.WriteLine(new string('-', 40));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
