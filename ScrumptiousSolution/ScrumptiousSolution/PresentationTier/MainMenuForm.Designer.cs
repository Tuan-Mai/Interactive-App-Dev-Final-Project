namespace ScrumptiousSolution.PresentationTier
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this._lblUserName = new System.Windows.Forms.Label();
            this._lblLogin = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tstrpEditDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this._txtSearchbox = new System.Windows.Forms.TextBox();
            this.lblSearchbyIngredient = new System.Windows.Forms.Label();
            this._btnSearch = new System.Windows.Forms.Button();
            this._btnCheckFridge = new System.Windows.Forms.Button();
            this.grpboxSearchedRecipes = new System.Windows.Forms.GroupBox();
            this._lblSearchedRecipeName = new System.Windows.Forms.Label();
            this._btnSearchedAddToFavorites = new System.Windows.Forms.Button();
            this.lblSearchedDescription = new System.Windows.Forms.Label();
            this._btnSearchedMoreDetails = new System.Windows.Forms.Button();
            this._picboxRecipeImage = new System.Windows.Forms.PictureBox();
            this._rchtxtDescription = new System.Windows.Forms.RichTextBox();
            this._lbSearchedRecipes = new System.Windows.Forms.ListBox();
            this.lblSeparateitemsbycommas = new System.Windows.Forms.Label();
            this._tabctrlRecipes = new System.Windows.Forms.TabControl();
            this._tabpgSearch = new System.Windows.Forms.TabPage();
            this._btnSearchWithMyFridge = new System.Windows.Forms.Button();
            this._tabpgFavorites = new System.Windows.Forms.TabPage();
            this.grpboxFavRecipes = new System.Windows.Forms.GroupBox();
            this._btnRemoveFromFavorites = new System.Windows.Forms.Button();
            this._lblFavRecipeName = new System.Windows.Forms.Label();
            this.lblFavDescription = new System.Windows.Forms.Label();
            this._btnFavMoreDetails = new System.Windows.Forms.Button();
            this._picboxFavRecipe = new System.Windows.Forms.PictureBox();
            this._rchtxtFavDescription = new System.Windows.Forms.RichTextBox();
            this._lbFavRecipes = new System.Windows.Forms.ListBox();
            this._tabpgCookbook = new System.Windows.Forms.TabPage();
            this._btnCreateRecipe = new System.Windows.Forms.Button();
            this.grpboxCreatedRecipes = new System.Windows.Forms.GroupBox();
            this._btnRemoveFromCookbook = new System.Windows.Forms.Button();
            this._lblCreatedRecipeName = new System.Windows.Forms.Label();
            this.lblCreatedDescription = new System.Windows.Forms.Label();
            this._btnCreatedMoreDetails = new System.Windows.Forms.Button();
            this._picboxCreatedRecipe = new System.Windows.Forms.PictureBox();
            this._rchtxtCreatedDescription = new System.Windows.Forms.RichTextBox();
            this._lbCookbook = new System.Windows.Forms.ListBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.grpboxSearchedRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picboxRecipeImage)).BeginInit();
            this._tabctrlRecipes.SuspendLayout();
            this._tabpgSearch.SuspendLayout();
            this._tabpgFavorites.SuspendLayout();
            this.grpboxFavRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picboxFavRecipe)).BeginInit();
            this._tabpgCookbook.SuspendLayout();
            this.grpboxCreatedRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picboxCreatedRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(519, 69);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(141, 29);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // _lblUserName
            // 
            this._lblUserName.AutoSize = true;
            this._lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblUserName.Location = new System.Drawing.Point(670, 69);
            this._lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblUserName.Name = "_lblUserName";
            this._lblUserName.Size = new System.Drawing.Size(76, 29);
            this._lblUserName.TabIndex = 1;
            this._lblUserName.Text = "Guest";
            // 
            // _lblLogin
            // 
            this._lblLogin.AutoSize = true;
            this._lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLogin.Location = new System.Drawing.Point(844, 115);
            this._lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblLogin.Name = "_lblLogin";
            this._lblLogin.Size = new System.Drawing.Size(423, 29);
            this._lblLogin.TabIndex = 2;
            this._lblLogin.Text = "Login for your favorite/created recipes:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1524, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(90, 29);
            this.toolStripDropDownButton1.Text = "Account";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tstrpEditDatabase});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // _tstrpEditDatabase
            // 
            this._tstrpEditDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this._tstrpEditDatabase.Name = "_tstrpEditDatabase";
            this._tstrpEditDatabase.Size = new System.Drawing.Size(201, 30);
            this._tstrpEditDatabase.Text = "Edit Database..";
            this._tstrpEditDatabase.Click += new System.EventHandler(this.OnEditIngredientsDatabase);
            // 
            // _txtSearchbox
            // 
            this._txtSearchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSearchbox.Location = new System.Drawing.Point(26, 54);
            this._txtSearchbox.Name = "_txtSearchbox";
            this._txtSearchbox.Size = new System.Drawing.Size(758, 35);
            this._txtSearchbox.TabIndex = 5;
            // 
            // lblSearchbyIngredient
            // 
            this.lblSearchbyIngredient.AutoSize = true;
            this.lblSearchbyIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchbyIngredient.Location = new System.Drawing.Point(21, 22);
            this.lblSearchbyIngredient.Name = "lblSearchbyIngredient";
            this.lblSearchbyIngredient.Size = new System.Drawing.Size(240, 29);
            this.lblSearchbyIngredient.TabIndex = 6;
            this.lblSearchbyIngredient.Text = "Search by Ingredient:";
            // 
            // _btnSearch
            // 
            this._btnSearch.BackColor = System.Drawing.Color.Gray;
            this._btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearch.ForeColor = System.Drawing.Color.White;
            this._btnSearch.Location = new System.Drawing.Point(819, 42);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(228, 58);
            this._btnSearch.TabIndex = 7;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = false;
            this._btnSearch.Click += new System.EventHandler(this.OnSearch);
            // 
            // _btnCheckFridge
            // 
            this._btnCheckFridge.BackColor = System.Drawing.Color.Gray;
            this._btnCheckFridge.Enabled = false;
            this._btnCheckFridge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnCheckFridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCheckFridge.ForeColor = System.Drawing.Color.White;
            this._btnCheckFridge.Location = new System.Drawing.Point(528, 125);
            this._btnCheckFridge.Name = "_btnCheckFridge";
            this._btnCheckFridge.Size = new System.Drawing.Size(228, 62);
            this._btnCheckFridge.TabIndex = 8;
            this._btnCheckFridge.Text = "Check Fridge";
            this._btnCheckFridge.UseVisualStyleBackColor = false;
            this._btnCheckFridge.Click += new System.EventHandler(this.OnCheckFridge);
            // 
            // grpboxSearchedRecipes
            // 
            this.grpboxSearchedRecipes.Controls.Add(this._lblSearchedRecipeName);
            this.grpboxSearchedRecipes.Controls.Add(this._btnSearchedAddToFavorites);
            this.grpboxSearchedRecipes.Controls.Add(this.lblSearchedDescription);
            this.grpboxSearchedRecipes.Controls.Add(this._btnSearchedMoreDetails);
            this.grpboxSearchedRecipes.Controls.Add(this._picboxRecipeImage);
            this.grpboxSearchedRecipes.Controls.Add(this._rchtxtDescription);
            this.grpboxSearchedRecipes.Controls.Add(this._lbSearchedRecipes);
            this.grpboxSearchedRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSearchedRecipes.Location = new System.Drawing.Point(16, 106);
            this.grpboxSearchedRecipes.Name = "grpboxSearchedRecipes";
            this.grpboxSearchedRecipes.Size = new System.Drawing.Size(1430, 745);
            this.grpboxSearchedRecipes.TabIndex = 9;
            this.grpboxSearchedRecipes.TabStop = false;
            this.grpboxSearchedRecipes.Text = "Recipes";
            // 
            // _lblSearchedRecipeName
            // 
            this._lblSearchedRecipeName.AutoSize = true;
            this._lblSearchedRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSearchedRecipeName.Location = new System.Drawing.Point(932, 25);
            this._lblSearchedRecipeName.Name = "_lblSearchedRecipeName";
            this._lblSearchedRecipeName.Size = new System.Drawing.Size(0, 29);
            this._lblSearchedRecipeName.TabIndex = 14;
            // 
            // _btnSearchedAddToFavorites
            // 
            this._btnSearchedAddToFavorites.BackColor = System.Drawing.Color.Gray;
            this._btnSearchedAddToFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnSearchedAddToFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearchedAddToFavorites.ForeColor = System.Drawing.Color.White;
            this._btnSearchedAddToFavorites.Location = new System.Drawing.Point(1180, 312);
            this._btnSearchedAddToFavorites.Name = "_btnSearchedAddToFavorites";
            this._btnSearchedAddToFavorites.Size = new System.Drawing.Size(228, 58);
            this._btnSearchedAddToFavorites.TabIndex = 12;
            this._btnSearchedAddToFavorites.Text = "Add to Favorites";
            this._btnSearchedAddToFavorites.UseVisualStyleBackColor = false;
            this._btnSearchedAddToFavorites.Click += new System.EventHandler(this.OnAddToFavorites);
            // 
            // lblSearchedDescription
            // 
            this.lblSearchedDescription.AutoSize = true;
            this.lblSearchedDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedDescription.Location = new System.Drawing.Point(932, 368);
            this.lblSearchedDescription.Name = "lblSearchedDescription";
            this.lblSearchedDescription.Size = new System.Drawing.Size(141, 29);
            this.lblSearchedDescription.TabIndex = 13;
            this.lblSearchedDescription.Text = "Description:";
            // 
            // _btnSearchedMoreDetails
            // 
            this._btnSearchedMoreDetails.BackColor = System.Drawing.Color.Gray;
            this._btnSearchedMoreDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnSearchedMoreDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearchedMoreDetails.ForeColor = System.Drawing.Color.White;
            this._btnSearchedMoreDetails.Location = new System.Drawing.Point(1180, 675);
            this._btnSearchedMoreDetails.Name = "_btnSearchedMoreDetails";
            this._btnSearchedMoreDetails.Size = new System.Drawing.Size(228, 58);
            this._btnSearchedMoreDetails.TabIndex = 12;
            this._btnSearchedMoreDetails.Text = "More Details..";
            this._btnSearchedMoreDetails.UseVisualStyleBackColor = false;
            this._btnSearchedMoreDetails.Click += new System.EventHandler(this.OnMoreDetails);
            // 
            // _picboxRecipeImage
            // 
            this._picboxRecipeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._picboxRecipeImage.Location = new System.Drawing.Point(936, 34);
            this._picboxRecipeImage.Name = "_picboxRecipeImage";
            this._picboxRecipeImage.Size = new System.Drawing.Size(472, 272);
            this._picboxRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picboxRecipeImage.TabIndex = 2;
            this._picboxRecipeImage.TabStop = false;
            // 
            // _rchtxtDescription
            // 
            this._rchtxtDescription.Location = new System.Drawing.Point(936, 398);
            this._rchtxtDescription.Name = "_rchtxtDescription";
            this._rchtxtDescription.ReadOnly = true;
            this._rchtxtDescription.Size = new System.Drawing.Size(472, 270);
            this._rchtxtDescription.TabIndex = 1;
            this._rchtxtDescription.Text = "";
            // 
            // _lbSearchedRecipes
            // 
            this._lbSearchedRecipes.DisplayMember = "RecipeName";
            this._lbSearchedRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbSearchedRecipes.FormattingEnabled = true;
            this._lbSearchedRecipes.ItemHeight = 29;
            this._lbSearchedRecipes.Location = new System.Drawing.Point(6, 34);
            this._lbSearchedRecipes.Name = "_lbSearchedRecipes";
            this._lbSearchedRecipes.ScrollAlwaysVisible = true;
            this._lbSearchedRecipes.Size = new System.Drawing.Size(914, 700);
            this._lbSearchedRecipes.TabIndex = 0;
            this._lbSearchedRecipes.SelectedIndexChanged += new System.EventHandler(this.OnSearchSelectedIndexChanged);
            // 
            // lblSeparateitemsbycommas
            // 
            this.lblSeparateitemsbycommas.AutoSize = true;
            this.lblSeparateitemsbycommas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparateitemsbycommas.Location = new System.Drawing.Point(286, 22);
            this.lblSeparateitemsbycommas.Name = "lblSeparateitemsbycommas";
            this.lblSeparateitemsbycommas.Size = new System.Drawing.Size(321, 29);
            this.lblSeparateitemsbycommas.TabIndex = 11;
            this.lblSeparateitemsbycommas.Text = "(separate items by commas.)";
            // 
            // _tabctrlRecipes
            // 
            this._tabctrlRecipes.Controls.Add(this._tabpgSearch);
            this._tabctrlRecipes.Controls.Add(this._tabpgFavorites);
            this._tabctrlRecipes.Controls.Add(this._tabpgCookbook);
            this._tabctrlRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabctrlRecipes.Location = new System.Drawing.Point(26, 188);
            this._tabctrlRecipes.Name = "_tabctrlRecipes";
            this._tabctrlRecipes.SelectedIndex = 0;
            this._tabctrlRecipes.Size = new System.Drawing.Size(1474, 909);
            this._tabctrlRecipes.TabIndex = 14;
            // 
            // _tabpgSearch
            // 
            this._tabpgSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this._tabpgSearch.Controls.Add(this._btnSearchWithMyFridge);
            this._tabpgSearch.Controls.Add(this.lblSearchbyIngredient);
            this._tabpgSearch.Controls.Add(this._txtSearchbox);
            this._tabpgSearch.Controls.Add(this._btnSearch);
            this._tabpgSearch.Controls.Add(this.lblSeparateitemsbycommas);
            this._tabpgSearch.Controls.Add(this.grpboxSearchedRecipes);
            this._tabpgSearch.Location = new System.Drawing.Point(4, 38);
            this._tabpgSearch.Name = "_tabpgSearch";
            this._tabpgSearch.Padding = new System.Windows.Forms.Padding(3);
            this._tabpgSearch.Size = new System.Drawing.Size(1466, 867);
            this._tabpgSearch.TabIndex = 0;
            this._tabpgSearch.Text = "Search";
            // 
            // _btnSearchWithMyFridge
            // 
            this._btnSearchWithMyFridge.BackColor = System.Drawing.Color.Gray;
            this._btnSearchWithMyFridge.Enabled = false;
            this._btnSearchWithMyFridge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnSearchWithMyFridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearchWithMyFridge.ForeColor = System.Drawing.Color.White;
            this._btnSearchWithMyFridge.Location = new System.Drawing.Point(1090, 42);
            this._btnSearchWithMyFridge.Name = "_btnSearchWithMyFridge";
            this._btnSearchWithMyFridge.Size = new System.Drawing.Size(291, 58);
            this._btnSearchWithMyFridge.TabIndex = 12;
            this._btnSearchWithMyFridge.Text = "Search With My Fridge";
            this._btnSearchWithMyFridge.UseVisualStyleBackColor = false;
            this._btnSearchWithMyFridge.Click += new System.EventHandler(this.OnSearchWithMyFridge);
            // 
            // _tabpgFavorites
            // 
            this._tabpgFavorites.Controls.Add(this.grpboxFavRecipes);
            this._tabpgFavorites.Location = new System.Drawing.Point(4, 38);
            this._tabpgFavorites.Name = "_tabpgFavorites";
            this._tabpgFavorites.Padding = new System.Windows.Forms.Padding(3);
            this._tabpgFavorites.Size = new System.Drawing.Size(1466, 867);
            this._tabpgFavorites.TabIndex = 1;
            this._tabpgFavorites.Text = "My Favorites";
            this._tabpgFavorites.UseVisualStyleBackColor = true;
            // 
            // grpboxFavRecipes
            // 
            this.grpboxFavRecipes.Controls.Add(this._btnRemoveFromFavorites);
            this.grpboxFavRecipes.Controls.Add(this._lblFavRecipeName);
            this.grpboxFavRecipes.Controls.Add(this.lblFavDescription);
            this.grpboxFavRecipes.Controls.Add(this._btnFavMoreDetails);
            this.grpboxFavRecipes.Controls.Add(this._picboxFavRecipe);
            this.grpboxFavRecipes.Controls.Add(this._rchtxtFavDescription);
            this.grpboxFavRecipes.Controls.Add(this._lbFavRecipes);
            this.grpboxFavRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxFavRecipes.Location = new System.Drawing.Point(16, 106);
            this.grpboxFavRecipes.Name = "grpboxFavRecipes";
            this.grpboxFavRecipes.Size = new System.Drawing.Size(1430, 745);
            this.grpboxFavRecipes.TabIndex = 10;
            this.grpboxFavRecipes.TabStop = false;
            this.grpboxFavRecipes.Text = "Recipes";
            // 
            // _btnRemoveFromFavorites
            // 
            this._btnRemoveFromFavorites.Enabled = false;
            this._btnRemoveFromFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRemoveFromFavorites.Location = new System.Drawing.Point(1137, 312);
            this._btnRemoveFromFavorites.Name = "_btnRemoveFromFavorites";
            this._btnRemoveFromFavorites.Size = new System.Drawing.Size(272, 58);
            this._btnRemoveFromFavorites.TabIndex = 11;
            this._btnRemoveFromFavorites.Text = "Remove from Favorites";
            this._btnRemoveFromFavorites.UseVisualStyleBackColor = true;
            this._btnRemoveFromFavorites.Click += new System.EventHandler(this.OnRemoveFromFavorites);
            // 
            // _lblFavRecipeName
            // 
            this._lblFavRecipeName.AutoSize = true;
            this._lblFavRecipeName.Location = new System.Drawing.Point(932, 25);
            this._lblFavRecipeName.Name = "_lblFavRecipeName";
            this._lblFavRecipeName.Size = new System.Drawing.Size(0, 29);
            this._lblFavRecipeName.TabIndex = 14;
            // 
            // lblFavDescription
            // 
            this.lblFavDescription.AutoSize = true;
            this.lblFavDescription.Location = new System.Drawing.Point(932, 368);
            this.lblFavDescription.Name = "lblFavDescription";
            this.lblFavDescription.Size = new System.Drawing.Size(141, 29);
            this.lblFavDescription.TabIndex = 13;
            this.lblFavDescription.Text = "Description:";
            // 
            // _btnFavMoreDetails
            // 
            this._btnFavMoreDetails.Enabled = false;
            this._btnFavMoreDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFavMoreDetails.Location = new System.Drawing.Point(1180, 675);
            this._btnFavMoreDetails.Name = "_btnFavMoreDetails";
            this._btnFavMoreDetails.Size = new System.Drawing.Size(228, 58);
            this._btnFavMoreDetails.TabIndex = 12;
            this._btnFavMoreDetails.Text = "More Details..";
            this._btnFavMoreDetails.UseVisualStyleBackColor = true;
            this._btnFavMoreDetails.Click += new System.EventHandler(this.OnMoreFavDetails);
            // 
            // _picboxFavRecipe
            // 
            this._picboxFavRecipe.Location = new System.Drawing.Point(936, 34);
            this._picboxFavRecipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._picboxFavRecipe.Name = "_picboxFavRecipe";
            this._picboxFavRecipe.Size = new System.Drawing.Size(472, 270);
            this._picboxFavRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picboxFavRecipe.TabIndex = 15;
            this._picboxFavRecipe.TabStop = false;
            // 
            // _rchtxtFavDescription
            // 
            this._rchtxtFavDescription.Location = new System.Drawing.Point(936, 398);
            this._rchtxtFavDescription.Name = "_rchtxtFavDescription";
            this._rchtxtFavDescription.ReadOnly = true;
            this._rchtxtFavDescription.Size = new System.Drawing.Size(472, 270);
            this._rchtxtFavDescription.TabIndex = 1;
            this._rchtxtFavDescription.Text = "";
            // 
            // _lbFavRecipes
            // 
            this._lbFavRecipes.DisplayMember = "RecipeName";
            this._lbFavRecipes.FormattingEnabled = true;
            this._lbFavRecipes.ItemHeight = 29;
            this._lbFavRecipes.Location = new System.Drawing.Point(6, 34);
            this._lbFavRecipes.Name = "_lbFavRecipes";
            this._lbFavRecipes.ScrollAlwaysVisible = true;
            this._lbFavRecipes.Size = new System.Drawing.Size(914, 700);
            this._lbFavRecipes.TabIndex = 0;
            this._lbFavRecipes.SelectedIndexChanged += new System.EventHandler(this.OnFavoritesSelectedIndexChanged);
            // 
            // _tabpgCookbook
            // 
            this._tabpgCookbook.Controls.Add(this._btnCreateRecipe);
            this._tabpgCookbook.Controls.Add(this.grpboxCreatedRecipes);
            this._tabpgCookbook.Location = new System.Drawing.Point(4, 38);
            this._tabpgCookbook.Name = "_tabpgCookbook";
            this._tabpgCookbook.Padding = new System.Windows.Forms.Padding(3);
            this._tabpgCookbook.Size = new System.Drawing.Size(1466, 867);
            this._tabpgCookbook.TabIndex = 2;
            this._tabpgCookbook.Text = "My Cookbook";
            this._tabpgCookbook.UseVisualStyleBackColor = true;
            // 
            // _btnCreateRecipe
            // 
            this._btnCreateRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCreateRecipe.Location = new System.Drawing.Point(735, 42);
            this._btnCreateRecipe.Name = "_btnCreateRecipe";
            this._btnCreateRecipe.Size = new System.Drawing.Size(201, 58);
            this._btnCreateRecipe.TabIndex = 11;
            this._btnCreateRecipe.Text = "Create Recipe";
            this._btnCreateRecipe.UseVisualStyleBackColor = true;
            this._btnCreateRecipe.Click += new System.EventHandler(this.OnCreateRecipe);
            // 
            // grpboxCreatedRecipes
            // 
            this.grpboxCreatedRecipes.Controls.Add(this._btnRemoveFromCookbook);
            this.grpboxCreatedRecipes.Controls.Add(this._lblCreatedRecipeName);
            this.grpboxCreatedRecipes.Controls.Add(this.lblCreatedDescription);
            this.grpboxCreatedRecipes.Controls.Add(this._btnCreatedMoreDetails);
            this.grpboxCreatedRecipes.Controls.Add(this._picboxCreatedRecipe);
            this.grpboxCreatedRecipes.Controls.Add(this._rchtxtCreatedDescription);
            this.grpboxCreatedRecipes.Controls.Add(this._lbCookbook);
            this.grpboxCreatedRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxCreatedRecipes.Location = new System.Drawing.Point(16, 106);
            this.grpboxCreatedRecipes.Name = "grpboxCreatedRecipes";
            this.grpboxCreatedRecipes.Size = new System.Drawing.Size(1430, 745);
            this.grpboxCreatedRecipes.TabIndex = 11;
            this.grpboxCreatedRecipes.TabStop = false;
            this.grpboxCreatedRecipes.Text = "Recipes";
            // 
            // _btnRemoveFromCookbook
            // 
            this._btnRemoveFromCookbook.Enabled = false;
            this._btnRemoveFromCookbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRemoveFromCookbook.Location = new System.Drawing.Point(1090, 312);
            this._btnRemoveFromCookbook.Name = "_btnRemoveFromCookbook";
            this._btnRemoveFromCookbook.Size = new System.Drawing.Size(320, 58);
            this._btnRemoveFromCookbook.TabIndex = 15;
            this._btnRemoveFromCookbook.Text = "Remove from Cookbook";
            this._btnRemoveFromCookbook.UseVisualStyleBackColor = true;
            this._btnRemoveFromCookbook.Click += new System.EventHandler(this.OnRemoveFromCookbook);
            // 
            // _lblCreatedRecipeName
            // 
            this._lblCreatedRecipeName.AutoSize = true;
            this._lblCreatedRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCreatedRecipeName.Location = new System.Drawing.Point(932, 25);
            this._lblCreatedRecipeName.Name = "_lblCreatedRecipeName";
            this._lblCreatedRecipeName.Size = new System.Drawing.Size(0, 29);
            this._lblCreatedRecipeName.TabIndex = 14;
            // 
            // lblCreatedDescription
            // 
            this.lblCreatedDescription.AutoSize = true;
            this.lblCreatedDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDescription.Location = new System.Drawing.Point(932, 368);
            this.lblCreatedDescription.Name = "lblCreatedDescription";
            this.lblCreatedDescription.Size = new System.Drawing.Size(141, 29);
            this.lblCreatedDescription.TabIndex = 13;
            this.lblCreatedDescription.Text = "Description:";
            // 
            // _btnCreatedMoreDetails
            // 
            this._btnCreatedMoreDetails.Enabled = false;
            this._btnCreatedMoreDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCreatedMoreDetails.Location = new System.Drawing.Point(1180, 675);
            this._btnCreatedMoreDetails.Name = "_btnCreatedMoreDetails";
            this._btnCreatedMoreDetails.Size = new System.Drawing.Size(228, 58);
            this._btnCreatedMoreDetails.TabIndex = 12;
            this._btnCreatedMoreDetails.Text = "More Details..";
            this._btnCreatedMoreDetails.UseVisualStyleBackColor = true;
            this._btnCreatedMoreDetails.Click += new System.EventHandler(this.OnMoreCookbookDetails);
            // 
            // _picboxCreatedRecipe
            // 
            this._picboxCreatedRecipe.Location = new System.Drawing.Point(936, 34);
            this._picboxCreatedRecipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._picboxCreatedRecipe.Name = "_picboxCreatedRecipe";
            this._picboxCreatedRecipe.Size = new System.Drawing.Size(474, 270);
            this._picboxCreatedRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picboxCreatedRecipe.TabIndex = 16;
            this._picboxCreatedRecipe.TabStop = false;
            // 
            // _rchtxtCreatedDescription
            // 
            this._rchtxtCreatedDescription.Location = new System.Drawing.Point(936, 398);
            this._rchtxtCreatedDescription.Name = "_rchtxtCreatedDescription";
            this._rchtxtCreatedDescription.ReadOnly = true;
            this._rchtxtCreatedDescription.Size = new System.Drawing.Size(472, 270);
            this._rchtxtCreatedDescription.TabIndex = 1;
            this._rchtxtCreatedDescription.Text = "";
            // 
            // _lbCookbook
            // 
            this._lbCookbook.DisplayMember = "RecipeName";
            this._lbCookbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbCookbook.FormattingEnabled = true;
            this._lbCookbook.ItemHeight = 29;
            this._lbCookbook.Location = new System.Drawing.Point(6, 34);
            this._lbCookbook.Name = "_lbCookbook";
            this._lbCookbook.ScrollAlwaysVisible = true;
            this._lbCookbook.Size = new System.Drawing.Size(914, 700);
            this._lbCookbook.TabIndex = 0;
            this._lbCookbook.SelectedIndexChanged += new System.EventHandler(this.OnCookbookSelectedIndexChanged);
            // 
            // _btnLogin
            // 
            this._btnLogin.BackColor = System.Drawing.Color.Gray;
            this._btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLogin.ForeColor = System.Drawing.Color.White;
            this._btnLogin.Location = new System.Drawing.Point(1268, 100);
            this._btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(228, 62);
            this._btnLogin.TabIndex = 3;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = false;
            this._btnLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ScrumptiousSolution.Properties.Resources.logoinverse;
            this.pictureBox1.InitialImage = global::ScrumptiousSolution.Properties.Resources.logoinverse;
            this.pictureBox1.Location = new System.Drawing.Point(60, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AcceptButton = this._btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1524, 1119);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._tabctrlRecipes);
            this.Controls.Add(this._btnCheckFridge);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._lblLogin);
            this.Controls.Add(this._lblUserName);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximumSize = new System.Drawing.Size(1546, 1175);
            this.MinimumSize = new System.Drawing.Size(1546, 1175);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpboxSearchedRecipes.ResumeLayout(false);
            this.grpboxSearchedRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picboxRecipeImage)).EndInit();
            this._tabctrlRecipes.ResumeLayout(false);
            this._tabpgSearch.ResumeLayout(false);
            this._tabpgSearch.PerformLayout();
            this._tabpgFavorites.ResumeLayout(false);
            this.grpboxFavRecipes.ResumeLayout(false);
            this.grpboxFavRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picboxFavRecipe)).EndInit();
            this._tabpgCookbook.ResumeLayout(false);
            this.grpboxCreatedRecipes.ResumeLayout(false);
            this.grpboxCreatedRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picboxCreatedRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label _lblUserName;
        private System.Windows.Forms.Label _lblLogin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _tstrpEditDatabase;
        private System.Windows.Forms.TextBox _txtSearchbox;
        private System.Windows.Forms.Label lblSearchbyIngredient;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.Button _btnCheckFridge;
        private System.Windows.Forms.GroupBox grpboxSearchedRecipes;
        private System.Windows.Forms.ListBox _lbSearchedRecipes;
        private System.Windows.Forms.Label lblSeparateitemsbycommas;
        private System.Windows.Forms.TabControl _tabctrlRecipes;
        private System.Windows.Forms.TabPage _tabpgSearch;
        private System.Windows.Forms.TabPage _tabpgFavorites;
        private System.Windows.Forms.TabPage _tabpgCookbook;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Label lblSearchedDescription;
        private System.Windows.Forms.Button _btnSearchedMoreDetails;
        private System.Windows.Forms.PictureBox _picboxRecipeImage;
        private System.Windows.Forms.RichTextBox _rchtxtDescription;
        private System.Windows.Forms.Label _lblSearchedRecipeName;
        private System.Windows.Forms.Button _btnSearchedAddToFavorites;
        private System.Windows.Forms.GroupBox grpboxFavRecipes;
        private System.Windows.Forms.Label _lblFavRecipeName;
        private System.Windows.Forms.Label lblFavDescription;
        private System.Windows.Forms.Button _btnFavMoreDetails;
        private System.Windows.Forms.PictureBox _picboxFavRecipe;
        private System.Windows.Forms.RichTextBox _rchtxtFavDescription;
        private System.Windows.Forms.ListBox _lbFavRecipes;
        private System.Windows.Forms.Button _btnRemoveFromFavorites;
        private System.Windows.Forms.Button _btnCreateRecipe;
        private System.Windows.Forms.GroupBox grpboxCreatedRecipes;
        private System.Windows.Forms.Label _lblCreatedRecipeName;
        private System.Windows.Forms.Label lblCreatedDescription;
        private System.Windows.Forms.Button _btnCreatedMoreDetails;
        private System.Windows.Forms.PictureBox _picboxCreatedRecipe;
        private System.Windows.Forms.RichTextBox _rchtxtCreatedDescription;
        private System.Windows.Forms.ListBox _lbCookbook;
        private System.Windows.Forms.Button _btnRemoveFromCookbook;
        private System.Windows.Forms.Button _btnSearchWithMyFridge;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}