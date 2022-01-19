/*
 * PROBLEM
 * Jhon is deciding to implement a library managment system. Along other, a major concern of the system is that a book can be issued to 
 * only one member at a time and jhon have to enforce this restriction. All books are managed by an interface named booksStore. each bookStore
 * can instansiate any particular book only once. 
 */
/*
 * SOLUTION
 * as bookstore can instansiate only one book at a time, if jhon can force booksStore to create only one instance at a time problem ll'be resolved.
 * So, Jhon decided to apply Singleton Method.
 */

using System;

namespace SingletonMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor claeed only for one 
            string c;
            do
            {
                Console.WriteLine("Wanna create a bookStore?(Y/N)");
                c = Console.ReadLine();
                if (c == "y" || c == "Y")
                {
                    BooksStore b = BooksStore.getStore();
                    Console.WriteLine("Book store created with id " + b.storeId);
                }
            } while (c == "y" || c == "Y");
        }
    }
}
