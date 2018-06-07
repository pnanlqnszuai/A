using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ICollection
{
    class GenericCollection<T> : ICollection<T>
    {
        T[] array = new T[8];
        object root = new object();

        int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                var newArray = new T[array.Length * 2];
                array.CopyTo(newArray, 0);
                array = newArray;
            }
            array[count] = item;
            count++;
        }

        public void Clear()
        {
            array = new T[8];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(this.array[i], i + arrayIndex);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        public bool Remove(T item)
        {
            int targetElement = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    targetElement = i;
                    break;
                }
            }

            if (targetElement != -1)
            {
                for (int i = targetElement; i < count - 1; i++)
                {
                    array[targetElement] = array[targetElement + 1];
                }
                count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
