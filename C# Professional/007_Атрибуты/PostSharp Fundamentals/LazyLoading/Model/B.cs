using System;
using LazyLoading.Aspects;

namespace LazyLoading.Model
{
    class B
    {
        public B()
        {
            Console.WriteLine("B()");
        }

        [LazyLoad(typeof(A))]
        private A a;

        public A GetA()
        {
            Console.WriteLine("GetA()");
            return a;
        }
    }
}