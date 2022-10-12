using System;

namespace Проблема_17
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Если бы все числа от 1 до 1000 включительно были записаны словами, сколько букв было бы использовано?");
			int letters = 11;
			for (int i = 1; i < 1000; i++)
			{
				int a = (i - i % 100) / 100;
				if (a > 0)
				{
					letters += nums(a);
					letters += 7;
					if ((i % 100) != 0)
					{
						letters += 3;
					}
				}
				int b = i % 100;
				if(b < 21)
				{
					letters += nums(b);
				}
				else
				{
					int c = b % 10;
					letters += nums(c);
					b -= c;
					letters += nums(b);
				}
			}
			Console.WriteLine("Ответ: " + letters);
		}
		static int nums(int a)
		{
			int res = 0;
			switch(a)
			{
				case 1:
					res = 3;
					break;
				case 2:
					res = 3;
					break;
				case 3:
					res = 5;
					break;
				case 4:
					res = 4;
					break;
				case 5:
					res = 4;
					break;
				case 6:
					res = 3;
					break;
				case 7:
					res = 5;
					break;
				case 8:
					res = 5;
					break;
				case 9:
					res = 4;
					break;
				case 10:
					res = 3;
					break;
				case 11:
					res = 6;
					break;
				case 12:
					res = 6;
					break;
				case 13:
					res = 8;
					break;
				case 14:
					res = 8;
					break;
				case 15:
					res = 7;
					break;
				case 16:
					res = 7;
					break;
				case 17:
					res = 9;
					break;
				case 18:
					res = 8;
					break;
				case 19:
					res = 8;
					break;
				case 20:
					res = 6;
					break;
				case 30:
					res = 6;
					break;
				case 40:
					res = 5;
					break;
				case 50:
					res = 5;
					break;
				case 60:
					res = 5;
					break;
				case 70:
					res = 7;
					break;
				case 80:
					res = 6;
					break;
				case 90:
					res = 6;
					break;
			}
			return res;
		}
	}
}
