#include <iostream>
#include <string>
#include <fstream>
using namespace std;

int main()
{
	fstream file;
	file.open("C:\\base_exp.txt");
	char base_exp[100];
	file.getline(base_exp, 100);
	double base1 = 0, base2 = 0, exp1 = 0, exp2 = 0;
	string temp = "";
	string temp2 = "";
	for (int j = 0; base_exp[j] != NULL; j++)
	{
		if (base_exp[j] == ',')
		{
			j += 1;
			for (; base_exp[j] != NULL; j++)
			{
				temp2 += base_exp[j];
			}
			break;
		}
		temp += base_exp[j];
	}
	base1 = atof(temp.c_str());
	exp1 = atof(temp2.c_str());
	int answer = 1;
	for (int i = 2; i <= 1000; i++)
	{
		file.getline(base_exp, 100);
		temp = "";
		temp2 = "";
		for (int j = 0; base_exp[j] != NULL; j++)
		{
			if (base_exp[j] == ',')
			{
				j += 1;
				for (; base_exp[j] != NULL; j++)
				{
					temp2 += base_exp[j];
				}
				break;
			}
			temp += base_exp[j];
		}
		base2 = atof(temp.c_str());
		exp2 = atof(temp2.c_str());
		if (base2 > pow(base1, (exp1 / exp2)))
		{
			answer = i;
			base1 = base2;
			exp1 = exp2;
		}
	}
	cout << answer;

	return 0;
}