using System;
using System.Windows;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    [Serializable]
    public class ExceptionDialogAttribute : OnExceptionAspect
    {
        public ExceptionDialogAttribute()
        {
            AspectPriority = 30;
        }

        public override void OnException(MethodExecutionEventArgs eventArgs)
        {
            // Compose the error message. We could do something more complex.
            string message = eventArgs.Exception.Message;

            MessageBoxHelper.Display(eventArgs.Instance as DependencyObject, message);  

            // Ignore the exception.
            eventArgs.FlowBehavior = FlowBehavior.Continue;
        }
    }
}