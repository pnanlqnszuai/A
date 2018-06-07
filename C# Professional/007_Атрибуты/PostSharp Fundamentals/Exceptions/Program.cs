using System;
using Exceptions.Aspects;

namespace Exceptions
{
    class Program
    {
        [ExceptionDialog]
        void DoSomethingDangerous()
        {
            var a = new Exception("Inner exception");
            var b = new Exception("Outer exception", a);
            throw b;
        }

        [IgnoreException(typeof(TimeoutException))]
        [ExceptionDialog(typeof(ArgumentException))]
        void DoSomethingDiverse(bool flag)
        {
            if (flag)
            {
                throw new TimeoutException();
            }
            throw new ArgumentException();
        }

        static void Main()
        {
            var p = new Program();

            p.DoSomethingDangerous(); // shows message box

            p.DoSomethingDiverse(true); // ignores

            p.DoSomethingDiverse(false); // shows
        }
    }
}
