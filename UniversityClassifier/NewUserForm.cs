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
            if (textBoxNewUserFName.Text == "" ||
                textBoxNewUserLName.Text == "" || 
                textBoxNewUserPW.Text == "" ||
                textBoxNewUserUsername.Text == "" ||
                textBoxNewUserPWVerify.Text == "")
            {
                MessageBox.Show("ERROR: EMPTY FIELD");
                return;
            }
            else if (textBoxNewUserPW.Text.Equals(textBoxNewUserPWVerify.Text) == false)
            {
                MessageBox.Show("ERROR: PASSWORDS DO NOT MATCH");
                return;
            }

        }
    }
}
