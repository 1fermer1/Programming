using System;

namespace Проблема_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько разных способов заработать 2 фунта стерлингов, используя любое количество монет?");
            int Sum = 0, Amount = 8;
            for (int i100 = 0; i100 < 2; i100++)
            {
                for (int i50 = 0; i50 < 4; i50++)
                {
                    for (int i20 = 0; i20 < 10; i20++)
                    {
                        for (int i10 = 0; i10 < 20; i10++)
                        {
                            for (int i5 = 0; i5 < 40; i5++)
                            {
                                for (int i2 = 0; i2 < 100; i2++)
                                {
                                    for (int i1 = 0; i1 < 200; i1++)
                                    {
                                        Sum += (i100 * 100);
                                        Sum += (i50 * 50);
                                        Sum += (i20 * 20);
                                        Sum += (i10 * 10);
                                        Sum += (i5 * 5);
                                        Sum += (i2 * 2);
                                        Sum += (i1 * 1);
                                        if (Sum == 200)
                                        {
                                            Amount++;
                                            break;
                                        }
                                        Sum = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Ответ: {Amount}");
        }
    }
}
