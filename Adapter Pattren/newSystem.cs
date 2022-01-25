
namespace adapterPattren
{
    public class newSystem
    {
        //locateid in new system is combination of the attributes stated below.
        public int accessionNumber { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public newSystem()
        {

        }
        public newSystem(int accNum, int day, int month,int year)
        {
            accessionNumber = accNum;
            this.day = day;
            this.year = year;
            this.month = month;
        }

        //we don't want to implement all the functionality of searching books, issuing books, and returning books etc.
        //rather we want to use the existing one.
    }
}
