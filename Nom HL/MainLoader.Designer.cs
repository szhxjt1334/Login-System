namespace Nom_HL
{
    partial class MainLoader
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.newCheck = new System.Windows.Forms.CheckBox();
            this.newUserBox = new System.Windows.Forms.TextBox();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.newuserLabel = new System.Windows.Forms.Label();
            this.newpassLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(86, 74);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 1;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(192, 74);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(140, 100);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(98, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newCheck
            // 
            this.newCheck.AutoSize = true;
            this.newCheck.Location = new System.Drawing.Point(147, 150);
            this.newCheck.Name = "newCheck";
            this.newCheck.Size = new System.Drawing.Size(91, 17);
            this.newCheck.TabIndex = 4;
            this.newCheck.Text = "New Account";
            this.newCheck.UseVisualStyleBackColor = true;
            this.newCheck.CheckedChanged += new System.EventHandler(this.newCheck_CheckedChanged);
            // 
            // newUserBox
            // 
            this.newUserBox.Location = new System.Drawing.Point(86, 48);
            this.newUserBox.Name = "newUserBox";
            this.newUserBox.Size = new System.Drawing.Size(100, 20);
            this.newUserBox.TabIndex = 5;
            this.newUserBox.Visible = false;
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(192, 48);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.PasswordChar = '*';
            this.newPassBox.Size = new System.Drawing.Size(100, 20);
            this.newPassBox.TabIndex = 6;
            this.newPassBox.Visible = false;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(124, 86);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(128, 20);
            this.keyBox.TabIndex = 7;
            this.keyBox.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(140, 112);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(98, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Visible = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(177, 71);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 9;
            this.keyLabel.Text = "Key";
            this.keyLabel.Visible = false;
            // 
            // newuserLabel
            // 
            this.newuserLabel.AutoSize = true;
            this.newuserLabel.Location = new System.Drawing.Point(106, 58);
            this.newuserLabel.Name = "newuserLabel";
            this.newuserLabel.Size = new System.Drawing.Size(55, 13);
            this.newuserLabel.TabIndex = 10;
            this.newuserLabel.Text = "Username";
            // 
            // newpassLabel
            // 
            this.newpassLabel.AutoSize = true;
            this.newpassLabel.Location = new System.Drawing.Point(222, 58);
            this.newpassLabel.Name = "newpassLabel";
            this.newpassLabel.Size = new System.Drawing.Size(53, 13);
            this.newpassLabel.TabIndex = 11;
            this.newpassLabel.Text = "Password";
            // 
            // MainLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 179);
            this.Controls.Add(this.newpassLabel);
            this.Controls.Add(this.newuserLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.newUserBox);
            this.Controls.Add(this.newCheck);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                      ·L¬·    Nom Loader    ·L¬·";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox newCheck;
        private System.Windows.Forms.TextBox newUserBox;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label newuserLabel;
        private System.Windows.Forms.Label newpassLabel;
    }
}

