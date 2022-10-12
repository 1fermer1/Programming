#include <iostream>
#include <numeric>
using namespace std;

int main(int argc, char* argv[])
{
	int a, b, temp, a2, b2;
	cout << "Input first number: ";
	cin >> a;
	cout << "Input second number: ";
	cin >> b;

	a2 = a; b2 = b;
	while (b2 != 0)
	{
		temp = a2 % b2;
		a2 = b2;
		b2 = temp;
	}
	cout << a * b / a2 << endl;
	cout << a * b / gcd(a, b) << endl;
	cout << lcm(a, b) << endl << endl;

	return 0;
}