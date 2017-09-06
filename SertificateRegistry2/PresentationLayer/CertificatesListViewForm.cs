using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SertificateRegistry2.DomainLayer;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace SertificateRegistry2.PresentationLayer
{
    public partial class CertificatesListViewForm:Form
    {
        #region Поля
        private Certificate CertificateRegistryHandler;
        private IList<CertificatesListItem> CertificatesList;
        private IList<CertificatesListItem> SelectedCertificatesList;
        private bool isFirstSelection = true;
        #endregion Поля

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
            CertificatesList = CertificateRegistryHandler.GetCertificatesRegistry();

            FillTableWithList(CertificatesList);
            EnableControls(CertificatesTable.RowCount > 0);
            if (CertificatesTable.RowCount > 0)
            {
                CertificatesTable.Rows[0].Selected = true;
            }
        }

        private void FillTableWithList(IList<CertificatesListItem> CertificatesList)
        {
            CertificatesTable.Rows.Clear();

            for (int i = 0; i < CertificatesList.Count; i++)
            {
                CertificatesListItem CurrentCertificate = CertificatesList[i];
                CertificatesTable.Rows.Add();

                CertificatesTable.Rows[i].Cells["ID"].Value = CurrentCertificate.ID_Certificate;
                CertificatesTable.Rows[i].Cells["CertificateName"].Value = CurrentCertificate.Name;
                CertificatesTable.Rows[i].Cells["Number"].Value = CurrentCertificate.Number;
                CertificatesTable.Rows[i].Cells["BeginDate"].Value = CurrentCertificate.Begin.ToShortDateString();
                CertificatesTable.Rows[i].Cells["EndDate"].Value = CurrentCertificate.End.ToShortDateString();
                CertificatesTable.Rows[i].Cells["Organization"].Value = CurrentCertificate.Organization;
            }

            CertificatesCount.Text = "Всего в базе: " + Convert.ToString(CertificatesList.Count);
            CertificatesTable.Sort(CertificatesTable.Columns[1], ListSortDirection.Ascending);
        }

        private void ClearHideSelectedList()
        {
            PrintAllBtn.Enabled = true;
            SelectedCertificates.Visible = false;
            PrintSelectedBtn.Visible = false;
            isFirstSelection = true;
            Width = 882;
            isFirstSelection = true;
            SelectedCertificates.Text = "";
        }
        #endregion

        #region Обработчики событий
        public CertificatesListViewForm()
        {
            InitializeComponent();
        }

        private void CertificatesListViewForm_Load(object sender, EventArgs e)
        {
            CertificateRegistryHandler = new Certificate();
            FillCertificatesTable();
            SelectedCertificatesList = new List<CertificatesListItem>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            CertificateForm AddCertificate = new CertificateForm();
            if (AddCertificate.ShowDialog() == DialogResult.OK)
            {
                FillCertificatesTable();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            CertificateForm EditCertificate = new CertificateForm(new CertificatesListItem( Convert.ToInt32(CertificatesTable.SelectedRows[0].Cells[0].Value),
                                                                                            Convert.ToString(CertificatesTable.SelectedRows[0].Cells[1].Value),
                                                                                            Convert.ToString(CertificatesTable.SelectedRows[0].Cells[2].Value),
                                                                                            Convert.ToDateTime(CertificatesTable.SelectedRows[0].Cells[3].Value),
                                                                                            Convert.ToDateTime(CertificatesTable.SelectedRows[0].Cells[4].Value),
                                                                                            Convert.ToString(CertificatesTable.SelectedRows[0].Cells[5].Value)));
            if (EditCertificate.ShowDialog() == DialogResult.OK)
            {
                FillCertificatesTable();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string Number = Convert.ToString(CertificatesTable.SelectedRows[0].Cells[2].Value);
            if (MessageBox.Show($"Хотите удалить сертификат № {Number}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID_CertificateToDelete = Convert.ToInt32(CertificatesTable.SelectedRows[0].Cells[0].Value);
                Certificate CertificateKiller = new Certificate();
                CertificateKiller.DeleteCertificate(ID_CertificateToDelete);
                FillCertificatesTable();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintAllBtn_Click(object sender, EventArgs e)
        {
            Certificate GetCertificates = new Certificate();
            IList<CertificatesListItem> Certificates = GetCertificates.GetCertificatesRegistry();

            TemplateHandler CertificateTemplate = new TemplateHandler();
            string CertificatesTable = CertificateTemplate.FillTemplate(Certificates);

            RegistryPrintForm PrintRegistry = new RegistryPrintForm(CertificatesTable);
            PrintRegistry.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName}, версия {Application.ProductVersion}. \nCopyright © Суханов Александр,  2017", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Certificate CertificateRegistryHandler = new Certificate();
            IList<CertificatesListItem> CertificatesList = CertificateRegistryHandler.GetCertificatesRegistry();

            int Expired = 0;
            int Today = 0;
            int ThisMonth = 0;
            DateTime CurrentDay = DateTime.Now;

            foreach (CertificatesListItem CurrentCertificate in CertificatesList)
            {
                if (CurrentCertificate.End.Date < CurrentDay.Date)
                {
                    Expired++;
                }
                else if (CurrentCertificate.End.Date == CurrentDay.Date)
                {
                    Today++;
                }
                else if (CurrentCertificate.End.Month == CurrentDay.Month)
                {
                    ThisMonth++;
                }
            }

            MessageBox.Show("Заканчивается срок действия сертификатов:" +
                            "\nСегодня:\t\t\t" + Convert.ToString(Today) +
                            "\nВ этом месяце:\t\t" + Convert.ToString(ThisMonth) +
                            "\nЗакончился:\t\t" + Convert.ToString(Expired) +
                            "\nВсего в базе:\t\t" + Convert.ToString(CertificatesList.Count),
                            "Статистика",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void распечататьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintAllBtn_Click(sender, e);
        }

        private void SearchTBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTBox.Text == "")
            {
                FillTableWithList(CertificatesList);
            }
            else
            {
                IList<CertificatesListItem> SearchCertificatesList = new List<CertificatesListItem>();
                for (int j = 0; j < CertificatesList.Count; j++)
                {
                    SearchCertificatesList.Add(CertificatesList[j]);
                }
                int i = 0;
                while (i < SearchCertificatesList.Count)
                {
                    if (SearchCertificatesList[i].Name.StartsWith(SearchTBox.Text, true, CultureInfo.CurrentCulture))
                    {
                        i++;
                    }
                    else
                    {
                        SearchCertificatesList.RemoveAt(i);
                    }
                }
                FillTableWithList(SearchCertificatesList);
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (isFirstSelection)
            {
                PrintAllBtn.Enabled = false;
                SelectedCertificatesList.Clear();
                SelectedCertificates.Visible = true;
                PrintSelectedBtn.Visible = true;
                isFirstSelection = false;
                Width = 977;
            }
            CertificatesListItem SelectedCertificate = new CertificatesListItem();
            SelectedCertificate.ID_Certificate = Convert.ToInt32(CertificatesTable.SelectedRows[0].Cells[0].Value);
            SelectedCertificate.Name = Convert.ToString(CertificatesTable.SelectedRows[0].Cells[1].Value);
            SelectedCertificate.Number = Convert.ToString(CertificatesTable.SelectedRows[0].Cells[2].Value);
            SelectedCertificate.Begin = Convert.ToDateTime(CertificatesTable.SelectedRows[0].Cells[3].Value);
            SelectedCertificate.End = Convert.ToDateTime(CertificatesTable.SelectedRows[0].Cells[4].Value);
            SelectedCertificate.Organization = Convert.ToString(CertificatesTable.SelectedRows[0].Cells[5].Value);
            SelectedCertificatesList.Add(SelectedCertificate);
            SelectedCertificates.Text += SelectedCertificate.Name + "\n----------\n";
        }

        private void PrintSelectedBtn_Click(object sender, EventArgs e)
        {
            TemplateHandler CertificateTemplate = new TemplateHandler();
            string CertificatesTable = CertificateTemplate.FillTemplate(SelectedCertificatesList);

            RegistryPrintForm PrintRegistry = new RegistryPrintForm(CertificatesTable);
            PrintRegistry.ShowDialog();

            ClearHideSelectedList();
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
            if (e.KeyCode == Keys.Delete)
            {
                DeleteBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Insert)
            {
                AddBtn_Click(sender, e);
            }
        }
        #endregion
    }
}