using System;
using System.Collections.Generic;

namespace Проблема_41
{
    class Pandigital
    {
        public int InputNumber = 0;
        private string stringNumber = null;
        private bool pandigitalNumber = true;

        public bool PandigitalNumber()
        {
            List<int> digits = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            pandigitalNumber = true;
            stringNumber = InputNumber.ToString();
            int a = stringNumber.Length;
            for (int i = 0; i < a && pandigitalNumber; i++)
            {
                pandigitalNumber = false;
                for (int n = 0; n < (a - i); n++)
                {
                    if (stringNumber[i].ToString() == digits[n].ToString())
                    {
                        pandigitalNumber = true;
                        digits.RemoveAt(n);
                        break;
                    }
                }
            }
            return pandigitalNumber;
        }
    }
}
