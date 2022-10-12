using System;

namespace Проблема_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите максимальную сумму сверху вниз в треугольнике ниже:");
            string s = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            s = s.Replace(@"
", "");
            s = s.Replace(" ", "");
            int a = 0;
            int[][] num = new int[15][];
            for (int i = 0; i < 15; i++)
            {
                num[i] = new int[i + 1];
                for (int n = 0; n < (i + 1); n++)
                {
                    int d = ((Convert.ToInt32(Convert.ToString(s[a])) * 10) + (Convert.ToInt32(Convert.ToString(s[a + 1]))));
                    num[i][n] = d;
                    a += 2;
                }
            }
            int sum = 0;
            a = 0;
            int[] ind = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            while (true)
            {
                for (int i = 0; i < 15; i++)
                {
                    a += num[i][ind[i]];
                }
                if (sum < a)
                {
                    sum = a;
                }
                a = 0;
                ind[14] += 1;
                for (int i = 14; i > 0; i--)
                {
                    if (ind[i] - ind[i - 1] == 2)
                    {
                        ind[(i - 1)] += 1;
                        for (int k = 14; k > (i - 1); k--)
                        {
                            ind[k] = ind[(i - 1)];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (ind[0] == 1)
                {
                    break;
                }
            }
            Console.WriteLine("Ответ: " + sum);
        }
    }
}
