using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver : ActionRequest
    {
        public MessageLogger Logger { get; set; }
        ActionRequest Request = new ActionRequest(requestID, action);
        public ActionResolver()
        {

        }
        public ActionResponse Execute(ActionRequest request)
        {
            Request= request;
            switch (request.action)
            {
                    case Convertion
                    break;
                    case Uppercase
                    break;
                    case Reverse
                    break;
                    default: Console.WriteLine("not a valid option");
                    break;

            }

                return null;
            
        }
    }
}
