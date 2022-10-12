using System;

namespace Проблемы_37
{
    class RemoveDigit
    {
        public int InputNumber = 0;
        private bool removePrimeNumber = true;
        private string inputNumber = null;
        private string reversinputNumber = null;
        Prime RemovedNumber = new Prime(); 

        public bool RemoveDigitRight()
        {
            removePrimeNumber = true;
            for (; InputNumber != (InputNumber % 10);)
            {
                InputNumber -= (InputNumber % 10);
                InputNumber /= 10;
                RemovedNumber.InputNumber = InputNumber;
                if (!RemovedNumber.PrimeNumber())
                {
                    removePrimeNumber = false;
                    break;
                }
            }
            return removePrimeNumber;
        }
        public bool RemoveDigitLeft()
        {
            removePrimeNumber = true;
            for (; InputNumber != (InputNumber % 10);)
            {
                inputNumber = Convert.ToString(InputNumber);
                reversinputNumber = "";
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    reversinputNumber += inputNumber[inputNumber.Length - (i + 1)];
                }
                InputNumber = (Convert.ToInt32(reversinputNumber));
                InputNumber -= (InputNumber % 10);
                InputNumber /= 10;
                inputNumber = Convert.ToString(InputNumber);
                reversinputNumber = "";
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    reversinputNumber += inputNumber[inputNumber.Length - (i + 1)];
                }
                InputNumber = (Convert.ToInt32(reversinputNumber));
                RemovedNumber.InputNumber = InputNumber;
                if (!RemovedNumber.PrimeNumber())
                {
                    removePrimeNumber = false;
                    break;
                }
            }
            return removePrimeNumber;
        }
    }
}
