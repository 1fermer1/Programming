using System;

namespace Проблема_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите пару пятиугольных чисел P(j) и P(k), для которых их сумма и разность являются пятиугольными и D =|P(k)-P(j)| сводится к минимуму; каково значение D?");
            int D = 0, Pk = 0, Pj = 0;

            for (int j = 1000; j < 10001; j++)
            {
                for (int k = (j + 1); k < 10002; k++)
                {
                    Pk = (k * ((3 * k) - 1) / 2);
                    Pj = (j * ((3 * j) - 1) / 2);
                    if ((((1 + Math.Sqrt((1 + 24 * (Pk + Pj)))) / 6) % 1) == 0)
                    {
                        if ((((1 + Math.Sqrt((1 + 24 * (Pk - Pj)))) / 6) % 1) == 0)
                        {
                            if (D < (Pk - Pj))
                            {
                                D = (Pk - Pj);
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Ответ: {0}", D);
        }
    }
}
