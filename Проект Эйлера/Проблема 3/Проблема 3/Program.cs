using System;

namespace Проблема_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой самый большой простой делитель числа 600851475143?");
            long num = 600851475143, a = 3;
            while (true)
            {
                if (num / a == 1)
                {
                    Console.WriteLine("Ответ: " + num);
                    break;
                }
                else if (num % a == 0) 
                {
                    num /= a;
                    continue;
                }
                else
                {
                    a += 2;
                    continue;
                }
            }
            
        }
    }
}
