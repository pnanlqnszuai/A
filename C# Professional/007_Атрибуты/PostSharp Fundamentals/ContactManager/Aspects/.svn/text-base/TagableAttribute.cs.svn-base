using System;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    public interface ITagable
    {
        object Tag { get; set; }
    }

    [Serializable]
    public class TagableAttribute : CompositionAspect
    {
        public override object CreateImplementationObject(InstanceBoundLaosEventArgs eventArgs)
        {
            return new TagableImpl();
        }

        public override Type GetPublicInterface(Type containerType)
        {
            return typeof (ITagable);
        }

      #region Nested type: TagableImpl

      private class TagableImpl : ITagable
        {
        #region ITagable Members

        public object Tag { get; set; }

        #endregion
        }

      #endregion
    }
}
