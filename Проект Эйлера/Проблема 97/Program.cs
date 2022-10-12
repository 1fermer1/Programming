using System;

namespace Проблема_97
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите последние десять цифр этого простого числа (28433 × 2^7830457 + 1).");
            int[] Digits = new int[11];
            Digits[0] = 2;
            int digits = 0;
            for (int i = 1; i < 3915229; i++)
            {
                for (int n = 0; n < 10; n++)
                {
                    Digits[n] *= 4;
                }
                for (int n = 0; n < 10; n++)
                {
                    digits = (Digits[n] % 10);
                    Digits[n + 1] += ((Digits[n] - digits) / 10);
                    Digits[n] = digits;
                }
                Digits[10] = 0;
            }
            for (int n = 0; n < 10; n++)
            {
                Digits[n] *= 28433;
            }
            for (int n = 0; n < 10; n++)
            {
                digits = (Digits[n] % 10);
                Digits[n + 1] += ((Digits[n] - digits) / 10);
                Digits[n] = digits;
            }
            Digits[0] += 1;
            for (int n = 0; n < 10; n++)
            {
                digits = (Digits[n] % 10);
                Digits[n + 1] += ((Digits[n] - digits) / 10);
                Digits[n] = digits;
            }
            Console.WriteLine("Ответ: ");
            for (int n = 9; n > -1; n--)
            {
                Console.Write(Digits[n]);
            }
        }
    }
}
