// test1.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
using namespace std;
bool firstThreadRun = false;
bool secondThreadRun = false;
int queue = 0;
int test = 0;
void check1();
void check2();
int main()
{
	CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)check1, NULL, NULL, NULL);
	CreateThread(NULL, NULL, (LPTHREAD_START_ROUTINE)check2, NULL, NULL, NULL);
	system("pause");
    return 0;
}
void check1() {//Деккера
	while (true) {
		firstThreadRun = true;
		while (secondThreadRun == true)
			if (queue == 2) {
				firstThreadRun = false;
				while (queue == 2) {
				}
				firstThreadRun = true;
			}
		//critical section
		test++;
		cout << test<<endl;
		firstThreadRun = false;
		queue = 2;
		Sleep(1000);
	}
}
void check2() {//Деккера
	while (true) {
		secondThreadRun = true;
		while (firstThreadRun == true)
			if (queue == 1) {
				secondThreadRun = false;
				while (queue == 1) {
				}
				secondThreadRun = true;
			}
	
		//critical section
		test--;
		cout << test<<endl;
		secondThreadRun = false;
		queue = 1;
		Sleep(1500);
	}
}

