using System;

namespace Проблема_35
{
    class Circular
    {
        public int InputNumber = 0;
        private int circularNumber = 0, temp = 0, temp3 = 1;
        private string temp2 = null;

        public int CircularNumber()
        {
            temp3 = 1;
            temp2 = Convert.ToString(InputNumber);
            for (int i = 1; i < temp2.Length; i++)
            {
                temp3 *= 10;
            }
            temp = InputNumber % 10;
            circularNumber = ((temp * temp3) + ((InputNumber - temp) / 10));
            return circularNumber;
        }
    }
}
