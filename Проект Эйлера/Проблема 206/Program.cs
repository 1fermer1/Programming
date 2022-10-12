using System;

namespace Проблема_206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите уникальное положительное целое число, квадрат которого имеет форму 1_2_3_4_5_6_7_8_9_0, где каждый символ «_» представляет собой одну цифру.");

            for (long i = 1010101010; i < 1389026631; i += 10)
            {
                if (Pow(i))
                {
                    Console.WriteLine($"Ответ: {i}");
                    return;
                }
            }
        }
        static bool Pow(long a)
        {
            long b = a;
            b *= a;
            string s = b.ToString();
            if (s[0] == '1' && s[2] == '2' && s[4] == '3' && s[6] == '4' && s[8] == '5' && s[10] == '6' && s[12] == '7' && s[14] == '8' && s[16] == '9' && s[18] == '0')
            {
                return true;
            }
            return false;
        }
    }
}
