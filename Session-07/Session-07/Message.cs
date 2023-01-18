namespace Session_07
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Text { get; set; }
        public Message() {
            ID = Guid.NewGuid();
        }
        public Message(string text) { 
            ID= Guid.NewGuid();
            TimeStamp= DateTime.Now;
            Text = text;
        }
    }
}