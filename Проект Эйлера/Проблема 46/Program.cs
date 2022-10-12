using System;
using System.Collections.Generic;

namespace Проблема_46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какая наименьшая нечетная композиция не может быть записана как сумма простого числа и удвоенного квадрата?");
            List<int> PrimeNumbers = new List<int> { 2 };
            bool Add = true;
            for (int i = 3; i < 100000; i += 2)
            {
                Add = true;
                for (int n = 0; PrimeNumbers[n] <= (i / 2); n++)
                {
                    if ((i % PrimeNumbers[n]) == 0)
                    {
                        Add = false;
                        break;
                    }
                }
                if (Add)
                {
                    PrimeNumbers.Add(i);
                }
            }
            int a = 0;
            bool Run = true;
            for (int i = 3; i < 100000; i += 2)
            {
                Run = false;
                for (int n = 1; PrimeNumbers[n] <= i; n++)
                {
                    a = (i - PrimeNumbers[n]);
                    a /= 2;
                    if ((Math.Sqrt(a) % 1) == 0)
                    {
                        Run = true;
                        break;
                    }
                }
                if (!Run)
                {
                    Console.WriteLine($"Ответ: {i}");
                    break;
                }
            }



        }
    }
}
