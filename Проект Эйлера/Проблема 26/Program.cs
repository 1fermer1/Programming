using System;

namespace Проблема_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите значение d < 1000, для которого 1 / d содержит самый длинный повторяющийся цикл в своей части десятичной дроби.");
            int b, c;
            int MaxSize = 0, iMaxSize = 0;
            for (int a = 2; a < 1000; a++)
            {
                c = 10;
                for (int i = 1; i < 100000; i++)
                {
                    b = (c % a);
                    if (b == 0)
                    {
                        break;
                    }
                    b *= 10;
                    c = b;
                    if (c == 10)
                    {
                        if (iMaxSize < i)
                        {
                            iMaxSize = i;
                            MaxSize = a;
                        }
                        break;
                    }
                }
            }
            Console.WriteLine("Ответ: " + MaxSize);
        }
    }
}
