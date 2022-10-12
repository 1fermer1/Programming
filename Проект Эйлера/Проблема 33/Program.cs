using System;

namespace Проблема_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Существует ровно четыре нетривиальных примера этого типа дроби, меньше единицы по значению и содержащих две цифры в числителе и знаменателе. Если произведение этих четырех дробей дано в его наименьших общих выражениях, найдите значение знаменателя.");
            int Numerator = 0, Denominator = 0, ProductNumerator = 1, ProductDenominator = 1;
            NonTrivialExamples Number = new NonTrivialExamples();

            for (int i = 99; i > 10; i--)
            {
                if ((i % 10) != 0)
                {
                    Number.Denominator = i;
                    for (int n = (i - 1); n > 10; n--)
                    {
                        if ((n % 10) != 0)
                        {
                            Number.Numerator = n;
                            if (Number.NonTrivialExamplesNumber())
                            {
                                Numerator = n;
                                Denominator = i;
                                for (int p = n; p > 1; p--)
                                {
                                    if ((Numerator % p) == 0 && (Denominator % p) == 0)
                                    {
                                        Numerator /= p;
                                        Denominator /= p;
                                    }
                                }
                                ProductDenominator *= Denominator;
                                ProductNumerator *= Numerator;
                            }
                        }
                    }
                }
            }
            for (int p = ProductNumerator; p > 1; p--)
            {
                if ((ProductNumerator % p) == 0 && (ProductDenominator % p) == 0)
                {
                    ProductNumerator /= p;
                    ProductDenominator /= p;
                }
            }
            Console.WriteLine($"Ответ: {ProductDenominator}");
        }
    }
}
