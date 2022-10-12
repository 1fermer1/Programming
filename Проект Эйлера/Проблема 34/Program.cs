using System;

namespace Проблема_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех чисел, которые равны сумме факториалов их цифр.");
            int Sum = 0;
            int a = 0;
            for (int i = 3; i < 50000; i++)
            {
                int Sumy = 0;
                int Num = i;
                string StrNum = Convert.ToString(Num);
                for (int n = 0; n < StrNum.Length; n++)
                {
                    a = Num % 10;
                    Num -= a;
                    Num /= 10;
                    switch (a)
                    {
                        case 0:
                            Sumy += 1;
                            break;
                        default:
                            int d = 1;
                            for (int u = a; u > 0; u--)
                            {
                                d *= u;
                            }
                            Sumy += d;
                            break;
                    }
                }
                if (i == Sumy)
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"Ответ: {Sum}");
        }
    }
}
