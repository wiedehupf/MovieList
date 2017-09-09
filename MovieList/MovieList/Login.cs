using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonAccounterstellen.Visible = true;
            buttonCreateAccount.Visible = false;
            textBoxPasswordwdhl.Visible = false;
            labelPasswordwdhl.Visible = false;
            buttonUserLogin.Visible = true;
            buttonBack.Visible = false;
            textBoxPasswordwdhl.Text = "";
            TextBoxPassword.Text = "";
            TextBoxUsername.Text = "";
        }

        private void buttonAccounterstellen_Click(object sender, EventArgs e)
        {
            buttonAccounterstellen.Visible = false;
            buttonBack.Visible = true;
            buttonCreateAccount.Visible = true;
            textBoxPasswordwdhl.Visible = true;
            labelPasswordwdhl.Visible = true;
            buttonUserLogin.Visible = false;
            textBoxPasswordwdhl.Text = "";
            TextBoxPassword.Text = "";
            TextBoxUsername.Text = "";
        }
    }
}
