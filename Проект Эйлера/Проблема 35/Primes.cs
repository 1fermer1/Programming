using System;
using System.Collections.Generic;

namespace Проблема_35
{
    class Prime
    {
        public int InputNumber = 0;
        public List<int> PrimesNumbers = new List<int> { 2, 3, 5, 7 };
        private bool justNumber = true;

        public bool JustNumber()
        {
            justNumber = true;
            for (int p = 0; PrimesNumbers[p] < 1000 && PrimesNumbers[p] < InputNumber/2; p++)
            {
                if ((InputNumber % PrimesNumbers[p]) == 0)
                {
                    justNumber = !justNumber;
                    break;
                }
            }
            return justNumber;
        }
    }
}
