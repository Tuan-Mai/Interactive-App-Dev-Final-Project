using ScrumptiousSolution.LogicTier;
using ScrumptiousSolution.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumptiousSolution.PresentationTier
{
    /// <summary>
    /// RecipeCreation form, used for creating recipes.
    /// </summary>
    public partial class RecipeCreation : Form
    {
        User _currentUser;
        /// <summary>
        /// recipecreation form constructor; takes a user to load information from.
        /// </summary>
        /// <param name="user"></param>
        public RecipeCreation(User user)
        {
            _currentUser = user;
            InitializeComponent();
        }

        /// <summary>
        /// refreshCreateButton method, used to check when the createRecipe button can be enabled.
        /// </summary>
        private void refreshCreateButton()
        {
            if(_txtRecipeName.Text.Length>0 && _rchtxtInstructions.Text.Length>0 && _cmbMealType.SelectedIndex>=0 && _clbIngredients.SelectedItems.Count>0)
            {
                _btnCreateRecipe.Enabled=true;
            }
            else
            {
                _btnCreateRecipe.Enabled=false;
            }
        }

        /// <summary>
        /// Event, closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Create a recipe from the filled in components on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreateRecipe(object sender, EventArgs e)
        {
            //create recipe database handler
            RecipeDB temp = new RecipeDB(_currentUser);
            temp.LoadSelect();
            temp.LoadUserCookbook();

            //create parts from the components
            string fRecipeName=_txtRecipeName.Text;
            int fMealType = _cmbMealType.SelectedIndex;
            List<Ingredient> fIngredients=new List<Ingredient>();
            foreach(Ingredient checkedIng in _clbIngredients.CheckedItems)
            {
                fIngredients.Add(checkedIng);
            }
            string fRecipeInstructions = _rchtxtInstructions.Text;

            //create a recipe from the parts
            Recipe freshRecipe = new Recipe(fRecipeName, fIngredients, fMealType, fRecipeInstructions);



            //add it to cookbook and recipe database.
            temp.AddToRecipeDB(freshRecipe);
            temp.AddToCookbook(freshRecipe);
            temp.UserSaveCookbook();
            temp.DBSave();

            Image imageToUse = _picboxRecipeImage.Image;
            IResourceWriter writer = new ResourceWriter("ScrumptiousSolution.Resources");
            
            writer.AddResource(_txtRecipeName.Text,imageToUse);
            writer.Close();
            MessageBox.Show("Added '" +freshRecipe.RecipeName +"' to the recipe database!");
            Close();

        }

        /// <summary>
        /// Sets all elements on the form to blank once loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            _currentUser.Fridge.LoadSelect();
            foreach (Ingredient ingredient in _currentUser.Fridge.AllIngredients)
            {
                _clbIngredients.Items.Add(ingredient);
            }
            _clbIngredients.DisplayMember = "IngredientName";
            string[] allMealTypes=Enum.GetNames(typeof(MealType));
            
            foreach(string mealtype in allMealTypes)
            {
                _cmbMealType.Items.Add(mealtype);
            }
        }

        /// <summary>
        /// event for all components on the form. (textbox, combobox, checklist, richtextbox.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSomethingChanged(object sender, EventArgs e)
        {
            refreshCreateButton();
        }

        /// <summary>
        /// Opens an openfiledialog to select an image for the recipe. 
        /// needs to be implemented.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Open Image";
            fDialog.Filter = "Image Files (*.jpeg,*.jpg,*.png,*.gif)|*.jpeg;*.png;*.jpg;*.gif"; ;

            

                
            
        }
    }
}
