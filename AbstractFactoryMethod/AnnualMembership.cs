//Concrete creator or factory class

namespace abstractFactoryMethod
{
    public class AnnualMembership:Membership
    {
        override public MemberInterface CreateMember()
        {
			return new AnnualMembers();
			
		}
        override public BooksCount AllocateBooks()
        {
            return new BooksForAnuualMembers();
        }
    }
}
