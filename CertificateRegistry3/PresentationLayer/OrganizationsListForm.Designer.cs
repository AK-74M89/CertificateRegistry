namespace CertificateRegistry3.PresentationLayer
{
    partial class OrganizationsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grdOrganizations = new System.Windows.Forms.DataGridView();
            this.coIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrganizations = new System.Windows.Forms.BindingSource(this.components);
            this.menuOrganizations = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrganizations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganizations)).BeginInit();
            this.menuOrganizations.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSelect);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 417);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 33);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(713, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Location = new System.Drawing.Point(627, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 25);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grdOrganizations);
            this.pnlMain.Controls.Add(this.menuOrganizations);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 417);
            this.pnlMain.TabIndex = 1;
            // 
            // grdOrganizations
            // 
            this.grdOrganizations.AllowUserToAddRows = false;
            this.grdOrganizations.AllowUserToDeleteRows = false;
            this.grdOrganizations.AutoGenerateColumns = false;
            this.grdOrganizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrganizations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coIID,
            this.colName});
            this.grdOrganizations.DataSource = this.bsOrganizations;
            this.grdOrganizations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrganizations.Location = new System.Drawing.Point(0, 28);
            this.grdOrganizations.Margin = new System.Windows.Forms.Padding(4);
            this.grdOrganizations.MultiSelect = false;
            this.grdOrganizations.Name = "grdOrganizations";
            this.grdOrganizations.ReadOnly = true;
            this.grdOrganizations.RowHeadersWidth = 51;
            this.grdOrganizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrganizations.Size = new System.Drawing.Size(800, 389);
            this.grdOrganizations.TabIndex = 3;
            this.grdOrganizations.SelectionChanged += new System.EventHandler(this.grdOrganizations_SelectionChanged);
            // 
            // coIID
            // 
            this.coIID.DataPropertyName = "OrganizationId";
            this.coIID.HeaderText = "Идентификатор";
            this.coIID.MinimumWidth = 6;
            this.coIID.Name = "coIID";
            this.coIID.ReadOnly = true;
            this.coIID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.coIID.Visible = false;
            this.coIID.Width = 6;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Название";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colName.Width = 500;
            // 
            // menuOrganizations
            // 
            this.menuOrganizations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOrganizations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuOrganizations.Location = new System.Drawing.Point(0, 0);
            this.menuOrganizations.Name = "menuOrganizations";
            this.menuOrganizations.Size = new System.Drawing.Size(800, 28);
            this.menuOrganizations.TabIndex = 4;
            this.menuOrganizations.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.tbSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 378);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(800, 39);
            this.pnlSearch.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(64, 7);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(729, 22);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 7);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Поиск";
            // 
            // OrganizationsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.MainMenuStrip = this.menuOrganizations;
            this.Name = "OrganizationsListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Организации";
            this.Load += new System.EventHandler(this.OrganizationsListForm_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrganizations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganizations)).EndInit();
            this.menuOrganizations.ResumeLayout(false);
            this.menuOrganizations.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView grdOrganizations;
        private System.Windows.Forms.BindingSource bsOrganizations;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.MenuStrip menuOrganizations;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}