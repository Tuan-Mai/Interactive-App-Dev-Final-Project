using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumptiousSolution.LogicTier
{
    /// <summary>
    /// Class used to define a User object. Contains user ID, password, name, favorite recipe, and email. 
    /// Author: Neel Reddy
    /// </summary>
    public class User
    {
        protected string _userPassword;
        protected string _userName;
        protected List<Recipe> _userFavoriteRecipes;
        protected List<Recipe> _userCookbook;
        protected Fridge _userFridge;

        /// <summary>
        /// Constructor used for the creation of a User object. Takes user name, and password.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        public User(string userName, string userPassword)
        {

            _userName = userName;
            _userPassword = userPassword;
            _userFridge = new Fridge(this);
        }

        #region Properties

        /// <summary>
        /// Property for _userPassword field of User
        /// </summary>
        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        /// <summary>
        /// Property for _userName field of User
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// Property of _userFavoriteRecipes of User
        /// </summary>
        public List<Recipe> UserFavoriteRecipes
        {
            get { return _userFavoriteRecipes; }
            set { _userFavoriteRecipes = value; }
        }

        /// <summary>
        /// Property of _userCreated of User
        /// </summary>
        public List<Recipe> UserCookbook
        {
            get { return _userCookbook; }
            set { _userCookbook = value; }
        }


        /// <summary>
        /// Property for _userFridge of User
        /// </summary>
        public Fridge Fridge
        {
            get { return _userFridge; }
            set { _userFridge = value; }
        }

        #endregion



    }
}
