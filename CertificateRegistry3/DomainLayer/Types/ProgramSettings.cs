using CertificateRegistry3.Properties;

namespace CertificateRegistry3.DomainLayer
{
    /// <summary>
    /// Хранит старые и изменённые настройки.
    /// Служит для большего удобства работы с настройками.
    /// </summary>
    public class ProgramSettings
    {
        public string OldDBType { get; private set; }        
        public string NewDBType { get; set; }

        public string OldHostOrAddress { get; private set; }        
        public string NewHostOrAddress { get; set; }

        public string OldUsername { get; private set; }
        public string NewUsername { get; set; }

        public string OldPassword { get; private set; }
        public string NewPassword { get; set; }

        public string OldPrintAddress { get; private set; }
        public string NewPrintAddress { get; set; }

        public bool SettingsHasChanges => OldDBType != NewDBType || OldHostOrAddress != NewHostOrAddress || OldUsername != NewUsername || OldPassword != NewPassword || OldPrintAddress != NewPrintAddress;

        public bool DBSettingsHasChanges => OldDBType != NewDBType || OldHostOrAddress != NewHostOrAddress || OldUsername != NewUsername || OldPassword != NewPassword;

        internal ProgramSettings(Settings oldSettings)
        {
            OldDBType = NewDBType = oldSettings.DBType;
            OldHostOrAddress = NewHostOrAddress = oldSettings.DBServer;
            OldUsername = NewUsername = oldSettings.Username;
            OldPassword = NewPassword = oldSettings.Password;
            OldPrintAddress = NewPrintAddress = oldSettings.PrintAddress;
        }
    }
}
