using System;
using System.Collections.Generic;

namespace Проблема_48
{
    class MathOperation
    {
        public short InputNumber = 0;
        private long result = 1;
        private string s = null;

        public long PowNumber()
        {
            result = 1;
            for (short i = InputNumber; i > 0; i--)
            {
                result *= InputNumber;
                result %= 10000000000;
            }
            return result;
        }

        public long AddNumber(List<long> a)
        {
            long result = 0;
            for (int i = 0; i < 1000; i++)
            {
                result += a[i];
                result %= 10000000000;
            }
            return result;
        }
    }
}
