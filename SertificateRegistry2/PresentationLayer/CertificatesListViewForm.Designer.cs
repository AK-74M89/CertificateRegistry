namespace CertificateRegistry3.PresentationLayer
{
    partial class CertificatesListViewForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificatesListViewForm));
            this.bsCertificates = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new System.Windows.Forms.Button();
            this.CertificateStatus = new System.Windows.Forms.StatusStrip();
            this.CertificatesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.CertificatesMainMenu = new System.Windows.Forms.MenuStrip();
            this.сертификатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечататьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбраныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.напечататьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PrintAllBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.PrintSelectedBtn = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.CertificatesTable = new System.Windows.Forms.DataGridView();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.SearchTBox = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsCertificates)).BeginInit();
            this.CertificateStatus.SuspendLayout();
            this.CertificatesMainMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatesTable)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(4, 73);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(133, 43);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CertificateStatus
            // 
            this.CertificateStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CertificateStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CertificatesCount});
            this.CertificateStatus.Location = new System.Drawing.Point(0, 709);
            this.CertificateStatus.Name = "CertificateStatus";
            this.CertificateStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.CertificateStatus.Size = new System.Drawing.Size(1024, 26);
            this.CertificateStatus.SizingGrip = false;
            this.CertificateStatus.TabIndex = 3;
            // 
            // CertificatesCount
            // 
            this.CertificatesCount.Name = "CertificatesCount";
            this.CertificatesCount.Size = new System.Drawing.Size(99, 20);
            this.CertificatesCount.Text = "Всего в базе:";
            // 
            // CertificatesMainMenu
            // 
            this.CertificatesMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CertificatesMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сертификатыToolStripMenuItem,
            this.выбраныеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.CertificatesMainMenu.Location = new System.Drawing.Point(0, 0);
            this.CertificatesMainMenu.Name = "CertificatesMainMenu";
            this.CertificatesMainMenu.Size = new System.Drawing.Size(1024, 28);
            this.CertificatesMainMenu.TabIndex = 4;
            this.CertificatesMainMenu.Text = "menuStrip1";
            // 
            // сертификатыToolStripMenuItem
            // 
            this.сертификатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.распечататьВсеToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.сертификатыToolStripMenuItem.Name = "сертификатыToolStripMenuItem";
            this.сертификатыToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.сертификатыToolStripMenuItem.Text = "Сертификаты";
            // 
            // распечататьВсеToolStripMenuItem
            // 
            this.распечататьВсеToolStripMenuItem.Name = "распечататьВсеToolStripMenuItem";
            this.распечататьВсеToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.распечататьВсеToolStripMenuItem.Text = "Распечатать все";
            this.распечататьВсеToolStripMenuItem.Click += new System.EventHandler(this.распечататьВсеToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // выбраныеToolStripMenuItem
            // 
            this.выбраныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.напечататьToolStripMenuItem,
            this.очиститьСписокToolStripMenuItem});
            this.выбраныеToolStripMenuItem.Name = "выбраныеToolStripMenuItem";
            this.выбраныеToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.выбраныеToolStripMenuItem.Text = "Выбраные";
            // 
            // напечататьToolStripMenuItem
            // 
            this.напечататьToolStripMenuItem.Name = "напечататьToolStripMenuItem";
            this.напечататьToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.напечататьToolStripMenuItem.Text = "Напечатать";
            this.напечататьToolStripMenuItem.Click += new System.EventHandler(this.напечататьToolStripMenuItem_Click);
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.очиститьСписокToolStripMenuItem.Text = "Очистить список";
            this.очиститьСписокToolStripMenuItem.Click += new System.EventHandler(this.очиститьСписокToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(4, 124);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(133, 43);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(4, 175);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(133, 43);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PrintAllBtn
            // 
            this.PrintAllBtn.Location = new System.Drawing.Point(4, 226);
            this.PrintAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintAllBtn.Name = "PrintAllBtn";
            this.PrintAllBtn.Size = new System.Drawing.Size(133, 43);
            this.PrintAllBtn.TabIndex = 7;
            this.PrintAllBtn.Text = "Напечатать реестр";
            this.PrintAllBtn.UseVisualStyleBackColor = true;
            this.PrintAllBtn.Click += new System.EventHandler(this.PrintAllBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Enabled = false;
            this.SelectBtn.Location = new System.Drawing.Point(4, 277);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(133, 43);
            this.SelectBtn.TabIndex = 11;
            this.SelectBtn.Text = "Выбрать";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Visible = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // PrintSelectedBtn
            // 
            this.PrintSelectedBtn.Enabled = false;
            this.PrintSelectedBtn.Location = new System.Drawing.Point(4, 328);
            this.PrintSelectedBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintSelectedBtn.Name = "PrintSelectedBtn";
            this.PrintSelectedBtn.Size = new System.Drawing.Size(133, 43);
            this.PrintSelectedBtn.TabIndex = 12;
            this.PrintSelectedBtn.Text = "Напечатать выбранные";
            this.PrintSelectedBtn.UseVisualStyleBackColor = true;
            this.PrintSelectedBtn.Visible = false;
            this.PrintSelectedBtn.Click += new System.EventHandler(this.PrintSelectedBtn_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.CertificatesTable);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 681);
            this.pnlMain.TabIndex = 13;
            // 
            // CertificatesTable
            // 
            this.CertificatesTable.AllowUserToAddRows = false;
            this.CertificatesTable.AllowUserToDeleteRows = false;
            this.CertificatesTable.AutoGenerateColumns = false;
            this.CertificatesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CertificatesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.clName,
            this.clNumber,
            this.clBeginDate,
            this.clEndDate,
            this.clOrganization});
            this.CertificatesTable.DataSource = this.bsCertificates;
            this.CertificatesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CertificatesTable.Location = new System.Drawing.Point(0, 0);
            this.CertificatesTable.Margin = new System.Windows.Forms.Padding(4);
            this.CertificatesTable.MultiSelect = false;
            this.CertificatesTable.Name = "CertificatesTable";
            this.CertificatesTable.ReadOnly = true;
            this.CertificatesTable.RowHeadersWidth = 51;
            this.CertificatesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CertificatesTable.Size = new System.Drawing.Size(1024, 681);
            this.CertificatesTable.TabIndex = 1;
            this.CertificatesTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CertificatesTable_ColumnHeaderMouseClick);
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnRefresh);
            this.pnlTools.Controls.Add(this.AddBtn);
            this.pnlTools.Controls.Add(this.EditBtn);
            this.pnlTools.Controls.Add(this.PrintSelectedBtn);
            this.pnlTools.Controls.Add(this.DeleteBtn);
            this.pnlTools.Controls.Add(this.SelectBtn);
            this.pnlTools.Controls.Add(this.PrintAllBtn);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(1024, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(144, 735);
            this.pnlTools.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 43);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.SearchTBox);
            this.pnlSearch.Controls.Add(this.SearchLbl);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 670);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1024, 39);
            this.pnlSearch.TabIndex = 15;
            // 
            // SearchTBox
            // 
            this.SearchTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTBox.Location = new System.Drawing.Point(64, 8);
            this.SearchTBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTBox.Name = "SearchTBox";
            this.SearchTBox.Size = new System.Drawing.Size(953, 22);
            this.SearchTBox.TabIndex = 11;
            this.SearchTBox.TextChanged += new System.EventHandler(this.SearchTBox_TextChanged);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(8, 8);
            this.SearchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(48, 17);
            this.SearchLbl.TabIndex = 10;
            this.SearchLbl.Text = "Поиск";
            // 
            // cID
            // 
            this.cID.DataPropertyName = "CertificateId";
            this.cID.HeaderText = "Идентификатор";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cID.Visible = false;
            this.cID.Width = 6;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "CertificateName";
            this.clName.HeaderText = "Название";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clName.Width = 125;
            // 
            // clNumber
            // 
            this.clNumber.DataPropertyName = "Number";
            this.clNumber.HeaderText = "Номер";
            this.clNumber.MinimumWidth = 6;
            this.clNumber.Name = "clNumber";
            this.clNumber.ReadOnly = true;
            this.clNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clNumber.Width = 150;
            // 
            // clBeginDate
            // 
            this.clBeginDate.DataPropertyName = "BeginDate";
            this.clBeginDate.HeaderText = "Дата выдачи";
            this.clBeginDate.MinimumWidth = 6;
            this.clBeginDate.Name = "clBeginDate";
            this.clBeginDate.ReadOnly = true;
            this.clBeginDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clBeginDate.Width = 125;
            // 
            // clEndDate
            // 
            this.clEndDate.DataPropertyName = "EndDate";
            this.clEndDate.HeaderText = "Действует до";
            this.clEndDate.MinimumWidth = 6;
            this.clEndDate.Name = "clEndDate";
            this.clEndDate.ReadOnly = true;
            this.clEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clEndDate.Width = 125;
            // 
            // clOrganization
            // 
            this.clOrganization.DataPropertyName = "Organization";
            this.clOrganization.HeaderText = "Орган, выдавший сертификат";
            this.clOrganization.MinimumWidth = 6;
            this.clOrganization.Name = "clOrganization";
            this.clOrganization.ReadOnly = true;
            this.clOrganization.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clOrganization.Width = 200;
            // 
            // CertificatesListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 735);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.CertificateStatus);
            this.Controls.Add(this.CertificatesMainMenu);
            this.Controls.Add(this.pnlTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.CertificatesMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CertificatesListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр сертификатов 3";
            this.Load += new System.EventHandler(this.CertificatesListViewForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CertificatesListViewForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bsCertificates)).EndInit();
            this.CertificateStatus.ResumeLayout(false);
            this.CertificateStatus.PerformLayout();
            this.CertificatesMainMenu.ResumeLayout(false);
            this.CertificatesMainMenu.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CertificatesTable)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.StatusStrip CertificateStatus;
        private System.Windows.Forms.MenuStrip CertificatesMainMenu;
        private System.Windows.Forms.ToolStripMenuItem сертификатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распечататьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button PrintAllBtn;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel CertificatesCount;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button PrintSelectedBtn;
        private System.Windows.Forms.ToolStripMenuItem выбраныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem напечататьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsCertificates;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView CertificatesTable;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox SearchTBox;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrganization;
    }
}