using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.DomainLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class CertificateForm:Form
    {
        private readonly bool isEdit;
        private readonly int certificateId;
        private readonly string currentOrganizationName;

        private Organization currentOrganization => OrganizationComboBox.SelectedValue as Organization;

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

            if (CertificateToEdit == null)
                throw new ArgumentNullException(nameof(CertificateToEdit), "Неправильный вызов формы для редактирования: пустой аргумент.");

            isEdit = true;
            CertificateNameTextBox.Text = CertificateToEdit.CertificateName;
            CertificateNumberTextBox.Text = CertificateToEdit.Number;
            BeginDatePicker.Value = CertificateToEdit.BeginDate;
            EndDatePicker.Value = CertificateToEdit.EndDate;
            currentOrganizationName = CertificateToEdit.Organization;
            certificateId = CertificateToEdit.ID_Certificate;
        }

        private void FillOrganizationComboBox()
        {           
            OrganizationComboBox.DataSource = OrganizationManager.GetOrganizationList();

            OrganizationComboBox.SelectedIndex = -1;
            if (isEdit)
            {
                OrganizationComboBox.SelectedIndex = OrganizationComboBox.Items.IndexOf((OrganizationComboBox.DataSource as List<Organization>).Find(o => o.Name == currentOrganizationName));
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
                if (string.IsNullOrEmpty(CertificateNameTextBox.Text))
                {
                    MessageBox.Show("Поле \"Название\" должно быть заполнено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(CertificateNumberTextBox.Text))
                {
                    MessageBox.Show("Поле \"Номер сертификата\" должно быть заполнено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(OrganizationComboBox.Text))
                {
                    MessageBox.Show("Нужно выбрать организацию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                    
                    CertificateManager CertificatesHandler = new CertificateManager();
                    if (isEdit)
                    {
                                                
                        CertificatesHandler.EditCertificate(certificateId,
                                                            CertificateNameTextBox.Text,
                                                            CertificateNumberTextBox.Text,
                                                            BeginDatePicker.Value,
                                                            EndDatePicker.Value,
                                                            currentOrganization.OrganizationId);
                    }
                    else
                    {
                        CertificatesHandler.AddCertificate(CertificateNameTextBox.Text,
                                                          CertificateNumberTextBox.Text,
                                                          BeginDatePicker.Value,
                                                          EndDatePicker.Value,
                                                          currentOrganization.OrganizationId);
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

        private void AddOrganizationBtn_Click(object sender, EventArgs e)
        {
            var organizationsFrom = new OrganizationsListForm(LookupMode:true);
            if (organizationsFrom.ShowDialog() == DialogResult.OK)
            {
                FillOrganizationComboBox();
                OrganizationComboBox.SelectedIndex = 
                    OrganizationComboBox.Items.IndexOf((OrganizationComboBox.DataSource as List<Organization>)
                    .Find(o => o.OrganizationId == organizationsFrom.CurrentOrganization.OrganizationId));
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
