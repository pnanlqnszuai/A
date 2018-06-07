using System;
using PostSharp.Aspects;
using System.Reflection;

namespace Exceptions.Aspects
{
    [Serializable]
    public sealed class IgnoreExceptionAttribute : OnExceptionAspect
    {
        private Type type;

        public IgnoreExceptionAttribute(Type type)
        {
            this.type = type;
        }

        public override Type GetExceptionType(MethodBase method)
        {
            return type;
        }

        public override void OnException(MethodExecutionArgs eventArgs)
        {
            eventArgs.FlowBehavior = FlowBehavior.Continue;
        }
    }
}