using CertificateRegistry3.Properties;
using System;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class SettingsForm : Form
    {
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
            if (rbPostgreSQL.Checked)
            {
                Settings.Default.DBType = Constants.POSTGRESQL;
            }
            else if (rbSQLite.Checked)
            {
                Settings.Default.DBType = Constants.SQLITE;
            }
            else
            {
                throw new Exception("Необходимо выбрать тип базы данных!");
            }

            if (gbConnectionSettings.Enabled)
            {
                if (teHostOrAddress.Text != string.Empty && teHostOrAddress.Text != Settings.Default.DBServer)
                    Settings.Default.DBServer = teHostOrAddress.Text;

                if (teUsername.Text != string.Empty && teUsername.Text != Settings.Default.Username)
                    Settings.Default.Username = teUsername.Text;

                if (tePassword.Text != string.Empty && tePassword.Text != Settings.Default.Password)
                    Settings.Default.Password = tePassword.Text;
            }
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
            SaveSettings();
            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
