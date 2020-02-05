using System.Net;
using System.Text.RegularExpressions;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Базовый класс для валидации настроек БД по общим для всех БД правилам
    /// </summary>
    public class BaseDBSettingsValidator : IDBSettingsValidator
    {
        public bool IsCorrectIPAddress(string IP)
        {
            try
            {
                var address = IPAddress.Parse(IP);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool IsCorrectHostName(string HostName)
        {
            return Regex.Match(HostName, @"^[^.][^\\\/:*?'<>|]{0,14}", RegexOptions.IgnoreCase).Success;
        }

        public virtual bool IsCorrectPassword(string Password, out string Requirements)
        {
            // требований нет
            Requirements = "";
            return true;
        }

        public virtual bool IsCorrectUsername(string Username, out string Requirements)
        {
            // требований нет
            Requirements = "";
            return true;
        }
    }
}
