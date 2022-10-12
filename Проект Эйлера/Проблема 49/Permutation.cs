using System;
using System.Collections.Generic;

namespace Проблема_49
{
    static class Permutation
    {
        private static string s = null;

        public static bool PermutationNumber(int InputNumber)
        {
            List<char> Number1 = new List<char>();
            List<char> Number2 = new List<char>();
            s = InputNumber.ToString();
            for (int i = 0; i < 4; i++)
            {
                Number1.Add(s[i]);
            }
            Number1.Sort();
            InputNumber += 3330;
            s = InputNumber.ToString();
            for (int i = 0; i < 4; i++)
            {
                Number2.Add(s[i]);
            }
            Number2.Sort();
            for (int i = 0; i < 4; i++)
            {
                if (Number1[i] != Number2[i])
                {
                    return false;
                }
            }
            List<char> Number3 = new List<char>();
            InputNumber += 3330;
            s = InputNumber.ToString();
            for (int i = 0; i < 4; i++)
            {
                Number3.Add(s[i]);
            }
            Number3.Sort();
            for (int i = 0; i < 4; i++)
            {
                if (Number3[i] != Number2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
