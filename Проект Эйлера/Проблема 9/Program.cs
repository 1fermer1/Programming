using System;

namespace Проблема_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Существует ровно одна тройка Пифагора, для которой a+b+c=1000. Найдите произведение abc.");
            int a, b = 0, c = 0;
            for (a = 1; a < 332; a++)
            {
                for (b = a + 1; b < 1000 - (a + b); b++)
                {
                    c = (1000 - (a + b));
                    if (((a*a) + (b*b)) == (c*c))
                    {
                        break;
                    }
                }
                if (((a * a) + (b * b)) == (c * c))
                {
                    break;
                }
            }
            int r = a * b * c;
            Console.WriteLine("Ответ: " + r);
        }
    }
}
