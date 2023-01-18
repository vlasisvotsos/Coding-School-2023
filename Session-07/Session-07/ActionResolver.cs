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
            Logger = new MessageLogger();
        }
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.RequestID = request.RequestID;
            response.ResponseID=Guid.NewGuid();

            Log("EXECUTION START");

            switch (request.Action)
            {
                case ActionEnum.Convert:
                    Log("CONVERT");
                    response.Output =  Convert(request.Input);
                break;
                case ActionEnum.Uppercase:
                    Log("UPPERCASE");
                    response.Output = Uppercase(request.Input);
                break;
                case ActionEnum.Reverse:
                    Log("REVERSE");
                    response.Output = Reverse(request.Input);
                break;
                default:
                    Log("Error Message");
                break;
            }

                return response;
            
        }
        public string Convert(string input) {
            try
            {
                StringConvert convert = new StringConvert();
                convert.Text = input;

            }
            catch(Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                Log("EXECUTION END");
            }
            return String.Empty;
        }
        public string Uppercase(string input)
        {
            try
            {
                StringUppercase convert = new StringUppercase();
                convert.Text = input;

            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                Log("EXECUTION END");
            }
            return String.Empty;
        }
        public string Reverse(string input)
        {
            try
            {
                StringReverse convert = new StringReverse();
                convert.Text = input;

            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                Log("EXECUTION END");
            }
            return String.Empty;
        }
        private void Log(string text)
        {

            Logger.Write(new Message("------------"));

            Message message = new Message(text);
            Logger.Write(message);
        }
    }
}
