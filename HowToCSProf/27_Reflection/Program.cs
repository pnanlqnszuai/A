using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _27_Reflection
{
    class MyClass
    {
        private string field = "123456";

        public string Field
        {
            get { return field; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass();
            Console.WriteLine(instance.Field);

            //instance.Field = "Hello";

            var type = instance.GetType();
            var field = type.GetField("field", BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(instance, "Hello");

            Console.WriteLine(instance.Field);

            // ---------------------------------

            var now = DateTime.Now;

            type = now.GetType();
            var props = type.GetProperties();

            foreach (var p in props)
            {
                Console.WriteLine(p.Name + " - " + p.GetValue(now));
            }
        }
    }
}
