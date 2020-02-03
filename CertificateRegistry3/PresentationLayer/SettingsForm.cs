using CertificateRegistry3.Properties;
using System;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class SettingsForm : Form
    {
        private bool dbSettingsChanged = false;

        public bool DBSettingsChanged { get { return dbSettingsChanged; } }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            switch (Settings.Default.DBType)
            {
                case Constants.POSTGRESQL:
                    rbPostgreSQL.Checked = true;
                    break;
                case Constants.SQLITE:
                    rbSQLite.Checked = true;
                    break;
                default: throw new NotImplementedException($"Настройки для БД {Settings.Default.DBType} ещё не реализованы!");
            }

            teHostOrAddress.Text = Settings.Default.DBServer;
            teUsername.Text = Settings.Default.Username;
            tePassword.Text = Settings.Default.Password;
        }

        private void SaveSettings()
        {
            string dbType;
            if (rbPostgreSQL.Checked)
            {
                dbType = Constants.POSTGRESQL;
            }
            else if (rbSQLite.Checked)
            {
                dbType = Constants.SQLITE;
            }
            else
            {
                throw new Exception("Необходимо выбрать тип базы данных!");
            }
            if (Settings.Default.DBType != dbType)
            {
                dbSettingsChanged = true;
                Settings.Default.DBType = dbType;
            }

            if (gbConnectionSettings.Enabled)
            {
                if (teHostOrAddress.Text != string.Empty && teHostOrAddress.Text != Settings.Default.DBServer)
                {
                    dbSettingsChanged = true;
                    Settings.Default.DBServer = teHostOrAddress.Text;
                }

                if (teUsername.Text != string.Empty && teUsername.Text != Settings.Default.Username)
                {
                    dbSettingsChanged = true;
                    Settings.Default.Username = teUsername.Text;
                }

                if (tePassword.Text != string.Empty && tePassword.Text != Settings.Default.Password)
                {
                    dbSettingsChanged = true;
                    Settings.Default.Password = tePassword.Text;
                }
            }
            if (dbSettingsChanged)
                Settings.Default.Save();
        }

        private bool CheckField(TextBox textBox, Label label)
        {
            if (textBox.Text == string.Empty)
            {
                MessageBox.Show($"Необходимо заполнить поле {label.Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckSettings()
        {
            if (gbConnectionSettings.Enabled)
            {
                return CheckField(teHostOrAddress, lbHostOrAddress) &&
                        CheckField(teUsername, lbUsername) &&
                        CheckField(tePassword, lbPassword);
            }
            return true;
        }

        private void rbPostgreSQL_CheckedChanged(object sender, EventArgs e)
        {            
            gbConnectionSettings.Enabled = rbPostgreSQL.Checked;
        }

        private void rbSQLite_CheckedChanged(object sender, EventArgs e)
        {
            gbConnectionSettings.Enabled = !rbSQLite.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
    }
}
