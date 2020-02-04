using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.DomainLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class CertificateForm:Form
    {
        private bool isEdit;
        private int ID_Certificate;
        private string CurrentOrganizationName;

        private Organization CurrentOrganization => OrganizationComboBox.SelectedValue as Organization;

        /// <summary>
        /// Конструктор формы по умолчанию (для добавления сертификата)
        /// </summary>
        public CertificateForm()
        {
            InitializeComponent();
            isEdit = false;
        }

        /// <summary>
        /// Конструктор формы редактирования сертификата
        /// </summary>
        /// <param name="CertificateToEdit"></param>
        public CertificateForm(Certificate CertificateToEdit)
        {
            InitializeComponent();

            isEdit = true;
            CertificateNameTextBox.Text = CertificateToEdit.CertificateName;
            CertificateNumberTextBox.Text = CertificateToEdit.Number;
            BeginDatePicker.Value = CertificateToEdit.BeginDate;
            EndDatePicker.Value = CertificateToEdit.EndDate;
            CurrentOrganizationName = CertificateToEdit.Organization;
            ID_Certificate = CertificateToEdit.ID_Certificate;
        }

        private void FillOrganizationComboBox()
        {           
            OrganizationComboBox.DataSource = OrganizationManager.GetOrganizationList();

            OrganizationComboBox.SelectedIndex = -1;
            if (isEdit)
            {
                OrganizationComboBox.SelectedIndex = OrganizationComboBox.Items.IndexOf((OrganizationComboBox.DataSource as List<Organization>).Find(o => o.Name == CurrentOrganizationName));
            }
        }

        private void OrganizationComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            OrganizationComboBox.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CertificateNameTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Название\" должно быть заполнено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CertificateNumberTextBox.Text == "")
                {
                    MessageBox.Show("Поле \"Номер сертификата\" должно быть заполнено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (OrganizationComboBox.Text == "")
                {
                    MessageBox.Show("Нужно выбрать организацию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                    
                    CertificateManager CertificatesHandler = new CertificateManager();
                    if (isEdit)
                    {
                                                
                        CertificatesHandler.EditCertificate(ID_Certificate,
                                                            CertificateNameTextBox.Text,
                                                            CertificateNumberTextBox.Text,
                                                            BeginDatePicker.Value,
                                                            EndDatePicker.Value,
                                                            CurrentOrganization.OrganizationId);
                    }
                    else
                    {
                        CertificatesHandler.AddCertificate(CertificateNameTextBox.Text,
                                                          CertificateNumberTextBox.Text,
                                                          BeginDatePicker.Value,
                                                          EndDatePicker.Value,
                                                          CurrentOrganization.OrganizationId);
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (DomainException CheckError)
            {
                MessageBox.Show(CheckError.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CertificateForm_Load(object sender, EventArgs e)
        {
            FillOrganizationComboBox();

            if (OrganizationComboBox.Items.Count == 0)
            {
                MessageBox.Show("Список организаций пуст. Добавьте организацию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // переделать
        private void DeleteOrganizationBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите удалить организацию{CurrentOrganization.Name}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OrganizationManager.DeleteOrganization(CurrentOrganization.OrganizationId);
            }
        }

        private void AddOrganizationBtn_Click(object sender, EventArgs e)
        {
            OrganizationForm AddOrganization = new OrganizationForm();
            if (AddOrganization.ShowDialog() == DialogResult.OK)
            {
                FillOrganizationComboBox();
            }
        }

        private void BeginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < BeginDatePicker.Value)
                EndDatePicker.Value = BeginDatePicker.Value;
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < BeginDatePicker.Value)
                EndDatePicker.Value = BeginDatePicker.Value;
        }
    }
}
