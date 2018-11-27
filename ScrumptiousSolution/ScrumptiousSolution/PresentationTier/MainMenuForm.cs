using ScrumptiousSolution.LogicTier;
using ScrumptiousSolution.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumptiousSolution.PresentationTier
{
    /// <summary>
    /// Main form. Pretty much does everything.
    /// </summary>
    public partial class MainMenuForm : Form
    {
        private User _currentUser;
        

        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method opens a fridge form for the user to add items to their fridge.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckFridge(object sender, EventArgs e)
        {
            FridgeForm fridgeform = new FridgeForm(_currentUser);
            fridgeform.StartPosition = FormStartPosition.CenterScreen;
            fridgeform.Show();
            disablebuttons();
        }

        /// <summary>
        /// Method updates the lists on all the tab pages
        /// </summary>
        private void updateAllUserLists()
        {
            RecipeDB temp = new RecipeDB(_currentUser);
            
            _lbSearchedRecipes.Items.Clear();
            _lbCookbook.Items.Clear();
            _lbFavRecipes.Items.Clear();
            temp.LoadSelect();
            temp.LoadUserCookbook();
            temp.LoadUserFavRecipes();
            foreach (Recipe recipe in temp.AllRecipes)
            {
                _lbSearchedRecipes.Items.Add(recipe);
            }
            foreach(Recipe recipe in temp.UserFavRecipes)
            {
                _lbFavRecipes.Items.Add(recipe);
            }
            foreach(Recipe recipe in temp.UserCookbook)
            {
                _lbCookbook.Items.Add(recipe);
            }

           
        }

        /// <summary>
        /// Creates a loginform where the user can log in
        /// or create a user (which is added to the user database)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLogin(object sender, EventArgs e)
        {

            //if not logged in
            if (_currentUser==null)
            {
                //create modal loginform
                LoginForm logForm = new LoginForm();
                logForm.StartPosition = FormStartPosition.CenterScreen;
                var loginInfo = logForm.ShowDialog();

                //once logged in, make user-specific features enabled, and make _currentUser the one logged in.
                if (loginInfo == DialogResult.OK)
                {
                   
                    _btnLogin.Text = "Logout";
                    _currentUser = logForm._currentUser;
                    _lblUserName.Text = _currentUser.UserName;

                    updateAllUserLists();
                    _tabpgFavorites.Enabled = true;
                    _tabpgCookbook.Enabled = true;
                    _btnCheckFridge.Enabled = true;
                    _btnSearchWithMyFridge.Enabled = true;
                } 
            }
            
            //if logged in, start logging out
            else 
            {
                //make user-specific features disabled, and make _currentUser null.
                MessageBox.Show("Logged out successfully.", "Logged out");
                
                _btnLogin.Text = "Login";
                _lblUserName.Text = "Guest";
                _tabpgFavorites.Enabled = false;
                _tabpgCookbook.Enabled = false;
                _btnCheckFridge.Enabled = false;
                disablebuttons();
                //clear all the listboxes except the database list
                _lbSearchedRecipes.Items.Clear();
                _lbFavRecipes.Items.Clear();
                _lbCookbook.Items.Clear();
                User guestUser = new User("Guest", "");
                RecipeDB tempList = new RecipeDB(guestUser);
                tempList.LoadSelect();
                foreach (Recipe recipe in tempList.AllRecipes)
                {
                    _lbSearchedRecipes.Items.Add(recipe.RecipeName);
                }

                _currentUser = null;

            }

            disablebuttons();
        }

        /// <summary>
        /// Method opens a recipecreation modal window.
        /// From here the user creates a Recipe which is added to the recipe database
        /// and their cookbook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreateRecipe(object sender, EventArgs e)
        {
            disablebuttons();
            RecipeCreation nRecForm = new RecipeCreation(_currentUser);
            nRecForm.StartPosition = FormStartPosition.CenterScreen;
            nRecForm.ShowDialog();
            updateAllUserLists();
        }

        /// <summary>
        /// Method checks for user permissions
        /// to open a modal databaseupdate form.
        /// 
        /// from here, the user can remove/add ingredients from the ingredients database,
        /// or remove recipes from the recipes database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditIngredientsDatabase(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                //if user is admin
                if (_currentUser.GetType() == typeof(Admin))
                {
                    //open modal form
                    DatabaseUpdate ingredientEditor = new DatabaseUpdate(_currentUser);
                    ingredientEditor.ShowDialog();
                    disablebuttons();
                }
                else if (_currentUser.UserName == "Admin" && _currentUser.UserPassword == "Admin")
                {
                    DatabaseUpdate ingredientEditor = new DatabaseUpdate(_currentUser);
                    ingredientEditor.ShowDialog();
                    disablebuttons();
                }
                //if not admin
                else
                {   //do nothing
                    MessageBox.Show("You don't have administrator rights to do that.");
                    disablebuttons();
                }
            }
            else
            {
                MessageBox.Show("You don't have administrator rights to do that.");
                disablebuttons();
            }

        }

        /// <summary>
        /// Event handles the searching features.
        /// This searching is restricted to the Recipe database.
        /// 
        /// Only recipes that have exactly all the ingredients inputted will be shown.
        /// (ex: ingredients beef,lettuce will not show a recipe that only uses beef)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSearch(object sender, EventArgs e)
        {
            _lbSearchedRecipes.Items.Clear();
            
            //if no one is logged in, use temporary account so they can still search.
            if(_currentUser==null)
            {
                User tempUser = new User("Guest", "");
                _currentUser=tempUser;
            }

            
            RecipeDB temp = new RecipeDB(_currentUser);
            temp.LoadSelect();
            //load database of recipes
            List<Recipe> existingRecipes = temp.AllRecipes; 
            
            //if search is pressed on a blank textbox, simply show the database.
            if(_txtSearchbox.Text=="")
            {
                foreach (Recipe exRecipe in existingRecipes)
                {
                    _lbSearchedRecipes.Items.Add(exRecipe);
                }
                disablebuttons();
            }
            //if there's something in the textbox...
            else
	        {

                //turn the comma-separated text in the textbox into a list of strings that are capitalized.
                string unspaced= _txtSearchbox.Text.Replace(" ",string.Empty);
                string[] unCpdSearchedIng = unspaced.Split(',');
                List<string> searchedIng = new List<string>();
                foreach (string unknownCpd in unCpdSearchedIng)
                {
                    string uncpdString = unknownCpd.ToLower();
                    uncpdString=uncpdString.First().ToString().ToUpper() + uncpdString.Substring(1);
                    searchedIng.Add(uncpdString);
                }

                //for each existing recipe
                foreach (Recipe exRecipe  in existingRecipes)
                {
                    int matchesFound = 0;
                    //for each ingredient word wanted to be searched
                    foreach(string sIngredient in searchedIng)
                    {
                        List<Ingredient>exRecipeIngs= exRecipe.Ingredients;
                    
                        //for each ingredient that actually exists
                        foreach (Ingredient existingIng in exRecipeIngs)
                        {
                            //if the word in the textbox and the name of the recipe match
                            if(sIngredient==existingIng.IngredientName && !(_lbSearchedRecipes.Items.Contains(exRecipe)))
                            {
                            //make a match
                                matchesFound++;
                            }
                            //if the recipe has all the ingredients given
                            if (matchesFound == searchedIng.Count && sIngredient == existingIng.IngredientName && !(_lbSearchedRecipes.Items.Contains(exRecipe)))
                            {
                                //show it in the recipe list
                                _lbSearchedRecipes.Items.Add(exRecipe);
                            }
                        }
                    }
                }
            }
            disablebuttons();
            if (_currentUser.UserName == "Guest")
            {
                _currentUser = null;
            }
        }

        /// <summary>
        /// This event handles the searching algorithms for searching by the ingredients in the user's fridge.
        /// 
        /// This will show recipes that can be made using the ingredients in your fridge.
        /// (ex: ingredients beef,lettuce WILL show recipes that can be made with only lettuce.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSearchWithMyFridge(object sender, EventArgs e)
        {
            //load ingredients from database 
            //and load user's fridge ingredients
            _lbSearchedRecipes.Items.Clear();
            RecipeDB temp = new RecipeDB(_currentUser);
            _currentUser.Fridge.LoadUserFridge();
            temp.LoadSelect();
            List<Recipe> existingRecipes = temp.AllRecipes; 

           //make a list of ingredient names from the fridge
            List<string> searchedIng=new List<string>(); 
           foreach(Ingredient fIngredient in _currentUser.Fridge.FridgeContents)
           {
               searchedIng.Add(fIngredient.IngredientName);
           }

            //for each existing recipe
            foreach (Recipe exRecipe in existingRecipes)
            {
                //for each ingredient name from the fridge
                foreach (string sIngredient in searchedIng)
                {
                    //make a list of ingredients from the existing recipes
                    List<Ingredient> exRecipeIngs = exRecipe.Ingredients;

                    //foreach existing ingredient
                    foreach (Ingredient existingIng in exRecipeIngs)
                    {
                        //if the ingredient name from the fridge matches an actual ingredient name
                        //and if the recipe list onscreen has that recipe
                        if (sIngredient == existingIng.IngredientName && !(_lbSearchedRecipes.Items.Contains(exRecipe)))
                        {
                            //show it on the listbox
                            _lbSearchedRecipes.Items.Add(exRecipe);
                        }
                    }
                }
            }
            disablebuttons();
        }

        /// <summary>
        /// Method takes a recipe and checks if it's in the user's favorites list
        /// </summary>
        /// <param name="recipe">recipe to check</param>
        /// <returns></returns>
        private bool InFavorites(Recipe recipe)
        {
            bool isAFavorite = false;
            RecipeDB temp = new RecipeDB(_currentUser);
            temp.LoadUserFavRecipes();

            //for each recipe the user has
            foreach (Recipe recipeUserHas in temp.UserFavRecipes)
            {
                //if the recipe we're checking's name matches a recipe in the user's favorites
                if (recipe.RecipeName == recipeUserHas.RecipeName)
                {
                    //is a favorite
                    isAFavorite = true;
                }
            }
            return isAFavorite;
        }

        /// <summary>
        /// Method handles adding recipes selected in the listbox to the user's favorites list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddToFavorites(object sender, EventArgs e)
        {
            //load recipes from the recipe database
            RecipeDB temp = new RecipeDB(_currentUser);
            temp.LoadSelect();
            
                //check if recipe is already in user's favorites
                if (!InFavorites((Recipe)_lbSearchedRecipes.SelectedItem))
                {

                    //add item to favorites
                    Recipe recipeToAdd = (Recipe)_lbSearchedRecipes.SelectedItem;
                    temp.AddToFavRecipes(recipeToAdd);
                    MessageBox.Show("Added '"+recipeToAdd.RecipeName+"' to favorites.");
                    temp.UserSaveFavRecipes();
                    
                }
                //otherwise, don't add.
                else
                {
                    MessageBox.Show("You already have this in your favorites.");
                }
                disablebuttons();
            //Repopulate form elements
                updateAllUserLists();
        }

        /// <summary>
        /// Event creates a more details page about the selected recipe that's
        /// in the listbox when the more details button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMoreDetails(object sender, EventArgs e)
        {
            DetailsForm moreDetails = new DetailsForm((Recipe)_lbSearchedRecipes.SelectedItem);
            moreDetails.StartPosition = FormStartPosition.CenterScreen;
            moreDetails.Show();
            disablebuttons();
        }
        private void OnMoreFavDetails(object sender, EventArgs e)
        {
            DetailsForm moreDetails = new DetailsForm((Recipe)_lbFavRecipes.SelectedItem);
            moreDetails.StartPosition = FormStartPosition.CenterScreen;
            moreDetails.Show();
            disablebuttons();
        }
        private void OnMoreCookbookDetails(object sender, EventArgs e)
        {
            DetailsForm moreDetails = new DetailsForm((Recipe)_lbCookbook.SelectedItem);
            moreDetails.StartPosition = FormStartPosition.CenterScreen;
            moreDetails.Show();
            disablebuttons();
        }

        /// <summary>
        /// Event to handle removing the selected recipe in the listbox
        /// from the user's favorite recipe csv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRemoveFromFavorites(object sender, EventArgs e)
        {
            //load user's favorites
            Recipe recipeToRemove = (Recipe)_lbFavRecipes.SelectedItem;
            RecipeDB temp = new RecipeDB(_currentUser);
            temp.LoadUserFavRecipes();
            
            //remove recipe from the user's favorites
            temp.RemoveFromFavRecipes(recipeToRemove);
            MessageBox.Show("Removed '" + recipeToRemove.RecipeName + "' from favorites.");
            //Repopulate form elements
            updateAllUserLists();
            disablebuttons();

        }

        /// <summary>
        /// Event to handle removing the selected recipe in the listbox
        /// from the user's cookbook csv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRemoveFromCookbook(object sender, EventArgs e)
        {
            //load user's cookbook
            Recipe recipeToRemove = (Recipe)_lbCookbook.SelectedItem;
            RecipeDB temp = new RecipeDB(_currentUser);

            temp.LoadUserCookbook();

            //remove recipe from the user's cookbook
            temp.RemoveFromDB(recipeToRemove);
            temp.RemoveFromCookbook(recipeToRemove);
            MessageBox.Show("Removed '" + recipeToRemove.RecipeName + "' from favorites.");
            //Repopulate form elements
            updateAllUserLists();
            disablebuttons();
        }

        /// <summary>
        /// When the main form is closed, exit the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// When the main form (application) first loads,
        /// this method sets everything up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            //set up buttons/labels for a guest user type layout
            _tabpgFavorites.Enabled=false;
            _tabpgCookbook.Enabled=false;
            disablebuttons();
            _lbSearchedRecipes.Items.Clear();
            User guestUser = new User("Guest","");
            RecipeDB tempList = new RecipeDB(guestUser);
            tempList.LoadSelect();

            //show recipe database in the main listbox
            foreach (Recipe recipe in tempList.AllRecipes)
            {
                _lbSearchedRecipes.Items.Add(recipe);
            }
        }

        /// <summary>
        /// Event handles changing the search listbox' selected 
        /// recipe's details in the form components on the right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSearchSelectedIndexChanged(object sender, EventArgs e)
        {
            //if someone is logged in, they can add the selected recipe to favorites
            if(_currentUser!=null)
            {
                _btnSearchedAddToFavorites.Enabled = _lbSearchedRecipes.SelectedIndex >=0 ;
            }
            if (_lbSearchedRecipes.SelectedIndex>=0)
            {
                //show description,name,and image of the selected recipe.
                Recipe selRecipe = (Recipe)_lbSearchedRecipes.SelectedItem;
                _rchtxtDescription.Text = selRecipe.RecipeInstructions;
                _lblSearchedRecipeName.Text = selRecipe.RecipeName;
                string imageId = ((Recipe)_lbSearchedRecipes.SelectedItem).RecipeName;
                imageId = imageId.Replace(" ", "_");
                _picboxRecipeImage.Image = Resources.ResourceManager.GetObject(imageId, Resources.Culture) as Bitmap;
                //allow user to view more details of the recipe

                _btnSearchedMoreDetails.Enabled = true; 
            }
        }

        /// <summary>
        /// Event handles changing the user's favorites listbox' selected 
        /// recipe's details in the form components on the right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFavoritesSelectedIndexChanged(object sender, EventArgs e)
        {
            //if someone is logged in, they can remove the selected recipe from favorites
            if (_currentUser != null)
            {
                _btnRemoveFromFavorites.Enabled = _lbFavRecipes.SelectedIndex >= 0;
            }
            if (_lbFavRecipes.SelectedIndex>=0)
            {
                //show description,name,and image of the selected recipe.
                Recipe selRecipe = (Recipe)_lbFavRecipes.SelectedItem;
                _rchtxtFavDescription.Text = selRecipe.RecipeInstructions;
                _lblFavRecipeName.Text = selRecipe.RecipeName;
                string imageId = ((Recipe)_lbFavRecipes.SelectedItem).RecipeName;
                imageId = imageId.Replace(" ", "_");
                _picboxFavRecipe.Image = Resources.ResourceManager.GetObject(imageId, Resources.Culture) as Bitmap;
                //allow user to view more details of the recipe
                _btnFavMoreDetails.Enabled = true; 
            }
        }

        /// <summary>
        /// Event handles changing the user's cookbook listbox' selected 
        /// recipe's details in the form components on the right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCookbookSelectedIndexChanged(object sender, EventArgs e)
        {
            //if someone is logged in, they can remove the selected recipe from favorites
            if (_currentUser != null)
            {
                _btnRemoveFromCookbook.Enabled = _lbCookbook.SelectedIndex >= 0;
            }

            if (_lbCookbook.SelectedIndex>=0)
            {
                //show description,name,and image of the selected recipe.
                Recipe selRecipe = (Recipe)_lbCookbook.SelectedItem;
                _rchtxtCreatedDescription.Text = selRecipe.RecipeInstructions;
                _lblSearchedRecipeName.Text = selRecipe.RecipeName;
                string imageId = ((Recipe)_lbCookbook.SelectedItem).RecipeName;
                imageId = imageId.Replace(" ", "_");
                _picboxCreatedRecipe.Image = Resources.ResourceManager.GetObject(imageId, Resources.Culture) as Bitmap;
                //allow user to view more details of the recipe
                _btnCreatedMoreDetails.Enabled = true; 
            }

        }

        
        private void disablebuttons()
        {
            _btnSearchedMoreDetails.Enabled = false;
            _btnFavMoreDetails.Enabled=false;
            _btnCreatedMoreDetails.Enabled = false;
            _btnSearchedAddToFavorites.Enabled = false;
            _btnRemoveFromCookbook.Enabled = false;
            _btnRemoveFromFavorites.Enabled = false;
            
        }
    }
}
