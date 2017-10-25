using StructuralPatterns.Bridge.Abstractions;
using System;


namespace StructuralPatterns.Bridge.Implementation
{
    public class EmailSender : MessageSenderBase
    {
        public void SendMessage(string title, string body, int importance)
        {
            Console.WriteLine("Email\n---------------------------\n" +
								"Title: {0}\nBody: {1}\nImportance: {2}\n", title, body, importance);
        }
    }
}
