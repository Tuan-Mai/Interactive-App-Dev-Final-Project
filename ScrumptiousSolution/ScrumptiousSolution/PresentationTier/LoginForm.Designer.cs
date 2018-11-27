namespace ScrumptiousSolution
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblAccountLogin = new System.Windows.Forms.Label();
            this.lblAccountUsername = new System.Windows.Forms.Label();
            this.lblAccountPassword = new System.Windows.Forms.Label();
            this._txtAccountUsername = new System.Windows.Forms.TextBox();
            this._txtAccountPassword = new System.Windows.Forms.TextBox();
            this._btnCreateAccount = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnAccountLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccountLogin
            // 
            this.lblAccountLogin.AutoSize = true;
            this.lblAccountLogin.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountLogin.Location = new System.Drawing.Point(86, 22);
            this.lblAccountLogin.Name = "lblAccountLogin";
            this.lblAccountLogin.Size = new System.Drawing.Size(120, 19);
            this.lblAccountLogin.TabIndex = 0;
            this.lblAccountLogin.Text = "Account Login";
            // 
            // lblAccountUsername
            // 
            this.lblAccountUsername.AutoSize = true;
            this.lblAccountUsername.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountUsername.Location = new System.Drawing.Point(12, 73);
            this.lblAccountUsername.Name = "lblAccountUsername";
            this.lblAccountUsername.Size = new System.Drawing.Size(91, 19);
            this.lblAccountUsername.TabIndex = 1;
            this.lblAccountUsername.Text = "Username:";
            // 
            // lblAccountPassword
            // 
            this.lblAccountPassword.AutoSize = true;
            this.lblAccountPassword.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountPassword.Location = new System.Drawing.Point(12, 106);
            this.lblAccountPassword.Name = "lblAccountPassword";
            this.lblAccountPassword.Size = new System.Drawing.Size(87, 19);
            this.lblAccountPassword.TabIndex = 2;
            this.lblAccountPassword.Text = "Password:";
            // 
            // _txtAccountUsername
            // 
            this._txtAccountUsername.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAccountUsername.Location = new System.Drawing.Point(120, 70);
            this._txtAccountUsername.Name = "_txtAccountUsername";
            this._txtAccountUsername.Size = new System.Drawing.Size(152, 27);
            this._txtAccountUsername.TabIndex = 1;
            this._txtAccountUsername.TextChanged += new System.EventHandler(this.OnUsernameChanged);
            // 
            // _txtAccountPassword
            // 
            this._txtAccountPassword.BackColor = System.Drawing.Color.White;
            this._txtAccountPassword.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAccountPassword.Location = new System.Drawing.Point(120, 103);
            this._txtAccountPassword.Name = "_txtAccountPassword";
            this._txtAccountPassword.Size = new System.Drawing.Size(152, 27);
            this._txtAccountPassword.TabIndex = 2;
            this._txtAccountPassword.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            // 
            // _btnCreateAccount
            // 
            this._btnCreateAccount.BackColor = System.Drawing.Color.Gray;
            this._btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCreateAccount.Font = new System.Drawing.Font("Montserrat Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this._btnCreateAccount.Location = new System.Drawing.Point(163, 223);
            this._btnCreateAccount.Name = "_btnCreateAccount";
            this._btnCreateAccount.Size = new System.Drawing.Size(109, 27);
            this._btnCreateAccount.TabIndex = 5;
            this._btnCreateAccount.Text = "Create Account";
            this._btnCreateAccount.UseVisualStyleBackColor = false;
            this._btnCreateAccount.Click += new System.EventHandler(this.OnCreateAccount);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.Color.Gray;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCancel.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(12, 153);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(115, 55);
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _btnAccountLogin
            // 
            this._btnAccountLogin.BackColor = System.Drawing.Color.Gray;
            this._btnAccountLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAccountLogin.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAccountLogin.ForeColor = System.Drawing.Color.White;
            this._btnAccountLogin.Location = new System.Drawing.Point(157, 153);
            this._btnAccountLogin.Name = "_btnAccountLogin";
            this._btnAccountLogin.Size = new System.Drawing.Size(115, 55);
            this._btnAccountLogin.TabIndex = 3;
            this._btnAccountLogin.Text = "Login";
            this._btnAccountLogin.UseVisualStyleBackColor = false;
            this._btnAccountLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Need to make an account?";
            // 
            // LoginForm
            // 
            this.AcceptButton = this._btnAccountLogin;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnAccountLogin);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnCreateAccount);
            this.Controls.Add(this._txtAccountPassword);
            this.Controls.Add(this._txtAccountUsername);
            this.Controls.Add(this.lblAccountPassword);
            this.Controls.Add(this.lblAccountUsername);
            this.Controls.Add(this.lblAccountLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label lblAccountLogin;
        private System.Windows.Forms.Label lblAccountUsername;
        private System.Windows.Forms.Label lblAccountPassword;
        private System.Windows.Forms.TextBox _txtAccountUsername;
        private System.Windows.Forms.TextBox _txtAccountPassword;
        private System.Windows.Forms.Button _btnCreateAccount;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnAccountLogin;
        private System.Windows.Forms.Label label1;
    }
}

