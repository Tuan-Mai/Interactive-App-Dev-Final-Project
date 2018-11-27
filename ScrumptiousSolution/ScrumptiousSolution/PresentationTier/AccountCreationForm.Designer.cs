namespace ScrumptiousSolution.PresentationTier
{
    partial class AccountCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCreationForm));
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblCreateUsername = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnCreate = new System.Windows.Forms.Button();
            this._txtCreateUsername = new System.Windows.Forms.TextBox();
            this._txtCreatePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.Location = new System.Drawing.Point(130, 42);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(226, 29);
            this.lblCreateAccount.TabIndex = 0;
            this.lblCreateAccount.Text = "Create your account";
            // 
            // lblCreateUsername
            // 
            this.lblCreateUsername.AutoSize = true;
            this.lblCreateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUsername.Location = new System.Drawing.Point(99, 131);
            this.lblCreateUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateUsername.Name = "lblCreateUsername";
            this.lblCreateUsername.Size = new System.Drawing.Size(136, 29);
            this.lblCreateUsername.TabIndex = 1;
            this.lblCreateUsername.Text = "Username: ";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePassword.Location = new System.Drawing.Point(111, 178);
            this.lblCreatePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(126, 29);
            this.lblCreatePassword.TabIndex = 2;
            this.lblCreatePassword.Text = "Password:";
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.Color.Gray;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCancel.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(18, 300);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(172, 85);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _btnCreate
            // 
            this._btnCreate.BackColor = System.Drawing.Color.Gray;
            this._btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCreate.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCreate.ForeColor = System.Drawing.Color.White;
            this._btnCreate.Location = new System.Drawing.Point(316, 300);
            this._btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCreate.Name = "_btnCreate";
            this._btnCreate.Size = new System.Drawing.Size(172, 85);
            this._btnCreate.TabIndex = 4;
            this._btnCreate.Text = "Create";
            this._btnCreate.UseVisualStyleBackColor = false;
            this._btnCreate.Click += new System.EventHandler(this.OnCreate);
            // 
            // _txtCreateUsername
            // 
            this._txtCreateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCreateUsername.Location = new System.Drawing.Point(266, 126);
            this._txtCreateUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtCreateUsername.Name = "_txtCreateUsername";
            this._txtCreateUsername.Size = new System.Drawing.Size(222, 35);
            this._txtCreateUsername.TabIndex = 1;
            this._txtCreateUsername.TextChanged += new System.EventHandler(this.OnUsernameChanged);
            // 
            // _txtCreatePassword
            // 
            this._txtCreatePassword.BackColor = System.Drawing.Color.White;
            this._txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCreatePassword.Location = new System.Drawing.Point(266, 174);
            this._txtCreatePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtCreatePassword.Name = "_txtCreatePassword";
            this._txtCreatePassword.Size = new System.Drawing.Size(222, 35);
            this._txtCreatePassword.TabIndex = 2;
            this._txtCreatePassword.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm Password:";
            // 
            // _txtConfirmPassword
            // 
            this._txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this._txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtConfirmPassword.Location = new System.Drawing.Point(266, 218);
            this._txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtConfirmPassword.Name = "_txtConfirmPassword";
            this._txtConfirmPassword.Size = new System.Drawing.Size(222, 35);
            this._txtConfirmPassword.TabIndex = 3;
            this._txtConfirmPassword.TextChanged += new System.EventHandler(this.OnConfirmPasswordChanged);
            // 
            // AccountCreationForm
            // 
            this.AcceptButton = this._btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this._txtConfirmPassword);
            this.Controls.Add(this._txtCreatePassword);
            this.Controls.Add(this._txtCreateUsername);
            this.Controls.Add(this._btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.lblCreateUsername);
            this.Controls.Add(this.lblCreateAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(520, 431);
            this.MinimumSize = new System.Drawing.Size(520, 431);
            this.Name = "AccountCreationForm";
            this.Text = "AccountCreationForm";
            this.Load += new System.EventHandler(this.AccountCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label lblCreateUsername;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.TextBox _txtCreateUsername;
        private System.Windows.Forms.TextBox _txtCreatePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtConfirmPassword;
    }
}