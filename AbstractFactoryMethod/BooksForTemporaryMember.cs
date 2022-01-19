//Concrete Product => it is different implementation of the product interface.
using System;

namespace abstractFactoryMethod
{
    public class BooksForTemporaryMember : BooksCount
    {
        public int noOfBooks { get; set; }

        public void booksCount()
        {
            noOfBooks = 3;
            Console.WriteLine("You can avail 3 books at a time.");
        }
    }
}
