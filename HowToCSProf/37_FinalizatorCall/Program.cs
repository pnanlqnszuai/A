﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_FinalizatorCall
{
    // Реализация IDisposable.
    public class MyClass : IDisposable
    {
        // Пользователь объекта должен вызвать этот метод 
        // перед завершением работы с объектом.
        public void Dispose()
        {
            // Освобождение неуправляемых ресурсов.
            // Освобождение других содержащихся объектов.
            // Например закрытие соединения с базой данных.
            Console.WriteLine("Метод Dispose() отработал:" + this.GetHashCode());
        }

        // Деструктор.
        ~MyClass()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(".");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            if (instance is IDisposable)
                instance.Dispose();

            Console.WriteLine(new string('_', 30));

            // Dispose() вызывается автоматически при выходе за пределы области видимости using.
            // Если возникает исключение внутри блока using то Dispose() гарантированно вызовется.
            using (instance = new MyClass())
            {
                // Использование instance.
            }

            try
            {
                // Использование instance.
            }
            finally
            {
                instance.Dispose();
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
