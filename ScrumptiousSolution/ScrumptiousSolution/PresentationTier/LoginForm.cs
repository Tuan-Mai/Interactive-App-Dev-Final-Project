using ScrumptiousSolution.LogicTier;
using ScrumptiousSolution.PresentationTier;
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

// Author: Tuan Mai

namespace ScrumptiousSolution
{
    public partial class LoginForm : Form
    {
        // Declare the field variables
        public List<User> _userAccounts;
        public User _currentUser;

        public LoginForm()
        {   // Constructor for LoginForm
            InitializeComponent();
            _userAccounts = new List<User>();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            _txtAccountPassword.Enabled = false;    // Disable the AccountPassword textbox if no username
            _btnAccountLogin.Enabled = false;       // Disable the AccountLogin button if not all fields are filled out
        }

        private void OnUsernameChanged(object sender, EventArgs e)
        {   // Check to see the length of the username is greater than 0
            _txtAccountPassword.Enabled = (_txtAccountUsername.Text.Length > 0);
        }   // Enable the password textbox if so

        private void OnPasswordChanged(object sender, EventArgs e)
        {   // Check to see the length of the password is greater than 0
            _txtAccountPassword.PasswordChar = '*';     // Sets all text in AccountPassword box to '*'
            _btnAccountLogin.Enabled = (_txtAccountPassword.Text.Length > 0);
        }   // Enable the Account Login button

        private void OnCreateAccount(object sender, EventArgs e)
        {   // If the user clicks the Create Account button
            AccountCreationForm createAccount = new AccountCreationForm();
            createAccount.StartPosition = FormStartPosition.CenterScreen;
            createAccount.ShowDialog();     // Open the AccountCreationForm in a modal window
        }

        public void AddToUsers(User user)
        {   // Add the user object into the list
            _userAccounts.Add(user);
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();    // If the user clicks cancel, close this form
        }

        private void OnLogin(object sender, EventArgs e)
        {   // When the user clicks Login
            using (StreamReader readUsers = new StreamReader("Users.csv"))
            {   // Open the "Users.csv" to read
                while (!readUsers.EndOfStream)
                {   // While the file is not at the end
                    string userData = readUsers.ReadLine();
                    string[] userDataParts = userData.Split('~');   // Use seperator '~'

                    if (_txtAccountUsername.Text == userDataParts[0])
                    {   // If the text in _txtAccountUsername is equal to any of the username elements in Users.csv
                        if (_txtAccountPassword.Text == userDataParts[1])
                        {   // If the password matches the password associated with the username
                            _currentUser = new User(userDataParts[0], userDataParts[1]);
                            OnVerifiedCredentials(_currentUser);        // Pass the current user to OnVerifiedCredentials
                            DialogResult = DialogResult.OK;
                            Close();
                            break;
                        }
                    }

                    else
                    {
                        _currentUser = null;            // Set current user to null for form handling
                    }
                }

                if (_currentUser == null)
                {   // If the user is null, reset all the login fields
                    ResetLoginFields();
                }
            }
        }

        private void ResetLoginFields()
        {   // Method to reset all the login fields
            _txtAccountUsername.Text = "";      // Clear username textbox  
            _txtAccountPassword.Text = "";      // Clear Password textbox
            _btnAccountLogin.Enabled = false;   // Disable the Login button
            MessageBox.Show("Incorrect Login Credentials!", "Try Again");
        }   // Message to tell user they had put in incorrect credentials

        private static void OnVerifiedCredentials(User _currentUser)
        {   // If the credentials of username and password are correct
 	        RecipeDB uRecipeManager = new RecipeDB(_currentUser);
            uRecipeManager.LoadSelect();
            uRecipeManager.CheckIfUserExists();
        }   // Pass current user to RecipeDB
    }
}
