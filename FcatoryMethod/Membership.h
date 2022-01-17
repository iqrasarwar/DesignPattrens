/* The Factory Class
*The Creator Class
* conatins Factory method.
*/
#pragma once
#include <string>
#include "MembersInterface.h";

class Membership
{
public:
	//standard method--> perform operations required/common for all!
	void CreatMembership()
	{
		MembersInterface* m = CreateMember();
		m->RegisterMember();
		cout << "You can get at max " << m->getBooksCount() << " books." << endl;
	}
	//factoy method
	virtual MembersInterface* CreateMember() = 0;
};

