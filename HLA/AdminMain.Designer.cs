namespace HLA
{
    partial class AdminMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.visitEmuDevsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Search = new System.Windows.Forms.TabPage();
            this.Accounts = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.activityGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resetKeysButton = new System.Windows.Forms.Button();
            this.listGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.unbanButton = new System.Windows.Forms.Button();
            this.unlockButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.banButton = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.genButton = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Search.SuspendLayout();
            this.Accounts.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.visitEmuDevsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // visitEmuDevsToolStripMenuItem
            // 
            this.visitEmuDevsToolStripMenuItem.Name = "visitEmuDevsToolStripMenuItem";
            this.visitEmuDevsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.visitEmuDevsToolStripMenuItem.Text = "Visit EmuDevs";
            // 
            // userGrid
            // 
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Location = new System.Drawing.Point(11, 34);
            this.userGrid.Name = "userGrid";
            this.userGrid.Size = new System.Drawing.Size(636, 319);
            this.userGrid.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(117, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(11, 8);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(106, 20);
            this.searchBox.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Controls.Add(this.Accounts);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 385);
            this.tabControl1.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Control;
            this.Search.Controls.Add(this.searchButton);
            this.Search.Controls.Add(this.userGrid);
            this.Search.Controls.Add(this.searchBox);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(625, 359);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // Accounts
            // 
            this.Accounts.BackColor = System.Drawing.SystemColors.Control;
            this.Accounts.Controls.Add(this.groupBox4);
            this.Accounts.Controls.Add(this.groupBox3);
            this.Accounts.Controls.Add(this.groupBox2);
            this.Accounts.Controls.Add(this.groupBox1);
            this.Accounts.Location = new System.Drawing.Point(4, 22);
            this.Accounts.Name = "Accounts";
            this.Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.Accounts.Size = new System.Drawing.Size(649, 359);
            this.Accounts.TabIndex = 1;
            this.Accounts.Text = "Accounts";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.activityGrid);
            this.groupBox4.Location = new System.Drawing.Point(238, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 240);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Last Login Activity";
            // 
            // activityGrid
            // 
            this.activityGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityGrid.Location = new System.Drawing.Point(6, 19);
            this.activityGrid.Name = "activityGrid";
            this.activityGrid.Size = new System.Drawing.Size(389, 215);
            this.activityGrid.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resetKeysButton);
            this.groupBox3.Controls.Add(this.listGrid);
            this.groupBox3.Location = new System.Drawing.Point(8, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 240);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Keys";
            // 
            // resetKeysButton
            // 
            this.resetKeysButton.Location = new System.Drawing.Point(52, 211);
            this.resetKeysButton.Name = "resetKeysButton";
            this.resetKeysButton.Size = new System.Drawing.Size(75, 23);
            this.resetKeysButton.TabIndex = 1;
            this.resetKeysButton.Text = "Refresh List";
            this.resetKeysButton.UseVisualStyleBackColor = true;
            this.resetKeysButton.Click += new System.EventHandler(this.resetKeysButton_Click);
            // 
            // listGrid
            // 
            this.listGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listGrid.Location = new System.Drawing.Point(6, 19);
            this.listGrid.Name = "listGrid";
            this.listGrid.Size = new System.Drawing.Size(195, 190);
            this.listGrid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.unbanButton);
            this.groupBox2.Controls.Add(this.unlockButton);
            this.groupBox2.Controls.Add(this.lockButton);
            this.groupBox2.Controls.Add(this.banButton);
            this.groupBox2.Controls.Add(this.userBox);
            this.groupBox2.Location = new System.Drawing.Point(238, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Control";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(232, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(151, 67);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // unbanButton
            // 
            this.unbanButton.Location = new System.Drawing.Point(70, 67);
            this.unbanButton.Name = "unbanButton";
            this.unbanButton.Size = new System.Drawing.Size(75, 23);
            this.unbanButton.TabIndex = 4;
            this.unbanButton.Text = "Unban";
            this.unbanButton.UseVisualStyleBackColor = true;
            this.unbanButton.Click += new System.EventHandler(this.unbanButton_Click);
            // 
            // unlockButton
            // 
            this.unlockButton.Location = new System.Drawing.Point(232, 43);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(75, 23);
            this.unlockButton.TabIndex = 3;
            this.unlockButton.Text = "Unlock";
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.Location = new System.Drawing.Point(151, 43);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(75, 23);
            this.lockButton.TabIndex = 2;
            this.lockButton.Text = "Lock";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // banButton
            // 
            this.banButton.Location = new System.Drawing.Point(70, 43);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(75, 23);
            this.banButton.TabIndex = 1;
            this.banButton.Text = "Ban";
            this.banButton.UseVisualStyleBackColor = true;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(114, 19);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(154, 20);
            this.userBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.genButton);
            this.groupBox1.Controls.Add(this.keyBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Key";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(106, 55);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Key";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(27, 55);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 1;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(27, 29);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(154, 20);
            this.keyBox.TabIndex = 0;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                            ·L¬· " +
    "   NL Admin    ·L¬·";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Accounts.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Accounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button unbanButton;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Button banButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView listGrid;
        private System.Windows.Forms.Button resetKeysButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem visitEmuDevsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView activityGrid;
    }
}