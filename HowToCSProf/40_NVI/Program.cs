using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_NVI
{
    class MyClass
    {
        public void DoWork()
        {
            Console.WriteLine("Pre do work");
            CoreDoWork();        
        }

        protected virtual void CoreDoWork()
        {
            Console.WriteLine("Do work");
        }
    }

    class Derived : MyClass
    {
        protected override void CoreDoWork()
        {
            Console.WriteLine("New do work");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass ins = new Derived();
            ins.DoWork();
        }
    }
}
