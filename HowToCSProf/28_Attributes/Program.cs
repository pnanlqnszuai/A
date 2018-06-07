using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28_Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
    public class MyAttribute : System.Attribute
    {
        private readonly string text;
        private readonly string data;

        public MyAttribute(string text, string data)
        {
            this.text = text;
            this.data = data;
        }

        public void Method()
        {
            Console.WriteLine("Метод класса Атрибута.");
        }

        public string Text
        {
            get { return text; }
        }

        public string Data
        {
            get { return data; }
        }
    }

    [My("XXX", "1/1/1111")]
    [My("XXX1", "1/1/1111")]
    class BaseClass
    {
        static BaseClass()
        {
            Console.WriteLine("Static");
        }
        public BaseClass()
        {
            Console.WriteLine("Ctor BaseClass!!!");
        }
    }

    [My("Hello!", "31/01/2008")]
    [My("World!", "31/01/2009")]
    class MyClass : BaseClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass ins = new MyClass();

            // MemberInfo - абстрактный класс, используется для получения информации о членах класса. 
            //Type type = typeof(MyClass);
            MemberInfo type = typeof(MyClass);

            // Метод GetCustomAttributes() - возвращает массив объектов, которые при выполнении приложения
            // представляют собой эквиваленты атрибутов, созданных в исходном коде.
            // Извлекаем из элементов массива элементы типа - MyAttribute.
            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);

            // Если в массиве есть соответствующие записи, то первый элемент представляет собой атрибут - MyAttribute.
            if (attributes.GetLength(0) != 0)
            {
                // Отображаем полученные значения.
                foreach (MyAttribute attribute in attributes)
                {
                    Console.WriteLine(attribute.Text);
                    Console.WriteLine(attribute.Data);
                    attribute.Method();
                }
            }

            //Задержка.
            Console.ReadKey();
        }
    }
}
