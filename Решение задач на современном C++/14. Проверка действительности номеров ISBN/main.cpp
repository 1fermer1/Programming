#include <iostream>
#include <string>
using namespace std;

int isISBN10(string strNumISBN)
{
	if (strNumISBN.size() != 10 && strNumISBN.size() != 13)
		return 0;
	for (int i = 0; i < strNumISBN.size(); i++)
	{
		if ((int)strNumISBN[i] < 48 || (int)strNumISBN[i] > 57)
			return 0;
	}
	if (strNumISBN.size() == 10)
	{
		int sum = 0;
		for (int i = 0; i < 10; i++)
		{
			sum += ((int)strNumISBN[i] - 48) * (10 - i);
		}
		if (sum % 11 == 0)
			return 10;
	}
	else
	{
		int sum = 0;
		for (int i = 0, j = -1; i < 13; i++, j *= -1)
		{
			sum += ((int)strNumISBN[i] - 48) * (2 + j);
		}
		if (sum % 10 == 0)
			return 13;
	}
	return 0;
}

int main(int argc, char* argv[])
{
	string strNumISBN = "", sTemp;
	cout << "input ISBN number: ";
	cin >> sTemp;
	cout << '\n';

	for (int i = 0; i < sTemp.size(); i++)
	{
		if (sTemp[i] == '-')
			continue;
		strNumISBN += sTemp[i];
	}


	switch(isISBN10(strNumISBN))
	{
	case 0:
		cout << sTemp << " isn't ISBN-10 or ISBN-13 number\n\n";
		break;
	case 10:
		cout << sTemp << " is ISBN-10 number\n\n";
		break;
	case 13:
		cout << sTemp << " is ISBN-13 number\n\n";
		break;
	}

	return 0;
}