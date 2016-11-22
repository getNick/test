// ConsoleApplication1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <string>
#include "student.h"
using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	string name;
	cin >> name;
	string lastName;
	cin >> lastName;
	student std(name,lastName);
	int arr[5];
	cout << "Enter score";
	for (int i = 0; i < 5; i++) {
		cin >> arr[i];
	}
	std.setScore(arr);
	cout << std.getName() << " " << std.getLastName() << " " << std.getAverageBall() <<endl;
	student t1;
	t1.setName("Vasia");
	t1.setLastName("Pupkin");
	int arr2[5];
	for (int i = 0; i < 5; i++) {
		arr2[i]=i++;
	}
	t1.setScore(arr2);
	cout << t1.getName() << " " << t1.getLastName() << " " <<t1.getAverageBall();
	~student();
	system("pause");
    return 0;
}

