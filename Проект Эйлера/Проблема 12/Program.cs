using System;
using System.Collections.Generic;

namespace Проблема_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое значение имеет первое число треугольника, которое имеет более пятисот делителей?");
            int a = 0;
            for (int n = 1; ; n++)
            {
                a += n;
                List<int> del = new List<int>();
                for (int i = 1; i <=(Math.Sqrt(a)); i++)
                {
                    if (a % i == 0)
                    {
                        if (a % i == i)
                        {
                            del.Add(i);
                        }
                        else
                        {
                            del.Add(i);
                            del.Add(a / i);
                        }
                    }
                }
                if (del.Count > 500)
                {
                    break;
                }
            }
            Console.WriteLine("Ответ: " + a);
        }
    }
}
