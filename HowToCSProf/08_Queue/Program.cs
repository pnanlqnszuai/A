using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            // Peek() - возвращает первый элемент из очереди не удаляя его.
            object element = queue.Peek();
            Console.WriteLine(element); //First

            Console.WriteLine(new string('-', 10));
                      
            Console.WriteLine(queue.Dequeue());  // First.

            // Count - возвращает количество элементов в очереди.
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); // Second, Third, Fourth.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
