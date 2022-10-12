using System;

namespace Проблема_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех панцифровых чисел от 0 до 9 с этим свойством.");
            long Sum = 0;

            for (int d1 = 0; d1 < 10; d1++)
            {
                if (d1 == 5)
                {
                    continue;
                }
                for (int d2 = 0; d2 < 10; d2++)
                {
                    if (d2 == d1 || d2 == 5)
                    {
                        continue;
                    }
                    for (int d3 = 0; d3 < 10; d3++)
                    {
                        if (d3 == d1 || d3 == d2 || d3 == 5)
                        {
                            continue;
                        }
                        for (int d4 = 0; d4 < 10; d4 += 2)
                        {
                            if (d4 == d1 || d4 == d2 || d4 == d3 || d4 == 5)
                            {
                                continue;
                            }
                            for (int d5 = 0; d5 < 10; d5++)
                            {
                                if (d5 == d1 || d5 == d2 || d5 == d3 || d5 == d4|| d5 == 5)
                                {
                                    continue;
                                }
                                int d6 = 5;
                                for (int d7 = 0; d7 < 10; d7++)
                                {
                                    if (d7 == d1 || d7 == d2 || d7 == d3 || d7 == d4 || d7 == d5 || d7 == 5)
                                    {
                                        continue;
                                    }
                                    for (int d8 = 0; d8 < 10; d8++)
                                    {
                                        if (d8 == d1 || d8 == d2 || d8 == d3 || d8 == d4 || d8 == d5 || d8 == 5 || d8 == d7)
                                        {
                                            continue;
                                        }
                                        for (int d9 = 0; d9 < 10; d9++)
                                        {
                                            if (d9 == d1 || d9 == d2 || d9 == d3 || d9 == d4 || d9 == d5 || d9 == 5 || d9 == d7 || d9 == d8)
                                            {
                                                continue;
                                            }
                                            for (int d10 = 0; d10 < 10; d10++)
                                            {
                                                if (d10 == d1 || d10 == d2 || d10 == d3 || d10 == d4 || d10 == d5 || d10 == d6 || d10 == d7 || d10 == d8 || d10 == d9)
                                                {
                                                    continue;
                                                }
                                                if (CheckDivision.On3(d3, d4, d5))
                                                {
                                                    if (CheckDivision.On7(d5, 5, d7))
                                                    {
                                                        if (CheckDivision.On11(5, d7, d8))
                                                        {
                                                            if (CheckDivision.On13(d7, d8, d9))
                                                            {
                                                                if (CheckDivision.On17(d8, d9, d10))
                                                                {
                                                                    Sum += (d10);
                                                                    Sum += (d9 * 10);
                                                                    Sum += (d8 * 100);
                                                                    Sum += (d7 * 1000);
                                                                    Sum += (d6 * 10000);
                                                                    Sum += (d5 * 100000);
                                                                    Sum += (d4 * 1000000);
                                                                    Sum += (d3 * 10000000);
                                                                    Sum += (d2 * 100000000);

                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);

                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
                                                                    Sum += (d1 * 100000000);
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
                        }
                    }
                }
            }
            Console.WriteLine($"Ответ: {Sum}");
        }
    }
}
