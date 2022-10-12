using System;

namespace Проблема_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько дробей в первых тысячах разложений содержат числитель с большим количеством цифр, чем знаменатель?");
            int Answer = 0;
            int[] temp = new int[500];
            int temp2 = 0; 

            for (int i = 0; i < 1000; i++)
            {
                int[] Numerator = new int[500];
                int[] Denominator = new int[500];

                Numerator[0] = 1;
                Denominator[0] = 2;

                for (int n = i; n > 0; n--)
                {
                    for (int p = 0; p < 499; p++)
                    {
                        Numerator[p] += (Denominator[p] * 2);
                        Numerator[p + 1] += ((Numerator[p] - (Numerator[p] % 10)) / 10);
                        Numerator[p] = (Numerator[p] % 10);
                    }

                    temp = Numerator;
                    Numerator = Denominator;
                    Denominator = temp;
                }

                for (int p = 0; p < 499; p++)
                {
                    Numerator[p] += (Denominator[p]);
                    Numerator[p + 1] += ((Numerator[p] - (Numerator[p] % 10)) / 10);
                    Numerator[p] = (Numerator[p] % 10);
                }

                if (BigNumerator(Numerator, Denominator))
                {
                    Answer++;
                }
            }
            Console.WriteLine(Answer);
        }
        static bool BigNumerator(int[] a, int[] b)
        {
            int aI = 0, bI = 0;
            for (int i = 499; ; i--)
            {
                if (a[i] != 0)
                {
                    aI = i;
                    break;
                }
            }
            for (int i = 499; ; i--)
            {
                if (b[i] != 0)
                {
                    bI = i;
                    break;
                }
            }

            return (aI > bI);
        }
    }
}
