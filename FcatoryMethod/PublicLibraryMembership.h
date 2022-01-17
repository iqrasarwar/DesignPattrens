//concreteCreator
#pragma once
#include "Membership.h"
#include "TemporaryMembers.h"
#include "AnnualMembers.h"
#include "PermanentMembers.h"
class PublicLibraryMembership : public Membership
{
	MembersInterface* CreateMember()
	{
		string type;
		cout << "Enter member type(temporary/permanent/annual):: ";
		cin >> type;
		if (type == "temporary")
			return new TemporaryMembers();
		else if (type == "permanent")
			return new PermanentMembers();
		else if (type == "annual")
			return new AnnualMembers();
		else
			cout << "Unknown type!By default using Tempoaray." << endl;
		return new TemporaryMembers();
	}
};

