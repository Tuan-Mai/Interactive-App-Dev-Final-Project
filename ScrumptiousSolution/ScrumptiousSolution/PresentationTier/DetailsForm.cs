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

// Author: Tuan Mai

namespace ScrumptiousSolution.PresentationTier
{
    public partial class DetailsForm : Form
    {
        // Declare the field variables
        private Recipe _recipeDetails;
        public DetailsForm(Recipe recipe)
        {   // Constructor for DetailsForm
            InitializeComponent();
            _recipeDetails = recipe;
        }

        private void OnLoad(object sender, EventArgs e)
        {   // When the form loads
            // Set the Title text to "<name of recipe> - Recipe Details"
            Text = _recipeDetails.RecipeName + " - Recipe Details";

            _lblNameOfRecipe.Text = _recipeDetails.RecipeName;  // Display the name of the recipe

            String allIngs="";  
            foreach(Ingredient gotIngredient in _recipeDetails.Ingredients)
            {   // Check all the ingredients that are part of the recipe
                allIngs += gotIngredient.ServingSize + " of - " + gotIngredient.IngredientName + ", ";
            }   // Display the amount of serving and the ingredient name
            _rchtxtIngredients.Text = allIngs;      // Display onto the rich text 

            _rchtxtInstructions.Text = _recipeDetails.RecipeInstructions;   // Display the recipe instructions 

            string imageId = _recipeDetails.RecipeName;     // Get the name of recipe
            imageId = imageId.Replace(" ", "_");            // Replace any spaces with underscores
            _picboxRecipePicture.Image = Resources.ResourceManager.GetObject(imageId, Resources.Culture) as Bitmap;


        }                                                   // Replaces image with image determined by the name of recipe

        private void OnEscapeKeyDown(object sender, KeyEventArgs e)
        {   // If the user hits the Escape key on the keyboard
            if (e.KeyCode == Keys.Escape)
            {
                Close();    // Close this form
            }
        }
    }
}
