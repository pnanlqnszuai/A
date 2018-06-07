using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ICollection
{
    class Collection : ICollection
    {
        int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        object root = new object();
        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return true;
            }
        }

        public object SyncRoot
        {
            get
            {
                return root;
            }
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array.SetValue(this.array[i], i + index);
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}
