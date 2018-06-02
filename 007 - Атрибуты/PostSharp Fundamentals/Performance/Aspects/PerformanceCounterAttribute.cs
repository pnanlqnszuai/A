using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using PostSharp.Aspects;

namespace Performance.Aspects
{
    [Serializable]
    public sealed class PerformanceCounterAttribute : MethodInterceptionAspect
    {
        private static readonly Dictionary<string, PerformanceCounterAttribute> attributes = new Dictionary<string, PerformanceCounterAttribute>();


        private long elapsedTicks;
        private long hits;

        [NonSerialized]
        private MethodBase method;

        public MethodBase Method { get { return method; } }

        public double ElapsedMilliseconds
        {
            get { return elapsedTicks / (Stopwatch.Frequency / 1000d); }
        }

        public long Hits { get { return hits; } }

        public static IDictionary<string, PerformanceCounterAttribute> Attributes
        {
            get
            {
                return attributes;
            }
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var stopwatch = Stopwatch.StartNew();

            try
            {
                args.Proceed();
            }
            finally
            {
                stopwatch.Stop();
                Interlocked.Add(ref elapsedTicks, stopwatch.ElapsedTicks);
                Interlocked.Increment(ref hits);
            }
        }

        public override void RuntimeInitialize(MethodBase callmethod)
        {
            base.RuntimeInitialize(callmethod);
            this.method = callmethod;
            attributes.Add(callmethod.Name, this);
        }

        public static void ShowPerfomanceData(string methodName)
        {
            var pc = PerformanceCounterAttribute.Attributes[methodName];

            Console.WriteLine("Function was called " + pc.Hits + " time(s) and took " + pc.ElapsedMilliseconds + " msec.");
        }
    }
}