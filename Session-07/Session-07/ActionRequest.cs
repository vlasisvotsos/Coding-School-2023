using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionRequest
    {
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public enum ActionEnums
        {
            Convertion,
            Uppercase,
            Reverse
        }
        public ActionRequest() { 
        
        }
        public ActionRequest(Guid requestID,ActionEnums action)
        {
            RequestID= requestID;
            switch (action)
            {
                case ActionEnums.Convertion:
                    break;
                case ActionEnums.Uppercase:
                    break;
                case ActionEnums.Reverse:
                    break;
                default:
                    Console.WriteLine("Error Message");
                    break;

            }
        }

        public ActionRequest(Guid requestID)
        {
            RequestID = requestID;
        }
    }
}
