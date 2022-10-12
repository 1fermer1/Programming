#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
	unsigned long long num;
	for (int u = 0; u < 10; u++)
	{
		cout << "input integer num >= 2: ";
		cin >> num;
		if (num < 2)
			continue;
		while (num % 2 == 0) 
		{
			cout << 2 << '\t';
			num /= 2;
		}
		while (num % 3 == 0)
		{
			cout << 3 << '\t';
			num /= 3;
		}while (num % 5 == 0)
		{
			cout << 5 << '\t';
			num /= 5;
		}

		for (unsigned long long i = 7; num != 1; i += 2)
		{
			while (num % i == 0)
			{
				cout << i << '\t';
				num /= i;
			}
		}
		cout << '\n';
	}
	return 0;
}