using System;
using System.Collections.Generic;

namespace Проблема_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите первые четыре последовательных целых числа, у каждого из которых будет по четыре различных простых множителя. Какое первое из этих чисел?");
            FourDistinctPrimeFactors Number = new FourDistinctPrimeFactors();
            List<int> PrimeNumbers = new List<int> { 2 };
            bool Add = true;

            for (int i = 3; i < 15000; i += 2)
            {
                Add = true;
                for (int n = 0; n < PrimeNumbers.Count; n++)
                {
                    if ((i % PrimeNumbers[n]) == 0)
                    {
                        Add = false;
                        break;
                    }
                }
                if (Add)
                {
                    PrimeNumbers.Add(i);
                }
            }
            Number.PrimeNumbers = PrimeNumbers;
            byte a = 0;
            for (int i = 1000; ; i++)
            {
                a = 4;
                for (int n = 0; n < 4 && a == 4; n++)
                {
                    a = 0;
                    for (int b = 0; b < PrimeNumbers.Count && PrimeNumbers[b] < (i / 2); b++)
                    {
                        if (((i + n) % PrimeNumbers[b]) == 0)
                        {
                            a++;
                        }
                    }
                }


                if (a == 4)
                {
                    Number.InputNumber = i;
                    if (Number.FourDistinctPrimeFactorsInNumbers())
                    {
                        Console.WriteLine($"Ответ: {i}");
                        break;
                    }
                }
            }
        }
    }
}
