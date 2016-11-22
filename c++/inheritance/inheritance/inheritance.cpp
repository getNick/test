// inheritance.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <string>
#include "box.h"
#include "obj.h"
using namespace std;

int main()
{
	box *obj1 = new box;
	cout<<obj1->getVolume();
	system("pause");
    return 0;
}

