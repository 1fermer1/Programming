using System;

namespace Проблема_19
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Сколько воскресений приходилось на первое число месяца в двадцатом веке(с 1 января 1901 года по 31 декабря 2000 года)?");
			int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			int Sunday = 0, days = 366;
			for (int i = 1901; i < 2001; i++)
			{
				if (i % 4 == 0)
				{
					month[1]++;
				}
				for (int n = 0; n < 12; n++)
				{
					days += month[n];
					if (days % 7 == 0)
					{
						Sunday++;
					}
				}
				if (i % 4 == 0)
				{
					month[1]--;
				}
			}
			Console.WriteLine("Ответ: " + Sunday);

		}
	}
}
