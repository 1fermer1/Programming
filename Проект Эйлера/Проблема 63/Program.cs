using System;

namespace Проблема_63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько существует n-значных натуральных чисел, которые также являются n-й степенью?");
            int Amount = 0;
            for (int i = 1; i < 30; i++)
            {
                for (int n = 1; n < 100000; n++)
                {
                    if (Pow(n, i).ToString().Length == i)
                    {
                        Amount++;
                    }
                    if (Pow(n, i) == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Ответ: {Amount}");
        }
        static decimal Pow(int n, int i)
        {
            decimal a = n;
            for (int j = i; j > 1; j--)
            {
                try
                {
                    a *= n;
                }
                catch
                {
                    return 0;
                }
            }
            return a;
        }
    }
}
