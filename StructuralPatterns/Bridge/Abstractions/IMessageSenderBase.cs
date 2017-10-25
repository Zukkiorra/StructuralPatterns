
namespace StructuralPatterns.Bridge.Abstractions
{
    public interface MessageSenderBase
    {
        void SendMessage(string title, string details, int importance);
    }
}
