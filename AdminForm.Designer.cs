namespace UserHash
{
    partial class AdminForm
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewUserPassword = new System.Windows.Forms.TextBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(30, 20);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(150, 95);
            this.lstUsers.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(200, 20);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(64, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Nové heslo:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(200, 40);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(150, 20);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(200, 70);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(100, 23);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Resetovat heslo";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(200, 160);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Přidat uživatele";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(30, 130);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(150, 20);
            this.txtNewUsername.TabIndex = 2;
            this.txtNewUsername.Text = "Uživatelské jméno";
            this.txtNewUsername.Enter += new System.EventHandler(this.txtNewUsername_Enter);
            this.txtNewUsername.Leave += new System.EventHandler(this.txtNewUsername_Leave);
            // 
            // txtNewUserPassword
            // 
            this.txtNewUserPassword.Location = new System.Drawing.Point(200, 130);
            this.txtNewUserPassword.Name = "txtNewUserPassword";
            this.txtNewUserPassword.Size = new System.Drawing.Size(150, 20);
            this.txtNewUserPassword.TabIndex = 1;
            this.txtNewUserPassword.Text = "Heslo";
            this.txtNewUserPassword.UseSystemPasswordChar = true;
            this.txtNewUserPassword.Enter += new System.EventHandler(this.txtNewUserPassword_Enter);
            this.txtNewUserPassword.Leave += new System.EventHandler(this.txtNewUserPassword_Leave);
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.Location = new System.Drawing.Point(30, 160);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(104, 24);
            this.chkIsAdmin.TabIndex = 0;
            this.chkIsAdmin.Text = "Admin?";
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(424, 248);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.txtNewUserPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnResetPassword);
            this.Name = "AdminForm";
            this.Text = "Správa uživatelů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtNewUserPassword;
        private System.Windows.Forms.CheckBox chkIsAdmin;
    }
}