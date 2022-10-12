using System;

namespace Проблема_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех чисел, которые можно записать как сумму пятых степеней их цифр.");
            double sum = 0;
            for (double i = 10; i < 1000000; i++)
            {
                string s = Convert.ToString(i);
                double a = 0;
                for (int n = 0; n < s.Length; n++)
                {
                    a += (Math.Pow((Convert.ToInt64(s[n]) - 48), 5));
                }
                if (i == a)
                {
                    sum += a;
                }
            }
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
