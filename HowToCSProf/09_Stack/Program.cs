using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            // Peek() - возвращает элемент с вершины стека, не удаляя его.
            Console.WriteLine(stack.Peek());

            // Count - возвращает количество элементов в стеке.
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
