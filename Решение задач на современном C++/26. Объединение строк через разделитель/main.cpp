#include <iostream>
#include <string>
using namespace std;

string combinedString(string words[], string splitter, int countWords)
{
	string temp = words[0];
	for (int i = 1; i < countWords; i++)
	{
		temp += splitter;
		temp += words[i];
	}
	return temp;
}

int main(int argc, char* argv[])
{
	string words[] = { "hi", "my", "name", "is", "mask"};
	
	cout << combinedString(words, " ", (sizeof(words) / sizeof(words[1])));


	return 0;
}