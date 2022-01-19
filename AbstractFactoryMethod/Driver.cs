/*
* PROBLEM STATMENT:
* Let say John owns a production compary that offers a membership boot for libraries. He conducted a survey and concluded that 
* currently libraries offers three types of memberships: 1- Annual 2- Permanent 3- Temporary. In future they may offer others too.
* Also all the libaries offer different number of books for each type of membership. i.e. 3 for temporary, 5 for annual, and 10 for 
* permanent. Design a system to offer theses pacakages. 
*/

/*
* ANALYSIS
* we have different pacakages here that offer different combinations of products and membership types can vary in future.
* so we can apply Abstract Factory pattren here effectively!
* Our PRODUCTS are Members and BooksCount. Concrete products can be annualMember, permanentMember, and TemporaryMember and bookscount for each.
* Our Factory/CREATOR is Membership. concrete factories can be the PermanentMembership and publicLibraryMembers etc.
*/

/*
 * Here we suposse that registrartion boot is being developed for publicLibaray out there.
 */
using System;

namespace abstractFactoryMethod
{
    class Driver
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~ Welcome to MemberShip Boot of PublicLibrary! ~~~~~~~~~~~~~~~~~~~~~~");
            string type;
            Console.WriteLine("Enter member type(temporary/permanent/annual):: ");
            type = Console.ReadLine();

            Membership m; //factory or creator class
			if (type == "temporary")
			{
				m = new TemporaryMembership(); //concrete creator/factory
			}
			else if (type == "permanent")
			{
				m = new permanentMembership(); //concrete creator/factory
			}
			else if (type == "annual")
			{
				m = new AnnualMembership(); //concrete creator/factory
			}
			else
			{
				Console.WriteLine("Not valid memeberType!");
				m = new TemporaryMembership(); //concrete creator/factory
			}
			// creating membership Pacakage
			MembershipPacakage p = new MembershipPacakage(m);
		}
    }
}
