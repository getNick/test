#pragma once
#include <string>
using namespace std;
class student {
public:
	student();
	student(string name, string lastName);

	~student();
	void setName(string str);
	string getName();
	void setLastName(string str);
	string getLastName();
	void setScore(int *arr);
	int* getScore();
	double getAverageBall();
	void saveInFile();

private:
	string name;
	string lastName;
	double averageBall;
	int score[5];
};
