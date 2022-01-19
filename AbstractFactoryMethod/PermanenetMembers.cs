//Concrete Product => it is different implementations of the product interface.
using System;

namespace abstractFactoryMethod
{
	public class PermanentMembers : MemberInterface
	{
		public void RegisterMember()
		{
			Console.WriteLine("Registering an permanent member.");
			//code to register a new member and add to database ....
		}
	}
}
