namespace CertificateRegistry3.PresentationLayer
{
    partial class CertificatesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificatesListForm));
            this.bsCertificates = new System.Windows.Forms.BindingSource(this.components);
            this.statusCertificate = new System.Windows.Forms.StatusStrip();
            this.lblCurrentDBType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCertificatesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuCertificates = new System.Windows.Forms.MenuStrip();
            this.сертификатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечататьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбраныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.напечататьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitCertificates = new System.Windows.Forms.SplitContainer();
            this.grdCertificates = new System.Windows.Forms.DataGridView();
            this.coIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSelectedCertificate = new System.Windows.Forms.DataGridView();
            this.colSelectedCertificateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedCertificateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedCertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedCertificateBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedCertificateEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectedCertificateOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSelectedCertificates = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTools = new System.Windows.Forms.Panel();
            this.pnlMainTools = new System.Windows.Forms.Panel();
            this.pnlToolsForSelected = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrintSelected = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSeparator1 = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCertificates)).BeginInit();
            this.statusCertificate.SuspendLayout();
            this.mainMenuCertificates.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCertificates)).BeginInit();
            this.splitCertificates.Panel1.SuspendLayout();
            this.splitCertificates.Panel2.SuspendLayout();
            this.splitCertificates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCertificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectedCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedCertificates)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.pnlMainTools.SuspendLayout();
            this.pnlToolsForSelected.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusCertificate
            // 
            this.statusCertificate.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusCertificate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentDBType,
            this.lblCertificatesCount});
            this.statusCertificate.Location = new System.Drawing.Point(0, 709);
            this.statusCertificate.Name = "statusCertificate";
            this.statusCertificate.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusCertificate.Size = new System.Drawing.Size(1058, 26);
            this.statusCertificate.SizingGrip = false;
            this.statusCertificate.TabIndex = 3;
            // 
            // lblCurrentDBType
            // 
            this.lblCurrentDBType.Name = "lblCurrentDBType";
            this.lblCurrentDBType.Size = new System.Drawing.Size(61, 20);
            this.lblCurrentDBType.Text = "Тип БД:";
            // 
            // lblCertificatesCount
            // 
            this.lblCertificatesCount.Name = "lblCertificatesCount";
            this.lblCertificatesCount.Size = new System.Drawing.Size(99, 20);
            this.lblCertificatesCount.Text = "Всего в базе:";
            // 
            // mainMenuCertificates
            // 
            this.mainMenuCertificates.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuCertificates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сертификатыToolStripMenuItem,
            this.выбраныеToolStripMenuItem,
            this.организацииToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenuCertificates.Location = new System.Drawing.Point(0, 0);
            this.mainMenuCertificates.Name = "mainMenuCertificates";
            this.mainMenuCertificates.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuCertificates.Size = new System.Drawing.Size(1058, 28);
            this.mainMenuCertificates.TabIndex = 4;
            this.mainMenuCertificates.Text = "menuStrip1";
            // 
            // сертификатыToolStripMenuItem
            // 
            this.сертификатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.распечататьВсеToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.toolStripSeparator1,
            this.настройкиToolStripMenuItem,
            this.separator1,
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(200, 6);
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
            this.выбраныеToolStripMenuItem.Enabled = false;
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
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокОрганизацийToolStripMenuItem});
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.организацииToolStripMenuItem.Text = "Организации";
            // 
            // списокОрганизацийToolStripMenuItem
            // 
            this.списокОрганизацийToolStripMenuItem.Name = "списокОрганизацийToolStripMenuItem";
            this.списокОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.списокОрганизацийToolStripMenuItem.Text = "Список организаций";
            this.списокОрганизацийToolStripMenuItem.Click += new System.EventHandler(this.списокОрганизацийToolStripMenuItem_Click);
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
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitCertificates);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1058, 681);
            this.pnlMain.TabIndex = 13;
            // 
            // splitCertificates
            // 
            this.splitCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCertificates.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCertificates.Location = new System.Drawing.Point(0, 0);
            this.splitCertificates.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitCertificates.Name = "splitCertificates";
            this.splitCertificates.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCertificates.Panel1
            // 
            this.splitCertificates.Panel1.AutoScroll = true;
            this.splitCertificates.Panel1.Controls.Add(this.grdCertificates);
            this.splitCertificates.Panel1MinSize = 400;
            // 
            // splitCertificates.Panel2
            // 
            this.splitCertificates.Panel2.AutoScroll = true;
            this.splitCertificates.Panel2.Controls.Add(this.grdSelectedCertificate);
            this.splitCertificates.Panel2Collapsed = true;
            this.splitCertificates.Panel2MinSize = 100;
            this.splitCertificates.Size = new System.Drawing.Size(1058, 681);
            this.splitCertificates.SplitterDistance = 400;
            this.splitCertificates.TabIndex = 17;
            // 
            // grdCertificates
            // 
            this.grdCertificates.AllowUserToAddRows = false;
            this.grdCertificates.AllowUserToDeleteRows = false;
            this.grdCertificates.AutoGenerateColumns = false;
            this.grdCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCertificates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coIID,
            this.colName,
            this.colNumber,
            this.colBeginDate,
            this.colEndDate,
            this.colOrganization});
            this.grdCertificates.DataSource = this.bsCertificates;
            this.grdCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCertificates.Location = new System.Drawing.Point(0, 0);
            this.grdCertificates.Margin = new System.Windows.Forms.Padding(5);
            this.grdCertificates.MultiSelect = false;
            this.grdCertificates.Name = "grdCertificates";
            this.grdCertificates.ReadOnly = true;
            this.grdCertificates.RowHeadersWidth = 51;
            this.grdCertificates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCertificates.Size = new System.Drawing.Size(1058, 681);
            this.grdCertificates.TabIndex = 2;
            this.grdCertificates.SelectionChanged += new System.EventHandler(this.grdCertificates_SelectionChanged);
            // 
            // coIID
            // 
            this.coIID.DataPropertyName = "CertificateId";
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
            this.colName.DataPropertyName = "CertificateName";
            this.colName.HeaderText = "Название";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colName.Width = 125;
            // 
            // colNumber
            // 
            this.colNumber.DataPropertyName = "Number";
            this.colNumber.HeaderText = "Номер";
            this.colNumber.MinimumWidth = 6;
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colNumber.Width = 150;
            // 
            // colBeginDate
            // 
            this.colBeginDate.DataPropertyName = "BeginDate";
            this.colBeginDate.HeaderText = "Дата выдачи";
            this.colBeginDate.MinimumWidth = 6;
            this.colBeginDate.Name = "colBeginDate";
            this.colBeginDate.ReadOnly = true;
            this.colBeginDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colBeginDate.Width = 125;
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "EndDate";
            this.colEndDate.HeaderText = "Действует до";
            this.colEndDate.MinimumWidth = 6;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colEndDate.Width = 125;
            // 
            // colOrganization
            // 
            this.colOrganization.DataPropertyName = "Organization";
            this.colOrganization.HeaderText = "Орган, выдавший сертификат";
            this.colOrganization.MinimumWidth = 6;
            this.colOrganization.Name = "colOrganization";
            this.colOrganization.ReadOnly = true;
            this.colOrganization.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colOrganization.Width = 200;
            // 
            // grdSelectedCertificate
            // 
            this.grdSelectedCertificate.AllowUserToAddRows = false;
            this.grdSelectedCertificate.AllowUserToDeleteRows = false;
            this.grdSelectedCertificate.AutoGenerateColumns = false;
            this.grdSelectedCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectedCertificate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectedCertificateId,
            this.colSelectedCertificateName,
            this.colSelectedCertificateNumber,
            this.colSelectedCertificateBeginDate,
            this.colSelectedCertificateEndDate,
            this.colSelectedCertificateOrganization});
            this.grdSelectedCertificate.DataSource = this.bsSelectedCertificates;
            this.grdSelectedCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSelectedCertificate.Location = new System.Drawing.Point(0, 0);
            this.grdSelectedCertificate.Margin = new System.Windows.Forms.Padding(5);
            this.grdSelectedCertificate.MultiSelect = false;
            this.grdSelectedCertificate.Name = "grdSelectedCertificate";
            this.grdSelectedCertificate.ReadOnly = true;
            this.grdSelectedCertificate.RowHeadersWidth = 51;
            this.grdSelectedCertificate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSelectedCertificate.Size = new System.Drawing.Size(150, 46);
            this.grdSelectedCertificate.TabIndex = 3;
            // 
            // colSelectedCertificateId
            // 
            this.colSelectedCertificateId.DataPropertyName = "CertificateId";
            this.colSelectedCertificateId.HeaderText = "Идентификатор";
            this.colSelectedCertificateId.MinimumWidth = 6;
            this.colSelectedCertificateId.Name = "colSelectedCertificateId";
            this.colSelectedCertificateId.ReadOnly = true;
            this.colSelectedCertificateId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSelectedCertificateId.Visible = false;
            this.colSelectedCertificateId.Width = 6;
            // 
            // colSelectedCertificateName
            // 
            this.colSelectedCertificateName.DataPropertyName = "CertificateName";
            this.colSelectedCertificateName.HeaderText = "Название";
            this.colSelectedCertificateName.MinimumWidth = 6;
            this.colSelectedCertificateName.Name = "colSelectedCertificateName";
            this.colSelectedCertificateName.ReadOnly = true;
            this.colSelectedCertificateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSelectedCertificateName.Width = 125;
            // 
            // colSelectedCertificateNumber
            // 
            this.colSelectedCertificateNumber.DataPropertyName = "Number";
            this.colSelectedCertificateNumber.HeaderText = "Номер";
            this.colSelectedCertificateNumber.MinimumWidth = 6;
            this.colSelectedCertificateNumber.Name = "colSelectedCertificateNumber";
            this.colSelectedCertificateNumber.ReadOnly = true;
            this.colSelectedCertificateNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSelectedCertificateNumber.Width = 150;
            // 
            // colSelectedCertificateBeginDate
            // 
            this.colSelectedCertificateBeginDate.DataPropertyName = "BeginDate";
            this.colSelectedCertificateBeginDate.HeaderText = "Дата выдачи";
            this.colSelectedCertificateBeginDate.MinimumWidth = 6;
            this.colSelectedCertificateBeginDate.Name = "colSelectedCertificateBeginDate";
            this.colSelectedCertificateBeginDate.ReadOnly = true;
            this.colSelectedCertificateBeginDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSelectedCertificateBeginDate.Width = 125;
            // 
            // colSelectedCertificateEndDate
            // 
            this.colSelectedCertificateEndDate.DataPropertyName = "EndDate";
            this.colSelectedCertificateEndDate.HeaderText = "Действует до";
            this.colSelectedCertificateEndDate.MinimumWidth = 6;
            this.colSelectedCertificateEndDate.Name = "colSelectedCertificateEndDate";
            this.colSelectedCertificateEndDate.ReadOnly = true;
            this.colSelectedCertificateEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSelectedCertificateEndDate.Width = 125;
            // 
            // colSelectedCertificateOrganization
            // 
            this.colSelectedCertificateOrganization.DataPropertyName = "Organization";
            this.colSelectedCertificateOrganization.HeaderText = "Орган, выдавший сертификат";
            this.colSelectedCertificateOrganization.MinimumWidth = 6;
            this.colSelectedCertificateOrganization.Name = "colSelectedCertificateOrganization";
            this.colSelectedCertificateOrganization.ReadOnly = true;
            this.colSelectedCertificateOrganization.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSelectedCertificateOrganization.Width = 200;
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.pnlMainTools);
            this.pnlTools.Controls.Add(this.pnlRefresh);
            this.pnlTools.Controls.Add(this.pnlSeparator1);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(1058, 0);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(144, 735);
            this.pnlTools.TabIndex = 14;
            // 
            // pnlMainTools
            // 
            this.pnlMainTools.Controls.Add(this.pnlToolsForSelected);
            this.pnlMainTools.Controls.Add(this.btnAdd);
            this.pnlMainTools.Controls.Add(this.btnEdit);
            this.pnlMainTools.Controls.Add(this.btnDelete);
            this.pnlMainTools.Controls.Add(this.btnSelect);
            this.pnlMainTools.Controls.Add(this.btnPrintAll);
            this.pnlMainTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTools.Location = new System.Drawing.Point(0, 86);
            this.pnlMainTools.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainTools.Name = "pnlMainTools";
            this.pnlMainTools.Size = new System.Drawing.Size(144, 476);
            this.pnlMainTools.TabIndex = 19;
            // 
            // pnlToolsForSelected
            // 
            this.pnlToolsForSelected.Controls.Add(this.btnClear);
            this.pnlToolsForSelected.Controls.Add(this.btnPrintSelected);
            this.pnlToolsForSelected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlToolsForSelected.Location = new System.Drawing.Point(0, 344);
            this.pnlToolsForSelected.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlToolsForSelected.Name = "pnlToolsForSelected";
            this.pnlToolsForSelected.Size = new System.Drawing.Size(144, 132);
            this.pnlToolsForSelected.TabIndex = 20;
            this.pnlToolsForSelected.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 55);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 43);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить список";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrintSelected
            // 
            this.btnPrintSelected.Location = new System.Drawing.Point(4, 4);
            this.btnPrintSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintSelected.Name = "btnPrintSelected";
            this.btnPrintSelected.Size = new System.Drawing.Size(133, 43);
            this.btnPrintSelected.TabIndex = 13;
            this.btnPrintSelected.Text = "Напечатать выбранные";
            this.btnPrintSelected.UseVisualStyleBackColor = true;
            this.btnPrintSelected.Click += new System.EventHandler(this.btnPrintSelected_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 1);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 43);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(5, 64);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 43);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(5, 127);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 43);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(5, 282);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(133, 43);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(5, 190);
            this.btnPrintAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(133, 43);
            this.btnPrintAll.TabIndex = 18;
            this.btnPrintAll.Text = "Напечатать реестр";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRefresh.Location = new System.Drawing.Point(0, 33);
            this.pnlRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(144, 53);
            this.pnlRefresh.TabIndex = 18;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(5, 1);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 43);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlSeparator1
            // 
            this.pnlSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator1.Location = new System.Drawing.Point(0, 0);
            this.pnlSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSeparator1.Name = "pnlSeparator1";
            this.pnlSeparator1.Size = new System.Drawing.Size(144, 33);
            this.pnlSeparator1.TabIndex = 17;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.tbSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 661);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1058, 48);
            this.pnlSearch.TabIndex = 15;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(85, 9);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(962, 22);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 9);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Поиск";
            // 
            // CertificatesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 735);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusCertificate);
            this.Controls.Add(this.mainMenuCertificates);
            this.Controls.Add(this.pnlTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuCertificates;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CertificatesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр сертификатов 3";
            this.Load += new System.EventHandler(this.CertificatesListViewForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CertificatesListViewForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bsCertificates)).EndInit();
            this.statusCertificate.ResumeLayout(false);
            this.statusCertificate.PerformLayout();
            this.mainMenuCertificates.ResumeLayout(false);
            this.mainMenuCertificates.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitCertificates.Panel1.ResumeLayout(false);
            this.splitCertificates.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCertificates)).EndInit();
            this.splitCertificates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCertificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectedCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedCertificates)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlMainTools.ResumeLayout(false);
            this.pnlToolsForSelected.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusCertificate;
        private System.Windows.Forms.MenuStrip mainMenuCertificates;
        private System.Windows.Forms.ToolStripMenuItem сертификатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распечататьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCertificatesCount;
        private System.Windows.Forms.ToolStripMenuItem выбраныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem напечататьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsCertificates;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.SplitContainer splitCertificates;
        private System.Windows.Forms.DataGridView grdCertificates;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganization;
        private System.Windows.Forms.DataGridView grdSelectedCertificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedCertificateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedCertificateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedCertificateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedCertificateBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedCertificateEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedCertificateOrganization;
        private System.Windows.Forms.BindingSource bsSelectedCertificates;
        private System.Windows.Forms.Panel pnlSeparator1;
        private System.Windows.Forms.Panel pnlMainTools;
        private System.Windows.Forms.Panel pnlToolsForSelected;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrintSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentDBType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокОрганизацийToolStripMenuItem;
    }
}