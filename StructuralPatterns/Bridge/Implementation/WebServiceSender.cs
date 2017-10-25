using StructuralPatterns.Bridge.Abstractions;
using System;

namespace StructuralPatterns.Bridge.Implementation
{
    public class WebServiceSender : MessageSenderBase
    {
        public void SendMessage(string title, string body, int importance)
        {
            Console.WriteLine("Web Service\n---------------------------\n" +
								"Title: {0}\nBody: {1}\nImportance: {2}\n", title, body, importance);
        }
    }
}
