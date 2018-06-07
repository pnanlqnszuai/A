using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Versioning
{
    class BaseClass
    {
        public virtual void SomeMethods()
        {
            SomeMetod1();
            SomeMetod2();
        }

        public virtual void SomeMetod1()
        {
            Console.Write("1.");
        }

        public virtual void SomeMetod2()
        {
            Console.Write("2.");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void SomeMethods()
        {
            SomeMetod1();
            SomeMetod2();
        }

        public new void SomeMetod1()
        {
            Console.Write("3.");
        }

        public override void SomeMetod2()
        {
            Console.Write("4.");
        }
    }

    class DerivedClassFromDerivedClass : DerivedClass
    {
        public override void SomeMetod2()
        {
            Console.Write("5.");
        }
    }

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите ключ: или 0 или 1 или 2");
                string s = Console.ReadLine();

                if (s == "0") // Версия: 1.2
                    new BaseClass().SomeMethods();

                if (s == "1") // Версия: 3.4
                    (new DerivedClass() as BaseClass).SomeMethods();

                if (s == "2") // Версия: 3.4                
                    new DerivedClass().SomeMethods();

                if (s == "3") // Версия: 3.5               
                    (new DerivedClassFromDerivedClass() as BaseClass).SomeMethods();

                Console.WriteLine("\n");
            }
        }
    }
}
