//Concrete creator or factory class

namespace abstractFactoryMethod
{
    public class TemporaryMembership : Membership
    {
        override public MemberInterface CreateMember()
        {
            return new TemporaryMembers();

        }
        override public BooksCount AllocateBooks()
        {
            return new BooksForTemporaryMember();
        }
    }
}
