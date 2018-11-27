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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }
        
        private void OnClick(object sender, EventArgs e)
        {   // When user clicks the logo
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.StartPosition = FormStartPosition.CenterScreen;
            mainMenu.Show();    // Open up the MainMenuForm
            Hide();
        }
    }
}
