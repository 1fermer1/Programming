#include <iostream>
#include <string>
using namespace std;

// Formula "code Gray": g = b ^ (b >> 1) 
//                      g = b 'xor' (b 'logical shift to the right' 1)
//                                  ((int)b / 2)

string bin(int n)
{
	string s = "";
	while (n > 0)
	{
		s.insert(0, to_string(n % 2));
		n /= 2;
	}

	while (s.size() < 5)
	{
		s.insert(0, "0");
	}

	return s;
}

int main(int argc, char* argv[])
{
	std::cout << "Number\tBinary\tGray\tDecoded\n";
	std::cout << "------\t------\t----\t-------\n";
	for (int i = 0; i < 32; i++)
	{
		cout << i << '\t' << bin(i) << '\t' << bin((i ^ (i >> 1))) << '\t' << i << '\n';
	}

	return 0;
}