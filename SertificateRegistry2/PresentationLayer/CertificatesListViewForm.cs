using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.DomainLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class CertificatesListViewForm : Form
    {
        #region Поля
        private CertificateManager CertificateRegistryHandler;

        private BindingList<Certificate> CertificateDataSource;
        private List<Certificate> SelectedCertificatesList;
        private bool isFirstSelection = true;
        #endregion Поля

        #region Свойства
        private Certificate CurrentCertificate => (Certificate)CertificatesTable.CurrentRow?.DataBoundItem;
        #endregion Свойства

        #region Вспомогательные методы
        private void EnableControls(bool Enable)
        {
            выбраныеToolStripMenuItem.Enabled = 
                PrintAllBtn.Enabled = 
                SelectBtn.Enabled = 
                DeleteBtn.Enabled = 
                EditBtn.Enabled =
                Enable;            
        }

        private void FillCertificatesTable()
        {
            CertificateDataSource = CertificateRegistryHandler.GetCertificatesRegistry();
            bsCertificates.DataSource = CertificateDataSource;
            
            EnableControls(CertificatesTable.RowCount > 0);
            if (CertificatesTable.RowCount > 0)
                CertificatesTable.Rows[0].Selected = true;
            CertificatesCount.Text = $"Всего в базе: {CertificatesTable.RowCount}";
        }

        private void ClearHideSelectedList()
        {
            PrintAllBtn.Enabled = true;
            //SelectedCertificates.Visible = false;
            PrintSelectedBtn.Visible = false;
            isFirstSelection = true;
            Width = 882; // TODO : переделать
            isFirstSelection = true;
            //SelectedCertificates.Clear();
            SelectedCertificatesList.Clear();
        }
        #endregion

        #region Обработчики событий
        public CertificatesListViewForm()
        {
            InitializeComponent();
            CertificateRegistryHandler = new CertificateManager();
            SelectedCertificatesList = new List<Certificate>();
            for (int i = 0; i < CertificatesTable.Columns.Count; i++)
            {
                CertificatesTable.Columns[i].Tag = 0;
            }
        }

        private void CertificatesListViewForm_Load(object sender, EventArgs e)
        {            
            FillCertificatesTable();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {            
            if (new CertificateForm().ShowDialog() == DialogResult.OK)
            {
                FillCertificatesTable();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CurrentCertificate == null)
                return;

            if (new CertificateForm(CurrentCertificate).ShowDialog() == DialogResult.OK)
            {
                FillCertificatesTable();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CurrentCertificate == null)
                return;

            if (MessageBox.Show($"Хотите удалить сертификат № {CurrentCertificate.Number}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CertificateRegistryHandler.DeleteCertificate(CurrentCertificate.ID_Certificate);
                FillCertificatesTable();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintAllBtn_Click(object sender, EventArgs e)
        {
            var Certificates = new List<Certificate>(CertificateRegistryHandler.GetCertificatesRegistry());

            var CertificateTemplate = new TemplateManager();
            string CertificatesTable = CertificateTemplate.FillTemplate(Certificates);

            RegistryPrintForm PrintRegistry = new RegistryPrintForm(CertificatesTable);
            PrintRegistry.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName}, версия {Application.ProductVersion}. \nCopyright © Суханов Александр, 2020", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CertificatesList = CertificateRegistryHandler.GetCertificatesRegistry();

            int Expired = 0;
            int Today = 0;
            int ThisMonth = 0;
            DateTime CurrentDay = DateTime.Now;

            foreach (var CurrentCertificate in CertificatesList)
            {
                if (CurrentCertificate.EndDate.Date < CurrentDay.Date)
                {
                    Expired++;
                }
                else if (CurrentCertificate.EndDate.Date == CurrentDay.Date)
                {
                    Today++;
                }
                else if (CurrentCertificate.EndDate.Year == CurrentDay.Year && CurrentCertificate.EndDate.Month == CurrentDay.Month)
                {
                    ThisMonth++;
                }
            }

            MessageBox.Show($"Заканчивается срок действия сертификатов:" +
                            $"\nСегодня:\t\t\t{Today}" +
                            $"\nВ этом месяце:\t\t{ThisMonth}" +
                            $"\nЗакончился:\t\t{Expired}" +
                            $"\nВсего в базе:\t\t{CertificatesList.Count}",
                            "Статистика",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void распечататьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintAllBtn_Click(sender, e);
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (isFirstSelection)
            {
                PrintAllBtn.Enabled = false;
                SelectedCertificatesList.Clear();
                //SelectedCertificates.Visible = true;
                PrintSelectedBtn.Visible = true;
                isFirstSelection = false;
                Width = 977; // TODO: переделать
            }
            if (SelectedCertificatesList.IndexOf(CurrentCertificate) < 0)
            {
                SelectedCertificatesList.Add(CurrentCertificate);
                //SelectedCertificates.Text += CurrentCertificate.Name + "\n----------\n";
            }
        }

        private void PrintSelectedBtn_Click(object sender, EventArgs e)
        {
            TemplateManager CertificateTemplate = new TemplateManager();
            string CertificatesTable = CertificateTemplate.FillTemplate(SelectedCertificatesList);

            RegistryPrintForm PrintRegistry = new RegistryPrintForm(CertificatesTable);
            if (PrintRegistry.ShowDialog() == DialogResult.OK)
            {
                ClearHideSelectedList();
            }
        }

        private void напечататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSelectedBtn_Click(sender, e);
        }

        private void очиститьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearHideSelectedList();
        }
        
        private void CertificatesTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Insert)
            {
                AddBtn_Click(sender, e);
            }
        }        

        private void CertificatesTable_DoubleClick(object sender, EventArgs e)
        {
            EditBtn_Click(sender, e);
        }
        #endregion

        private void CertificatesListViewForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                FillCertificatesTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillCertificatesTable();
        }

        private void SearchTBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTBox.TextLength == 0)
            {
                bsCertificates.DataSource = CertificateDataSource;
            }
            else
            {
                const string DATE_FORMAT = "dd.MM.yyyy";
                var searchText = SearchTBox.Text;
                bsCertificates.DataSource = new BindingList<Certificate>(CertificateDataSource.Where(c => c.CertificateName.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.Number.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.BeginDate.ToString(DATE_FORMAT).IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.EndDate.ToString(DATE_FORMAT).IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.Organization.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0)
                                                                                                .ToList());
            }
        }
    }
}