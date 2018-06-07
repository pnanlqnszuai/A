using System;
using System.Threading;
using Threading.Aspects;

namespace Threading
{
    class Program
    {
        [WorkerThread]
        void Print(char s)
        {
            int i = 300;

            while (i-- > 0)
            {
                Thread.Sleep(10);
                Console.Write(s);
            }
        }

        static void Main()
        {
            var p = new Program();

            p.Print('.');
            p.Print('-');
            p.Print('/');
            Thread.Sleep(4000);
           // Console.ReadKey();
        }
    }
}
