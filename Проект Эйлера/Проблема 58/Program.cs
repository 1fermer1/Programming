using System;
using System.Collections.Generic;

namespace Проблема_58
{
    class Program
    {
        public static List<int> PrimeNumbers = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        public static bool Add = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Какова длина стороны квадратной спирали, для которой соотношение простых чисел по обеим диагоналям > 10%?");
            for (int i = 25; i < 1000000; i += 2)
            {
                Add = true;
                for (int n = 1; PrimeNumbers[n] < Math.Sqrt(i) && n < PrimeNumbers.Count; n++)
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
            int PrimeNumberAtDiogonals = 8;
            int AllNumberAtDiogonals = 13;
            int SideLenght = 8;
            long StartNumder = 49;
            decimal s = 0.0000m;
            while (true)
            {
                StartNumder += SideLenght;
                if (Prime(StartNumder))
                {
                    PrimeNumberAtDiogonals++;
                }
                StartNumder += SideLenght;
                if (Prime(StartNumder))
                {
                    PrimeNumberAtDiogonals++;
                }
                StartNumder += SideLenght;
                if (Prime(StartNumder))
                {
                    PrimeNumberAtDiogonals++;
                }
                StartNumder += SideLenght;
                if (Prime(StartNumder))
                {
                    PrimeNumberAtDiogonals++;
                }
                SideLenght += 2;
                AllNumberAtDiogonals += 4;
                s = PrimeNumberAtDiogonals;
                s /= AllNumberAtDiogonals;
                if (s < 0.1m)
                {
                    break;
                }
            }
            Console.WriteLine("Ответ: {0}", (SideLenght - 1));
        }
        static bool Prime(long a)
        {
            for (int i = 0; PrimeNumbers[i] <= Math.Sqrt(a); i++)
            {
                if ((a % PrimeNumbers[i]) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
