using System;

namespace Проблема_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассматривая члены последовательности Фибоначчи, значения которых не превышают четырех миллионов, найдите сумму четных членов.");
            int sum = 2, a = 1, b = 1, c = 2;
            while (true)
            {
                a = b + c;
                if (a < 4000000 && a % 2 == 0)
                {
                    sum += a;
                }
                b = a + c;
                if (b < 4000000 && b % 2 == 0)
                {
                    sum += b;
                }
                c = a + b;
                if (c < 4000000 && c % 2 == 0)
                {
                    sum += c;
                }
                if (a >= 4000000 || b >= 4000000 || c >= 4000000)
                {
                    Console.WriteLine("Ответ: " + sum);
                    break;
                }
            }
        }
    }
}
