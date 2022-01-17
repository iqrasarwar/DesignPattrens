//Concrete Product => it is different implementations of the product interface.
#pragma once
#include "MembersInterface.h"
class PermanentMembers : public MembersInterface
{
	void RegisterMember()
	{
		cout << "Registering an permanent member." << endl;
		//code to register a new member and add to database ....
	}
};

