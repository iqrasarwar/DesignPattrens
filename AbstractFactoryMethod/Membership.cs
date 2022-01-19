/* The Factory Interface
*The Creator Class
* conatins Factory method.
*/

namespace abstractFactoryMethod
{
	public abstract class Membership 
	{
		//standard method--> perform operations required/common for all!
		public void CreatMembership()
		{
			MemberInterface m = CreateMember();
			BooksCount b = AllocateBooks();
			m.RegisterMember();
			b.booksCount();
			
		}
		//factoy methods
		public abstract MemberInterface CreateMember();
		public abstract BooksCount AllocateBooks();
	}
}
