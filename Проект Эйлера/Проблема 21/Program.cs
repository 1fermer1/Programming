using System;

namespace Проблема_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оцените сумму всех полюбившихся чисел меньше 10000.");
            int sum = 0, a, b;
            for (int i = 0; i < 10000; i++)
            {
                a = b = 0;
                for (int n = 1; n <= i/2; n++)
                {
                    if ((i % n) == 0)
                    {
                        a += n;
                    }
                }
                for (int n = 1; n <= a/2; n++)
                {
                    if ((a % n) == 0)
                    {
                        b += n;
                    }
                }
                if (b == i && a < i)
                {
                    sum += b;
                    sum += a;
                }
            }
            Console.WriteLine("Ответ: {0}", sum);
        }
    }
}
