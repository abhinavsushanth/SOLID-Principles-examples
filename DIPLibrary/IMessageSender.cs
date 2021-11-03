namespace DIPLibrary
{
    public interface IMessageSender
    {
        void SendEmail(IPerson person, string message);
    }
}