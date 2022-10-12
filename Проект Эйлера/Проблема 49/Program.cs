using System;
using System.Collections.Generic;

namespace Проблема_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое 12-значное число вы получите, объединив три члена в этой последовательности?");
            List<int> PrimeDigits = new List<int> { 3 };
            bool Add = true;
            for (int i = 5; i < 10000; i += 2)
            {
                Add = true;
                for (int n = 0; PrimeDigits[n] <= (i / 3); n++)
                {
                    if ((i % PrimeDigits[n]) == 0)
                    {
                        Add = true;
                        break;
                    }
                }
                if (Add)
                {
                    PrimeDigits.Add(i);
                }
            }
            Prime.PrimeDigits = PrimeDigits;
            for (int i = 1001; i < 3340; i += 2)
            {
                if (Prime.PrimeNumber(i))
                {
                    if (Permutation.PermutationNumber(i))
                    {
                        if (i != 1487)
                        {
                            Console.Write(("Ответ: " + i));
                            Console.Write((i + 3330));
                            Console.Write((i + 6660));
                            return;
                        }
                    }
                }
            }
        }
    }
}
