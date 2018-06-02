using System;

// Динамические типы данных.

namespace Dynamic
{
	class Calculator
	{
		public dynamic Add(dynamic a, dynamic b)
		{
			return a + b;
		}
	}

	class Program
	{
		static void Main()
		{
			dynamic calculator = new Calculator();
			
			Console.WriteLine(calculator.Add(2, 3));
			Console.WriteLine(calculator.Add(2.2, 3.3));
			Console.WriteLine(calculator.Add("here", "_it is"));

			// Delay.
			Console.ReadKey();
		}
	}
}
