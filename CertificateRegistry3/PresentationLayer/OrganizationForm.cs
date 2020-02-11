using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.DomainLayer;
using System;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class OrganizationForm:Form
    {
        private readonly int OrganizationId;
        private readonly bool isEdit;        

        public OrganizationForm()
        {
            InitializeComponent();
            isEdit = false;
        }

        public OrganizationForm(Organization organizationToEdit)
        {
            InitializeComponent();

            if (organizationToEdit == null)
                throw new ArgumentNullException(nameof(organizationToEdit), "Неправильный вызов формы для редактирования: пустой аргумент.");

            isEdit = true;
            teOrganizationName.Text = organizationToEdit.Name;
            OrganizationId = organizationToEdit.OrganizationId;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(teOrganizationName.Text))
                {
                    MessageBox.Show("Поле \"Название\" должно быть заполнено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (isEdit)
                    {
                        OrganizationManager.EditOrganization(OrganizationId, teOrganizationName.Text);
                    }
                    else
                    {
                        OrganizationManager.AddOrganization(teOrganizationName.Text);
                    }
                    Close();
                }
            }
            catch (DomainException CheckError)
            {
                MessageBox.Show(CheckError.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                teOrganizationName.Focus();
            }
        }
    }
}
