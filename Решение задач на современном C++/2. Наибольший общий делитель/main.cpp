#include <iostream>
#include <numeric>
using namespace std;

int main(int argc, char* argv[])
{
	unsigned int firstNumber, secondNumber, temp;
	cout << "Input first number: ";
	cin >> firstNumber;
	cout << "Input second number: ";
	cin >> secondNumber;

	while (secondNumber != 0)
	{
		temp = firstNumber % secondNumber;
		firstNumber = secondNumber;
		secondNumber = temp;
	}

	cout << "Greatest common divisior equals to " << firstNumber << endl;

	// cout << "Greatest common divisior equals to " << gcd(firstNumber, secondNumber) << endl;
	return 0;
}