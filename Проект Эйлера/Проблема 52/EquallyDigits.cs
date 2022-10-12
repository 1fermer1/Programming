using System;
using System.Collections.Generic;

namespace Проблема_52
{
    static class EquallyDigits
    {
        public static bool EquallyDigitsOfNumbers(int a, int b)
        {
            List<char> Digits_a = new List<char>();
            List<char> Digits_b = new List<char>();
            string Num_a = a.ToString();
            string Num_b = b.ToString();
            for (int i = 0; i < Num_a.Length; i++)
            {
                Digits_a.Add(Num_a[i]);
                Digits_b.Add(Num_b[i]);
            }
            Digits_a.Sort();
            Digits_b.Sort();
            for (int i = 0; i < Num_a.Length; i++)
            {
                if (Digits_a[i] != Digits_b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
