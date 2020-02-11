namespace CertificateRegistry3.PresentationLayer
{
    partial class CertificateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrganizationLbl = new System.Windows.Forms.Label();
            this.AddOrganizationBtn = new System.Windows.Forms.Button();
            this.OrganizationComboBox = new System.Windows.Forms.ComboBox();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BeginDateLbl = new System.Windows.Forms.Label();
            this.CertificateNumberTextBox = new System.Windows.Forms.TextBox();
            this.CertificateNumberLbl = new System.Windows.Forms.Label();
            this.CertificateNameLbl = new System.Windows.Forms.Label();
            this.BeginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CertificateNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrganizationLbl);
            this.panel1.Controls.Add(this.AddOrganizationBtn);
            this.panel1.Controls.Add(this.OrganizationComboBox);
            this.panel1.Controls.Add(this.EndDateLbl);
            this.panel1.Controls.Add(this.EndDatePicker);
            this.panel1.Controls.Add(this.BeginDateLbl);
            this.panel1.Controls.Add(this.CertificateNumberTextBox);
            this.panel1.Controls.Add(this.CertificateNumberLbl);
            this.panel1.Controls.Add(this.CertificateNameLbl);
            this.panel1.Controls.Add(this.BeginDatePicker);
            this.panel1.Controls.Add(this.CertificateNameTextBox);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 178);
            this.panel1.TabIndex = 0;
            // 
            // OrganizationLbl
            // 
            this.OrganizationLbl.AutoSize = true;
            this.OrganizationLbl.Location = new System.Drawing.Point(7, 135);
            this.OrganizationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrganizationLbl.Name = "OrganizationLbl";
            this.OrganizationLbl.Size = new System.Drawing.Size(206, 17);
            this.OrganizationLbl.TabIndex = 9;
            this.OrganizationLbl.Text = "Огран, выдавший сертификат";
            // 
            // AddOrganizationBtn
            // 
            this.AddOrganizationBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrganizationBtn.Location = new System.Drawing.Point(540, 123);
            this.AddOrganizationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddOrganizationBtn.Name = "AddOrganizationBtn";
            this.AddOrganizationBtn.Size = new System.Drawing.Size(33, 37);
            this.AddOrganizationBtn.TabIndex = 5;
            this.AddOrganizationBtn.Text = "+";
            this.AddOrganizationBtn.UseVisualStyleBackColor = true;
            this.AddOrganizationBtn.Click += new System.EventHandler(this.AddOrganizationBtn_Click);
            // 
            // OrganizationComboBox
            // 
            this.OrganizationComboBox.DisplayMember = "Name";
            this.OrganizationComboBox.FormattingEnabled = true;
            this.OrganizationComboBox.Location = new System.Drawing.Point(220, 129);
            this.OrganizationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.OrganizationComboBox.Name = "OrganizationComboBox";
            this.OrganizationComboBox.Size = new System.Drawing.Size(312, 24);
            this.OrganizationComboBox.TabIndex = 4;
            this.OrganizationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OrganizationComboBox_KeyUp);
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.Location = new System.Drawing.Point(7, 105);
            this.EndDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(98, 17);
            this.EndDateLbl.TabIndex = 7;
            this.EndDateLbl.Text = "Действует до";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(220, 98);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(312, 22);
            this.EndDatePicker.TabIndex = 3;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // BeginDateLbl
            // 
            this.BeginDateLbl.AutoSize = true;
            this.BeginDateLbl.Location = new System.Drawing.Point(7, 74);
            this.BeginDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BeginDateLbl.Name = "BeginDateLbl";
            this.BeginDateLbl.Size = new System.Drawing.Size(95, 17);
            this.BeginDateLbl.TabIndex = 5;
            this.BeginDateLbl.Text = "Дата выдачи";
            // 
            // CertificateNumberTextBox
            // 
            this.CertificateNumberTextBox.Location = new System.Drawing.Point(220, 37);
            this.CertificateNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CertificateNumberTextBox.Name = "CertificateNumberTextBox";
            this.CertificateNumberTextBox.Size = new System.Drawing.Size(352, 22);
            this.CertificateNumberTextBox.TabIndex = 1;
            // 
            // CertificateNumberLbl
            // 
            this.CertificateNumberLbl.AutoSize = true;
            this.CertificateNumberLbl.Location = new System.Drawing.Point(7, 43);
            this.CertificateNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CertificateNumberLbl.Name = "CertificateNumberLbl";
            this.CertificateNumberLbl.Size = new System.Drawing.Size(51, 17);
            this.CertificateNumberLbl.TabIndex = 3;
            this.CertificateNumberLbl.Text = "Номер";
            // 
            // CertificateNameLbl
            // 
            this.CertificateNameLbl.AutoSize = true;
            this.CertificateNameLbl.Location = new System.Drawing.Point(7, 12);
            this.CertificateNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CertificateNameLbl.Name = "CertificateNameLbl";
            this.CertificateNameLbl.Size = new System.Drawing.Size(72, 17);
            this.CertificateNameLbl.TabIndex = 2;
            this.CertificateNameLbl.Text = "Название";
            // 
            // BeginDatePicker
            // 
            this.BeginDatePicker.Location = new System.Drawing.Point(220, 68);
            this.BeginDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.BeginDatePicker.Name = "BeginDatePicker";
            this.BeginDatePicker.Size = new System.Drawing.Size(312, 22);
            this.BeginDatePicker.TabIndex = 2;
            this.BeginDatePicker.ValueChanged += new System.EventHandler(this.BeginDatePicker_ValueChanged);
            // 
            // CertificateNameTextBox
            // 
            this.CertificateNameTextBox.Location = new System.Drawing.Point(220, 6);
            this.CertificateNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CertificateNameTextBox.Name = "CertificateNameTextBox";
            this.CertificateNameTextBox.Size = new System.Drawing.Size(352, 22);
            this.CertificateNameTextBox.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(413, 197);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(133, 43);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(40, 197);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 43);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(595, 250);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сертификат";
            this.Load += new System.EventHandler(this.CertificateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CertificateNameTextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label CertificateNameLbl;
        private System.Windows.Forms.DateTimePicker BeginDatePicker;
        private System.Windows.Forms.Label BeginDateLbl;
        private System.Windows.Forms.TextBox CertificateNumberTextBox;
        private System.Windows.Forms.Label CertificateNumberLbl;
        private System.Windows.Forms.ComboBox OrganizationComboBox;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label OrganizationLbl;
        private System.Windows.Forms.Button AddOrganizationBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}