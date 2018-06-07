using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CollectionInterfaces
{
    class Collection : IEnumerable
    {
        int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            int[] array;
            public Iterator(Collection col)
            {
                array = col.array;
            }

            int currentPosition = -1;

            public object Current
            {
                get
                {
                    return array[currentPosition];
                }
            }

            public bool MoveNext()
            {
                if (currentPosition < array.Length - 1)
                {
                    currentPosition++;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                currentPosition = -1;
            }
        }
    }
}
