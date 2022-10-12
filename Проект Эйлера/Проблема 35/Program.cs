using System;
using System.Collections.Generic;

namespace Проблема_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько круговых простых чисел меньше миллиона?");
            List<int> Answer = new List<int>();
            Prime Number = new Prime();
            for (int i = 11; i < 1000000; i += 2)
            {
                Number.InputNumber = i;
                if (Number.JustNumber())
                {
                    Number.PrimesNumbers.Add(i);
                }
            }
            string temp = null;
            Circular JustNumber = new Circular();
            for (int i = 0; i < Number.PrimesNumbers.Count; i++)
            {
                temp = Convert.ToString(Number.PrimesNumbers[i]);
                JustNumber.InputNumber = Number.PrimesNumbers[i];
                for (int n = 1; n < temp.Length; n++)
                {
                    Number.InputNumber = JustNumber.CircularNumber();
                    JustNumber.InputNumber = Number.InputNumber;
                    if (!Number.JustNumber())
                    {
                        Answer.Add(Number.PrimesNumbers[i]);
                        break;
                    }
                }
            }
            Console.WriteLine($"Ответ: {Number.PrimesNumbers.Count - Answer.Count}");
        }
    }
}
