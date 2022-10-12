using System;

namespace Проблема_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько, не обязательно различных, значений ( n r ) для 1 <= n <= 100, больше миллиона?");
            int Amount = 0;
            for (double n = 2; n < 101; n++)
            {
                for (double r = 1; r < n; r++)
                {
                    if (FormulaAmount(n, r))
                    {
                        Amount++;
                    }
                }
            }
            Console.WriteLine($"Ответ: {Amount}");
        }
        static bool FormulaAmount(double a, double b)
        {
            double result = 1;
            result *= Factorial(a);
            result /= Factorial(b);
            result /= Factorial((a - b));
            return (result > 1000000);
        }
        static double Factorial(double a)
        {
            double result = 1;
            for (double i = a; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
