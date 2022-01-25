using System;

namespace adapterPattren
{
    public class existingSystem
    {
        //locateId is the combination of call number and accession number
        public string LocateId { get; set; }
        public bool status { get; set; }
        public existingSystem(int callNumber,int accesionNumber)
        {
            LocateId = Convert.ToString(callNumber) +"_"+ Convert.ToString(accesionNumber);
            status = true;
        }
        public existingSystem(){ }
        //return locateId of book if it is available
        public string search()
        {
            Console.WriteLine("Searching book with locateID::" + LocateId);
            if (status == true)
                return LocateId;
            else
                return "";
        }
        public void issueBook(string locId)
        {
            Console.WriteLine("Issuing book with locateID::" + locId);
            //issue the book
        }
        public void returnBook(string locID)
        {
            Console.WriteLine("Returning book with locateID::" + locID);
            //return the book
        }
    }
}
