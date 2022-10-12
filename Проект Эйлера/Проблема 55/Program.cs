using System;
using System.Collections.Generic;

namespace Проблема_55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел Лихрела ниже десяти тысяч?");
            List<decimal> Numbers = new List<decimal>();
            for (int i = 1; i < 10000; i++)
            {
                Numbers.Add(i);
            }
            for (int i = 1; i < 50; i++)
            {
                for (int n = 0; n < Numbers.Count; n++)
                {
                    Numbers[n] = ReverseAndAdd(Numbers[n]);
                }
                for (int n = 0; n < Numbers.Count; n++)
                {
                    if (Palindromic(Numbers[n]))
                    {
                        Numbers.RemoveAt(n);
                        n--;
                    }
                }
            }
            Console.WriteLine($"Ответ: {Numbers.Count}");
        }
        static decimal ReverseAndAdd(decimal InputNumber)
        {
            string s = InputNumber.ToString();
            List<string> sList = new List<string>();
            for (int i = (s.Length - 1); i > -1; i--)
            {
                sList.Add(s[i].ToString());
            }
            s = "";
            for (int i = 0; i < sList.Count; i++)
            {
                s += sList[i];
            }
            InputNumber += Convert.ToDecimal(s);
            return InputNumber;
        }
        static bool Palindromic(decimal InputNumber)
        {
            string s1 = InputNumber.ToString();
            string s2 = InputNumber.ToString();
            List<string> sList = new List<string>();
            for (int i = (s2.Length - 1); i > -1; i--)
            {
                sList.Add(s2[i].ToString());
            }
            s2 = "";
            for (int i = 0; i < sList.Count; i++)
            {
                s2 += sList[i];
            }
            if (s1 == s2)
            {
                return true;
            }
            return false;
        }
    }
}
