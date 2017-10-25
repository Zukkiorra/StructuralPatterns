using StructuralPatterns.Bridge.Abstractions;
using StructuralPatterns.Bridge.Implementation;

namespace StructuralPatterns.Bridge.BridgeAbstraction
{
    public class Message
    {
        protected MessageSenderBase messageSender { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Importance { get; set; }


        public Message()
        {
            messageSender = new EmailSender();
        }

        public virtual void Send()
        {
            messageSender.SendMessage(Title, Body, Importance);
        }
    }
}
