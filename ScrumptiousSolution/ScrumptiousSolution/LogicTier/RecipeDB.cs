using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumptiousSolution.LogicTier
{
    /// <summary>
    /// Class used to create a RecipeDB object. This object is used to access the recipe database and make changes.
    /// Author: Jordan Larock
    /// </summary>
    class RecipeDB
    {
        private User _currentUser;
        public static List<Recipe> _recipeData;

        /// <summary>
        /// Constructor for RecipeDB. Creates a recipe DB for the current user. 
        /// </summary>
        /// <param name="currentUser"></param>
        public RecipeDB(User currentUser)
        {
            _currentUser = currentUser;
            _currentUser.UserCookbook = new List<Recipe>();
            _currentUser.UserFavoriteRecipes = new List<Recipe>();
            _recipeData = new List<Recipe>();
        }

        /// <summary>
        /// Property for _currentUser.UserFavoriteRecipes in RecipeDB
        /// </summary>
        public List<Recipe> UserFavRecipes
        {
            get { return _currentUser.UserFavoriteRecipes; }
            set { _currentUser.UserFavoriteRecipes = value; }
        }

        //Property for _currentUser.UserCookbook in RecipeDB
        public List<Recipe> UserCookbook
        {
            get { return _currentUser.UserCookbook; }
            set { _currentUser.UserCookbook = value; }
        }

        //Property for _recipeData in RecipeDB
        public List<Recipe> AllRecipes
        {
            get { return _recipeData; }
            set { _recipeData = value; }
        }

        /// <summary>
        /// Adds items that have been selected by the checked list box in FridgeForm to the fridge. 
        /// </summary>
        /// <param name="ingredients"></param>
        public void AddToCookbook(Recipe recipe)
        {
            _currentUser.UserCookbook.Add(recipe);
        }
        public void AddToFavRecipes(Recipe recipe)
        {
            _currentUser.UserFavoriteRecipes.Add(recipe);
        }
        public void AddToRecipeDB(Recipe recipe)
        {
            _recipeData.Add(recipe);
        }

        //Remove items from DB by called the respective remove method
        public void RemoveFromCookbook(Recipe recipe)
        {
            RemoveFromUserCookbook(recipe);
        }
        public void RemoveFromFavRecipes(Recipe recipe)
        {
            RemoveFromUserFavRecipes(recipe);
        }
        public void RemoveFromRecipeDB(Recipe recipe)
        {
            RemoveFromDB(recipe);
        }

        /// <summary>
        /// Removes a selected recipe from the main csv file. 
        /// </summary>
        /// <param name="recipe"></param>
        public void RemoveFromDB( Recipe recipe)
        {
            //Loads main csv file
            LoadSelect();

            //Removes the recipe from user favorites as wel
            _currentUser.UserFavoriteRecipes.Remove(recipe);

            //Opens streamwriter
            using (StreamWriter writer = new StreamWriter("Recipes.csv"))
            {
                //rewrites all information that the user would like to keep into the csv
                foreach (Recipe checkedRecipe in _recipeData)
                {
                    //checks if user wants to keep this recipe
                    if (!(checkedRecipe.RecipeName == recipe.RecipeName))
                    {
                        string ingNames = "#";
                        //write in ingredients
                        foreach (Ingredient checkedIngredient in checkedRecipe.Ingredients)
                        {
                            ingNames += checkedIngredient.IngredientName + "#";
                        }
                        ingNames.TrimStart('#');
                        ingNames.TrimEnd('#');

                        //saves all other data to the csv (recipes user did not choose to delete)
                        string recipeData = String.Format("{0}|{1}|{2}|{3}", checkedRecipe.RecipeName, ingNames,
                        checkedRecipe.MealType, checkedRecipe.RecipeInstructions);
                        writer.WriteLine(recipeData);
                    }
                }
            }

        }

        /// <summary>
        /// Removes a recipe from the users personal cookbook.
        /// </summary>
        /// <param name="recipe"></param>
        public void RemoveFromUserCookbook(Recipe recipe)
        {
            //Load in users personally created recipes
            LoadUserCookbook();

            //Removes the recipe chosen from the cookbook
            _currentUser.UserCookbook.Remove(recipe);

            //Rewrites all data that the user wants to keep into the users recipe file
            using (StreamWriter writer = new StreamWriter(String.Format("{0}Recipes.csv",_currentUser.UserName)))
            {
                //compares each recipe in user cookbook to the one they want to remoe
                foreach (Recipe checkedRecipe in _currentUser.UserCookbook)
                {
                    //if it is not the same recipe, rewrites the recipe into the csv file
                    if (!(checkedRecipe.RecipeName == recipe.RecipeName))
                    {
                        string ingNames="#";
                        foreach(Ingredient checkedIngredient in checkedRecipe.Ingredients )
                        {
                            //write in the ingredients required in the recipe
                             ingNames+= checkedIngredient.IngredientName+"#";
                        }
                        ingNames.TrimStart('#');
                        ingNames.TrimEnd('#');

                        //save the recipe to the csv file
                        string recipeData = String.Format("{0}|{1}|{2}|{3}", checkedRecipe.RecipeName, ingNames,
                        checkedRecipe.MealType, checkedRecipe.RecipeInstructions);
                        writer.WriteLine(recipeData);
                    }
                }
            }

        }

        /// <summary>
        /// Remove a recipe from the users favorite recipes
        /// </summary>
        /// <param name="recipe"></param>
        public void RemoveFromUserFavRecipes(Recipe recipe)
        {
            //loads the users favorite recipes
            LoadUserFavRecipes();

            //removes the recipe from the user favorite field
            _currentUser.UserFavoriteRecipes.Remove(recipe);
            
            //open streamwriter to change user favorites
            using (StreamWriter writer = new StreamWriter(String.Format("{0}FavRecipes.csv",_currentUser.UserName)))
            {
                //check each recipe in the user favorites
                foreach (Recipe checkedRecipe in _currentUser.UserFavoriteRecipes)
                {
                    //if they are not the one the user wants to remove, rewrites it into the csv file
                    if (!(checkedRecipe.RecipeName == recipe.RecipeName))
                    {
                        string ingNames = "#";
                        foreach (Ingredient checkedIngredient in checkedRecipe.Ingredients)
                        {
                            //writes in the ingredients
                            ingNames += checkedIngredient.IngredientName + "#";
                        }
                        ingNames.TrimStart('#');
                        ingNames.TrimEnd('#');

                        //rewrite data to be kept into csv file
                        string recipeData = String.Format("{0}|{1}|{2}|{3}", checkedRecipe.RecipeName, ingNames,
                        checkedRecipe.MealType, checkedRecipe.RecipeInstructions);
                        writer.WriteLine(recipeData);
                    }
                }
            }

        }

        /// <summary>
        /// Loads main database of recipes in order to be worked on. 
        /// </summary>
        public void LoadSelect()
        {
            //clear current recipe data
            _recipeData.Clear();

            string[] recipeDataParts = null;
            string[] recipeIngNameDataParts = null;

            using (StreamReader reader = new StreamReader(String.Format("Recipes.csv")))
            {
                //loop through all recipes in the main database
                while (!reader.EndOfStream)
                {
                    //split each recipe into its fields and list of ingredients
                    string recipeData = reader.ReadLine();
                    recipeDataParts = recipeData.Split('|');
                    recipeIngNameDataParts = recipeDataParts[1].Split('#');
                    List<Ingredient> recipeIngredients = new List<Ingredient>();
    
                    //loops through all ingredients in the recipe
                    foreach (string ingredientName in recipeIngNameDataParts)
                    {

                        using (StreamReader reader2 = new StreamReader("ingredients.csv"))
                        {
                            //loops through all ingredients in main csv file
                            while (!reader2.EndOfStream)
                            {
                                //reads ingredient object from csv file
                                string ingredientData = reader2.ReadLine();
                                string[] ingredientDataParts = ingredientData.Split('|');
                                string comparableName = ingredientDataParts[0];

                                //if recipe owns this ingredient, writes it
                                if (ingredientName == comparableName)
                                {
                                    Ingredient ingfromDB = new Ingredient(ingredientDataParts[0], ingredientDataParts[1],
                                    int.Parse(ingredientDataParts[2]), bool.Parse(ingredientDataParts[3]), bool.Parse(ingredientDataParts[4]));
                                    recipeIngredients.Add(ingfromDB);
                                }
                            }
                        }
                    }

                    //creates recipe according to its field and the ingredients retrieved from the ingredient database
                    Recipe cnstrdRecipe = new Recipe(recipeDataParts[0], recipeIngredients,
                            int.Parse(recipeDataParts[2]), recipeDataParts[3]);
                    _recipeData.Add(cnstrdRecipe);
                }                    
            }             
        }

        /// <summary>
        /// Check if user has been initialized before.
        /// </summary>
        public void CheckIfUserExists()
        {
            //clear previous users session
            _currentUser.UserCookbook.Clear();
            _currentUser.UserFavoriteRecipes.Clear();

            //sets users created and favorited recipes file name
            string createdRecipes = String.Format("{0}Recipes.csv", _currentUser.UserName);
            string favRecipes = String.Format("{0}FavRecipes.csv", _currentUser.UserName);

            //checks if they have a created recipes csv file
            if (File.Exists(createdRecipes))
            {
                //if they do, loads it
                LoadUserCookbook();
            }
            //otherwise, creates a new file for them and closes it
            else
            {
                var newFile =File.CreateText(createdRecipes);
                newFile.Close();
            }
            //checks if they have a favorited recipes csv file
            if (File.Exists(favRecipes))
            {
                //if they do, loads it
                LoadUserFavRecipes();
            }
                //otherwise, creates a new file for them and closes it
            else
            {
                var newFile= File.CreateText(favRecipes);
                newFile.Close();
            }
        }

        /// <summary>
        /// Loads the users created recipes into memory. 
        /// </summary>
        public void LoadUserCookbook()
        {
            //clears the previous session of recipes
            _currentUser.UserCookbook.Clear();

            //prepare stream
            List<Ingredient> recipeIngredients = new List<Ingredient>();
            string[] recipeDataParts = null;
            string[] recipeIngNameDataParts = null;
            using (StreamReader reader = new StreamReader(String.Format("{0}Recipes.csv",_currentUser.UserName)))
            {
                //loop through all recipes in the main database
                while (!reader.EndOfStream)
                {
                    //split each recipe into its fields and list of ingredients
                    string recipeData = reader.ReadLine();
                    recipeDataParts = recipeData.Split('|');
                    recipeIngNameDataParts = recipeDataParts[1].Split('#');

                    //loops through all ingredients in the recipe
                    foreach (string ingredientName in recipeIngNameDataParts)
                    {
                        using (StreamReader reader2 = new StreamReader("ingredients.csv"))
                        {
                            //loops through all ingredients in main csv file
                            while (!reader2.EndOfStream)
                            {
                                //reads ingredient object from csv file
                                string ingredientData = reader2.ReadLine();
                                string[] ingredientDataParts = ingredientData.Split('|');
                                Ingredient ingfromDB = new Ingredient(ingredientDataParts[0], ingredientDataParts[1],
                                int.Parse(ingredientDataParts[2]), bool.Parse(ingredientDataParts[3]), bool.Parse(ingredientDataParts[4]));
                                //if recipe owns this ingredient, writes it
                                if (ingredientName == ingfromDB.IngredientName)
                                {
                                    recipeIngredients.Add(ingfromDB);
                                }  
                            }
                        }
                    }

                    //creates recipe according to its field and the ingredients retrieved from the ingredient database
                    Recipe cnstrdRecipe = new Recipe(recipeDataParts[0], recipeIngredients,
                                int.Parse(recipeDataParts[2]), recipeDataParts[3]);
                    _currentUser.UserCookbook.Add(cnstrdRecipe);
                }
            }
        }

        /// <summary>
        /// Loads users favorite recipes from csv 
        /// </summary>
        public void LoadUserFavRecipes()
        {
            //clears previous userfavorites session
            _currentUser.UserFavoriteRecipes.Clear();

            //prepare stream 
            List<Ingredient> recipeIngredients = new List<Ingredient>();
            string[] recipeDataParts = null;
            string[] recipeIngNameDataParts = null;
            using (StreamReader reader = new StreamReader(String.Format("{0}FavRecipes.csv", _currentUser.UserName)))
            {
                //loop through all recipes in the main database
                while (!reader.EndOfStream)
                {
                    //split each recipe into its fields and list of ingredients
                    string recipeData = reader.ReadLine();
                    recipeDataParts = recipeData.Split('|');
                    recipeIngNameDataParts = recipeDataParts[1].Split('#');

                    //loops through all ingredients in the recipe
                    foreach (string ingredientName in recipeIngNameDataParts)
                    {
                        using (StreamReader reader2 = new StreamReader("ingredients.csv"))
                        {
                            //loops through all ingredients in main csv file
                            while (!reader2.EndOfStream)
                            {
                                //reads ingredient object from csv file
                                string ingredientData = reader2.ReadLine();
                                string[] ingredientDataParts = ingredientData.Split('|');
                                Ingredient ingfromDB = new Ingredient(ingredientDataParts[0], ingredientDataParts[1],
                                int.Parse(ingredientDataParts[2]), bool.Parse(ingredientDataParts[3]), bool.Parse(ingredientDataParts[4]));
                                //if recipe owns this ingredient, writes it
                                if (ingredientName == ingfromDB.IngredientName)
                                {
                                    recipeIngredients.Add(ingfromDB);
                                }    
                            }
                        }
                    }

                    //creates recipe according to its field and the ingredients retrieved from the ingredient database
                    Recipe cnstrdRecipe = new Recipe(recipeDataParts[0], recipeIngredients,
                                int.Parse(recipeDataParts[2]), recipeDataParts[3]);
                    _currentUser.UserFavoriteRecipes.Add(cnstrdRecipe);
                }
                

            }

            
        }

       
        /// <summary>
        /// Saves the users cookbook to csv when a change is made.
        /// </summary>
        public void UserSaveCookbook()
        {
            //prepare streamwriter
            using (StreamWriter writer = new StreamWriter(String.Format("{0}Recipes.csv", _currentUser.UserName)))
            {
                //loop through each recipe in the userscookbook
                foreach (Recipe checkedRecipe in _currentUser.UserCookbook)
                {
                        string ingNames = "#";
                        foreach (Ingredient checkedIngredient in checkedRecipe.Ingredients)
                        {
                            //write ingredients to temporary collections
                            ingNames += checkedIngredient.IngredientName + "#";
                        }
                        ingNames.TrimStart('#');
                        ingNames.TrimEnd('#');

                        //create recipe data with ingredients and its fields, and writes it into the file
                        string recipeData = String.Format("{0}|{1}|{2}|{3}", checkedRecipe.RecipeName, ingNames,
                        checkedRecipe.MealType, checkedRecipe.RecipeInstructions);
                        writer.WriteLine(recipeData);
                }
            }
        }

        /// <summary>
        /// Saves the users favorite recipes to csv when a change is made
        /// </summary>
        public void UserSaveFavRecipes()
        {
            //prepare streamwriter
            using (StreamWriter writer = new StreamWriter(String.Format("{0}FavRecipes.csv", _currentUser.UserName)))
            {
                //loops through each recipe in the users favorite list
                foreach (Recipe checkedRecipe in _currentUser.UserFavoriteRecipes)
                {
                    string ingNames = "";
                    foreach (Ingredient checkedIngredient in checkedRecipe.Ingredients)
                    {
                        //write ingredients to temporary collection
                        ingNames += checkedIngredient.IngredientName + "#";
                    }
                    ingNames.TrimEnd('#');

                    //create recipe data with the ingredients and its fields, and writes it into the file
                    string recipeData = String.Format("{0}|{1}|{2}|{3}", checkedRecipe.RecipeName, ingNames,
                    checkedRecipe.MealType, checkedRecipe.RecipeInstructions);
                    writer.WriteLine(recipeData);
                }
            }
        }

        /// <summary>
        /// Saves full database to csv when a change is made
        /// </summary>
        public void DBSave()
        {
            //prepare streamwriter
            using (StreamWriter writer = new StreamWriter("Recipes.csv"))
            {
                //loops through each recipe in the full database
                foreach (Recipe checkedRecipe in _recipeData)
                {
                    string ingNames = "#";
                    foreach (Ingredient checkedIngredient in checkedRecipe.Ingredients)
                    {
                        //write ingredients to temporary collection
                        ingNames += checkedIngredient.IngredientName + "#";
                    }
                    ingNames.TrimStart('#');
                    ingNames.TrimEnd('#');

                    //creates recipe data with the infredients and its fields, and writes it into the file
                    string recipeData = String.Format("{0}|{1}|{2}|{3}", checkedRecipe.RecipeName, ingNames,
                    checkedRecipe.MealType, checkedRecipe.RecipeInstructions);
                    writer.WriteLine(recipeData,true);

                }
            }
        }

    }
}
