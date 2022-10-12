using System;
using System.Collections.Generic;

namespace Проблема_47
{
    class FourDistinctPrimeFactors
    {
        public int InputNumber = 0;
        public List<int> PrimeNumbers = new List<int>();
        private bool fourDistinctPrimeFactorsInNumbers = true;
        private byte a = 0;

        public bool FourDistinctPrimeFactorsInNumbers()
        {
            a = 0;
            fourDistinctPrimeFactorsInNumbers = false;
            for (int i = 0; PrimeNumbers[i] <= (InputNumber / 2 ) && a != 4; i++)
            {
                if ((InputNumber % PrimeNumbers[i]) == 0)
                {
                    if (((InputNumber + 1) % PrimeNumbers[i]) == 0)
                    {
                        if (((InputNumber + 2) % PrimeNumbers[i]) == 0)
                        {
                            if (((InputNumber + 3) % PrimeNumbers[i]) != 0)
                            {
                                a++;
                                continue;
                            }
                        }
                        else
                        {
                            a++;
                            continue;
                        }
                    }
                    else
                    {
                        a++;
                        continue;
                    }
                }
            }
            if (a == 4)
            {
                fourDistinctPrimeFactorsInNumbers = true;
            }
            return fourDistinctPrimeFactorsInNumbers;
        }
    }
}
