using System;
using System.Threading;
using PostSharp.Aspects;

namespace Retry.Aspects
{
    [Serializable]
    public class RetryAttribute : MethodInterceptionAspect
    {
        public int Count { get; set; }
        public int DelayMsec { get; set; }

        public RetryAttribute(int count) : this(count, 0) { }

        public RetryAttribute(int count, int delayMsec)
        {
            Count = count;
            DelayMsec = delayMsec;
        }

        public override void OnInvoke(MethodInterceptionArgs eventArgs)
        {
            for (int a = 0; ; ++a)
            {
                try
                {
                    if (a != 0 && DelayMsec > 0)
                        Thread.Sleep(DelayMsec);
                    eventArgs.Proceed();
                    Console.WriteLine("Succeeded on try " + a);
                    return;
                }
                catch
                {
                    Console.WriteLine("Failed on try " + a);
                    if (a == Count) throw;
                }
            }
        }
    }
}