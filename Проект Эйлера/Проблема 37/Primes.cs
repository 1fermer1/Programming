using System;

namespace Проблемы_37
{
    class Prime
    {
        public int InputNumber = 0;
        private bool primeNumber = true;

        public bool PrimeNumber()
        {
            if (InputNumber != 1)
            {
                primeNumber = true;
                for (int i = 2; i <= Math.Sqrt(InputNumber); i++)
                {
                    if ((InputNumber % i) == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
            }
            else
            {

                primeNumber = false;
            }
            return primeNumber;
        }
    }
}
