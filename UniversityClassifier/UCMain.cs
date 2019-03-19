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
    public partial class UCMain : Form
    {
        public UCMain()
        {
            this.BackgroundImage = Properties.Resources.classifierBackground;
            InitializeComponent();
        }
        //Have small main page, then open up other larger pages? Because I'd have to individually hide, show parts of the app

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMainLogin_Click(object sender, EventArgs e)
        {
            if (mainUNTextbox.Text=="" || mainPWTextbox.Text == "")
            {
                MessageBox.Show("ERROR: Empty Field");
                return;
            }
            userAccount userLogin = new userAccount();
            userLogin.accountLogin(mainUNTextbox.Text, mainPWTextbox.Text);
        }

        private void linkLabelMainNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserForm newForm = new NewUserForm();
            newForm.Show();
            
        }
    }
}
