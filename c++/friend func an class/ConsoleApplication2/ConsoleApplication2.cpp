// ConsoleApplication2.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;
class human;
class medicineChest {
	int healthRecovery;
public:
	friend class human;
	medicineChest(int h) {
		healthRecovery = h;
	}
	~medicineChest() {
		cout << "Used medicine chest" << endl;
	}
};
class human {
	string name;
	int healht;
public:
	friend void usedMedChest(human &h);
	human(string name, int healht) {
		this->name = name;
		this->healht = healht;
		getStatus();
	}
	void getStatus() {
		cout << name << " " << healht << endl;
	}
	void useMedChest(medicineChest &h) {
		healht += h.healthRecovery;
		h.~medicineChest();
	}
};

void usedMedChest(human &h) {//friend function
	h.healht += 10;
}

int main()
{
	human player("Maks", 40);
	usedMedChest(player);//friend function
	player.getStatus();
	medicineChest apt(25);
	player.useMedChest(apt);
	//delete &apt;
	player.getStatus();
	system("pause");
	return 0;
}
