#include <iostream>
#include <string>
using namespace std;

int main(int argc, char* argv[])
{
	// version 1
	for (int i = 1; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			for (int k = 0; k < 10; k++)
			{
				if (i * 100 + j * 10 + k == pow(i, 3) + pow(j, 3) + pow(k, 3))
					cout << i * 100 + j * 10 + k << '\n';
			}
		}
	}
	cout << "\n\n";

	// version 2
	string temp;
	for (int i = 100; i < 1000; i++)
	{
		temp = to_string(i);
		if (i == pow(int(temp[0]) - 48, 3) + pow(int(temp[1]) - 48, 3) + pow(int(temp[2]) - 48, 3))
			cout << i << '\n';
	}
	cout << "\n\n";

	// version 3
	for (int i = 100; i < 1000; i++)
	{
		if (i == pow((i % 100 - i % 10) / 10, 3) + pow(i % 10, 3) + pow((i - i % 100) / 100, 3))
			cout << i << '\n';
	}
	cout << "\n\n";

	// version ***
	string temp1;
	int UwU;
	cout << "is this armstrong number? ";
	cin >> UwU;
	temp1 = to_string(UwU);
	int sum = 0;
	//if (i == pow(int(temp[0]) - 48, 3) + pow(int(temp[1]) - 48, 3) + pow(int(temp[2]) - 48, 3))
	for (int i = 0; i < temp1.size(); i++)
	{
		sum += pow(int(temp1[i]) - 48, temp1.size());
	}
	if (UwU == sum)
		cout << "yes\n";
	else
		cout << "no\n";


	return 0;
}