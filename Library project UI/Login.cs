using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_project_logic;

namespace Library_project_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LibrarianRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LibrarianRadioButton.Checked == true
                && UserNameTextBox.Text.Equals("sela")
                && PasswordTextBox.Text.Equals("4321"))
            {
                this.Hide();
                Main main = new Main(this,true);
                main.ShowDialog();
            }
            else if (UserRadioButton.Checked == true
                && UserNameTextBox.Text.Equals("user")
                && PasswordTextBox.Text.Equals("1234"))
            {
                this.Hide();
                Main main = new Main(this,false);
                main.ShowDialog();
            }
            else { MessageBox.Show("Username and password do not match an existing account."); }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
