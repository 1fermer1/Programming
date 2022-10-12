using System;

namespace Проблема_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите произведение коэффициентов, a а также b, для квадратичного выражения, которое дает максимальное количество простых чисел для последовательных значений n, начиная с n = 0.");
            int N = 0, Multiply = 0;
            for (int b = -1000; b < 1001; b++)
            {
                for (int a = -999; a < 1000; a++)
                {
                    bool run = true;
                    for (int n = 0; run; n++)
                    {
                        int number = b;
                        number += (n * n);
                        number += (a * n);
                        if (number < 0)
                        {
                            if (N < (n - 1))
                            {
                                N = (n - 1);
                                Multiply = (a * b);
                            }
                            run = !run;
                            break;
                        }
                        for (int i = 2; i < (number / 2); i++)
                        {
                            if ((number % i) == 0)
                            {
                                if (N < (n - 1))
                                {
                                    N = (n - 1);
                                    Multiply = (a * b);
                                }
                                run = !run;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Ответ: {0}", Multiply);
        }
    }
}
