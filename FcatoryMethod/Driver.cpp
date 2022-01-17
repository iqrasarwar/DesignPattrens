/*
* PROBLEM STATMENT:
* Let say John owns a production compary that offers a membership boot for libraries. He conducted a survey and concluded that 
* currently libraries offers three types of memberships: 1- Annual 2- Permanent 3- Temporary. In future they may offer others too.
* Also all the libaries offer at max 5 books issueable at a time. other aspects of survey are not of our concern.
*/

/*
* ANALYSIS
* As membership types can vary in future we can apply Factory pattren here effectively!
* Our PRODUCT is Member. Concrete members can be annualMember, permanentMember, and TemporaryMember.
* Our CREATOR is Membership. concrete members can be the orgainzations offering memberships like PuLibrary or PublicLibrary.
*/

#include<iostream>
#include "Membership.h"
#include "PublicLibraryMembership.h";
#include "GcLibraryMembership.h";
#include "PuLibraryMembership.h";
using namespace std;

int main()
{
	//First of all a concrete creator is decided! In actaull system it may be a login or whatever.. just simulation a login slightly!
	cout << "~~~~~~~~~~~~~~~~~~~~~~ Welcome to MemberShip Boot! ~~~~~~~~~~~~~~~~~~~~~~" << endl;
	cout << " Login First, Choose your organization(1,2,3)!\n~~1.PU/FCIT\n~~2.GCU\n~~3.PublicLibrary\n" << endl;
	int n = 0;
	cin >> n;
	Membership* m; //factory or creator class
	if (n == 1)
	{
		m = new PuLibraryMembership(); //concrete creator
	}
	else if (n == 2)
	{
		m = new GcLibraryMembership(); //concrete creator
	}
	else if(n == 3)
	{
		m = new PublicLibraryMembership(); //concrete creator
	}
	else
	{
		cout << "Not valid organization! By default using a Public Library Interface." << endl;
		m = new PublicLibraryMembership(); //concrete creator
	}
	// creating memborship
	m->CreatMembership();//standard method in factory class
	return 0;
}
