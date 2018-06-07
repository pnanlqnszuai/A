using System;
using System.Threading;
using PostSharp.Aspects;

namespace Threading.Aspects
{
    [Serializable]
    public sealed class WorkerThreadAttribute : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs eventArgs)
        {
            ThreadPool.QueueUserWorkItem(state => eventArgs.Proceed());
        }
    }
}