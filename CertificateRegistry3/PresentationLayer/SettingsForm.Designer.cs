﻿namespace CertificateRegistry3.PresentationLayer
{
    partial class SettingsForm
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpPrintSettings = new System.Windows.Forms.TabPage();
            this.lblAddress = new System.Windows.Forms.Label();
            this.teAddress = new System.Windows.Forms.TextBox();
            this.tpDBSettings = new System.Windows.Forms.TabPage();
            this.gbConnectionSettings = new System.Windows.Forms.GroupBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tePassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.teUsername = new System.Windows.Forms.TextBox();
            this.lbHostOrAddress = new System.Windows.Forms.Label();
            this.teHostOrAddress = new System.Windows.Forms.TextBox();
            this.gbDBType = new System.Windows.Forms.GroupBox();
            this.rbSQLite = new System.Windows.Forms.RadioButton();
            this.rbPostgreSQL = new System.Windows.Forms.RadioButton();
            this.pnlButtons.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpPrintSettings.SuspendLayout();
            this.tpDBSettings.SuspendLayout();
            this.gbConnectionSettings.SuspendLayout();
            this.gbDBType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 198);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(554, 30);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(472, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(391, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpPrintSettings);
            this.tcSettings.Controls.Add(this.tpDBSettings);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(0, 0);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(554, 198);
            this.tcSettings.TabIndex = 3;
            // 
            // tpPrintSettings
            // 
            this.tpPrintSettings.Controls.Add(this.lblAddress);
            this.tpPrintSettings.Controls.Add(this.teAddress);
            this.tpPrintSettings.Location = new System.Drawing.Point(4, 22);
            this.tpPrintSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tpPrintSettings.Name = "tpPrintSettings";
            this.tpPrintSettings.Padding = new System.Windows.Forms.Padding(2);
            this.tpPrintSettings.Size = new System.Drawing.Size(546, 172);
            this.tpPrintSettings.TabIndex = 1;
            this.tpPrintSettings.Text = "Настройки печати";
            this.tpPrintSettings.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 13);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(163, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Адрес хранения сертификатов";
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(171, 5);
            this.teAddress.Margin = new System.Windows.Forms.Padding(2);
            this.teAddress.Multiline = true;
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(368, 163);
            this.teAddress.TabIndex = 0;
            this.teAddress.Leave += new System.EventHandler(this.teAddress_Leave);
            // 
            // tpDBSettings
            // 
            this.tpDBSettings.Controls.Add(this.gbConnectionSettings);
            this.tpDBSettings.Controls.Add(this.gbDBType);
            this.tpDBSettings.Location = new System.Drawing.Point(4, 22);
            this.tpDBSettings.Name = "tpDBSettings";
            this.tpDBSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpDBSettings.Size = new System.Drawing.Size(546, 172);
            this.tpDBSettings.TabIndex = 0;
            this.tpDBSettings.Text = "Настройки базы данных";
            this.tpDBSettings.UseVisualStyleBackColor = true;
            // 
            // gbConnectionSettings
            // 
            this.gbConnectionSettings.Controls.Add(this.lbPassword);
            this.gbConnectionSettings.Controls.Add(this.tePassword);
            this.gbConnectionSettings.Controls.Add(this.lbUsername);
            this.gbConnectionSettings.Controls.Add(this.teUsername);
            this.gbConnectionSettings.Controls.Add(this.lbHostOrAddress);
            this.gbConnectionSettings.Controls.Add(this.teHostOrAddress);
            this.gbConnectionSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConnectionSettings.Location = new System.Drawing.Point(3, 68);
            this.gbConnectionSettings.Name = "gbConnectionSettings";
            this.gbConnectionSettings.Size = new System.Drawing.Size(540, 100);
            this.gbConnectionSettings.TabIndex = 4;
            this.gbConnectionSettings.TabStop = false;
            this.gbConnectionSettings.Text = "Настройки подключения";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 74);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Пароль";
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(166, 71);
            this.tePassword.Name = "tePassword";
            this.tePassword.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(371, 20);
            this.tePassword.TabIndex = 4;
            this.tePassword.Leave += new System.EventHandler(this.tePassword_Leave);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(12, 48);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(103, 13);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Имя пользователя";
            // 
            // teUsername
            // 
            this.teUsername.Location = new System.Drawing.Point(166, 45);
            this.teUsername.Name = "teUsername";
            this.teUsername.Size = new System.Drawing.Size(371, 20);
            this.teUsername.TabIndex = 2;
            this.teUsername.Leave += new System.EventHandler(this.teUsername_Leave);
            // 
            // lbHostOrAddress
            // 
            this.lbHostOrAddress.AutoSize = true;
            this.lbHostOrAddress.Location = new System.Drawing.Point(12, 22);
            this.lbHostOrAddress.Name = "lbHostOrAddress";
            this.lbHostOrAddress.Size = new System.Drawing.Size(148, 13);
            this.lbHostOrAddress.TabIndex = 1;
            this.lbHostOrAddress.Text = "Адрес или имя компьютера";
            // 
            // teHostOrAddress
            // 
            this.teHostOrAddress.Location = new System.Drawing.Point(166, 19);
            this.teHostOrAddress.Name = "teHostOrAddress";
            this.teHostOrAddress.Size = new System.Drawing.Size(371, 20);
            this.teHostOrAddress.TabIndex = 0;
            this.teHostOrAddress.Leave += new System.EventHandler(this.teHostOrAddress_Leave);
            // 
            // gbDBType
            // 
            this.gbDBType.Controls.Add(this.rbSQLite);
            this.gbDBType.Controls.Add(this.rbPostgreSQL);
            this.gbDBType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDBType.Location = new System.Drawing.Point(3, 3);
            this.gbDBType.Name = "gbDBType";
            this.gbDBType.Size = new System.Drawing.Size(540, 65);
            this.gbDBType.TabIndex = 3;
            this.gbDBType.TabStop = false;
            this.gbDBType.Text = "Тип базы данных";
            // 
            // rbSQLite
            // 
            this.rbSQLite.AutoSize = true;
            this.rbSQLite.Location = new System.Drawing.Point(12, 42);
            this.rbSQLite.Name = "rbSQLite";
            this.rbSQLite.Size = new System.Drawing.Size(57, 17);
            this.rbSQLite.TabIndex = 1;
            this.rbSQLite.TabStop = true;
            this.rbSQLite.Text = "SQLite";
            this.rbSQLite.UseVisualStyleBackColor = true;
            this.rbSQLite.CheckedChanged += new System.EventHandler(this.rbSQLite_CheckedChanged);
            // 
            // rbPostgreSQL
            // 
            this.rbPostgreSQL.AutoSize = true;
            this.rbPostgreSQL.Location = new System.Drawing.Point(12, 19);
            this.rbPostgreSQL.Name = "rbPostgreSQL";
            this.rbPostgreSQL.Size = new System.Drawing.Size(82, 17);
            this.rbPostgreSQL.TabIndex = 0;
            this.rbPostgreSQL.TabStop = true;
            this.rbPostgreSQL.Text = "PostgreSQL";
            this.rbPostgreSQL.UseVisualStyleBackColor = true;
            this.rbPostgreSQL.CheckedChanged += new System.EventHandler(this.rbPostgreSQL_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 228);
            this.Controls.Add(this.tcSettings);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pnlButtons.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpPrintSettings.ResumeLayout(false);
            this.tpPrintSettings.PerformLayout();
            this.tpDBSettings.ResumeLayout(false);
            this.gbConnectionSettings.ResumeLayout(false);
            this.gbConnectionSettings.PerformLayout();
            this.gbDBType.ResumeLayout(false);
            this.gbDBType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpDBSettings;
        private System.Windows.Forms.GroupBox gbDBType;
        private System.Windows.Forms.RadioButton rbSQLite;
        private System.Windows.Forms.RadioButton rbPostgreSQL;
        private System.Windows.Forms.GroupBox gbConnectionSettings;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tePassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox teUsername;
        private System.Windows.Forms.Label lbHostOrAddress;
        private System.Windows.Forms.TextBox teHostOrAddress;
        private System.Windows.Forms.TabPage tpPrintSettings;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox teAddress;
    }
}