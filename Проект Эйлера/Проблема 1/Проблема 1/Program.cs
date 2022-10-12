using System;

namespace Проблема_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех кратных 3 и 5 ниже 1000.");
            int sum = 0;
            for (int a = 0; a < 1000; a += 3)
            {
                sum += a;
            }
            for (int b = 0; b < 1000; b += 5)
            {
                if (b % 3 == 0)
                {
                    continue;
                }
                else
                {
                    sum += b;
                }
            }
            Console.WriteLine("Ответ: " + sum);
        }
    }
}
