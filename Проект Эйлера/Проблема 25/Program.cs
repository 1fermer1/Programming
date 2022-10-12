using System;

namespace Проблема_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каков индекс первого члена последовательности Фибоначчи, содержащего 1000 цифр?");
            byte[] not_even = new byte[1000];
            byte[] even = new byte[1000];
            not_even[0] = even[0] = 1;
            int i = 2;
            while(true)
            {
                i++;
                for (int n = 0; n < 1000; n++)
                {
                    not_even[n] += even[n];
                }
                for (int n = 0; n < 1000; n++)
                {
                    if (not_even[n] > 9)
                    {
                        not_even[n] -= 10;
                        not_even[n + 1] += 1;
                    }
                }
                if (not_even[999] != 0)
                {
                    break;
                }
                i++;
                for (int n = 0; n < 1000; n++)
                {
                    even[n] += not_even[n];
                }
                for (int n = 0; n < 1000; n++)
                {
                    if (even[n] > 9)
                    {
                        even[n] -= 10;
                        even[n + 1] += 1;
                    }
                }
                if (even[999] != 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Ответ: {i}");
        }
    }
}
