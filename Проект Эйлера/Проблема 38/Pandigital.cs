using System;

namespace Проблема_38
{
    class Pandigital
    {
        public string InputNumber = null;
        private bool pandigitalNumber = true;

        public bool PandigitalNumber()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int n = 0; n < 9; n++)
                {
                    pandigitalNumber = false;
                    if (((int)(InputNumber[n]) - 48) == i)
                    {
                        pandigitalNumber = true;
                        break;
                    }
                }
                if (pandigitalNumber == false)
                {
                    break;
                }
            }
            return pandigitalNumber;
        }
    }
}
