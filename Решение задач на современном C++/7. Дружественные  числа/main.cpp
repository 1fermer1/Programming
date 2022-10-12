#include <iostream>
using namespace std;

int sumDivisors(int const num)
{
	int sum = 1;
	for (int i = 2; i <= sqrt(num); i++)
	{
		if (num % i == 0)
			sum += i * i == num ? i : (i + num / i);
	}
	return sum;
}

int main(int argc, char* argv[])
{
	int temp;
	for (int i = 4; i < 1000000; i++)
	{
		temp = sumDivisors(i);
		if (i == sumDivisors(temp) && i < temp && temp < 1000000)
			cout << i << '\t' << temp << '\n';
	}


	return 0;
}