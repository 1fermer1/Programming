using System;
using System.Collections.Generic;

namespace Проблема_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько различных терминов содержится в последовательности, генерируемой a^b для 2 <= a <= 100 и 2 <= b <= 100?");
            List<double> array = new List<double>();
            for (double a = 2; a < 101; a++)
            {
                for (double b = 2; b < 101; b++)
                {
                    double temp = Math.Pow(a, b);
                    bool f = true;
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] == temp)
                        {
                            f = !f;
                            break;
                        }
                    }
                    if (f)
                    {
                        array.Add(temp);
                        array.Sort();
                    }
                }
            }
            Console.WriteLine($"Ответ: {array.Count}");
        }
    }
}
