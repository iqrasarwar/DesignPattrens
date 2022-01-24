using System;

namespace FacadePattren
{
    class Facade
    {
       public void DisplayTranscript()
        {
            Console.WriteLine("\t\t------------DISPLAYING TRANSCRIPT-----------");
            semInterface first = new FirstSem();
            semInterface second = new SecondSem();
            semInterface third = new ThirdSem();
            semInterface fourth = new FourthSem();
            first.DisplayGrades();
            second.DisplayGrades();
            third.DisplayGrades();
            fourth.DisplayGrades();
        }
    }
}
