using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumptiousSolution.LogicTier
{
    /// <summary>
    /// Class used to define an Ingredient object. Made up of the ingredient's name, the serving size, and the calorie amount per serving. 
    /// Author: Neel Reddy
    /// </summary>
    public class Ingredient : IComparable<Ingredient>
    {

        private string _ingredientName;
        private string _servingSize;
        private int _caloriesPerServing;
        private bool _isVegetarian;
        private bool _isGlutenFree;


        /// <summary>
        /// Constructor used to define an Ingredient object. Takes the ingredients name, serving size, and calories per seving.  
        /// </summary>
        /// <param name="ingredientName"></param>
        /// <param name="servingSize"></param>
        /// <param name="caloriesPerServing"></param>
        public Ingredient(string ingredientName, string servingSize, int caloriesPerServing, bool isVegetarian, bool isGlutenFree)
        {
            _ingredientName = ingredientName;
            _servingSize = servingSize;
            _caloriesPerServing = caloriesPerServing;
            _isVegetarian = isVegetarian;
            _isGlutenFree = isGlutenFree;
        }

        #region Properties
        /// <summary>
        /// Property for _ingredientName field of Ingredient.
        /// </summary>
        public string IngredientName{
            get { return _ingredientName; }
            set { _ingredientName = value; }
        }

        /// <summary>
        /// Property for _servingSize field of Ingredient.
        /// </summary>
        public string ServingSize{
            get { return _servingSize; }
            set { _servingSize = value; }
        }

        /// <summary>
        /// Property for _caloriesPerServing field of Ingredient.
        /// </summary>
        public int CaloriesPerSeving{
            get { return _caloriesPerServing; }
            set { _caloriesPerServing = value; }
        }

        /// <summary>
        /// Property for _isVegetarian field of Ingredient. 
        /// </summary>
        public bool IsVegetarian
        {
            get { return _isVegetarian; }
        }

        /// <summary>
        /// Property for _isGlutenFree field of Ingredient. 
        /// </summary>
        public bool IsGlutenFree
        {
            get { return _isGlutenFree; }
        }
        #endregion

        /// <summary>
        /// CompareTo method for sorting ingredients alphabetically
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Ingredient other)
        {
            if (string.Compare(_ingredientName, other._ingredientName) == -1)
            {
                return -1;
            }
            else if (string.Compare(_ingredientName, other._ingredientName) == 1)
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
