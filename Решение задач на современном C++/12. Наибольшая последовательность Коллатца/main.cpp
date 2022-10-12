#include <iostream>
using namespace std;

int main(int argc, char* argv[])
{
	long long limit = 1000001;
	int* nums = new int[limit]{};
	long long temp;
	int count;

	for (int i = 1; i < 20; i++)
	{
		nums[(int)pow(2, i)] = i;
	}
	for (int i = 3; i < limit; i += 2)
	{
		temp = i;
		count = 0;
		if (nums[i] == 0)
		{
			while (temp > limit || nums[temp] == 0)
			{
				temp = (temp % 2 == 0) ? (temp / 2) : (temp * 3 + 1);
				count++;
			}
			nums[i] = nums[temp] + count;
		}
		for (int j = 1; i * (int)pow(2, j) < limit; j++)
		{
			nums[i * (int)pow(2, j)] = nums[i] + j;
		}
	}

	int maxNum = 0, maxWay = 0;
	for (int i = (limit / 2 + 1); i < limit; i++)
	{
		if (nums[i] > maxWay)
		{
			maxWay = nums[i];
			maxNum = i;
		}
	}

	cout << "num: " << maxNum << "\tway: " << maxWay << '\n';

	return 0;
}