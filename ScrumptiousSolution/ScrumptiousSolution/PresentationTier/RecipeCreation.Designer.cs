namespace ScrumptiousSolution.PresentationTier
{
    partial class RecipeCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeCreation));
            this.lblMealType = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this._cmbMealType = new System.Windows.Forms.ComboBox();
            this._txtRecipeName = new System.Windows.Forms.TextBox();
            this._clbIngredients = new System.Windows.Forms.CheckedListBox();
            this._rchtxtInstructions = new System.Windows.Forms.RichTextBox();
            this._btnCreateRecipe = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnChooseFile = new System.Windows.Forms.Button();
            this.lblRecipe = new System.Windows.Forms.Label();
            this._picboxRecipeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._picboxRecipeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealType.Location = new System.Drawing.Point(16, 74);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(136, 29);
            this.lblMealType.TabIndex = 0;
            this.lblMealType.Text = "Meal Type:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(16, 398);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(156, 29);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Instructions:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(16, 120);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(151, 29);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(16, 26);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(177, 29);
            this.lblRecipeName.TabIndex = 3;
            this.lblRecipeName.Text = "Recipe Name:";
            // 
            // _cmbMealType
            // 
            this._cmbMealType.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmbMealType.FormattingEnabled = true;
            this._cmbMealType.Location = new System.Drawing.Point(200, 69);
            this._cmbMealType.Name = "_cmbMealType";
            this._cmbMealType.Size = new System.Drawing.Size(240, 37);
            this._cmbMealType.TabIndex = 4;
            this._cmbMealType.Text = "------------------";
            this._cmbMealType.SelectedIndexChanged += new System.EventHandler(this.OnSomethingChanged);
            // 
            // _txtRecipeName
            // 
            this._txtRecipeName.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtRecipeName.Location = new System.Drawing.Point(200, 22);
            this._txtRecipeName.Name = "_txtRecipeName";
            this._txtRecipeName.Size = new System.Drawing.Size(240, 36);
            this._txtRecipeName.TabIndex = 5;
            this._txtRecipeName.TextChanged += new System.EventHandler(this.OnSomethingChanged);
            // 
            // _clbIngredients
            // 
            this._clbIngredients.BackColor = System.Drawing.Color.WhiteSmoke;
            this._clbIngredients.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clbIngredients.FormattingEnabled = true;
            this._clbIngredients.Location = new System.Drawing.Point(22, 152);
            this._clbIngredients.Name = "_clbIngredients";
            this._clbIngredients.Size = new System.Drawing.Size(416, 221);
            this._clbIngredients.TabIndex = 6;
            this._clbIngredients.SelectedIndexChanged += new System.EventHandler(this.OnSomethingChanged);
            // 
            // _rchtxtInstructions
            // 
            this._rchtxtInstructions.BackColor = System.Drawing.Color.WhiteSmoke;
            this._rchtxtInstructions.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rchtxtInstructions.Location = new System.Drawing.Point(16, 431);
            this._rchtxtInstructions.Name = "_rchtxtInstructions";
            this._rchtxtInstructions.Size = new System.Drawing.Size(577, 256);
            this._rchtxtInstructions.TabIndex = 7;
            this._rchtxtInstructions.Text = "";
            this._rchtxtInstructions.TextChanged += new System.EventHandler(this.OnSomethingChanged);
            // 
            // _btnCreateRecipe
            // 
            this._btnCreateRecipe.BackColor = System.Drawing.Color.Gray;
            this._btnCreateRecipe.Enabled = false;
            this._btnCreateRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCreateRecipe.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCreateRecipe.ForeColor = System.Drawing.Color.White;
            this._btnCreateRecipe.Location = new System.Drawing.Point(620, 518);
            this._btnCreateRecipe.Name = "_btnCreateRecipe";
            this._btnCreateRecipe.Size = new System.Drawing.Size(168, 91);
            this._btnCreateRecipe.TabIndex = 8;
            this._btnCreateRecipe.Text = "Create Recipe!";
            this._btnCreateRecipe.UseVisualStyleBackColor = false;
            this._btnCreateRecipe.Click += new System.EventHandler(this.OnCreateRecipe);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackColor = System.Drawing.Color.Gray;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCancel.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(620, 634);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(168, 55);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _btnChooseFile
            // 
            this._btnChooseFile.BackColor = System.Drawing.Color.Gray;
            this._btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnChooseFile.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnChooseFile.ForeColor = System.Drawing.Color.White;
            this._btnChooseFile.Location = new System.Drawing.Point(604, 325);
            this._btnChooseFile.Name = "_btnChooseFile";
            this._btnChooseFile.Size = new System.Drawing.Size(183, 48);
            this._btnChooseFile.TabIndex = 10;
            this._btnChooseFile.Text = "Choose File";
            this._btnChooseFile.UseVisualStyleBackColor = false;
            this._btnChooseFile.Click += new System.EventHandler(this._btnChooseFile_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(456, 14);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(93, 29);
            this.lblRecipe.TabIndex = 12;
            this.lblRecipe.Text = "Image:";
            // 
            // _picboxRecipeImage
            // 
            this._picboxRecipeImage.Location = new System.Drawing.Point(462, 46);
            this._picboxRecipeImage.Name = "_picboxRecipeImage";
            this._picboxRecipeImage.Size = new System.Drawing.Size(326, 272);
            this._picboxRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picboxRecipeImage.TabIndex = 11;
            this._picboxRecipeImage.TabStop = false;
            // 
            // RecipeCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(804, 706);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this._picboxRecipeImage);
            this.Controls.Add(this._btnChooseFile);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnCreateRecipe);
            this.Controls.Add(this._rchtxtInstructions);
            this.Controls.Add(this._clbIngredients);
            this.Controls.Add(this._txtRecipeName);
            this.Controls.Add(this._cmbMealType);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblMealType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeCreation";
            this.Text = "Create a Recipe";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this._picboxRecipeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.ComboBox _cmbMealType;
        private System.Windows.Forms.TextBox _txtRecipeName;
        private System.Windows.Forms.CheckedListBox _clbIngredients;
        private System.Windows.Forms.RichTextBox _rchtxtInstructions;
        private System.Windows.Forms.Button _btnCreateRecipe;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnChooseFile;
        private System.Windows.Forms.PictureBox _picboxRecipeImage;
        private System.Windows.Forms.Label lblRecipe;
    }
}