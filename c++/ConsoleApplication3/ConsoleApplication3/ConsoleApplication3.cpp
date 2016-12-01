// ConsoleApplication3.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
class Test {
public:
	int *i;
	int value;
	Test(int v) {
		i = new int;
		value = v;
		std::cout << "construstor";
	}
	~Test() {
		delete i;
		std::cout << "destructor";
	}
	void print(){
		std::cout << *i;
	}
};
int main()
{
	/*double * ptr;
	ptr = (double*)malloc(sizeof(double) * 10);
	for (int i = 0; i < 10; i++) {
		ptr[i] = i;
	}
	for (int i = 0; i < 10; i++) {
		std::cout<<ptr[i];
	}*/
	//std::cout << sizeof(Test);
	//Test *t1 = new Test(1);
	int b = 10;
	int a[10];
	for (int i = 0; i < 10; i++) {
		a[i] = 1;
	}
	std::cout << b <<" "<<&b<< std::endl;
	for (int q = 0;1; q++)
		std::cout << *(&b + q)<< std::endl;
	/*

	Test*t =(Test*)malloc(sizeof(Test));
	//t->Test();
	//t->print();
	//std::cout << *t->i;
	t->value = 2;
	std::cout << t->value;
	//delete t;
	free(t);
	*/
	system("pause");
    return 0;
}

