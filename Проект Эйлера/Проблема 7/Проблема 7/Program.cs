using System;
using System.Collections.Generic;

namespace Проблема_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое 10001-е простое число?");
            List<int> nums = new List<int> { 2, 3, 5, 7, 11, 13 };
            int a = 13;
            while (true)
            {
                a += 2;
                if (nums.Count == 10001)
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
                        nums.Add(a);
                    }
                }
            }
            Console.WriteLine("Ответ: " + nums[10000]);
        }
    }
}
