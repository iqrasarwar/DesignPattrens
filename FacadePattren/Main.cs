//Driver not need to go the details of the semesters their objrects and functions facade is doing all for it.
//here we just need to call a function 

namespace FacadePattren
{
    class driver
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.DisplayTranscript();
        }
    }
}
