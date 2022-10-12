using System;

namespace Проблема_43
{
    static class CheckDivision
    {
        private static int Number = 0;
        public static bool On3(int a, int b, int c)
        {
            Number = (100 * a + 10 * b + c);
            if ((Number % 3) == 0)
            {
                return true;
            }
            return false;
        }
        public static bool On7(int a, int b, int c)
        {
            Number = (100 * a + 10 * b + c);
            if ((Number % 7) == 0)
            {
                return true;
            }
            return false;
        }
        public static bool On11(int a, int b, int c)
        {
            Number = (100 * a + 10 * b + c);
            if ((Number % 11) == 0)
            {
                return true;
            }
            return false;
        }
        public static bool On13(int a, int b, int c)
        {
            Number = (100 * a + 10 * b + c);
            if ((Number % 13) == 0)
            {
                return true;
            }
            return false;
        }
        public static bool On17(int a, int b, int c)
        {
            Number = (100 * a + 10 * b + c);
            if ((Number % 17) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
