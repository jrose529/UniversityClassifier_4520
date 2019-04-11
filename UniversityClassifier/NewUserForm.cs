using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityClassifier
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            this.BackgroundImage = Properties.Resources.classifierBackground;
            InitializeComponent();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            int status;

            if (textBoxNewUserFName.Text == "" ||
                textBoxNewUserLName.Text == "" || 
                textBoxNewUserPW.Text == "" ||
                textBoxNewUserUsername.Text == "" ||
                textBoxNewUserPWVerify.Text == "" ||
                textBoxNewUserEmail.Text == "")
            {
                MessageBox.Show("ERROR: EMPTY FIELD");
                return;
            }
            else if (textBoxNewUserPW.Text.Equals(textBoxNewUserPWVerify.Text) == false)
            {
                MessageBox.Show("ERROR: PASSWORDS DO NOT MATCH");
                return;
            }
            userAccount newUser = new userAccount();
            status = newUser.createAccount(textBoxNewUserUsername.Text,
                                  textBoxNewUserFName.Text,
                                  textBoxNewUserLName.Text,
                                  textBoxNewUserEmail.Text,
                                  textBoxNewUserPW.Text);

            if (status == 0) // Account alreadys exists
            {
                MessageBox.Show("ERROR: An account with this username already exists.");
                return;
            }
            else if (status == 1) //Account made successfully
            {
                MessageBox.Show("Account created successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR: This is not good.");
            }
        }
    }
}
