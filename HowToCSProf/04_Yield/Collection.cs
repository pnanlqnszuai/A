using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Yield
{
    class Collection : IEnumerable
    {
        int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}
