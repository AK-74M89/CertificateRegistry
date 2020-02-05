namespace CertificateRegistry3.DomainLayer
{
    public interface IDBSettingsValidator
    {
        bool IsCorrectIPAddress(string IP);

        bool IsCorrectHostName(string HostName);

        bool IsCorrectUsername(string Username, out string Requirements);

        bool IsCorrectPassword(string Password, out string Requirements);
    }
}
