using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_DictionaryGeneric
{
    class PhoneBook : Dictionary<int, Contact>
    {
        public void Add(int phone, string fName, string lName)
        {
            this[phone] = new Contact
            {
                FirstName = fName,
                LastName = lName
            };
        }
    }

    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
