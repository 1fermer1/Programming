using System;

namespace Проблема_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите разницу между суммой квадратов первых ста натуральных чисел и квадратом суммы.");
            int smallsum = 0, bigsum = 0, a = 0;
            while (true)
            {
                a++;
                smallsum += (a * a);
                if (a == 100)
                {
                    break;
                }
            }
            a = 0;
            while (true)
            {
                a++;
                bigsum += a;
                if (a == 100)
                {
                    bigsum *= bigsum;
                    break;
                }
            }
            Console.WriteLine("Ответ: " + (bigsum - smallsum));
        }
    }
}
