namespace UserHash
{
    partial class UserForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(30, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(76, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Vítej, uživateli!";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(30, 60);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(64, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Nové heslo:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(120, 60);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(150, 20);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(120, 100);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(100, 23);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Změnit heslo";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(336, 185);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "UserForm";
            this.Text = "Uživatelský účet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}