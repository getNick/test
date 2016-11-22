// template.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
template<typename T>
void printArr( T* const &arr);
template<typename T>
void printArr( T const &arr);
template<typename T>
size_t getArrSize(const T* arr);
int main()
{
	int intArr[]{ 1,23,4,5 };
	double doubleArr[]{ 0.11,2.22,4.2 };
	float floatArr[]{ 0.144,9.242,5.43 };
	double *p = new double[4] {0.23, 0.1, 9.2, 10.42312};
	int *q=new int[3]{ 144,242,43 };
	printArr(doubleArr);
	printArr(intArr);
	printArr(floatArr);
	printArr(p);
	printArr(q);
	system("pause");
	return 0;
}
template<typename T>
void printArr( T const &arr) {
	cout << typeid(arr).name() << endl;
	for (int i = 0; i < size(arr);i++)
	{
		cout << arr[i] << " ";
	}
	cout << endl;
}
template<typename T>
void printArr( T* const&arr) {
	cout << typeid(arr).name() << endl;
	int size = 3;
	for (int i = 0; i <size ; i++)
	{
		cout << arr[i] << " ";
	}
	cout << endl;
}
template<typename T>
size_t getArrSize(T* arr) {
	return _msize(arr)/sizeof(arr);
}
