#include "stdafx.h"
#include "box.h"


box::box()
{
	cout << "Enter size" << endl;
	cin >> size[0] >> size[1] >> size[2];
}

box::~box()
{
}
double box::getVolume() {
	double vol = 1;
	for each (double i in size)
	{
		vol *= i;
	}
	return vol;
}