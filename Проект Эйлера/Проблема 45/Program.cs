using System;

namespace Пробема_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите следующий номер треугольника, который также будет пятиугольным и шестиугольным.");
            long Number = 0;

            for (long i = 286; ; i++)
            {
                Number = ((i * (i + 1)) / 2);
                if (((((1 + Math.Sqrt((1 + (24 * Number))))) / 6) % 1) == 0)
                {
                    if (((((1 + Math.Sqrt((1 + (8 * Number))))) / 4) % 1) == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Ответ: {Number}");
        }
    }
}
