using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _29_XMLSerialization
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>()
            {
                new Contact { FirstName = "Anakin", LastName = "Skywalker", Age = 48, Phone = "+380221112233", Comment = "I am your father" },
                new Contact { FirstName = "Luke", LastName = "Skywalker", Age = 21, Phone = "+380112233444", Comment = "No-nooooo!!!" },
                new Contact { FirstName = "Obi-Wan", LastName = "Kenobi", Age = 62, Phone = "+380221231212", Comment = "Use the Force" },
                new Contact { FirstName = "Yoda", Age = 920, Phone = "+380455558855", Comment = "Powerful you have become, the dark side I sense in you"  }
            };


            FileStream stream = new FileStream("PhoneBook.xml", FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
            serializer.Serialize(stream, contacts);
            stream.Close();


            stream = new FileStream("PhoneBook", FileMode.OpenOrCreate);
            List<Contact> newContacts = serializer.Deserialize(stream) as List<Contact>;
            Console.WriteLine(newContacts[0].Comment);
        }
    }
}
