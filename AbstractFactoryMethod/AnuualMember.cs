//Concrete Product => it is different implementations of the product interface.
using System;

namespace abstractFactoryMethod
{
	public class AnnualMembers : MemberInterface
	{
		public void RegisterMember()
		{
			Console.WriteLine("Registering an anuual member.");
			//code to register a new member and add to database ....
		}
	}
}
