using System;

namespace Проблема_20
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Найдите сумму цифр числа 100!");
			int[] nums = new int[158];
			nums[157] = 6;
			for(int i = 4; i < 101; i++)
            {
				for(int n = 157; n > 0; n--)
				{
					nums[n] *= i;
				}
				for(int k = 157; k > 0; k--)
				{
					int temp = (nums[k] % 10);
					int a = (nums[k] - temp);
					a /= 10;
					nums[k - 1] += a;
					nums[k] = temp;
				}
			}
			int sum = 0;
			foreach (int n in nums)
		    {
				sum += n;
			}
			Console.WriteLine("Ответ: " + sum);
		}
    }
}
