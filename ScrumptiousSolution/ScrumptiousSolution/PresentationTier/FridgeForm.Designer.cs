namespace ScrumptiousSolution.PresentationTier
{
    partial class FridgeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FridgeForm));
            this.lblFridgeContents = new System.Windows.Forms.Label();
            this.lblAddIngredient = new System.Windows.Forms.Label();
            this._btnAddToFridge = new System.Windows.Forms.Button();
            this._clbFridge = new System.Windows.Forms.CheckedListBox();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.lblAte = new System.Windows.Forms.Label();
            this._lbFridge = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblFridgeContents
            // 
            this.lblFridgeContents.AutoSize = true;
            this.lblFridgeContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFridgeContents.Location = new System.Drawing.Point(20, 22);
            this.lblFridgeContents.Name = "lblFridgeContents";
            this.lblFridgeContents.Size = new System.Drawing.Size(82, 20);
            this.lblFridgeContents.TabIndex = 2;
            this.lblFridgeContents.Text = "My Fridge:";
            // 
            // lblAddIngredient
            // 
            this.lblAddIngredient.AutoSize = true;
            this.lblAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddIngredient.Location = new System.Drawing.Point(400, 22);
            this.lblAddIngredient.Name = "lblAddIngredient";
            this.lblAddIngredient.Size = new System.Drawing.Size(139, 20);
            this.lblAddIngredient.TabIndex = 3;
            this.lblAddIngredient.Text = "What did you buy?";
            // 
            // _btnAddToFridge
            // 
            this._btnAddToFridge.BackColor = System.Drawing.Color.Gray;
            this._btnAddToFridge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAddToFridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddToFridge.ForeColor = System.Drawing.Color.White;
            this._btnAddToFridge.Location = new System.Drawing.Point(404, 309);
            this._btnAddToFridge.Name = "_btnAddToFridge";
            this._btnAddToFridge.Size = new System.Drawing.Size(162, 54);
            this._btnAddToFridge.TabIndex = 4;
            this._btnAddToFridge.Text = "Put in my fridge";
            this._btnAddToFridge.UseVisualStyleBackColor = false;
            this._btnAddToFridge.Click += new System.EventHandler(this.onAddIngredient);
            // 
            // _clbFridge
            // 
            this._clbFridge.CheckOnClick = true;
            this._clbFridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clbFridge.FormattingEnabled = true;
            this._clbFridge.Location = new System.Drawing.Point(404, 63);
            this._clbFridge.Name = "_clbFridge";
            this._clbFridge.Size = new System.Drawing.Size(162, 235);
            this._clbFridge.TabIndex = 5;
            // 
            // _btnRemove
            // 
            this._btnRemove.BackColor = System.Drawing.Color.Gray;
            this._btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRemove.ForeColor = System.Drawing.Color.White;
            this._btnRemove.Location = new System.Drawing.Point(404, 397);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(162, 54);
            this._btnRemove.TabIndex = 8;
            this._btnRemove.Text = "Delete selected items";
            this._btnRemove.UseVisualStyleBackColor = false;
            this._btnRemove.Click += new System.EventHandler(this.onRemoveIngredient);
            // 
            // _btnClose
            // 
            this._btnClose.BackColor = System.Drawing.Color.Gray;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClose.ForeColor = System.Drawing.Color.White;
            this._btnClose.Location = new System.Drawing.Point(404, 493);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(162, 54);
            this._btnClose.TabIndex = 9;
            this._btnClose.Text = "Close the fridge";
            this._btnClose.UseVisualStyleBackColor = false;
            this._btnClose.Click += new System.EventHandler(this.onClose);
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAte.Location = new System.Drawing.Point(442, 454);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(85, 20);
            this.lblAte.TabIndex = 7;
            this.lblAte.Text = "I ate them.";
            // 
            // _lbFridge
            // 
            this._lbFridge.CheckOnClick = true;
            this._lbFridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbFridge.FormattingEnabled = true;
            this._lbFridge.Location = new System.Drawing.Point(24, 63);
            this._lbFridge.Name = "_lbFridge";
            this._lbFridge.Size = new System.Drawing.Size(363, 487);
            this._lbFridge.TabIndex = 10;
            // 
            // FridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(586, 567);
            this.Controls.Add(this._lbFridge);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnRemove);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this._clbFridge);
            this.Controls.Add(this._btnAddToFridge);
            this.Controls.Add(this.lblAddIngredient);
            this.Controls.Add(this.lblFridgeContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(602, 605);
            this.MinimumSize = new System.Drawing.Size(602, 605);
            this.Name = "FridgeForm";
            this.Text = "Refridgerator";
            this.Load += new System.EventHandler(this.FridgeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFridgeContents;
        private System.Windows.Forms.Label lblAddIngredient;
        private System.Windows.Forms.Button _btnAddToFridge;
        private System.Windows.Forms.CheckedListBox _clbFridge;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.CheckedListBox _lbFridge;
    }
}