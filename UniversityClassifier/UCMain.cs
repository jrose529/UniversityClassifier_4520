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
            tabControl1.Hide();
        }

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
            int loginCheck = userLogin.accountLogin(mainUNTextbox.Text, mainPWTextbox.Text);

            switch (loginCheck)
            {
                case 0:
                    MessageBox.Show("ERROR: Incorrect Login");
                    mainUNTextbox.Clear();
                    mainPWTextbox.Clear();
                    break;
                case 1:
                    //academicInfo academicInfo = new academicInfo();
                    //academicInfo.Show();
                    tabControl1.Show();
                    tabControl1.SelectedTab = tabPage2;
                    break;
                case 2:
                    MessageBox.Show("ERROR: Multiple accounts with the same username detected");
                    break;
                default:
                    MessageBox.Show("ERROR: UNHANDLED EXCEPTION");
                    break;
            }
        }

        private void linkLabelMainNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserForm newForm = new NewUserForm();
            newForm.Show();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                tabControl1.Hide();
                mainUNTextbox.Clear();
                mainPWTextbox.Clear();
            }
        }

        private void btnUMainAICancel_Click(object sender, EventArgs e)
        {
            textBoxUMainGPA.Clear();
            textBoxUMainGRE.Clear();
            textBoxUMainTOEFL.Clear();
            textBoxUMainSoP.Clear();
            textBoxUMainLoR.Clear();
        }

        private void btnUMainAISubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (textBoxUpdateUserPW.Text == "" &&
                textBoxUpdateUserPWVerify.Text == "" &&
                textBoxUpdateUserEmail.Text == "")
            {
                MessageBox.Show("ERROR: ALL FIELDS EMPTY");
                return;
            }

            if (textBoxUpdateUserPW.Text.Equals(textBoxUpdateUserPWVerify.Text) == false)
            {
                MessageBox.Show("ERROR: PASSWORDS DO NOT MATCH");
                return;
            }

            userAccount update = new userAccount();
            update.updateAccount(textBoxUpdateUserEmail.Text,
                                 textBoxUpdateUserPW.Text);

            tabControl1.SelectedTab = tabPage2;
        }

        private void btnUpdateProfileCancel_Click(object sender, EventArgs e)
        {
            textBoxUpdateUserEmail.Clear();
            textBoxUpdateUserPW.Clear();
            textBoxUpdateUserPWVerify.Clear();
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
