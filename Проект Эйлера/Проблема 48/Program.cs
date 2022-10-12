using System;
using System.Collections.Generic;

namespace Проблема_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите последние десять цифр ряда: 1^1 + 2^2 + 3^3 + ... + 1000^1000.");
            MathOperation Number = new MathOperation();
            List<long> Number10 = new List<long>();

            for (short i = 1; i < 1001; i++)
            {
                Number.InputNumber = i;
                Number10.Add(Number.PowNumber());
            }
            Console.WriteLine($"Ответ: {Number.AddNumber(Number10)}");
        }
    }
}
