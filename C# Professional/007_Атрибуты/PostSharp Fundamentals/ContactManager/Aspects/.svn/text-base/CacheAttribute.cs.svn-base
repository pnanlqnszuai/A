using System;
using System.Collections.Generic;
using System.Threading;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    [Serializable]
    public class CacheAttribute : OnMethodInvocationAspect
    {
        static readonly Cache cache = new Cache();
       
        public override void OnInvocation(MethodInvocationEventArgs eventArgs)
        {
            // Compute the cache key.
            string key = Formatter.GetMethodFormatStrings(eventArgs.Delegate.Method)
                .Format(eventArgs.Delegate.Target,
                        eventArgs.Delegate.Method,
                        eventArgs.GetArgumentArray());

            object value;

            if (!cache.TryGetValue(key, out value))
            {
                lock ( this )
                {
                    if (!cache.TryGetValue(key, out value))
                    {
                        eventArgs.Proceed();
                        value = eventArgs.ReturnValue;
                        cache.Add(key, value);
                        return;
                    }
                }
            }

            eventArgs.ReturnValue = value;

        }

      #region Nested type: Cache

      class Cache
        {
        private readonly Dictionary<string, object> dictionary = new Dictionary<string, object>();
        readonly ReaderWriterLockSlim @lock = new ReaderWriterLockSlim();

        public bool TryGetValue( string key, out object value )
            {
                @lock.EnterReadLock();
                bool found = dictionary.TryGetValue(key, out value);
                @lock.ExitReadLock();
                return found;
            }

            public void Add(string key, object value)
            {
                @lock.EnterWriteLock();
                dictionary.Add(key, value);
                @lock.ExitWriteLock();
            }

        }

      #endregion
    }
}
