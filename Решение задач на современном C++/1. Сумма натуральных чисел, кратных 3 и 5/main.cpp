#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
	setlocale(LC_ALL, "");
	unsigned int limit; // unsigned �.�. ���� ���������� ����������� �����
	long long sum = 0;
	cout << "Upper limit: ";
	cin >> limit;

	for (unsigned int i = 3; i <= limit; i++) // unsigned �.�. limit ���� unsigned
	{
		if ((i % 3 == 0) || (i % 5 == 0))
		{
			sum += i;
		}
	}
	cout << "Sum equals to " << sum << endl;

	return 0;
}