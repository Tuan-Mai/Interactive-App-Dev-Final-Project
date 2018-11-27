using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumptiousSolution.LogicTier
{
    /// <summary>
    /// Enumeration used for identification of meal type. Breakfast, Lunch, Dinner, Snack, Drink
    /// Author: Neel Reddy
    /// </summary>
    public enum MealType
    {
        Breakfast = 1,
        Lunch,
        Dinner,
        Snack,
        Drink,
        Side
    }

    /// <summary>
    /// Class used to define recipe objects. Recipes contain their name, ingredients, type of meal, and instructions.
    /// Author : Neel Reddy
    /// </summary>
    public class Recipe : IComparable<Recipe>
    {
        private string _recipeName;
        private List<Ingredient> _ingredients;
        private int _mealType;
        private string _recipeInstructions;

        /// <summary>
        /// Constructor used for the creation of a Recipe object. Takes recipe name, list of ingredients, meal type, and recipe instructions.
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="ingredients"></param>
        /// <param name="mealType"></param>
        /// <param name="recipeInstructions"></param>
        public Recipe(string recipeName, List<Ingredient> ingredients, int mealType, string recipeInstructions)
        {
            _recipeName = recipeName;
            _ingredients = ingredients;
            _mealType = mealType;
            _recipeInstructions = recipeInstructions;
        }

        #region Properties
        /// <summary>
        /// Property for _recipeName of Recipe
        /// </summary>
        public string RecipeName
        {
            get { return _recipeName; }
            set { _recipeName = value; }
        }

        /// <summary>
        /// Property for _ingredients of Recipe
        /// </summary>
        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        /// <summary>
        /// Property for _mealType of Recipe
        /// </summary>
        public int MealType
        {
            get { return _mealType; }
            set { _mealType = value; }
        }

        /// <summary>
        /// Property for _recipeInstructions of Recipe
        /// </summary>
        public string RecipeInstructions
        {
            get { return _recipeInstructions; }
            set { _recipeInstructions = value; }
        }
        #endregion

        /// <summary>
        /// Property for _recipeInstructions of Recipe
        /// <param name="other"></param>
        /// </summary>
        public int CompareTo(Recipe other)
        {
            if (string.Compare(_recipeName, other._recipeName) == -1)
            {
                return -1;
            }
            else if (string.Compare(_recipeName, other._recipeName) == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
