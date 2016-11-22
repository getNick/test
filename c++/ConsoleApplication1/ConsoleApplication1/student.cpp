#include "stdafx.h"
#include "student.h"
#include <string>
#include <iostream>
#include <fstream>

student::student()
{
}
student::student(string name,string lastName)
{
	setName(name);
	setLastName(lastName);
}


student::~student()
{
	saveInFile();
}
void student::setName(string str) {
	student::name = str;
}
string student::getName() {
	return student::name;
}
void student::setLastName(string str) {
	student::lastName = str;
}
string student::getLastName() {
	return student::lastName;
}
void student::setScore(int *arr) {
	for (int i = 0; i < 5; i++) {
		score[i] = arr[i];
	}
}
int* student::getScore() {
	return score;
}
double student::getAverageBall() {
	double sum = 0;
	for (int i = 0; i < 5; i++) {
		sum += score[i];
	}
	averageBall = sum / 5;
	return averageBall;
}

void student::saveInFile()
{
	ofstream fout("file.txt", std::ios::app);
	fout << student::getName() << " " << student::getLastName() << endl;
	for each (int i in student::score)
	{
		fout << i << " ";
	}
	fout << endl;
	fout.close();
}
