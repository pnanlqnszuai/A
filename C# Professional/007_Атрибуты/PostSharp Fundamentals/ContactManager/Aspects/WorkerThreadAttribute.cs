using System;
using System.Threading;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    [Serializable]
    public class WorkerThreadAttribute : OnMethodInvocationAspect
    {
        public WorkerThreadAttribute()
        {
            AspectPriority = 20;
        }

        public override void OnInvocation(MethodInvocationEventArgs eventArgs)
        {
            ThreadPool.QueueUserWorkItem(delegate { eventArgs.Proceed(); });
        }
    }
}