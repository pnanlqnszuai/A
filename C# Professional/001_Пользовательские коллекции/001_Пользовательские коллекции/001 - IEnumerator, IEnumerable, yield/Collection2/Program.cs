﻿using System;
using System.Collections.Generic;

// Создание простой пользовательской коллекции с использованием обобщенных интерфейсов.

namespace Collection
{
	class Program
	{
		static void Main()
		{
			// Создаем коллекцию.
			var сollection = new UserCollection<Element>();

			// Помещаем в коллекцию 4 элемента.
			сollection[0] = new Element(1, 2);
			сollection[1] = new Element(3, 4);
			сollection[2] = new Element(5, 6);
			сollection[3] = new Element(7, 8);
      
			// В циклической конструкции foreach выводим содержимое коллекции на экран.
			foreach (var element in сollection)
			{
				Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
			}

			Console.WriteLine(new string('-', 5));

			// В циклической конструкции foreach выводим содержимое коллекции на экран.
			foreach (var element in сollection)
			{
				Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
			}

			// Delay.
			Console.ReadKey();
		}
	}
}
