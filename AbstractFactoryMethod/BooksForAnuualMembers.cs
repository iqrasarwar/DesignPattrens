//Concrete Product => it is different implementations of the product interface.
using System;

namespace abstractFactoryMethod
{
    public class BooksForAnuualMembers : BooksCount
    {
        public int noOfBooks { get; set; }

        public void booksCount()
        {
            noOfBooks = 5;
            Console.WriteLine("You can avail 5 books at a time.");
        }
    }
}
