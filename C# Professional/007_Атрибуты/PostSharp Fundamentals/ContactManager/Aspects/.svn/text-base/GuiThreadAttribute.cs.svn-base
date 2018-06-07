using System;
using System.Reflection;
using System.Windows.Threading;
using PostSharp.Extensibility;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    [Serializable]
    public class GuiThreadAttribute : OnMethodInvocationAspect
    {
      public GuiThreadAttribute() : this(DispatcherPriority.Normal, false)
        {
        }

        public GuiThreadAttribute(DispatcherPriority priority, bool async)
        {
            Async = async;
            Priority = priority;
            AspectPriority = 1;
        }

      public DispatcherPriority Priority { get; set; }

      public bool Async { get; set; }

      public override bool CompileTimeValidate(MethodBase method)
        {
            if (!method.IsStatic )
            {
                if (!typeof(DispatcherObject).IsAssignableFrom(method.DeclaringType))
                {
                    MessageSource.MessageSink.Write(new Message(SeverityType.Error,
                                                                "CM00001",
                                                                string.Format(
                                                                    "Cannot apply the [GuiThread] custom attribute to instance methods of type {0} " +
                                                                    "because it is not derived from DispatcherObject.",
                                                                    method.DeclaringType.FullName),
                                                                "GuiThreadAttribute"));
                    return false;
                }
                
            }
            else
            {
                ParameterInfo[] parameters = method.GetParameters();
                if ( parameters.Length < 1 || !typeof(DispatcherObject).IsAssignableFrom(parameters[0].ParameterType) )
                {
                    MessageSource.MessageSink.Write(new Message(SeverityType.Error,
                                                         "CM00002",
                                                         string.Format(
                                                             "Cannot apply the [GuiThread] custom attribute to static method {0} " +
                                                             "because the first parameter is not derived from DispatcherObject.",
                                                             method.DeclaringType.FullName),
                                                         "GuiThreadAttribute"));
                    return false;
                }
            }


            return true;
        }

        public override void OnInvocation(MethodInvocationEventArgs eventArgs)
        {
            DispatcherObject dispatcherObject = (eventArgs.Delegate.Target ?? eventArgs.GetArgumentArray()[0]) as DispatcherObject;

            if (dispatcherObject != null)
            {
                if (dispatcherObject.CheckAccess())
                {
                    // We are already in the GUI thread. Proceed.
                    eventArgs.Proceed();
                }
                else
                {
                    if (Async)
                    {
                        // Invoke the target method asynchronously (don't wait).
                        dispatcherObject.Dispatcher.BeginInvoke(Priority,
                                                                new Action(() => eventArgs.Proceed()));
                    }
                    else
                    {
                        // Invoke the target method synchronously.  
                        dispatcherObject.Dispatcher.Invoke(
                            Priority,
                            new Action(() => eventArgs.Proceed()));
                    }
                }
            }
            else
            {
                eventArgs.Proceed();
            }
        }
    }
}