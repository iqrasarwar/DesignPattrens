
/*
 * PROBLEM
 * Jhon is implementing a library managment system.
 * Punjab Public Library have initiated a new section for newspapers and journals. The existing books collection of library is arranged on 
 * the basis of a call number and accession number. But for this section, they have an arrangment based on the date and then accession 
 * number.They want jhon to upgrade their managment system to support (the search, issue, return) all operations for the new section as it 
 * does for existing sections.
 */
/*
 * SOLUTION
 * jhon can't change the existing system. so, he decided to implement a adapter pattren to resolve the incompatibility problem.
 */

using System;

namespace adapterPattren
{
    class driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t------------------ Upgrading existing system to New System! ------------------\n");
            //existing system have its all functionality implemented.
            existingSystem oldBook = new existingSystem(300,20);
            existingSystem oldBook1 = new existingSystem(600, 34);
            oldBook.search();
            oldBook1.issueBook(oldBook.LocateId);
            //new system have no functionality and have to use existing system functionality but it have no compatible locateId
            newSystem newsPaper1 = new newSystem(540, 22, 01, 2022);
            newSystem newsPaper2 = new newSystem(310, 09, 04, 2015);
            //newsPaper2.issueBook(); //error
            //adapter can provide existing system functionality to new system
            adapter adapter1 = new adapter(newsPaper1);
            adapter adapter2 = new adapter(newsPaper2);
            adapter1.search();
            adapter2.returnBook(adapter2.LocateId);
        }
    }
}
