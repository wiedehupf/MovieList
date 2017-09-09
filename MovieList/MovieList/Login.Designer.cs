namespace MovieList
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.buttonAccounterstellen = new System.Windows.Forms.Button();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.labelPasswordwdhl = new System.Windows.Forms.Label();
            this.textBoxPasswordwdhl = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(122, 92);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(180, 20);
            this.TextBoxUsername.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(122, 162);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(180, 20);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(118, 69);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(114, 20);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Benutzername";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(119, 139);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(76, 20);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Kennwort";
            // 
            // buttonAccounterstellen
            // 
            this.buttonAccounterstellen.Location = new System.Drawing.Point(299, 302);
            this.buttonAccounterstellen.Name = "buttonAccounterstellen";
            this.buttonAccounterstellen.Size = new System.Drawing.Size(113, 31);
            this.buttonAccounterstellen.TabIndex = 5;
            this.buttonAccounterstellen.Text = "Account erstellen";
            this.buttonAccounterstellen.UseVisualStyleBackColor = true;
            this.buttonAccounterstellen.Click += new System.EventHandler(this.buttonAccounterstellen_Click);
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Location = new System.Drawing.Point(122, 210);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(180, 36);
            this.buttonUserLogin.TabIndex = 6;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            // 
            // labelPasswordwdhl
            // 
            this.labelPasswordwdhl.AutoSize = true;
            this.labelPasswordwdhl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordwdhl.Location = new System.Drawing.Point(119, 210);
            this.labelPasswordwdhl.Name = "labelPasswordwdhl";
            this.labelPasswordwdhl.Size = new System.Drawing.Size(165, 20);
            this.labelPasswordwdhl.TabIndex = 9;
            this.labelPasswordwdhl.Text = "Kennwort wiederholen";
            this.labelPasswordwdhl.Visible = false;
            // 
            // textBoxPasswordwdhl
            // 
            this.textBoxPasswordwdhl.Location = new System.Drawing.Point(122, 233);
            this.textBoxPasswordwdhl.Name = "textBoxPasswordwdhl";
            this.textBoxPasswordwdhl.Size = new System.Drawing.Size(180, 20);
            this.textBoxPasswordwdhl.TabIndex = 8;
            this.textBoxPasswordwdhl.UseSystemPasswordChar = true;
            this.textBoxPasswordwdhl.Visible = false;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(123, 274);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(180, 36);
            this.buttonCreateAccount.TabIndex = 10;
            this.buttonCreateAccount.Text = "Account erstellen";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 308);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(71, 25);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "zurück";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 345);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelPasswordwdhl);
            this.Controls.Add(this.textBoxPasswordwdhl);
            this.Controls.Add(this.buttonUserLogin);
            this.Controls.Add(this.buttonAccounterstellen);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button buttonAccounterstellen;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.Label labelPasswordwdhl;
        private System.Windows.Forms.TextBox textBoxPasswordwdhl;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonBack;
    }
}

