namespace ScrumptiousSolution.PresentationTier
{
    partial class DatabaseUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUpdate));
            this.lblIngredient = new System.Windows.Forms.Label();
            this._txtIngredientName = new System.Windows.Forms.TextBox();
            this.lblAddIngredient = new System.Windows.Forms.Label();
            this.lblServingSize = new System.Windows.Forms.Label();
            this._txtServingSize = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this._txtCalories = new System.Windows.Forms.TextBox();
            this._ckbtnVegetarian = new System.Windows.Forms.CheckBox();
            this._ckbtnGlutenFree = new System.Windows.Forms.CheckBox();
            this._btnAddIngredient = new System.Windows.Forms.Button();
            this.lblRemoveIngredient = new System.Windows.Forms.Label();
            this._btnRemoveIngredients = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._ckbtnIngredient = new System.Windows.Forms.CheckBox();
            this._ckbtnRecipe = new System.Windows.Forms.CheckBox();
            this._lblAddResponse = new System.Windows.Forms.Label();
            this._lblRemoveResponse = new System.Windows.Forms.Label();
            this._lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(50, 103);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(193, 29);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Ingredient name:";
            // 
            // _txtIngredientName
            // 
            this._txtIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtIngredientName.Location = new System.Drawing.Point(270, 98);
            this._txtIngredientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtIngredientName.Name = "_txtIngredientName";
            this._txtIngredientName.Size = new System.Drawing.Size(283, 35);
            this._txtIngredientName.TabIndex = 1;
            this._txtIngredientName.TextChanged += new System.EventHandler(this.CheckAddEnable);
            // 
            // lblAddIngredient
            // 
            this.lblAddIngredient.AutoSize = true;
            this.lblAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddIngredient.Location = new System.Drawing.Point(93, 34);
            this.lblAddIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddIngredient.Name = "lblAddIngredient";
            this.lblAddIngredient.Size = new System.Drawing.Size(372, 29);
            this.lblAddIngredient.TabIndex = 2;
            this.lblAddIngredient.Text = "Add an ingredient to the database";
            // 
            // lblServingSize
            // 
            this.lblServingSize.AutoSize = true;
            this.lblServingSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingSize.Location = new System.Drawing.Point(110, 175);
            this.lblServingSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServingSize.Name = "lblServingSize";
            this.lblServingSize.Size = new System.Drawing.Size(150, 29);
            this.lblServingSize.TabIndex = 3;
            this.lblServingSize.Text = "Serving size:";
            // 
            // _txtServingSize
            // 
            this._txtServingSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtServingSize.Location = new System.Drawing.Point(270, 171);
            this._txtServingSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtServingSize.Name = "_txtServingSize";
            this._txtServingSize.Size = new System.Drawing.Size(283, 35);
            this._txtServingSize.TabIndex = 4;
            this._txtServingSize.TextChanged += new System.EventHandler(this.CheckAddEnable);
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.Location = new System.Drawing.Point(21, 249);
            this.lblCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(235, 29);
            this.lblCalories.TabIndex = 5;
            this.lblCalories.Text = "Calories per serving:";
            // 
            // _txtCalories
            // 
            this._txtCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCalories.Location = new System.Drawing.Point(270, 245);
            this._txtCalories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtCalories.Name = "_txtCalories";
            this._txtCalories.Size = new System.Drawing.Size(283, 35);
            this._txtCalories.TabIndex = 6;
            this._txtCalories.TextChanged += new System.EventHandler(this.CheckAddEnable);
            // 
            // _ckbtnVegetarian
            // 
            this._ckbtnVegetarian.AutoSize = true;
            this._ckbtnVegetarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ckbtnVegetarian.Location = new System.Drawing.Point(120, 315);
            this._ckbtnVegetarian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._ckbtnVegetarian.Name = "_ckbtnVegetarian";
            this._ckbtnVegetarian.Size = new System.Drawing.Size(167, 33);
            this._ckbtnVegetarian.TabIndex = 7;
            this._ckbtnVegetarian.Text = "Vegetarian?";
            this._ckbtnVegetarian.UseVisualStyleBackColor = true;
            // 
            // _ckbtnGlutenFree
            // 
            this._ckbtnGlutenFree.AutoSize = true;
            this._ckbtnGlutenFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ckbtnGlutenFree.Location = new System.Drawing.Point(346, 315);
            this._ckbtnGlutenFree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._ckbtnGlutenFree.Name = "_ckbtnGlutenFree";
            this._ckbtnGlutenFree.Size = new System.Drawing.Size(180, 33);
            this._ckbtnGlutenFree.TabIndex = 8;
            this._ckbtnGlutenFree.Text = "Gluten-Free?";
            this._ckbtnGlutenFree.UseVisualStyleBackColor = true;
            // 
            // _btnAddIngredient
            // 
            this._btnAddIngredient.BackColor = System.Drawing.Color.Gray;
            this._btnAddIngredient.Enabled = false;
            this._btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddIngredient.ForeColor = System.Drawing.Color.White;
            this._btnAddIngredient.Location = new System.Drawing.Point(332, 378);
            this._btnAddIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnAddIngredient.Name = "_btnAddIngredient";
            this._btnAddIngredient.Size = new System.Drawing.Size(224, 57);
            this._btnAddIngredient.TabIndex = 9;
            this._btnAddIngredient.Text = "Add";
            this._btnAddIngredient.UseVisualStyleBackColor = false;
            this._btnAddIngredient.Click += new System.EventHandler(this.onAddIngredient);
            // 
            // lblRemoveIngredient
            // 
            this.lblRemoveIngredient.AutoSize = true;
            this.lblRemoveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveIngredient.Location = new System.Drawing.Point(152, 466);
            this.lblRemoveIngredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveIngredient.Name = "lblRemoveIngredient";
            this.lblRemoveIngredient.Size = new System.Drawing.Size(262, 29);
            this.lblRemoveIngredient.TabIndex = 10;
            this.lblRemoveIngredient.Text = "Remove from database";
            // 
            // _btnRemoveIngredients
            // 
            this._btnRemoveIngredients.BackColor = System.Drawing.Color.Gray;
            this._btnRemoveIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnRemoveIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRemoveIngredients.ForeColor = System.Drawing.Color.White;
            this._btnRemoveIngredients.Location = new System.Drawing.Point(332, 725);
            this._btnRemoveIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnRemoveIngredients.Name = "_btnRemoveIngredients";
            this._btnRemoveIngredients.Size = new System.Drawing.Size(224, 91);
            this._btnRemoveIngredients.TabIndex = 12;
            this._btnRemoveIngredients.Text = "Remove Selected Item";
            this._btnRemoveIngredients.UseVisualStyleBackColor = false;
            this._btnRemoveIngredients.Click += new System.EventHandler(this.onRemoveItem);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.Color.Gray;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(196, 857);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(224, 68);
            this._btnCancel.TabIndex = 14;
            this._btnCancel.Text = "Close";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _ckbtnIngredient
            // 
            this._ckbtnIngredient.AutoSize = true;
            this._ckbtnIngredient.Checked = true;
            this._ckbtnIngredient.CheckState = System.Windows.Forms.CheckState.Checked;
            this._ckbtnIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ckbtnIngredient.Location = new System.Drawing.Point(346, 551);
            this._ckbtnIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._ckbtnIngredient.Name = "_ckbtnIngredient";
            this._ckbtnIngredient.Size = new System.Drawing.Size(147, 33);
            this._ckbtnIngredient.TabIndex = 16;
            this._ckbtnIngredient.Text = "Ingredient";
            this._ckbtnIngredient.UseVisualStyleBackColor = true;
            this._ckbtnIngredient.CheckedChanged += new System.EventHandler(this.DisableOtherCheck);
            // 
            // _ckbtnRecipe
            // 
            this._ckbtnRecipe.AutoSize = true;
            this._ckbtnRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ckbtnRecipe.Location = new System.Drawing.Point(346, 597);
            this._ckbtnRecipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._ckbtnRecipe.Name = "_ckbtnRecipe";
            this._ckbtnRecipe.Size = new System.Drawing.Size(116, 33);
            this._ckbtnRecipe.TabIndex = 17;
            this._ckbtnRecipe.Text = "Recipe";
            this._ckbtnRecipe.UseVisualStyleBackColor = true;
            this._ckbtnRecipe.CheckedChanged += new System.EventHandler(this.DisableOtherCheck);
            // 
            // _lblAddResponse
            // 
            this._lblAddResponse.AutoSize = true;
            this._lblAddResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAddResponse.Location = new System.Drawing.Point(34, 391);
            this._lblAddResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblAddResponse.Name = "_lblAddResponse";
            this._lblAddResponse.Size = new System.Drawing.Size(179, 29);
            this._lblAddResponse.TabIndex = 18;
            this._lblAddResponse.Text = "Result text here";
            this._lblAddResponse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this._lblAddResponse.Visible = false;
            // 
            // _lblRemoveResponse
            // 
            this._lblRemoveResponse.AutoSize = true;
            this._lblRemoveResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRemoveResponse.Location = new System.Drawing.Point(346, 671);
            this._lblRemoveResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblRemoveResponse.Name = "_lblRemoveResponse";
            this._lblRemoveResponse.Size = new System.Drawing.Size(179, 29);
            this._lblRemoveResponse.TabIndex = 19;
            this._lblRemoveResponse.Text = "Result text here";
            this._lblRemoveResponse.Visible = false;
            // 
            // _lbItems
            // 
            this._lbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbItems.FormattingEnabled = true;
            this._lbItems.ItemHeight = 29;
            this._lbItems.Location = new System.Drawing.Point(36, 551);
            this._lbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._lbItems.Name = "_lbItems";
            this._lbItems.Size = new System.Drawing.Size(274, 236);
            this._lbItems.TabIndex = 20;
            this._lbItems.SelectedIndexChanged += new System.EventHandler(this._lbItems_SelectedIndexChanged);
            // 
            // DatabaseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(596, 915);
            this.Controls.Add(this._lbItems);
            this.Controls.Add(this._lblRemoveResponse);
            this.Controls.Add(this._lblAddResponse);
            this.Controls.Add(this._ckbtnRecipe);
            this.Controls.Add(this._ckbtnIngredient);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnRemoveIngredients);
            this.Controls.Add(this.lblRemoveIngredient);
            this.Controls.Add(this._btnAddIngredient);
            this.Controls.Add(this._ckbtnGlutenFree);
            this.Controls.Add(this._ckbtnVegetarian);
            this.Controls.Add(this._txtCalories);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this._txtServingSize);
            this.Controls.Add(this.lblServingSize);
            this.Controls.Add(this.lblAddIngredient);
            this.Controls.Add(this._txtIngredientName);
            this.Controls.Add(this.lblIngredient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(618, 971);
            this.MinimumSize = new System.Drawing.Size(618, 971);
            this.Name = "DatabaseUpdate";
            this.Text = "Modify Ingredient Database";
            this.Load += new System.EventHandler(this.DatabaseUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.TextBox _txtIngredientName;
        private System.Windows.Forms.Label lblAddIngredient;
        private System.Windows.Forms.Label lblServingSize;
        private System.Windows.Forms.TextBox _txtServingSize;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.TextBox _txtCalories;
        private System.Windows.Forms.CheckBox _ckbtnVegetarian;
        private System.Windows.Forms.CheckBox _ckbtnGlutenFree;
        private System.Windows.Forms.Button _btnAddIngredient;
        private System.Windows.Forms.Label lblRemoveIngredient;
        private System.Windows.Forms.Button _btnRemoveIngredients;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.CheckBox _ckbtnIngredient;
        private System.Windows.Forms.CheckBox _ckbtnRecipe;
        private System.Windows.Forms.Label _lblAddResponse;
        private System.Windows.Forms.Label _lblRemoveResponse;
        private System.Windows.Forms.ListBox _lbItems;
    }
}