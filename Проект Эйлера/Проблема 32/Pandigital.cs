using System;

namespace Проблема_32
{
    class Pandigital
    {
        public string Input = null;
        private bool pandigitalNumber = true;

        public bool PandigitalNumber()
        {
            pandigitalNumber = true;
            for (int i = 1; i < 10 && pandigitalNumber; i++)
            {
                pandigitalNumber = false;
                for (int n = 0; n < 9; n++)
                {
                    if ((Convert.ToInt32(Input[n]) - 48) == i)
                    {
                        pandigitalNumber = true;
                        break;
                    }
                }
            }
            return pandigitalNumber;
        }
    }
}
