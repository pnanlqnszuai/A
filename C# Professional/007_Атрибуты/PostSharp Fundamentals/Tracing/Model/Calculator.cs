using System;
using Tracing.Aspects;

namespace Tracing.Model
{

    class Calculator
    {
        [Trace]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}