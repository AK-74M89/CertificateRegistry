﻿using CertificateRegistry3.DataSourceLayer;
using CertificateRegistry3.DomainLayer;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CertificateRegistry3.PresentationLayer
{
    public partial class OrganizationsListForm : Form
    {
        private BindingList<Organization> organizationsList;

        public bool OrganizationsListChanged { get; private set; } = false;

        private Organization currentOrganization => (Organization)grdOrganizations.CurrentRow?.DataBoundItem;

        public int SelectedOrganizationId => currentOrganization.OrganizationId;

        private void FillOrganizationsTable()
        {
            organizationsList = new BindingList<Organization>(OrganizationManager.GetOrganizationList());

            bsOrganizations.DataSource = organizationsList;

            if (organizationsList.Count > 0)
                grdOrganizations.Rows[0].Selected = true;
        }

        public OrganizationsListForm(bool LookupMode)
        {
            InitializeComponent();

            pnlButtons.Visible = LookupMode;
        }

        private void OrganizationsListForm_Load(object sender, EventArgs e)
        {
            FillOrganizationsTable();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdOrganizations_SelectionChanged(object sender, EventArgs e)
        {
            редактироватьToolStripMenuItem.Enabled = currentOrganization != null;
            удалитьToolStripMenuItem.Enabled = currentOrganization != null && OrganizationManager.CanDelete(currentOrganization.OrganizationId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.TextLength == 0)
            {
                bsOrganizations.DataSource = organizationsList;
            }
            else
            {
                bsOrganizations.DataSource = new BindingList<Organization>(organizationsList.Where(o => o.Name.IndexOf(tbSearch.Text, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList());
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new OrganizationForm().ShowDialog() == DialogResult.OK)
            {
                OrganizationsListChanged = true;
                FillOrganizationsTable();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new OrganizationForm(currentOrganization).ShowDialog() == DialogResult.OK)
            {
                OrganizationsListChanged = true;
                FillOrganizationsTable();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Удалить организацию \"{currentOrganization.Name}\"?", "Запрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OrganizationsListChanged = true;
                OrganizationManager.DeleteOrganization(currentOrganization.OrganizationId);
                FillOrganizationsTable();
            }
        }
    }
}