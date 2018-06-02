using System;
using System.Linq.Expressions;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            ParameterExpression x = Expression.Parameter(typeof(int), "x");

            var constant1 = Expression.Constant(2);
            var constant2 = Expression.Constant(3);
            var constant3 = Expression.Constant(4);

            var subBody = Expression.Subtract(x, constant2);
            var multBody = Expression.Multiply(constant1, subBody);
            var addBody = Expression.Add(multBody, x);
            var body = Expression.Subtract(addBody, constant3);

            var expression = Expression.Lambda<Func<int, int>>(body, x);

            Console.WriteLine(expression.Body);

            Func<int, int> func = expression.Compile();

            Console.WriteLine("Результат: " + func(4));

            Console.ReadKey();
        }
    }
}
