using System;
using System.Diagnostics;
using PostSharp.Aspects;

namespace Tracing.Aspects
{
    [Serializable]
    sealed class TraceAttribute : OnMethodBoundaryAspect
    {
        private string fullMethodName;

        public override void OnEntry(MethodExecutionArgs args)
        {
            Trace.WriteLine(String.Format("{0} OnEntry", fullMethodName));
            
            if (args.Arguments.Count > 0)
            {
                foreach (var argument in args.Arguments)
                {
                    Trace.Write("Аргумент: " + argument.GetType() + "=");
                    Trace.WriteLine(argument);
                }
            }
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Trace.WriteLine(String.Format("{0} OnSuccess returns {1}", fullMethodName, args.ReturnValue));
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Trace.WriteLine(String.Format("{0} OnExit", fullMethodName));
        }

        public override void CompileTimeInitialize(System.Reflection.MethodBase method, AspectInfo aspectInfo)
        {
            fullMethodName = string.Format("{0}.{1}",
                      method.DeclaringType.Name, method.Name);
        }
    }
}