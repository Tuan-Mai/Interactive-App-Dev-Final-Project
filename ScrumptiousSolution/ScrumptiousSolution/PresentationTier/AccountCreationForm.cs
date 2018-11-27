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

// Author: Tuan Mai

namespace ScrumptiousSolution.PresentationTier
{
    public partial class AccountCreationForm : Form
    {
        #region Fields
        // Declare the field variables
        private User _user;
        private LoginForm _loginForm;
        private bool _newUser;
        #endregion

        public AccountCreationForm()
        {   // Constructor for AccountCreationForm
            InitializeComponent();
            _loginForm = new LoginForm();           
        }

        private void AccountCreationForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            _txtCreatePassword.Enabled = false;     // Disable the CreatePassword box if no username
            _txtConfirmPassword.Enabled = false;    // Disable the ConfirmPassword box if no password
            _btnCreate.Enabled = false;             // Disable the Creat button if not all fields are filled out
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();        // Close the form if the user clicks cancel
        }

        private void OnUsernameChanged(object sender, EventArgs e)
        {   // Check to see if the text length of Username is greater than 0
            _txtCreatePassword.Enabled = (_txtCreateUsername.Text.Length > 0);
        }   // Enable the CreatePassword if so

        private void OnPasswordChanged(object sender, EventArgs e)
        {   // Check to see if the text length of CreatePassword is greater than 0
            _txtCreatePassword.PasswordChar = '*';      // Sets all text in CreatePassword box to '*'
            _txtConfirmPassword.Enabled = (_txtCreatePassword.Text.Length > 0);
        }   // Enable the ConfirmPassword if so

        private void OnConfirmPasswordChanged(object sender, EventArgs e)
        {   
            _txtConfirmPassword.PasswordChar = '*';     // Sets all text in ConfirmPassword box to '*'
            if (_txtConfirmPassword.Text == _txtCreatePassword.Text)
            {   // Check to see if the ConfirmedPassword is equal to the CreatePassword
                _btnCreate.Enabled = (_txtConfirmPassword.Text.Length > 0);
            }   // If so, enable the Create button to be pressed

            else
            {   // Else, the button stays disabled
                _btnCreate.Enabled = false;
            }
        }

        private void OnCreate(object sender, EventArgs e)
        {   // When the user clickes Create
            using (StreamReader readUsers = new StreamReader("Users.csv"))
            {   // Open the "Users.csv" to read
                bool alreadyAUser = false;      // Sets bool alreadyAUser to false

                while (!readUsers.EndOfStream)
                {   // While the file is not at the end
                    string userData = readUsers.ReadLine();
                    string[] userDataParts = userData.Split('~');   // Use seperator '~'

                    if (_txtCreateUsername.Text == userDataParts[0])
                    {   // If the text in _txtCreateUsername is equal to any of the username elements in Users.csv
                        alreadyAUser = true;    // There is already a user
                    }
                }

                if (alreadyAUser != true)
                {   // If the _txtCreateUsername is not already a user
                    _user = new User(_txtCreateUsername.Text, _txtConfirmPassword.Text);
                    _loginForm.AddToUsers(_user);   // Add it to the Users List in the LoginForm
                    _newUser = true;                // Verify it is a new user
                    Close();
                }
                else
                {
                    ResetLoginFields();             // If not a new user, reset the fields
                }
            }

            if (_newUser == true)
            {   // If it is a verified new user,
                Save(_loginForm._userAccounts);     // Save the user's info
            }
        }

        private void ResetLoginFields()
        {   // Warn user that username is already taken, and reset the fields (Only comes here if username is already taken)
            MessageBox.Show("Your desired Username is already taken!", "Try again");
            _txtCreatePassword.Text = "";
            _txtCreatePassword.Enabled = false;
            _txtConfirmPassword.Text = "";
            _txtConfirmPassword.Enabled = false;
        }

        public void Save(List<User> userAccounts)
        {   // Open the "Users.csv" to be written to
            using (StreamWriter writeUserInfo = new StreamWriter(("Users.csv"), true))
            {   // Append onto the file with the created username and password, spereated by "~"
                string userInfo = String.Format("{0}~{1}", _txtCreateUsername.Text, _txtConfirmPassword.Text);
                writeUserInfo.WriteLine(userInfo);      // Write to the "Users.csv" file
            }
        }
    }
}
