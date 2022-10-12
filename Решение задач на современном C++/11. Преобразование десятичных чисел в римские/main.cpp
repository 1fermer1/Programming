#include <iostream>
#include <string>
using namespace std;

string romeDigit(string s, int n)
{
	string a = "";
	switch (n)
	{
	case 0:
		return "";
	case 1:
		a = s[0];
		return a;
	case 2:
		a = s[0];
		a += s[0];
		return a;
	case 3:
		a = s[0];
		a += s[0];
		a += s[0];
		return a;
	case 4:
		a = s[0];
		a += s[1];
		return a;
	case 5:
		a = s[1];
		return a;
	case 6:
		a = s[1];
		a += s[0];
		return a;
	case 7:
		a = s[1];
		a += s[0];
		a += s[0];
		return a;
	case 8:
		a = s[1];
		a += s[0];
		a += s[0];
		a += s[0];
		return a;
	case 9:
		a = s[0];
		a += s[2];
		return a;
	}
}

int main(int argc, char* argv[])
{
	string l1 = "IVX";
	string l2 = "XLC";
	string l3 = "CDM";


	int num;
	cin >> num;
	string romeNum = "";
	if (num == 0)
		cout << "nulla";
	romeNum.insert(0, romeDigit(l1, (num % 10)));
	num /= 10;
	romeNum.insert(0, romeDigit(l2, (num % 10)));
	num /= 10;
	romeNum.insert(0, romeDigit(l3, (num % 10)));
	num /= 10;
	while (num > 0)
	{
		romeNum.insert(0, "M");
		num--;
	}
	cout << romeNum << endl;
	
	return 0;
}