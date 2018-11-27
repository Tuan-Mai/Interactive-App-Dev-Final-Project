using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumptiousSolution.LogicTier
{
    /// <summary>
    /// Class used to create a Fridge object. This is used to symbolize a users refrigerator and its contents. 
    /// Author: Neel Reddy
    /// </summary>
    public class Fridge 
    {
        private User _user;
        private List<Ingredient> _fridgeContents;
        private List<Ingredient> _allIngredients;

        /// <summary>
        /// Constructor used for creation of a fridge class. Keeps track of a users fridge. 
        /// </summary>
        /// <param name="user"></param>
        public Fridge(User user)
        {
            _user = user;
            _allIngredients = new List<Ingredient>();
            _fridgeContents = new List<Ingredient>();
        }

        /// <summary>
        /// Property for _ingredients in Fridge
        /// </summary>
        public List<Ingredient> FridgeContents
        {
            get { return _fridgeContents; }
            set { _fridgeContents = value; }
        }

        /// <summary>
        /// Property for _allIngredients in Fridge
        /// </summary>
        public List<Ingredient> AllIngredients
        {
            get { return _allIngredients; }
            set { _allIngredients = value; }
        }

        /// <summary>
        /// Adds items that have been selected by the checked list box in FridgeForm to the fridge. 
        /// </summary>
        /// <param name="ingredients"></param>
        public void AddToFridge(Ingredient ingredient){
            _fridgeContents.Add(ingredient);
        }

        /// <summary>
        /// Removes a selected ingredient from the _fridgeContents
        /// </summary>
        /// <param name="ingredientToBeRemoved"></param>
        public void RemoveFromFridge(Ingredient ingredientToBeRemoved)
        {
            //Remove ingredient from _fridgeContents
            _fridgeContents.Remove(ingredientToBeRemoved);

            //Open Streamwrite
            using (StreamWriter writer = new StreamWriter(String.Format("{0}Fridge.csv", _user.UserName)))
            {
                //loop through all ingredients in _fridgeContents persistence file, and rewrite all information the user
                //does not want to rewrite
                foreach (Ingredient checkedIngredient in _fridgeContents)
                {
                    //Check if user wants to remove this item
                    if (!(checkedIngredient.IngredientName == ingredientToBeRemoved.IngredientName))
                    {
                        //if user wanted to keep this ingredient, rewrites it into the csv file
                        string ingredientData = String.Format("{0}|{1}|{2}|{3}|{4}", checkedIngredient.IngredientName, checkedIngredient.ServingSize,
                        checkedIngredient.CaloriesPerSeving, checkedIngredient.IsVegetarian, checkedIngredient.IsGlutenFree);
                        writer.WriteLine(ingredientData, true);
                    }
                }
            }


        }

        /// <summary>
        /// Loads full ingredient list, and sets it to the _ingredientNotInFridge list
        /// </summary>
        public void LoadSelect()
        {
            //load the ingredients to the select from fridge
            _allIngredients.Clear();

            using (StreamReader reader = new StreamReader("ingredients.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string ingredientData = reader.ReadLine();
                    string[] ingredientDataParts = ingredientData.Split('|');
                    //create Ingredient Object
                    Ingredient ingredient = new Ingredient(ingredientDataParts[0], ingredientDataParts[1],
                        int.Parse(ingredientDataParts[2]), bool.Parse(ingredientDataParts[3]), bool.Parse(ingredientDataParts[4]));

                    //add each ingredient to the _allIngredients  field
                    _allIngredients.Add(ingredient);
                }
            }
        }

        /// <summary>
        /// Loads the users fridge, and sets it to the _ingredients list.
        /// </summary>
        public void CheckIfUserExists()
        {
            //load the ingredients to the users fridge
            _fridgeContents.Clear();

            //set users fridge file location
            string fridgeLocation = String.Format("{0}Fridge.csv", _user.UserName);
            
            //check whether the user has previously created a fridge, and loads it if so
            if (File.Exists(fridgeLocation))
            {
                LoadUserFridge();
            }
            //otherwise, creates a new fridge for the user and closes the file
            else {
                var myFile = File.CreateText(fridgeLocation);
                myFile.Close();
            }
        }

        /// <summary>
        /// Method used to load information from csv into _fridgeContents field
        /// </summary>
        public void LoadUserFridge()
        {
            //Opens file
            using (StreamReader reader = new StreamReader(String.Format("{0}Fridge.csv", _user.UserName)))
            {
                //loop through all contents
                while (!reader.EndOfStream)
                {
                    string fridgeData = reader.ReadLine();
                    string[] fridgeDataParts = fridgeData.Split('|');
                    //create Ingredient Object
                    Ingredient ingredient = new Ingredient(fridgeDataParts[0], fridgeDataParts[1],
                        int.Parse(fridgeDataParts[2]), bool.Parse(fridgeDataParts[3]), bool.Parse(fridgeDataParts[4]));

                    //add each ingredient to the _fridgeContents field
                    _fridgeContents.Add(ingredient);
                }
            }
        }

        /// <summary>
        /// Saves newly added ingredients into the users fridge. 
        /// </summary>
        /// <param name="ingredient"></param>
        public void Save(List<Ingredient> ingredients)
        {
            //Opens streamwriter object
            using (StreamWriter writer = new StreamWriter((String.Format("{0}Fridge.csv", _user.UserName)), true))
            {
                //loops through all ingredients the user would like to keep
                foreach (Ingredient ingredient in ingredients)
                {
                    //writes each of the ingredients into the csv file for the user
                    string ingredientData = String.Format("{0}|{1}|{2}|{3}|{4}", ingredient.IngredientName, ingredient.ServingSize,
                    ingredient.CaloriesPerSeving, ingredient.IsVegetarian, ingredient.IsGlutenFree);
                    writer.WriteLine(ingredientData, true);
                }
            }
        }

    }
}
