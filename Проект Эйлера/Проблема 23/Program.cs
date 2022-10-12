using System;
using System.Collections.Generic;

namespace Проблема_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех положительных целых чисел, которые нельзя записать как сумму двух обильных чисел.");
            List<int> AbundantNumbers = new List<int>();
            List<int> AllNumbers = new List<int>();
            int Sum = 0;
            for (int i = 11; i < 28124; i++)
            {
                int a = 0;
                for (int n = 1; n <= i/2; n++)
                {
                    if ((i % n) == 0)
                    {
                        a += n;
                    }
                }
                if (a > i)
                {
                    AbundantNumbers.Add(i);
                }
            }
            for (int i = 1; i < 28124; i++)
            {
                AllNumbers.Add(i);
            }
            int b = 0;
            for (int i = 0; i < (AbundantNumbers.Count - 1); i++)
            {
                for (int n = i; n < AbundantNumbers.Count; n++)
                {
                    b = AbundantNumbers[n] + AbundantNumbers[i];
                    AllNumbers.Remove(b);
                }
            }
            foreach (int i in AllNumbers)
            {
                Sum += i;
            }
            Console.WriteLine("Ответ: {0}", Sum);
        }
    }
}
