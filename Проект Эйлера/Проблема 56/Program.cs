using System;

namespace Проблема_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассматривая натуральные числа вида a^b , где a, b < 100, какова максимальная цифровая сумма?");
            short MaxSumDigits = 0;
            for (byte a = 99; a > 30; a--)
            {
                for (byte b = 99; b > 30; b--)
                {
                    short SumDigits = Pow(a, b);
                    if (MaxSumDigits < SumDigits)
                    {
                        MaxSumDigits = SumDigits;
                    }
                }
            }
            Console.WriteLine($"Ответ: {MaxSumDigits}");
            Console.ReadLine();
        }
        static short Pow(byte a, byte b)
        {
            short temp = 0;
            short[] Digits = new short[197];
            Digits[0] = (short)(a % 10);
            Digits[1] = (short)((a - (a % 10)) / 10);
            for (byte i = b; i > 1; i--)
            {
                for (byte n = 0; n < 197; n++)
                {
                    Digits[n] *= a;
                }
                for (byte n = 0; n < 196; n++)
                {
                    temp = (short)(Digits[n] % 10);
                    Digits[n + 1] += (short)((Digits[n] - temp) / 10);
                    Digits[n] = (short)(temp);
                }
            }
            short SumDigits = 0;
            for (int i = 0; i < 197; i++)
            {
                SumDigits += Digits[i];
            }
            return SumDigits;
        }
    }
}
