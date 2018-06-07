using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    [Serializable]
    public class WaitCursorAttribute : OnMethodBoundaryAspect
    {
        public WaitCursorAttribute()
        {
            this.AspectPriority = 20;
        }
        public override void OnEntry(MethodExecutionEventArgs eventArgs)
        {
            Mouse.SetCursor(Cursors.Wait);
        }

        public override void OnExit(MethodExecutionEventArgs eventArgs)
        {
            Mouse.SetCursor(Cursors.Arrow);
        }
    }
}