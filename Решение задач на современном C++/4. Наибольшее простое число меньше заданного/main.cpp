#include <iostream>
#include <vector>
using namespace std;

int main(int argc, char* argv[])
{
	int a;
	cout << "Input number: ";
	cin >> a;
	int* nums = new int[a];
	//vector<int> nums = { 0, 0 };
	nums[0] = nums[1] = 0;
	for (int i = 2; i < a; i++)
	{
		nums[i] = i;
		//nums.push_back(i);
	}

	for (int i = 2; i < a; i++)
	{
		for (int j = 2; a > i * j; j++)
		{
			nums[i * j] = 0;
		}
	}

	for (int i = a - 1; i > 0; i--)
	{
		if (nums[i] != 0)
		{
			cout << nums[i] << endl;
			break;
		}
	}

	delete nums;
	return 0;
}