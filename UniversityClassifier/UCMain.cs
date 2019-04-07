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
        public string username_current;

        public UCMain()
        {
            this.BackgroundImage = Properties.Resources.classifierBackground;
            InitializeComponent();
            tabControl1.Hide();
            dgvUniStats.Rows[0].Cells[0].Value = "GRE Score";
            dgvUniStats.Rows[1].Cells[0].Value = "TOEFL Score";
            dgvUniStats.Rows[2].Cells[0].Value = "GPA";
            dgvUniStats.Rows[3].Cells[0].Value = "Statement of Purpose";
            dgvUniStats.Rows[4].Cells[0].Value = "Letters of Rec";
            dgvUniStats.Hide();
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
                    username_current = mainUNTextbox.Text;
                    tabControl1.Show();
                    tabControl1.SelectedTab = tabPage2;
                    textBoxUniversitySearcher.Show();
                    btnUniversitySearcher.Hide();
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

        private void tabControl1_Click(object sender, EventArgs e) //logout
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                for (int a = 1; a< 5; a++)
                {
                    for (int b = 0; b < 2; b++)
                    {
                        dgvUniStats.Rows[a].Cells[b].Value = "";
                    }
                }
                dgvUniStats.Hide();
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
            bool research = false;
            if (radioButtonAIYes.Checked == true)
            {
                research = true;
            }
            else if (radioButtonAINo.Checked == true)
            {
                research = false;
            }
            uniQuery academicData = new uniQuery();
            academicData.insertAcademicData(username_current,
                                        textBoxUMainGPA.Text,
                                        textBoxUMainGRE.Text,
                                        textBoxUMainTOEFL.Text,
                                        textBoxUMainSoP.Text,
                                        textBoxUMainLoR.Text,
                                        research);

            academicData.generateReport(username_current);
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
                                 textBoxUpdateUserPW.Text,
                                 username_current);

            tabControl1.SelectedTab = tabPage2;
        }

        private void btnUpdateProfileCancel_Click(object sender, EventArgs e)
        {
            textBoxUpdateUserEmail.Clear();
            textBoxUpdateUserPW.Clear();
            textBoxUpdateUserPWVerify.Clear();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnUniversitySearcher_Click(object sender, EventArgs e)
        {
            uniQuery newQuery = new uniQuery();
            newQuery.universityQuery(username_current, textBoxUniversitySearcher.Text);
        }


        //Leave academic info events
        private void textBoxUMainGRE_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxUMainGRE.Text) < 34 || Int32.Parse(textBoxUMainGRE.Text) > 260)
            {
                MessageBox.Show("ERROR: Outside of range 34-260");
            }
        }

        private void textBoxUMainLoR_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxUMainLoR.Text) < 0 || Int32.Parse(textBoxUMainLoR.Text) > 5)
            {
                MessageBox.Show("ERROR: Outside of range 0-5");
            }
        }

        private void textBoxUMainGPA_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxUMainGPA.Text) < 0 || Int32.Parse(textBoxUMainGPA.Text) > 10)
            {
                MessageBox.Show("ERROR: Outside of range 0-10");
            }
        }

        private void textBoxUMainSoP_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxUMainSoP.Text) < 0 || Int32.Parse(textBoxUMainSoP.Text) > 5)
            {
                MessageBox.Show("ERROR: Outside of range 0-5");
            }
        }

        private void textBoxUMainTOEFL_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxUMainTOEFL.Text) < 0 || Int32.Parse(textBoxUMainTOEFL.Text) > 120)
            {
                MessageBox.Show("ERROR: Outside of range 0-120");
            }
        }
    }
}
