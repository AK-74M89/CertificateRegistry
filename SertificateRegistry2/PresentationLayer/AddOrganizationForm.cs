using SertificateRegistry2.DomainLayer;
using System;
using System.Windows.Forms;

namespace SertificateRegistry2.PresentationLayer
{
    public partial class AddOrganizationForm:Form
    {
        public AddOrganizationForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Название\" должно быть заполнено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    new Organization().AddOrganization(NameTextBox.Text);
                    Close();
                }
            }
            catch (DomainException CheckError)
            {
                MessageBox.Show(CheckError.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameTextBox.Focus();
            }
        }
    }
}
