using System;
using System.Threading;
using Performance.Aspects;


namespace Performance
{
    class Program
  {
    [PerformanceCounter]
    static void LongRunningMethod()
    {
      Thread.Sleep(1000);
    }

    static void Main()
    {
        for (int i = 0; i < 2; i++)
        {
            LongRunningMethod();
        }
       
      PerformanceCounterAttribute.ShowPerfomanceData("LongRunningMethod");

      Console.ReadKey();
    }
  }
}

