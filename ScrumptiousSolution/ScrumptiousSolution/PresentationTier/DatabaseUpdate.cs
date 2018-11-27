using ScrumptiousSolution.LogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumptiousSolution.PresentationTier
{
    public partial class DatabaseUpdate : Form
    {
        
        User _currentUser;

        public DatabaseUpdate(User currentUser)
        {   // Constructor for DatabaseUpdate
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void onAddIngredient(object sender, EventArgs e)
        {   // Method to add ingredients
            bool alreadyExists = false;

            using (StreamReader reader = new StreamReader("ingredients.csv"))
            {   // Open "ingredients.csv" to read
                while (!reader.EndOfStream)
                {   // while the file has not ended yet,
                    string ingredientData = reader.ReadLine();
                    string[] ingredientDataParts = ingredientData.Split('|');

                    if (_txtIngredientName.Text == ingredientDataParts[0])
                    {   // If the ingredient name is already in the csv file
                        alreadyExists = true;
                    }   // alreadyExists invoked
                }
            }

            if (!alreadyExists)
            {   // If it does not alreadyExist
                using (StreamWriter writer = new StreamWriter(("ingredients.csv"), true))
                {   // Open "ingredients.csv" to write to
                    string ingredientToAdd = String.Format("{0}|{1}|{2}|{3}|{4}", _txtIngredientName.Text, _txtServingSize.Text,
                        int.Parse(_txtCalories.Text), (bool)_ckbtnVegetarian.Checked, (bool)_ckbtnGlutenFree.Checked);
                    writer.WriteLine(ingredientToAdd);  // Write the ingredient name, serving size, calories, if vegetarian, if gluten free
                }
                _lblAddResponse.Text = "Succesfully added.";
                _lblAddResponse.Visible = true;     // Show user that it has been added
                changeShownList();
            }
            else
            {   // If it alreadyExists, tell user
                _lblAddResponse.Text = "Ingredient already exists.";
                _lblAddResponse.Visible = true;
            }
        }

        private void CheckAddEnable(object sender, EventArgs e)
        {   // If all textboxes contain value
            if (_txtIngredientName.TextLength > 0 &&
                _txtServingSize.TextLength > 0 &&
                _txtCalories.TextLength > 0)
            {   // Enable the add button
                _btnAddIngredient.Enabled = true;
            }
            else
            {   // Else do not
                _btnAddIngredient.Enabled = false;
            }
        }

        private void DisableOtherCheck(object sender, EventArgs e)
        {   // Method to disallow the other checkbox to be checked at the same time
            if ((sender as CheckBox).Name == _ckbtnIngredient.Name && (sender as CheckBox).Checked)
            {
                _ckbtnRecipe.Checked = false;
            }
            else if ((sender as CheckBox).Name == _ckbtnRecipe.Name && (sender as CheckBox).Checked)
            {
                _ckbtnIngredient.Checked = false;
            }
            changeShownList();
        }

        private void DatabaseUpdate_Load(object sender, EventArgs e)
        {   // When loading, show the changes on the list
            changeShownList();
        }

        private void changeShownList()
        {
            //clear listbox
            _lbItems.Items.Clear();

            //check if ingredient is clicked
            if (_ckbtnIngredient.Checked)
            {
                List<Ingredient> tempList = new List<Ingredient>();

                saveCurrentIngredientList(ref tempList);

                tempList.Sort();

                foreach (Ingredient ingredient in tempList)
                {   // Checks each ingredient in the List
                    _lbItems.Items.Add(ingredient);
                }
            }
            //recipe is clicked
            else
            {
                List<Recipe> tempListRecipes = new List<Recipe>();

                saveCurrentRecipeList(ref tempListRecipes);

                tempListRecipes.Sort();

                foreach (Recipe recipe in tempListRecipes)
                {   // Check each recipe in the List
                    _lbItems.Items.Add(recipe);
                }
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {   // If user clicks Cancel button
            Close();    // Close the form
        }

        private void onRemoveItem(object sender, EventArgs e)
        {
            //Check whether an item is an ingredient
            if (_ckbtnIngredient.Checked)
            {
                //save selected item as an ingredient
                Ingredient ingredientToBeRemoved = (Ingredient)_lbItems.SelectedItem;

                //create list to save current ingredients
                List<Ingredient> tempList = new List<Ingredient>();
                saveCurrentIngredientList(ref tempList);

                //Open streamreader
                using (StreamWriter writer = new StreamWriter("ingredients.csv"))
                {
                    //loops through each ingredient in ingredient list
                    foreach (Ingredient ingredient in tempList)
                    {
                        //rewrite ingredient into csv if it is not the one the user wants to remove
                        if (!(ingredient.IngredientName == ingredientToBeRemoved.IngredientName))
                        {
                            string ingredientData = String.Format("{0}|{1}|{2}|{3}|{4}", ingredient.IngredientName, ingredient.ServingSize,
                            ingredient.CaloriesPerSeving, ingredient.IsVegetarian, ingredient.IsGlutenFree);
                            writer.WriteLine(ingredientData, true);
                        }
                        //item was removed, inform user
                        else
                        {
                            _lblRemoveResponse.Text = "Item removed.";
                            _lblRemoveResponse.Visible = true;
                        }
                    }
                }
            }
            else
            {
                Recipe recipeToBeRemoved = (Recipe)_lbItems.SelectedItem;

                //create list to save current ingredients
                List<Recipe> tempListRecipes = new List<Recipe>();
                saveCurrentRecipeList(ref tempListRecipes);

                RecipeDB recDB = new RecipeDB(_currentUser);
                recDB.LoadSelect();
                recDB.RemoveFromDB(recipeToBeRemoved);

            }
            //update data on listbox
            changeShownList();
        }

        private void saveCurrentIngredientList(ref List<Ingredient> tempList)
        {
            //load the ingredients to the remove listbox
            tempList.Clear();

            using (StreamReader reader = new StreamReader("ingredients.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string ingredientData = reader.ReadLine();
                    string[] ingredientDataParts = ingredientData.Split('|');
                    //create Ingredient Object
                    Ingredient ingredient = new Ingredient(ingredientDataParts[0], ingredientDataParts[1],
                        int.Parse(ingredientDataParts[2]), bool.Parse(ingredientDataParts[3]), bool.Parse(ingredientDataParts[4]));

                    tempList.Add(ingredient);
                    _lbItems.DisplayMember = "IngredientName";
                }
            }
        }

        private void saveCurrentRecipeList(ref List<Recipe> tempList)
        {   // Save the current recipe list
            RecipeDB recDB = new RecipeDB(_currentUser);
            // Pass current user to RecipeDB
            recDB.LoadSelect();
            tempList = recDB.AllRecipes;
            _lbItems.DisplayMember = "RecipeName";  // Display the RecipeName
        }

        private void _lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_lbItems.SelectedItem==null)
            {
                _btnRemoveIngredients.Enabled = false;

            }
        }
    }
}
