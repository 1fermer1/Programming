using System;

namespace Проблема_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("При каком значении p <= 1000 количество решений максимально.");
            int P = 0, Max = 0;
            for (int p = 12; p < 1001; p++)
            {
                int max = 0;
                for (int i = 1; i < p / 3; i++)
                {
                    decimal c = ((i * i) + ((p - i) * (p - i)));
                    c /= (2 * (p - i));
                    if ((c % 1) == 0)
                    {
                        max++;
                    }
                }
                if (Max < max)
                {
                    Max = max;
                    P = p;
                }
            }
            Console.WriteLine($"Ответ: {P}");
        }
    }
}
