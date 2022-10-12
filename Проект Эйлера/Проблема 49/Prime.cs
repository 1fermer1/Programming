using System;
using System.Collections.Generic;

namespace Проблема_49
{
    static class Prime
    {
        public static List<int> PrimeDigits = new List<int>();

        public static bool PrimeNumber(int InputNumber)
        {
            for (int i = 0; PrimeDigits[i] <= (InputNumber / 3); i++)
            {
                if ((InputNumber % PrimeDigits[i]) == 0)
                {
                    return false;
                }
            }
            InputNumber += 3330;
            for (int i = 0; PrimeDigits[i] <= (InputNumber / 3); i++)
            {
                if ((InputNumber % PrimeDigits[i]) == 0)
                {
                    return false;
                }
            }
            InputNumber += 3330;
            for (int i = 0; PrimeDigits[i] <= (InputNumber / 3); i++)
            {
                if ((InputNumber % PrimeDigits[i]) == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
