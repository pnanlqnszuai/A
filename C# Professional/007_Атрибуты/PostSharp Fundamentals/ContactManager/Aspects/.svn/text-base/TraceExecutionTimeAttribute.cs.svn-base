using System;
using System.Diagnostics;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    [Serializable]
    public class TraceExecutionTimeAttribute : OnMethodBoundaryAspect
    {
        /// <summary>
        /// Gets or sets the shortest method execution time (in milliseconds)
        /// that is traced.
        /// Methods executing in time below this threshold are not traced.
        /// </summary>
        /// <value>The threashold.</value>
        public double Threshold { get; set; }

        public override void OnEntry(MethodExecutionEventArgs eventArgs)
        {
            eventArgs.MethodExecutionTag = DateTime.Now;
        }

        public override void OnExit(MethodExecutionEventArgs eventArgs)
        {
            DateTime end = DateTime.Now;
            DateTime start = (DateTime)eventArgs.MethodExecutionTag;
            TimeSpan duration = end - start;

            if (duration.TotalMilliseconds >= Threshold)
            {
                Trace.WriteLine(
                    String.Format("{2} ms took execution of {0}.{1}.",
                                  eventArgs.Method.DeclaringType.FullName,
                                  eventArgs.Method.Name,
                                  (end - start).TotalMilliseconds));
            }
        }
    }
}