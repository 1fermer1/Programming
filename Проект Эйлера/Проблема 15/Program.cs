using System;

namespace Проблема_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько существует таких маршрутов через сетку 20 × 20?");
            long[][] nums = new long[41][];
            for (int i = 0; i < 41; i++)
            {
                nums[i] = new long[i + 1];
                nums[i][0] = 1;
                nums[i][i] = 1;
            }
            for (int i = 2; i < 41; i++)
            {
                for (int n = 1; n < (nums[i].Length - 1); n++)
                {
                    nums[i][n] = nums[i - 1][n - 1] + nums[i - 1][n];
                }
            }
            Console.WriteLine("Ответ: " + nums[40][20]);
        }
    }
}
