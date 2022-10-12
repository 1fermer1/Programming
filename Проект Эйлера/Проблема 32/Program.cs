using System;

namespace Проблема_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех произведений, множимое/множитель/произведение которые можно записать в виде панцифров от 1 до 9.");
            int SumProducts = 0;
            Pandigital Number = new Pandigital();

            for (int i = 1000; i < 10000; i++)
            {
                Number.Input = null;
                for (int n = 2; n < Math.Sqrt(i); n++)
                {
                    if ((i % n) == 0)
                    {
                        Number.Input = (i.ToString() + n.ToString() + (i / n).ToString());
                        if (Number.Input.Length == 9 && Number.PandigitalNumber())
                        {
                            SumProducts += i;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"Ответ: {SumProducts}");
        }
    }
}
