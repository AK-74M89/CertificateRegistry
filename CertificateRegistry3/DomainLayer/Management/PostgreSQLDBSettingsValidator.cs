using System.Text.RegularExpressions;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Класс для валидации настроек БД PostgreSQL
    /// </summary>
    class PostgreSQLDBSettingsValidator : BaseDBSettingsValidator
    {
        public override  bool IsCorrectUsername(string Username, out string Requirements)
        {
            Requirements = "до 31 символа, английские буквы, цифры, знак подчёркивания, начинается с буквы или подчёркивания.";
            return Regex.Match(Username, "^[a-z_][a-z0-9_]{1,30}", RegexOptions.IgnoreCase).Success;
        }
    }
}
