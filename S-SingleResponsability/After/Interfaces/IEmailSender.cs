namespace SOLID_By_Example.S_SingleResponsability.After.Interfaces
{
    public interface IEmailSender
    {
        void Send(string customer, string subject, string body);
    }
}