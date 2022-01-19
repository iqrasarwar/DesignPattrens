//Concrete Product => it is different implementations of the product interface.
using System;

namespace abstractFactoryMethod
{
    public class BooksForPermanentMembers : BooksCount
    {
        public int noOfBooks { get; set; }

        public void booksCount()
        {
            noOfBooks = 10;
            Console.WriteLine("You can avail 10 books at a time.");
        }
    }
}
