using System;

namespace Проблема_41
{
    class Prime
    {
        public int InputPandigitalNumber = 0;
        private bool primePandigitalNumber = true;

        public bool PrimePandigitalNumber()
        {
            primePandigitalNumber = true;
            for (int i = 3; i < Math.Sqrt(InputPandigitalNumber); i++)
            {
                if ((InputPandigitalNumber % i) == 0)
                {
                    primePandigitalNumber = false;
                    break;
                }
            }
            return primePandigitalNumber;
        }
    }
}
