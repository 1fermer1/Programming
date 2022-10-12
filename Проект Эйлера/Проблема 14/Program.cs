using System;
using System.Collections.Generic;

namespace Проблема_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое начальное число меньше миллиона дает самую длинную цепочку?");
            double[] ind = new double[500000];
            for (int i = 0; i < 500000; i++)
            {
                ind[i] = (i + 500000);
            }
            for (int i = 0; i < 400; i++)
            {
                for (int n = 0; n < 500000; n++)
                {
                    if(ind[n] != 16)
                    {
                        if (ind[n] % 2 == 0)
                        {
                            ind[n] /= 2;
                        }
                        else
                        {
                            ind[n] = ((3 * ind[n]) + 1);
                        }
                    }
                }
            }
            List<double> ind2 = new List<double>();
            List<double> num = new List<double>();
            for (int i = 0; i < 500000; i++)
            {
                if (ind[i] != 16)
                {
                    ind2.Add(ind[i]);
                    num.Add(i + 500000);
                }
            }
            for (int i = 0; ; i++)
            {
                for (int n = 0; n < ind2.Count; n++)
                {
                    if (ind2[n] != 16)
                    {
                        if (ind2[n] % 2 == 0)
                        {
                            ind2[n] /= 2;
                        }
                        else
                        {
                            ind2[n] = ((3 * ind2[n]) + 1);
                        }
                    }
                    else
                    {
                        ind2.RemoveAt(n);
                        num.RemoveAt(n);
                    }
                }
                if (num.Count == 1)
                {
                    break;
                }
            }
            Console.WriteLine(num[0]);
        }
    }
}
