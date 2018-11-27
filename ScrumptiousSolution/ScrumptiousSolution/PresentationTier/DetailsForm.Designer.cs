namespace ScrumptiousSolution.PresentationTier
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this._picboxRecipePicture = new System.Windows.Forms.PictureBox();
            this._lblNameOfRecipe = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this._rchtxtIngredients = new System.Windows.Forms.RichTextBox();
            this._rchtxtInstructions = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._picboxRecipePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // _picboxRecipePicture
            // 
            this._picboxRecipePicture.Image = global::ScrumptiousSolution.Properties.Resources.background;
            this._picboxRecipePicture.Location = new System.Drawing.Point(44, 80);
            this._picboxRecipePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._picboxRecipePicture.Name = "_picboxRecipePicture";
            this._picboxRecipePicture.Size = new System.Drawing.Size(423, 372);
            this._picboxRecipePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picboxRecipePicture.TabIndex = 0;
            this._picboxRecipePicture.TabStop = false;
            // 
            // _lblNameOfRecipe
            // 
            this._lblNameOfRecipe.AutoSize = true;
            this._lblNameOfRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNameOfRecipe.Location = new System.Drawing.Point(33, 23);
            this._lblNameOfRecipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblNameOfRecipe.Name = "_lblNameOfRecipe";
            this._lblNameOfRecipe.Size = new System.Drawing.Size(434, 55);
            this._lblNameOfRecipe.TabIndex = 1;
            this._lblNameOfRecipe.Text = "NAME OF RECIPE";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(726, 80);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(275, 55);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(504, 395);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(635, 55);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Instructions on how to make:";
            // 
            // _rchtxtIngredients
            // 
            this._rchtxtIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rchtxtIngredients.Location = new System.Drawing.Point(576, 163);
            this._rchtxtIngredients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._rchtxtIngredients.Name = "_rchtxtIngredients";
            this._rchtxtIngredients.ReadOnly = true;
            this._rchtxtIngredients.Size = new System.Drawing.Size(565, 184);
            this._rchtxtIngredients.TabIndex = 4;
            this._rchtxtIngredients.Text = "";
            // 
            // _rchtxtInstructions
            // 
            this._rchtxtInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rchtxtInstructions.Location = new System.Drawing.Point(44, 488);
            this._rchtxtInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._rchtxtInstructions.Name = "_rchtxtInstructions";
            this._rchtxtInstructions.ReadOnly = true;
            this._rchtxtInstructions.Size = new System.Drawing.Size(1098, 526);
            this._rchtxtInstructions.TabIndex = 5;
            this._rchtxtInstructions.Text = "";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1174, 1011);
            this.Controls.Add(this._rchtxtInstructions);
            this.Controls.Add(this._rchtxtIngredients);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this._lblNameOfRecipe);
            this.Controls.Add(this._picboxRecipePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1196, 1067);
            this.MinimumSize = new System.Drawing.Size(1196, 1067);
            this.Name = "DetailsForm";
            this.Text = "xRecipex - Details";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEscapeKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this._picboxRecipePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picboxRecipePicture;
        private System.Windows.Forms.Label _lblNameOfRecipe;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.RichTextBox _rchtxtIngredients;
        private System.Windows.Forms.RichTextBox _rchtxtInstructions;
    }
}