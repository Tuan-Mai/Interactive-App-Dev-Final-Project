using ScrumptiousSolution.LogicTier;
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
    /// Form for UI interaction with the users fridge
    /// </summary>
    public partial class FridgeForm : Form
    {
        private User _user;
        private List<Ingredient> _listToAdd = new List<Ingredient>();

        /// <summary>
        /// sets the _user field of the fridge. A user has a fridge, a fridge has a user. 
        /// </summary>
        /// <param name="user"></param>
        public FridgeForm(User user)
        {
            InitializeComponent();

            _user = user;
        }

        /// <summary>
        /// Method used to add ingredients selected in the checked list box to the users fridge. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onAddIngredient(object sender, EventArgs e)
        {
            //clears previous session
            _listToAdd.Clear();

            //loop through checked items
            for (int i = 0; i < _clbFridge.CheckedItems.Count; i++)
            {
                //check if item is already in the users fridge
                if (!InFridge((Ingredient)_clbFridge.CheckedItems[i]))
                {
                    //add item
                    _listToAdd.Add((Ingredient)_clbFridge.CheckedItems[i]);
                    _lbFridge.Items.Add((Ingredient)_clbFridge.CheckedItems[i]);
                    _user.Fridge.FridgeContents.Add((Ingredient)_clbFridge.CheckedItems[i]);
                }
            }
            //Save list of ingredients user wants to add to persisitng fridge
            _user.Fridge.Save(_listToAdd);

            //Repopulate form elements
            showFridgeContents();
        }

        /// <summary>
        /// Checks whether an ingredient is currently in the fridge
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        private bool InFridge(Ingredient ingredient)
        {
            //loops through each ingredient in the fridge
            foreach (Ingredient i in _user.Fridge.FridgeContents)
            {
                //if it finds the ingredient its looking for, return true, ingredient is inFridge
                if (ingredient.IngredientName == i.IngredientName)
                {
                    return true;
                }
            }

            //returns false if ingredient is not found
            return false;
        }

        /// <summary>
        /// Method used to remove ingredient selected in combo box from the users fridge. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onRemoveIngredient(object sender, EventArgs e)
        {
            //loops through all items the user would like to remove
            while (_lbFridge.CheckedItems.Count > 0)
            {
                //removes the items from the listbox and the users fridge items
                _user.Fridge.RemoveFromFridge((Ingredient)_lbFridge.CheckedItems[0]);
                _lbFridge.Items.Remove((Ingredient)_lbFridge.CheckedItems[0]);
            }
        }

        /// <summary>
        /// Closes the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClose(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Loads the full ingredient lit into the adding to fridge listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FridgeForm_Load(object sender, EventArgs e)
        {
            //error check if user is null or not
            if (_user != null)
            {
                //loads the fridge, check if user exists
                _user.Fridge.LoadSelect();
                _user.Fridge.CheckIfUserExists();
                //set display members of checked list boxes
                _clbFridge.DisplayMember = "IngredientName";
                _lbFridge.DisplayMember = "IngredientName";
                //set the fridge contents visibility to true
                showFridgeContents();
            }
        }

        /// <summary>
        /// Adds all ingredients to the checkedlistbox and listbox.
        /// </summary>
        private void showFridgeContents()
        {
            //Sorts fridge lists
            _user.Fridge.AllIngredients.Sort();
            _user.Fridge.FridgeContents.Sort();
            //clear all form elements
            _clbFridge.Items.Clear();
            _lbFridge.Items.Clear();

            //updates the users currently owned fridge contents
            foreach (Ingredient ingredient in _user.Fridge.FridgeContents)
            {
                _lbFridge.Items.Add(ingredient);
            }

            //updates the full ingredient list
            foreach (Ingredient ingredient in _user.Fridge.AllIngredients)
            {
                _clbFridge.Items.Add(ingredient);
            }
        }

    }
}
