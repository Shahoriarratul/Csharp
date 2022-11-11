using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {
        public string LockStatus
        {
            get
            {
               if(LockStatus=="Open" || LockStatus=="Close") 
                {
                    return "Correct";

                }
                else
                {
                    return "Incorrect";
                }
            }
            set
            {
                if(LockStatus == "Open")
                {
                    LockStatus = "Close";
                }
                else
                    {
                    LockStatus = "Open";
                }
            }
        } // Correct lock status are: Open & Close
    }
}
