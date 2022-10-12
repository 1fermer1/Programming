using System;

namespace Проблема_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько начальных чисел меньше десяти миллионов дойдут до 89?");
            int Answer = 1;
            for (int i = 3; i < 10000000; i++)
            {
                if (Chain(i))
                {
                    Answer++;
                }
            }
            Console.WriteLine($"Ответ: {Answer}");
        }
        static bool Chain(int a)
        {
            int b = a;
            string s = null;
            for (; b != 1 && b != 89;)
            {
                s = b.ToString();
                b = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    b += ((s[i] - 48) * (s[i] - 48));
                }
            }
            if (b == 89)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
