using System.Runtime.CompilerServices;

namespace Session_07
{
    public class MessageLogger
    {
        public Message[] Message { get; set; }
        private int _messageCounter = 0;
        public MessageLogger() {
            Message= new Message[1000];
            
    }
        public void ReadAll()
        {
            foreach (Message message in Message)
            {

                if (message != null)
                {
                    Console.WriteLine(message.Text);
                }
            }
        }
        public void Clear()
        {
            Message = new Message[1000];
            _messageCounter = 0;
        }
        public void Write(Message messages)
        {
            Message[_messageCounter] = messages;
            _messageCounter++;
        }

    }
}