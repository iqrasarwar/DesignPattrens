//Product Class
//The Product declares the interface, which is common to all objects that can be produced by the creatorand its subclasses.
#pragma once
#include<string>
#include<iostream>
using namespace std;

class MembersInterface
{
public:
	//different implementation for each concrete product
	virtual void RegisterMember() = 0;
	//same for all is implemented in product(interface) class
	int getBooksCount()
	{
		return this->BooksAllowed;
	}
private:
	const int BooksAllowed = 5;
};

