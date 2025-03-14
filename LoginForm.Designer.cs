namespace UserHash
{
    partial class LoginForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 13);
            this.lblUsername.Text = "Uživatelské jméno:";

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 13);
            this.lblPassword.Text = "Heslo:";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(130, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.Text = "Přihlásit se";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Přihlášení";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

