using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {

        }
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.RequestID = request.RequestID;
            response.ResponseID=Guid.NewGuid();

            MessageLogger logger = new MessageLogger();

            Message message = new Message();
            message.Text = "Execution Start";
            message.TimeStamp = DateTime.Now;



            switch (request.Action)
            {
                case ActionEnum.Convert:
                    response.Output =  Convert(request.Input);
                break;
                case ActionEnum.Uppercase:
                    response.Output = Uppercase(request.Input);
                break;
                case ActionEnum.Reverse:
                    response.Output = Reverse(request.Input);
                break;
                default:
                break;
            }

                return response;
            
        }
        public string Convert(string input) {
            try
            {

            }
            catch(Exception ex)
            {
                throw;
            }
            return null;

        }
        public string Uppercase(string input)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }
        public string Reverse(string input)
        {
            try
            {

            }
            catch (Exception ex)
            {

            throw;
            }
            return null;
        }
    }
}
