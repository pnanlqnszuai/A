using System;
using System.Collections.Generic;

namespace AdditionTask
{
    delegate void DelegateModifier();
    class Program
    {
        static void Main()
        {
            List<int> listOriginal = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<List<int>> func = () =>
            {
                List<int> list = new List<int>();
                foreach (var item in listOriginal)
                {
                    list.Add(item * 2);
                }
                return list;
            };

            List<int> listNew = func();

            foreach (var item in listNew)
            {
                Console.WriteLine(item);
            }

            DelegateModifier modifier = () =>
            {
                for (int i = listOriginal.Count-1; i > 0; i--)
                {
                    if (listOriginal[i] % 2 != 0)
                    {
                        listOriginal[i] = listOriginal[i] + 1;
                    }
                }
            };

            modifier();

            foreach (var item in listOriginal)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
