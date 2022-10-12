using System;

namespace Проблема_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите сумму всех чисел, меньших одного миллиона, которые являются палиндромными по основанию 10 и основанию 2.");
            int Sum = 0;
            PalindromicNumber Num = new PalindromicNumber();
            BinaryNumber BNum = new BinaryNumber();
            for (int i = 1; i < 1000000; i++)
            {
                Num.StrNum = Convert.ToString(i);
                if (Num.Palindromic())
                {
                    BNum.BiNum = i;
                    Num.StrNum = BNum.StrBNum();
                    if (Num.Palindromic())
                    {
                        Sum += i;
                    }
                }
            }
            Console.WriteLine($"Ответ: {Sum}");
        }
    }
}
