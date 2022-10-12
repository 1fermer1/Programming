using System;

namespace Проблема_36
{
    class PalindromicNumber
    {
        public string StrNum = null;
        private string StrNumRev = null;

        public bool Palindromic()
        {
            StrNumRev = null;
            for (int i = 0; i < StrNum.Length; i++)
            {
                StrNumRev += StrNum[StrNum.Length - (i + 1)];
            }
            return (StrNum.Equals(StrNumRev));
        }
    }
}
