using System;
using System.Windows.Forms;
using Microsoft.SqlServer.MessageBox;
using PostSharp.Aspects;

namespace Exceptions.Aspects
{
    [Serializable]
    public sealed class ExceptionDialogAttribute : OnExceptionAspect
    {
        private readonly Type exceptionType;

        public ExceptionDialogAttribute()
        {
            exceptionType = typeof (Exception);
        }

        public ExceptionDialogAttribute(Type exceptionType)
        {
            this.exceptionType = exceptionType;
        }

        //Specify Exception Type that will be used in catch block
        public override Type GetExceptionType(System.Reflection.MethodBase method)
        {
            return exceptionType;
        }

        public override void OnException(MethodExecutionArgs eventArgs)
        {
            var emb = new ExceptionMessageBox(
                eventArgs.Exception,
                ExceptionMessageBoxButtons.OK,
                ExceptionMessageBoxSymbol.Error);

            emb.Show(eventArgs.Instance as Form);
            eventArgs.FlowBehavior = FlowBehavior.Continue;
        }
    }
}