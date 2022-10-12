#include <iostream>
#include <vector>
using namespace std;

int main()
{
	vector<int> prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
	bool temp = 1;
	for (int i = 27; i < 10001; i += 2)
	{
		temp = 1;
		for (int j = 1; prime[j] <= sqrt(i); j++)
		{
			if (i % prime[j] == 0)
			{
				temp = 0;
				break;
			}
		}
		if (temp)
		{
			prime.push_back(i);
		}
	}

	long long sum = 1;
	temp = 1;
	int temp2 = 0;
	
	for (int i = 2; i < 100000000; i += 4)
	{
		temp = 1;
		for (int j = 1; j <= sqrt(i); j++)
		{
			if (i % j == 0)
			{
				temp2 = j + (i / j);
				for (int n = 0; n < 1229 && prime[n] <= sqrt(temp2); n++)
				{
					if (temp2 % prime[n] == 0)
					{
						temp = 0;
						break;
					}
				}
				if (!temp)
				{
					break;
				}
			}
		}
		if (temp)
		{
			sum += i;
		}
	}






	std::cout << sum;


	return 0;
}