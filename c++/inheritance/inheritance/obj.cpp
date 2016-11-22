#include "stdafx.h"
#include "obj.h"

obj::obj()
{
	cout << "Enter name obj" << endl;
	cin >> name;
	cout << "Enter position" << endl;
	cin >> position[0] >> position[1] >> position[2];
}

obj::~obj()
{
}