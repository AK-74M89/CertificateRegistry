using SertificateRegistry2.DomainLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SertificateRegistry2.PresentationLayer
{
    public partial class CertificateForm:Form
    {
        private IList<OrganizationListItem> OrganizationList;
        private bool isEdit;
        private string CurrentOrganization;
        private int ID_Certificate;

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
        public CertificateForm(CertificatesListItem CertificateToEdit)
        {
            InitializeComponent();

            isEdit = true;
            CertificateNameTextBox.Text = CertificateToEdit.Name;
            CertificateNumberTextBox.Text = CertificateToEdit.Number;
            BeginDatePicker.Value = CertificateToEdit.Begin;
            EndDatePicker.Value = CertificateToEdit.End;
            CurrentOrganization = CertificateToEdit.Organization;
            ID_Certificate = CertificateToEdit.ID_Certificate;
        }

        private void FillOrganizationComboBox()
        {
            Organization OrganizationListSource = new Organization();
            OrganizationList = OrganizationListSource.GetOrganizationList();

            OrganizationComboBox.Items.Clear();
            for (int i = 0; i < OrganizationList.Count; i++)
            {
                OrganizationComboBox.Items.Add(OrganizationList[i].Name);
            }

            if (isEdit)
            {
                OrganizationComboBox.SelectedIndex = OrganizationComboBox.Items.IndexOf(CurrentOrganization);
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
                    if (isEdit)
                    {
                        int ID_CurrentOrganization = OrganizationList[OrganizationComboBox.SelectedIndex].ID_Organization;

                        Certificate NewCertificate = new Certificate();
                        NewCertificate.EditCertificate(ID_Certificate,
                                                       CertificateNameTextBox.Text,
                                                       CertificateNumberTextBox.Text,
                                                       BeginDatePicker.Value,
                                                       EndDatePicker.Value,
                                                       ID_CurrentOrganization);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        int ID_CurrentOrganization = OrganizationList[OrganizationComboBox.SelectedIndex].ID_Organization;

                        Certificate NewCertificate = new Certificate();
                        NewCertificate.AddCertificate(CertificateNameTextBox.Text,
                                                      CertificateNumberTextBox.Text,
                                                      BeginDatePicker.Value,
                                                      EndDatePicker.Value,
                                                      ID_CurrentOrganization);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
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

        private void DeleteOrganizationBtn_Click(object sender, EventArgs e)
        {
            string OrganizationName = OrganizationList[OrganizationComboBox.SelectedIndex].Name;
            if (MessageBox.Show("Вы хотите удалить организацию" + OrganizationName + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Organization OrganizationKiller = new Organization();
                int ID_OrganizationToDelete = OrganizationList[OrganizationComboBox.SelectedIndex].ID_Organization;
                OrganizationKiller.DeleteOrganization(ID_OrganizationToDelete);
            }
        }

        private void AddOrganizationBtn_Click(object sender, EventArgs e)
        {
            AddOrganizationForm AddOrganization = new AddOrganizationForm();
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
