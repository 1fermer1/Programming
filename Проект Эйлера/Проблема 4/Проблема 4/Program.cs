using System;

namespace Проблема_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите самый большой палиндром, который является произведением двух трехзначных чисел.");
            int a = 100, b = 100, c, i = 0, d, f, p = 0;
            int[] ar = new int[500499];
            while (true)
            {
                i++;
                c = a * b;
                ar [i] = c;
                b++;
                if (b == 1000)
                {
                    a++;
                    b = 0 + a;
                }
                if (a == 1000)
                {
                    break;
                }
            }
            Array.Sort(ar);
            Array.Reverse(ar);
            while (true)
            {
                d = ar[p];
                string s = d.ToString();
                char[] ra = s.ToCharArray();
                Array.Reverse(ra);
                s = new String(ra);
                f = Convert.ToInt32(s);
                if (f == d)
                {
                    break;
                }
                else
                {
                    p++;
                }
            }
            Console.WriteLine("Ответ: " + f);
        }
    }
}
