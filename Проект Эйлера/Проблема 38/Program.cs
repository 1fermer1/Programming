using System;

namespace Проблема_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое наибольшее панцифровое 9-значное число от 1 до 9 может быть образовано как конкатенированное произведение целого числа на (1,2, ..., n ), где n > 1?");
            string AnswerPandigitalNumber = "000000000";
            string PandigitalNumber = null;
            Pandigital Number = new Pandigital();
            
            for (int i = 1; i < 10000; i++)
            {
                PandigitalNumber = null;
                for (int n = 1; ; n++)
                {
                    PandigitalNumber += (i * n);
                    if (PandigitalNumber.Length >= 9)
                    {
                        break;
                    }
                }
                if (PandigitalNumber.Length == 9)
                {
                    Number.InputNumber = PandigitalNumber;
                    if (Number.PandigitalNumber())
                    {
                        for (int n = 0; n < 9; n++)
                        {
                            if (AnswerPandigitalNumber[n] < PandigitalNumber[n])
                            {
                                AnswerPandigitalNumber = PandigitalNumber;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Ответ: {AnswerPandigitalNumber}");
        }
    }
}
