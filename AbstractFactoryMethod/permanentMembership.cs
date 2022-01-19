//Concrete creator or factory class

namespace abstractFactoryMethod
{
    public class permanentMembership : Membership
    {
        override public MemberInterface CreateMember()
        {
            return new PermanentMembers();

        }
        override public BooksCount AllocateBooks()
        {
            return new BooksForPermanentMembers();
        }
    }
}
