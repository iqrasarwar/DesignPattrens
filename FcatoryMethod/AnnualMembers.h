//Concrete Product => it is different implementations of the product interface.
#pragma once
#include "MembersInterface.h"
class AnnualMembers : public MembersInterface
{
	void RegisterMember()
	{
		cout << "Registering an anuual member." << endl;
		//code to register a new member and add to database ....
	}
};

