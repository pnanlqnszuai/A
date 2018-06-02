using System;
using Retry.Aspects;

namespace Retry
{
    class Program
  {
    public static Random Rand = new Random();

    [Retry(3, 2000)]
    public static void CanFail()
    {
      if (Rand.Next(2) == 0)
        throw new Exception("I just failed.");
    }

    static void Main()
    {
        try
        {
          CanFail();
        }
        catch
        {
          Console.WriteLine("=== COMPLETELY FAILED ===");
        }
    }
  }
}
