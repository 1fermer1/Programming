using System;

namespace Проблемы_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму только одиннадцати простых чисел, которые можно усечь слева направо и справа налево.");
            int Sum = 0, Amount = 0;
            Prime Number = new Prime();
            RemoveDigit PrimeNumber = new RemoveDigit();

            for (int i = 11; Amount < 11; i++)
            {
                Number.InputNumber = i;
                if (Number.PrimeNumber())
                {
                    PrimeNumber.InputNumber = i;
                    if (PrimeNumber.RemoveDigitRight())
                    {
                        PrimeNumber.InputNumber = i;
                        if (PrimeNumber.RemoveDigitLeft())
                        {
                            Sum += i;
                            Amount++;
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.WriteLine($"Ответ: {Sum}");
        }
    }
}
