using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            var listInts = new List<string> { "Ivan", "Petya", "Vasiliy", "Andrey" };
            var linkList = MyFamily<string>.CreateList(listInts);

            foreach (var item in linkList.LinkListIterator())
                Console.Write("{0}, ", item);

            // Задержка.
            Console.ReadKey();
        }
    }

    public interface IFamily<T>
    {
        T Name { get; }
        IFamily<T> Parent { get; }
    }

    public class MyFamily<T> : IFamily<T>
    {
        private readonly T name;
        private readonly IFamily<T> parent;

        public T Name { get { return name; } }
        public IFamily<T> Parent { get { return parent; } }

        private MyFamily(T name, IFamily<T> parent)
        {
            this.name = name;
            this.parent = parent;
        }

        public static IFamily<T> CreateList(IEnumerable<T> items)
        {
            IEnumerator<T> iter = items.GetEnumerator();
            return CreateList(iter);
        }

        public static IFamily<T> CreateList(IEnumerator<T> iter)
        {
            return iter.MoveNext() ?
                  new MyFamily<T>(iter.Current, CreateList(iter))
                : new MyFamily<T>(default(T), null);
        }
    }

    public static class CustomIterators
    {
        public static IEnumerable<T> LinkListIterator<T>(this IFamily<T> theList)
        {
            for (IFamily<T> list = theList; list.Parent != null; list = list.Parent)
                yield return list.Name;
        }
    }
}

