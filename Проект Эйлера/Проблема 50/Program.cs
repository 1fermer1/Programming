using System;
using System.Collections.Generic;

namespace Проблема_50
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> PrimeNumbers = new List<int> { 2, 3 };
            bool Add = true;
            for (int i = 5; i < 1000000; i += 2)
            {
                Add = true;
                for (int n = 1; PrimeNumbers[n] <= Math.Sqrt(i); n++)
                {
                    if ((i % PrimeNumbers[n]) == 0)
                    {
                        Add = false;
                    }
                }
                if (Add)
                {
                    PrimeNumbers.Add(i);
                }
            }
            Prime.PrimeNumbers = PrimeNumbers;
            int Answer = 0;
            for (int n = 0; ; n++)
            {
                Answer = 0;
                for (int i = n; ; i++)
                {
                    Answer += PrimeNumbers[i];
                    if (Answer > 1000000)
                    {
                        Answer -= PrimeNumbers[i];
                        if (Prime.PrimeNumber(Answer))
                        {
                            Console.WriteLine($"Ответ: {Answer}");
                            return;
                        }
                        break;
                    }
                }
            }
        }
    }
}
