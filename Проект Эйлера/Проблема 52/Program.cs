using System;

namespace Проблема_52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите наименьшее положительное целое число x , такое, чтобы 2x , 3x , 4x , 5x и 6x содержали одинаковые цифры.");

            for (int n = 1; ; n *= 10)
            {
                for (int i = (10 * n); n < (10 * i / 6); i++)
                {
                    int a = i;
                    int b = (2 * i);
                    if (EquallyDigits.EquallyDigitsOfNumbers(a, b))
                    {
                        a = (3 * i);
                        if (EquallyDigits.EquallyDigitsOfNumbers(a, b))
                        {
                            b = (4 * i);
                            if (EquallyDigits.EquallyDigitsOfNumbers(a, b))
                            {
                                a = (5 * i);
                                if (EquallyDigits.EquallyDigitsOfNumbers(a, b))
                                {
                                    b = (6 * i);
                                    if (EquallyDigits.EquallyDigitsOfNumbers(a, b))
                                    {
                                        Console.WriteLine($"Ответ: {i}");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }
    }
}
