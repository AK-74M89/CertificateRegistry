using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.DomainLayer;
using CertificateRegistry3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class CertificatesListForm : Form
    {
        private BindingList<Certificate> certificatesList;
        private readonly BindingList<Certificate> selectedCertificatesList = new BindingList<Certificate>();
        private bool isFirstSelection = true;

        private Certificate currentCertificate => grdCertificates.CurrentRow?.DataBoundItem as Certificate;

        private void EnableControls(bool Enable)
        {
            btnPrintAll.Enabled = 
                btnSelect.Enabled = 
                btnDelete.Enabled = 
                btnEdit.Enabled = Enable;            
        }

        private void FillCertificatesTable()
        {
            certificatesList = CertificateManager.GetCertificatesRegistry();

            bsCertificates.DataSource = certificatesList;

            EnableControls(grdCertificates.RowCount > 0);
            if (grdCertificates.RowCount > 0)
                grdCertificates.Rows[0].Selected = true;
            lblCertificatesCount.Text = $"Всего в базе: {grdCertificates.RowCount}";

            foreach (DataGridViewColumn column in grdCertificates.Columns)
            {
                column.Tag = null;
            }
        }

        private void ClearHideSelectedList()
        {
            pnlToolsForSelected.Visible = false;
            isFirstSelection = true;
            selectedCertificatesList.Clear();
            btnPrintAll.Enabled = true;
            splitCertificates.Panel2Collapsed = true;
            выбраныеToolStripMenuItem.Enabled = false;
        }

        public CertificatesListForm()
        {
            InitializeComponent();
            bsCertificates.DataSource = certificatesList;
            bsSelectedCertificates.DataSource = selectedCertificatesList;

            lblCurrentDBType.Text = $"Тип БД: {Settings.Default.DBType}";
            
            if (Settings.Default.DBType == "SQLite")
            {
                pnlRefresh.Visible = false;
            }
        }

        private void CertificatesListViewForm_Load(object sender, EventArgs e)
        {            
            FillCertificatesTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new CertificateForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FillCertificatesTable();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentCertificate == null)
                return;

            using (var form = new CertificateForm(currentCertificate))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FillCertificatesTable();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentCertificate == null)
                return;

            if (MessageBox.Show($"Хотите удалить сертификат № {currentCertificate.Number}?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedCertificatesList.Remove(selectedCertificatesList.FirstOrDefault(c => c.ID_Certificate == currentCertificate.ID_Certificate));
                if (selectedCertificatesList.Count == 0)
                {
                    ClearHideSelectedList();
                }
                CertificateManager.DeleteCertificate(currentCertificate.ID_Certificate);
                FillCertificatesTable();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            var сertificates = new List<Certificate>(CertificateManager.GetCertificatesRegistry());

            using (var printRegistryForm = new RegistryPrintForm(TemplateManager.FillTemplate(сertificates)))
            {
                printRegistryForm.ShowDialog();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName}, версия {Application.ProductVersion}. \nCopyright © Суханов Александр, 2020", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CertificatesList = CertificateManager.GetCertificatesRegistry();

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
            btnPrintAll_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (isFirstSelection)
            {            
                selectedCertificatesList.Clear();
                splitCertificates.Panel2Collapsed = false;
                isFirstSelection = false;
                btnPrintAll.Enabled = false;
                pnlToolsForSelected.Visible = true;
                выбраныеToolStripMenuItem.Enabled = true;
            }
            if (selectedCertificatesList.IndexOf(currentCertificate) < 0)
            {
                selectedCertificatesList.Add(currentCertificate);
            }
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            string certificatesTable = TemplateManager.FillTemplate(selectedCertificatesList.ToList());

            using (var form = new RegistryPrintForm(certificatesTable, "Печать выбранных"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ClearHideSelectedList();
                }
            }
        }

        private void напечататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPrintSelected_Click(sender, e);
        }

        private void очиститьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearHideSelectedList();
        }
        
        private void grdCertificates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEdit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Insert)
            {
                btnAdd_Click(sender, e);
            }
        }        

        private void grdCertificates_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void CertificatesListViewForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                FillCertificatesTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearHideSelectedList();
            FillCertificatesTable();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.TextLength == 0)
            {
                bsCertificates.DataSource = certificatesList;
            }
            else
            {
                const string DATE_FORMAT = "dd.MM.yyyy";
                var searchText = tbSearch.Text;
                bsCertificates.DataSource = new BindingList<Certificate>(certificatesList.Where(c => c.CertificateName.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.Number.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.BeginDate.ToString(DATE_FORMAT).IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.EndDate.ToString(DATE_FORMAT).IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0 ||
                                                                                                            c.Organization.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0)
                                                                                                .ToList());
            }
        }

        private void grdCertificates_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            var affectedColumn = grdCertificates.Columns[e.ColumnIndex];
            // true - сортировка в прямом направлении, false - в обратном
            // если тэг был пустой, то ставим прямую, если нет - меняем на противоположную
            affectedColumn.Tag = affectedColumn.Tag == null || !(bool)affectedColumn.Tag;
            var tag = (bool)affectedColumn.Tag;

            affectedColumn.HeaderCell.SortGlyphDirection = tag ? SortOrder.Ascending : SortOrder.Descending;

            List<Certificate> sortedList = null;

            if (affectedColumn.Name == colName.Name)
            {
                sortedList = tag ? certificatesList.OrderBy(c => c.CertificateName).ToList() : certificatesList.OrderByDescending(c => c.CertificateName).ToList();
            }
            else if (affectedColumn.Name == colNumber.Name)
            {
                sortedList = tag ? certificatesList.OrderBy(c => c.Number).ToList() : certificatesList.OrderByDescending(c => c.Number).ToList();
            }
            else if (affectedColumn.Name == colBeginDate.Name)
            {
                sortedList = tag ? certificatesList.OrderBy(c => c.BeginDate).ToList() : certificatesList.OrderByDescending(c => c.BeginDate).ToList();
            }
            else if (affectedColumn.Name == colEndDate.Name)
            {
                sortedList = tag ? certificatesList.OrderBy(c => c.EndDate).ToList() : certificatesList.OrderByDescending(c => c.EndDate).ToList();
            }
            else if (affectedColumn.Name == colOrganization.Name)
            {
                sortedList = tag ? certificatesList.OrderBy(c => c.Organization).ToList() : certificatesList.OrderByDescending(c => c.Organization).ToList();
            }
            else throw new Exception($"Неизвестное название столбца: {affectedColumn.Name}");

            bsCertificates.DataSource = new BindingList<Certificate>(sortedList);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearHideSelectedList();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK && settingsForm.DBSettingsChanged)
                {
                    if (MessageBox.Show("Изменились настройки БД. Необходимо перезапустить приложение. Перезапустить?",
                                        "Запрос",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
        }
        
        private void списокОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var organizationsForm = new OrganizationsListForm(LookupMode: false))
            {
                organizationsForm.ShowDialog();
                if (organizationsForm.OrganizationsListChanged)
                {
                    FillCertificatesTable();
                }
            }
        }

        private void grdCertificates_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = btnEdit.Enabled = btnSelect.Enabled = currentCertificate != null;
        }
    }
}