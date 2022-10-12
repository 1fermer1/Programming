using System;
using System.Collections.Generic;

namespace Проблема_69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите значение n ≤ 1 000 000, для которого n / φ ( n ) является максимальным.");
            List<int> PrimeNumbers = new List<int>() { 3, 5, 7, 11, 13 };
            bool Add = true;
            for (int i = 17; i < 1500; i += 2)
            {
                Add = true;
                for (int n = 0; n <= Math.Sqrt(i); n++)
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
            int Max = 1000000;
            double Answer = 0;
            int RealAnswer = 0;
            for(; Max != 2; )
            {
                int BigNumbers = 2;
                int LastPrimeDivited = 0;
                for (int i = 0; ; i++)
                {
                    BigNumbers *= PrimeNumbers[i];
                    if (BigNumbers >= Max)
                    {
                        LastPrimeDivited = (i - 1);
                        BigNumbers /= PrimeNumbers[i];
                        break;
                    }
                }
                Max = BigNumbers;
                int AmountRelativelyPrimeNubers = 1;
                for (int i = 3; i < BigNumbers; i += 2)
                {
                    Add = true;
                    for (int n = 0; n <= LastPrimeDivited; n++)
                    {
                        if ((i % PrimeNumbers[n]) == 0)
                        {
                            Add = false;
                            break;
                        }
                    }
                    if (Add)
                    {
                        AmountRelativelyPrimeNubers++;
                    }
                }
                double a = BigNumbers;
                a /= AmountRelativelyPrimeNubers;
                if (Answer < a)
                {
                    Answer = a;
                    RealAnswer = BigNumbers;
                }
            }
            Console.WriteLine($"Ответ: {RealAnswer}");
        }
    }
}
