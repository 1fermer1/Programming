using System;
using System.Collections.Generic;

namespace Проблема_50
{
    static class Prime
    {
        public static List<int> PrimeNumbers = new List<int>();

        public static bool PrimeNumber(int InputNumber)
        {
            for (int i = 1; PrimeNumbers[i] <= (InputNumber / 3); i++)
            {
                if ((InputNumber % PrimeNumbers[i]) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
