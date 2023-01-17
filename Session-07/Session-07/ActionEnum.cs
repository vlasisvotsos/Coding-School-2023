namespace Session_07
{
    public class ActionEnum
    {
        public string Request;
        public enum actionEnum
        {
            Convertion, 
            Uppercase, 
            Reverse
        }
        public ActionEnum() {
        }
        public ActionEnum(string request)
        {
            Request = request;
        }
    }
}