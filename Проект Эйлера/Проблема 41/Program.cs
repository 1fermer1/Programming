using System;

namespace Проблема_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое наибольшее существующее n-значное панцифровое простое число?");
            Pandigital Number = new Pandigital();
            Prime PandigitalNumber = new Prime();

            for (int i = 7654321; i > 1234566; i -= 2)
            {
                Number.InputNumber = i;
                if (Number.PandigitalNumber())
                {
                    PandigitalNumber.InputPandigitalNumber = i;
                    if (PandigitalNumber.PrimePandigitalNumber())
                    {
                        Console.WriteLine($"Ответ: {i}");
                        return;
                    }
                }
            }
            for (int i = 4321; i > 1233; i -= 2)
            {
                Number.InputNumber = i;
                if (Number.PandigitalNumber())
                {
                    PandigitalNumber.InputPandigitalNumber = i;
                    if (PandigitalNumber.PrimePandigitalNumber())
                    {
                        Console.WriteLine($"Ответ: {i}");
                        return;
                    }
                }
            }
        }
    }
}
