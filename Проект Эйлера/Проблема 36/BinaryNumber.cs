using System;

namespace Проблема_36
{
    class BinaryNumber
    {
        public int BiNum = 0;
        private string StrBiNum = null;

        public string StrBNum()
        {
            StrBiNum = null;
            while (true)
            {
                StrBiNum += Convert.ToString((BiNum % 2));
                if ((BiNum % 2) == 1)
                {
                    BiNum -= 1;
                }
                BiNum /= 2;
                if (BiNum == 0)
                {
                    break;
                }
            }
            return StrBiNum;
        }
    }
}
