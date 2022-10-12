using System;
using System.Collections.Generic;

namespace Проблема_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех простых чисел меньше двух миллионов.");
            List<int> nums = new List<int> { 2, 3, 5, 7, 11, 13 };
            int a = 13;
            long sum = 41;
            while (true)
            {
                a += 2;
                if (a > 2000000)
                {
                    break;
                }
                for (int i = 1; i < nums.Count; i++)
                {
                    if (a % nums[i] == 0)
                    {
                        break;
                    }
                    if (i == nums.Count - 1 && a % nums[i] != 0)
                    {
                        if (a < 1500)
                        {
                            nums.Add(a);
                        }
                        sum += a;
                    }
                }
            }
            Console.WriteLine("Ответ: " + sum);
        }
    }
}
