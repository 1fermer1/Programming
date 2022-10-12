#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
	int maxNum;
	cout << "Input max number: ";
	cin >> maxNum;
	int* primeNums = new int[maxNum + 1];
	primeNums[0] = primeNums[1] = 0;

	for (int i = 2; i < maxNum + 1; i++)
	{
		if (i % 2 == 0)
			primeNums[i] = 0;
		else
			primeNums[i] = i;
	}
	
	for (int i = 3; i < maxNum + 1; i += 2)
	{
		for (int j = 2; maxNum + 1 >= i * j; j++)
			primeNums[i * j] = 0;
	}

	for (int i = 5; i < maxNum - 5; i += 2)
	{
		if (primeNums[i] != 0 && primeNums[i + 6] != 0)
			cout << i << '\t' << i + 6 << '\n';
	}

	return 0;
}