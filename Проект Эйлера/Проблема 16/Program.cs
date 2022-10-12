using System;

namespace Проблема_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какова сумма цифр числа 2^1000?");
            int[] bignum = new int[320];
            bignum[319] = 1;
            for (int i = 1; i < 1001; i++)
            {
                for (int n = 0; n < 320; n ++)
                {
                    bignum[n] *= 2;
                }
                for (int y = 319; y > -1; y--)
                {
                    if (bignum[y] > 9)
                    {
                        bignum[y] -= 10;
                        bignum[y - 1]++;
                    }
                }
            }
            int sum = 0;
            foreach (int f in bignum)
            {
                sum += f;
            }
            Console.WriteLine("Ответ: " + sum);
        }
    }
}
