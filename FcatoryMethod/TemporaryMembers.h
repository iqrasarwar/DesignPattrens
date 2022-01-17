//Concrete Product => it is different implementations of the product interface.
#pragma once
#include "MembersInterface.h"
class TemporaryMembers : public MembersInterface
{
	void RegisterMember()
	{
		cout << "Registering an temporay member." << endl;
		//code to register a new member and add to database ....
	}
};

