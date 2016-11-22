#pragma once
#include <string>
#include "obj.h"
#include <iostream>
using namespace std;
class box :public obj
{
public:
	box();
	~box();
	double getVolume();
private:
	double size[3];
};
