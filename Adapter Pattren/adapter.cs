using System;

namespace adapterPattren
{
    public class adapter : existingSystem
    {
        public newSystem oldSys { get; set; }
        public adapter(newSystem sys)
        {
            oldSys = sys;
            int callNumber = oldSys.day * oldSys.month;
            string callNum = Convert.ToString(callNumber) +"_"+ Convert.ToString(oldSys.year);
            LocateId = callNum + "_"+ Convert.ToString(oldSys.accessionNumber);
        }
        //adapter can convert the newSystem locateId into existing system locateID and call functions of existing system safely with 
        //that locateID.
    }
}
