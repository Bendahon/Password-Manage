namespace Password_Manager
{
    partial class Form1
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
            this.dgridActivePasswords = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefaultPasswords = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordBox = new System.Windows.Forms.Label();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.chckDefaultPassword = new System.Windows.Forms.CheckBox();
            this.btnSeePassword = new System.Windows.Forms.Button();
            this.chckViewPassword = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportEncryptedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importEncryptedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgridActivePasswords)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridActivePasswords
            // 
            this.dgridActivePasswords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridActivePasswords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgridActivePasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgridActivePasswords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgridActivePasswords.Location = new System.Drawing.Point(0, 297);
            this.dgridActivePasswords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgridActivePasswords.Name = "dgridActivePasswords";
            this.dgridActivePasswords.Size = new System.Drawing.Size(2018, 731);
            this.dgridActivePasswords.TabIndex = 2;
            this.dgridActivePasswords.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(4, 5);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 88);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Loa&d";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLock
            // 
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Location = new System.Drawing.Point(304, 5);
            this.btnLock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(141, 88);
            this.btnLock.TabIndex = 4;
            this.btnLock.TabStop = false;
            this.btnLock.Text = "Lo&ck";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "btnExit";
            this.btnExit.AccessibleName = "btnExit";
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(604, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 88);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLock, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDefaultPasswords, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(154, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 88);
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDefaultPasswords
            // 
            this.btnDefaultPasswords.Enabled = false;
            this.btnDefaultPasswords.FlatAppearance.BorderSize = 0;
            this.btnDefaultPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultPasswords.Location = new System.Drawing.Point(454, 5);
            this.btnDefaultPasswords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDefaultPasswords.Name = "btnDefaultPasswords";
            this.btnDefaultPasswords.Size = new System.Drawing.Size(141, 88);
            this.btnDefaultPasswords.TabIndex = 15;
            this.btnDefaultPasswords.TabStop = false;
            this.btnDefaultPasswords.Text = "Default";
            this.btnDefaultPasswords.UseVisualStyleBackColor = true;
            this.btnDefaultPasswords.Click += new System.EventHandler(this.btnDefaultPasswords_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 11);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(716, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordBox
            // 
            this.lblPasswordBox.AutoSize = true;
            this.lblPasswordBox.Location = new System.Drawing.Point(18, 17);
            this.lblPasswordBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordBox.Name = "lblPasswordBox";
            this.lblPasswordBox.Size = new System.Drawing.Size(172, 20);
            this.lblPasswordBox.TabIndex = 11;
            this.lblPasswordBox.Text = "Enter password in here";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLogFile.Location = new System.Drawing.Point(1138, 35);
            this.txtLogFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogFile.Multiline = true;
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.ReadOnly = true;
            this.txtLogFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogFile.Size = new System.Drawing.Size(880, 262);
            this.txtLogFile.TabIndex = 14;
            this.txtLogFile.TabStop = false;
            // 
            // chckDefaultPassword
            // 
            this.chckDefaultPassword.AutoSize = true;
            this.chckDefaultPassword.Location = new System.Drawing.Point(477, 160);
            this.chckDefaultPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckDefaultPassword.Name = "chckDefaultPassword";
            this.chckDefaultPassword.Size = new System.Drawing.Size(160, 24);
            this.chckDefaultPassword.TabIndex = 15;
            this.chckDefaultPassword.TabStop = false;
            this.chckDefaultPassword.Text = "Default Password";
            this.chckDefaultPassword.UseVisualStyleBackColor = true;
            this.chckDefaultPassword.CheckedChanged += new System.EventHandler(this.chckDefaultPassword_CheckedChanged);
            // 
            // btnSeePassword
            // 
            this.btnSeePassword.Enabled = false;
            this.btnSeePassword.FlatAppearance.BorderSize = 0;
            this.btnSeePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePassword.Location = new System.Drawing.Point(782, 55);
            this.btnSeePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeePassword.Name = "btnSeePassword";
            this.btnSeePassword.Size = new System.Drawing.Size(141, 88);
            this.btnSeePassword.TabIndex = 16;
            this.btnSeePassword.TabStop = false;
            this.btnSeePassword.Text = "View Password";
            this.btnSeePassword.UseVisualStyleBackColor = true;
            this.btnSeePassword.MouseEnter += new System.EventHandler(this.btnSeePassword_MouseEnter);
            this.btnSeePassword.MouseLeave += new System.EventHandler(this.btnSeePassword_MouseLeave);
            // 
            // chckViewPassword
            // 
            this.chckViewPassword.AutoSize = true;
            this.chckViewPassword.Location = new System.Drawing.Point(800, 160);
            this.chckViewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckViewPassword.Name = "chckViewPassword";
            this.chckViewPassword.Size = new System.Drawing.Size(142, 24);
            this.chckViewPassword.TabIndex = 17;
            this.chckViewPassword.TabStop = false;
            this.chckViewPassword.Text = "View Password";
            this.chckViewPassword.UseVisualStyleBackColor = true;
            this.chckViewPassword.CheckedChanged += new System.EventHandler(this.chckViewPassword_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2018, 35);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemeToolStripMenuItem,
            this.exportEncryptedDataToolStripMenuItem,
            this.importEncryptedDataToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ThemeToolStripMenuItem
            // 
            this.ThemeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem";
            this.ThemeToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.ThemeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(149, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.chckViewPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnSeePassword);
            this.panel1.Controls.Add(this.lblPasswordBox);
            this.panel1.Controls.Add(this.chckDefaultPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 262);
            this.panel1.TabIndex = 20;
            // 
            // exportEncryptedDataToolStripMenuItem
            // 
            this.exportEncryptedDataToolStripMenuItem.Name = "exportEncryptedDataToolStripMenuItem";
            this.exportEncryptedDataToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.exportEncryptedDataToolStripMenuItem.Text = "Export Encrypted Data";
            this.exportEncryptedDataToolStripMenuItem.Click += new System.EventHandler(this.exportEncryptedDataToolStripMenuItem_Click);
            // 
            // importEncryptedDataToolStripMenuItem
            // 
            this.importEncryptedDataToolStripMenuItem.Name = "importEncryptedDataToolStripMenuItem";
            this.importEncryptedDataToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.importEncryptedDataToolStripMenuItem.Text = "Import Encrypted Data";
            this.importEncryptedDataToolStripMenuItem.Click += new System.EventHandler(this.importEncryptedDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(2018, 1028);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.dgridActivePasswords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgridActivePasswords)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgridActivePasswords;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPasswordBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Button btnDefaultPasswords;
        private System.Windows.Forms.CheckBox chckDefaultPassword;
        private System.Windows.Forms.Button btnSeePassword;
        private System.Windows.Forms.CheckBox chckViewPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem exportEncryptedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importEncryptedDataToolStripMenuItem;
    }
}

