using CertificateRegistry3.Properties;

namespace CertificateRegistry3.DomainLayer
{
    public class ProgramSettingsManager
    {
        private static IDBSettingsValidator validator = null;

        private static bool IsCorrectIP(string IPAddress)
        {
            return validator.IsCorrectIPAddress(IPAddress);
        }

        private static bool IsCorrectHostname(string HostName)
        {
            return validator.IsCorrectHostName(HostName);
        }

        private static bool IsCorrectUsername(string Username, out string Requirements)
        {
            return validator.IsCorrectUsername(Username, out Requirements);
        }

        private static bool IsCorrectPassword(string Password, out string Requirements)
        {
            return validator.IsCorrectPassword(Password, out Requirements);
        }

        private static bool IsCorrectPrintAddress(string Address, out string Requirements)
        {
            Requirements = "максимальная длина 200 символов.";
            return Address.Length <= 200;
        }
        
        public static string CheckSettings(ProgramSettings settingsToCheck)
        {
            if (settingsToCheck.DBSettingsHasChanges)
            {                                
                string requirements;

                if (!Constants.DBTypes.Contains(settingsToCheck.NewDBType))
                {
                    return $"Некорректно выбран тип базы данных: {settingsToCheck.NewDBType}!";
                }

                switch (settingsToCheck.NewDBType)
                {
                    case Constants.DB_TYPE_POSTGRESQL:
                    {
                        validator = new PostgreSQLDBSettingsValidator();
                        break;
                    }
                    default:
                    {
                        validator = new BaseDBSettingsValidator();
                        break;
                    }
                }

                if (!IsCorrectIP(settingsToCheck.NewHostOrAddress) && !IsCorrectHostname(settingsToCheck.NewHostOrAddress))
                {
                    return $"Некорректно введены адрес или название сервера БД: {settingsToCheck.NewHostOrAddress}!";
                }

                if (!IsCorrectUsername(settingsToCheck.NewUsername, out requirements))
                {
                    return $"Некорректно заполнено имя пользователя: {settingsToCheck.NewUsername}! Требования: {requirements}";
                }

                if (!IsCorrectPassword(settingsToCheck.NewPassword, out requirements))
                {
                    return $"Некорректно заполнен пароль! Требования: {requirements}";
                }

                if (!IsCorrectPrintAddress(settingsToCheck.NewPrintAddress, out requirements))
                {
                    return $"Некорректно заполнен адрес! Требования: {requirements}";
                }
            }
            
            return "";
        }

        internal static void SaveSettings(Settings target, ref ProgramSettings newSettings)
        {
            if (newSettings.SettingsHasChanges)
            {
                target.DBType = newSettings.NewDBType;
                target.DBServer = newSettings.NewHostOrAddress;
                target.Username = newSettings.NewUsername;
                target.Password = newSettings.NewPassword;
                target.PrintAddress = newSettings.NewPrintAddress;
                target.Save();
                newSettings = new ProgramSettings(target);
            }
        }
    }
}
