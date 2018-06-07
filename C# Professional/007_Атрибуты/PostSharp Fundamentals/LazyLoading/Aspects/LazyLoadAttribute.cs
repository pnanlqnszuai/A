using System;
using PostSharp.Aspects;

namespace LazyLoading.Aspects
{
    [Serializable]
    public sealed class LazyLoadAttribute : LocationInterceptionAspect
    {
        private readonly Type type;

        public LazyLoadAttribute(Type type)
        {
            this.type = type;
        }

        public override void OnGetValue(LocationInterceptionArgs args)
        {
            args.ProceedGetValue();
            if (args.Value != null) return;
            args.SetNewValue(Activator.CreateInstance(type));
            args.ProceedGetValue();
        }
    }
}