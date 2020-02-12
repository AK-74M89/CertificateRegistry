using CertificateRegistry3.DomainLayer;
using CertificateRegistry3.Properties;
using System;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Менялись ли настройки
        /// </summary>
        private bool hasChanges => newSettings == null ? false : newSettings.SettingsHasChanges;

        private ProgramSettings newSettings = null;

        /// <summary>
        /// Менялись ли настройки БД - для их применения требуется перезапуск приложения
        /// </summary>
        private bool dbSettingsChanged = false; 

        public bool DBSettingsChanged { get { return dbSettingsChanged; } }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            newSettings = new ProgramSettings(Settings.Default);
            switch (newSettings.OldDBType)
            {
                case Constants.DB_TYPE_POSTGRESQL:
                {
                    rbPostgreSQL.Checked = true;
                    break;
                }
                case Constants.DB_TYPE_SQLITE:
                {
                    rbSQLite.Checked = true;
                    break;
                }
                default: throw new NotImplementedException($"Настройки для типа БД {newSettings.OldDBType} не реализованы!");
            }
            teHostOrAddress.Text = newSettings.OldHostOrAddress;
            teUsername.Text = newSettings.OldUsername;
            tePassword.Text = newSettings.OldPassword;
            teAddress.Text = newSettings.OldPrintAddress;
        }

        private void SaveSettings()
        {
            dbSettingsChanged = newSettings.DBSettingsHasChanges;
            ProgramSettingsManager.SaveSettings(Settings.Default, ref newSettings);
        }

        private bool CheckSettings()
        {
            var errorMessage = ProgramSettingsManager.CheckSettings(newSettings);
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void rbPostgreSQL_CheckedChanged(object sender, EventArgs e)
        {            
            gbConnectionSettings.Enabled = rbPostgreSQL.Checked;
            if (rbPostgreSQL.Checked)
            {
                newSettings.NewDBType = Constants.DB_TYPE_POSTGRESQL;
            }
        }

        private void rbSQLite_CheckedChanged(object sender, EventArgs e)
        {
            gbConnectionSettings.Enabled = !rbSQLite.Checked;
            if (rbSQLite.Checked)
            {
                newSettings.NewDBType = Constants.DB_TYPE_SQLITE;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // на всякий случай, чтобы сработали события на контролах
            btnSave.Focus();
            if (CheckSettings())
            {
                SaveSettings();
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanges)
            {
                switch (MessageBox.Show("Настройки изменились. Сохранить?", "Запрос", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                    {
                        btnSave_Click(sender, e);
                        break;
                    }
                    case DialogResult.No:
                    {
                        break;
                    }
                    default:
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void teHostOrAddress_Leave(object sender, EventArgs e)
        {
            newSettings.NewHostOrAddress = teHostOrAddress.Text;
        }

        private void teUsername_Leave(object sender, EventArgs e)
        {
            newSettings.NewUsername = teUsername.Text;
        }

        private void tePassword_Leave(object sender, EventArgs e)
        {
            newSettings.NewPassword = tePassword.Text;
        }

        private void teAddress_Leave(object sender, EventArgs e)
        {
            newSettings.NewPrintAddress = teAddress.Text;
        }
    }
}
