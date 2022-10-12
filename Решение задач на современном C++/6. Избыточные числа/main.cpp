#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
	int temp, limit;
	cout << "Upper limit: ";
	cin >> limit;

	for (int i = 12; i <= limit; i++)
	{
		
		temp = 1;
		for (int j = 2; j <= sqrt(i); j++)
		{
			if (i % j == 0)
				temp += j * j == i ? j : (j + i / j);
		}
		if (temp > i)
			cout << i << '\t' << temp - i << '\n';
	}




	return 0;
}