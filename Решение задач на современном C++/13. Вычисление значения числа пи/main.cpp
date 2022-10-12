#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
	double PI = 3;

	for (double i = 2, j = 1; i < 2000; i += 2, j *= -1)
	{
		PI += j * (4 / (i * (i + 1) * (i + 2)));
	}
	PI = round(PI * 100) / 100;
	cout << PI << '\n';
	

	return 0;
}