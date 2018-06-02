using System;

// Динамические типы данных. 

namespace Dynamic
{
    struct Point
    {
        dynamic x, y;

        public Point(dynamic x, dynamic y)
        {
            this.x = x;
            this.y = y;
        }

        // Один из параметров бинарного оператора, должен иметь существующий тип.

        //public static dynamic operator +(dynamic pointA, dynamic pointB) - так недопустимо.

        public static dynamic operator +(Point pointA, dynamic pointB)
        {
            return new Point(pointA.x + pointB.x, pointA.y + pointB.y);
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}", x, y);
        }
    }

    class Program
    {
        static void Main()
        {
            dynamic a = new Point(1, 1), b = new Point(2, 2);
           Point c = a + b;

            Console.WriteLine(c);

            // Delay.
            Console.ReadKey();
        }
    }
}
