using System;
using System.Collections.Generic;

namespace Проблема_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Какое наименьшее положительное число делится без остатка на все числа от 1 до 20?");
            //List<int> mn = new List<int>();
            //int a = 2, b, mnmn = 2;
            //mn.Add(2);
            //while (true)
            //{
            //    a++;
            //    b = a;
            //    for (int i = 0; i < mn.Count; i++)
            //    {
            //        if (b % mn[i] == 0)
            //        {
            //            b /= mn[i];
            //        }
            //    }
            //    mnmn *= b;
            //    mn.Add(b);
            //    if (a == 20)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Ответ: " + mnmn);
            for (int i = 1; ; i++)
            {
                if (i % 20 == 0)
                {
                    if (i % 19 == 0)
                    {
                        if (i % 9 == 0)
                        {
                            if (i % 17 == 0)
                            {
                                if (i % 16 == 0)
                                {
                                    if (i % 7 == 0)
                                    {
                                        if (i % 13 == 0)
                                        {
                                            if (i % 11 == 0)
                                            {
                                                Console.WriteLine(i);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
