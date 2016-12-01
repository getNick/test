// ConsoleApplication2.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;
class A
{
public:
	int normal;
	A() {
		normal = 0;
		cout << "constructor A" << endl;
	}
	~A() {
		normal = 1;
		cout << "destructor A" << endl;
	}
};
class B :public A {
public:
	void print() {
		cout << "void B" << endl;
	}
	int *m_p;
	B() { m_p = new int;
	cout << "constructor B" << endl;
	}
	~B() {
		delete m_p;
		cout << "destructor B" << endl;
	}
};
int main()
{
	A *classa = new B();
	delete classa;
	system("pause");
    return 0;
}

