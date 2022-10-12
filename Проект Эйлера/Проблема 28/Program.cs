using System;

namespace Проблема_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какова сумма чисел на диагоналях спирали 1001 на 1001, сформированной таким же образом?");
            int[] numbers = new int[1002001];
            for (int i = 0; i < 1002001; i++)
            {
                numbers[i] = (i + 1);
            }
            long sum = 0;
            int index = 0, a = 2;
            bool run = true;
            while (run)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum += numbers[index];
                    index += a;
                    if (index > 1002000)
                    {
                        run = !run;
                        break;
                    }
                }
                a += 2;
            }
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
