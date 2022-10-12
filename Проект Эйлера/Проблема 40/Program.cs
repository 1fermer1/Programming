using System;

namespace Проблема_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если d(n) представляет собой n-ю цифру дробной части, найдите значение следующего выражения. d(1) × d(10) × d(100) × d(1000) × d(10000) × d(100000) × d(1000000)");
            int Sum = 1;
            
            
            string Number = "";
            for (int i = 1; Number.Length < 100001; i++)
            {
                Number += i;
            }
            for (int i = 0; i < 100000; i = ((i * 10) + 9))
            {
                Sum *= (Convert.ToInt32(Number[i]) - 48);
            }
            int a = 1000000;
            a -= 488889;
            int b = a % 6;
            t:
            if ((a % 6) != 0)
            {
                a++;
                goto t;
            }
            a /= 6;
            a += 99999;
            string c = Convert.ToString(a);
            Sum *= (Convert.ToInt32(c[b - 1]) - 48);
            Console.WriteLine($"Ответ: {Sum}");
        }
    }
}
