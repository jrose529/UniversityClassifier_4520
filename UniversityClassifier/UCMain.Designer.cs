namespace UniversityClassifier
{
    partial class UCMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainUNTextbox = new System.Windows.Forms.TextBox();
            this.mainPWTextbox = new System.Windows.Forms.TextBox();
            this.btnMainLogin = new System.Windows.Forms.Button();
            this.linkLabelMainNewUser = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateProfileCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdateUserPWVerify = new System.Windows.Forms.TextBox();
            this.textBoxUpdateUserEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUpdateUserPW = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.radioButtonAINo = new System.Windows.Forms.RadioButton();
            this.radioButtonAIYes = new System.Windows.Forms.RadioButton();
            this.btnUMainAISubmit = new System.Windows.Forms.Button();
            this.btnUMainAICancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUMainTOEFL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUMainSoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUMainGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUMainLoR = new System.Windows.Forms.TextBox();
            this.textBoxUMainGRE = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvUniStats = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUniversitySearcher = new System.Windows.Forms.Button();
            this.textBoxUniversitySearcher = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniStats)).BeginInit();
            this.SuspendLayout();
            // 
            // mainUNTextbox
            // 
            this.mainUNTextbox.Location = new System.Drawing.Point(472, 209);
            this.mainUNTextbox.Name = "mainUNTextbox";
            this.mainUNTextbox.Size = new System.Drawing.Size(183, 26);
            this.mainUNTextbox.TabIndex = 1;
            // 
            // mainPWTextbox
            // 
            this.mainPWTextbox.Location = new System.Drawing.Point(472, 253);
            this.mainPWTextbox.Name = "mainPWTextbox";
            this.mainPWTextbox.Size = new System.Drawing.Size(183, 26);
            this.mainPWTextbox.TabIndex = 2;
            // 
            // btnMainLogin
            // 
            this.btnMainLogin.Location = new System.Drawing.Point(378, 310);
            this.btnMainLogin.Name = "btnMainLogin";
            this.btnMainLogin.Size = new System.Drawing.Size(150, 35);
            this.btnMainLogin.TabIndex = 3;
            this.btnMainLogin.Text = "Login";
            this.btnMainLogin.UseVisualStyleBackColor = true;
            this.btnMainLogin.Click += new System.EventHandler(this.btnMainLogin_Click);
            // 
            // linkLabelMainNewUser
            // 
            this.linkLabelMainNewUser.AutoSize = true;
            this.linkLabelMainNewUser.Location = new System.Drawing.Point(568, 325);
            this.linkLabelMainNewUser.Name = "linkLabelMainNewUser";
            this.linkLabelMainNewUser.Size = new System.Drawing.Size(87, 20);
            this.linkLabelMainNewUser.TabIndex = 4;
            this.linkLabelMainNewUser.TabStop = true;
            this.linkLabelMainNewUser.Text = "New User?";
            this.linkLabelMainNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMainNewUser_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(185, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 552);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateProfileCancel);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxUpdateUserPWVerify);
            this.tabPage1.Controls.Add(this.textBoxUpdateUserEmail);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnUpdateProfile);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBoxUpdateUserPW);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfileCancel
            // 
            this.btnUpdateProfileCancel.Location = new System.Drawing.Point(375, 317);
            this.btnUpdateProfileCancel.Name = "btnUpdateProfileCancel";
            this.btnUpdateProfileCancel.Size = new System.Drawing.Size(165, 40);
            this.btnUpdateProfileCancel.TabIndex = 35;
            this.btnUpdateProfileCancel.Text = "Cancel";
            this.btnUpdateProfileCancel.UseVisualStyleBackColor = true;
            this.btnUpdateProfileCancel.Click += new System.EventHandler(this.btnUpdateProfileCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Verify Password";
            // 
            // textBoxUpdateUserPWVerify
            // 
            this.textBoxUpdateUserPWVerify.Location = new System.Drawing.Point(171, 161);
            this.textBoxUpdateUserPWVerify.Name = "textBoxUpdateUserPWVerify";
            this.textBoxUpdateUserPWVerify.Size = new System.Drawing.Size(138, 26);
            this.textBoxUpdateUserPWVerify.TabIndex = 33;
            // 
            // textBoxUpdateUserEmail
            // 
            this.textBoxUpdateUserEmail.Location = new System.Drawing.Point(171, 84);
            this.textBoxUpdateUserEmail.Name = "textBoxUpdateUserEmail";
            this.textBoxUpdateUserEmail.Size = new System.Drawing.Size(138, 26);
            this.textBoxUpdateUserEmail.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Email Address";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(43, 317);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(165, 40);
            this.btnUpdateProfile.TabIndex = 30;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Edit Your University Classifier Profile";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Password";
            // 
            // textBoxUpdateUserPW
            // 
            this.textBoxUpdateUserPW.Location = new System.Drawing.Point(171, 121);
            this.textBoxUpdateUserPW.Name = "textBoxUpdateUserPW";
            this.textBoxUpdateUserPW.Size = new System.Drawing.Size(138, 26);
            this.textBoxUpdateUserPW.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGenerateReport);
            this.tabPage2.Controls.Add(this.radioButtonAINo);
            this.tabPage2.Controls.Add(this.radioButtonAIYes);
            this.tabPage2.Controls.Add(this.btnUMainAISubmit);
            this.tabPage2.Controls.Add(this.btnUMainAICancel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxUMainTOEFL);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxUMainSoP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxUMainGPA);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxUMainLoR);
            this.tabPage2.Controls.Add(this.textBoxUMainGRE);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(184, 429);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(111, 33);
            this.btnGenerateReport.TabIndex = 53;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // radioButtonAINo
            // 
            this.radioButtonAINo.AutoSize = true;
            this.radioButtonAINo.Location = new System.Drawing.Point(327, 250);
            this.radioButtonAINo.Name = "radioButtonAINo";
            this.radioButtonAINo.Size = new System.Drawing.Size(54, 24);
            this.radioButtonAINo.TabIndex = 52;
            this.radioButtonAINo.TabStop = true;
            this.radioButtonAINo.Text = "No";
            this.radioButtonAINo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAIYes
            // 
            this.radioButtonAIYes.AutoSize = true;
            this.radioButtonAIYes.Location = new System.Drawing.Point(327, 220);
            this.radioButtonAIYes.Name = "radioButtonAIYes";
            this.radioButtonAIYes.Size = new System.Drawing.Size(62, 24);
            this.radioButtonAIYes.TabIndex = 51;
            this.radioButtonAIYes.TabStop = true;
            this.radioButtonAIYes.Text = "Yes";
            this.radioButtonAIYes.UseVisualStyleBackColor = true;
            // 
            // btnUMainAISubmit
            // 
            this.btnUMainAISubmit.Location = new System.Drawing.Point(35, 429);
            this.btnUMainAISubmit.Name = "btnUMainAISubmit";
            this.btnUMainAISubmit.Size = new System.Drawing.Size(111, 33);
            this.btnUMainAISubmit.TabIndex = 50;
            this.btnUMainAISubmit.Text = "Submit";
            this.btnUMainAISubmit.UseVisualStyleBackColor = true;
            this.btnUMainAISubmit.Click += new System.EventHandler(this.btnUMainAISubmit_Click);
            // 
            // btnUMainAICancel
            // 
            this.btnUMainAICancel.Location = new System.Drawing.Point(615, 429);
            this.btnUMainAICancel.Name = "btnUMainAICancel";
            this.btnUMainAICancel.Size = new System.Drawing.Size(111, 33);
            this.btnUMainAICancel.TabIndex = 49;
            this.btnUMainAICancel.Text = "Cancel";
            this.btnUMainAICancel.UseVisualStyleBackColor = true;
            this.btnUMainAICancel.Click += new System.EventHandler(this.btnUMainAICancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Research Conducted";
            // 
            // textBoxUMainTOEFL
            // 
            this.textBoxUMainTOEFL.Location = new System.Drawing.Point(35, 218);
            this.textBoxUMainTOEFL.Name = "textBoxUMainTOEFL";
            this.textBoxUMainTOEFL.Size = new System.Drawing.Size(150, 26);
            this.textBoxUMainTOEFL.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "TOEFL Score";
            // 
            // textBoxUMainSoP
            // 
            this.textBoxUMainSoP.Location = new System.Drawing.Point(327, 37);
            this.textBoxUMainSoP.Name = "textBoxUMainSoP";
            this.textBoxUMainSoP.Size = new System.Drawing.Size(150, 26);
            this.textBoxUMainSoP.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "GRE Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "GPA";
            // 
            // textBoxUMainGPA
            // 
            this.textBoxUMainGPA.Location = new System.Drawing.Point(35, 37);
            this.textBoxUMainGPA.Name = "textBoxUMainGPA";
            this.textBoxUMainGPA.Size = new System.Drawing.Size(150, 26);
            this.textBoxUMainGPA.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Letters of Rec Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Statement of Purpose Score";
            // 
            // textBoxUMainLoR
            // 
            this.textBoxUMainLoR.Location = new System.Drawing.Point(327, 124);
            this.textBoxUMainLoR.Name = "textBoxUMainLoR";
            this.textBoxUMainLoR.Size = new System.Drawing.Size(138, 26);
            this.textBoxUMainLoR.TabIndex = 39;
            // 
            // textBoxUMainGRE
            // 
            this.textBoxUMainGRE.Location = new System.Drawing.Point(35, 124);
            this.textBoxUMainGRE.Name = "textBoxUMainGRE";
            this.textBoxUMainGRE.Size = new System.Drawing.Size(150, 26);
            this.textBoxUMainGRE.TabIndex = 38;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvUniStats);
            this.tabPage4.Controls.Add(this.btnUniversitySearcher);
            this.tabPage4.Controls.Add(this.textBoxUniversitySearcher);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 519);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "University Stats";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvUniStats
            // 
            this.dgvUniStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvUniStats.Location = new System.Drawing.Point(49, 164);
            this.dgvUniStats.Name = "dgvUniStats";
            this.dgvUniStats.RowTemplate.Height = 28;
            this.dgvUniStats.Size = new System.Drawing.Size(670, 178);
            this.dgvUniStats.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "University Score";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Student Score";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 175;
            // 
            // btnUniversitySearcher
            // 
            this.btnUniversitySearcher.Location = new System.Drawing.Point(24, 27);
            this.btnUniversitySearcher.Name = "btnUniversitySearcher";
            this.btnUniversitySearcher.Size = new System.Drawing.Size(95, 33);
            this.btnUniversitySearcher.TabIndex = 36;
            this.btnUniversitySearcher.Text = "Search";
            this.btnUniversitySearcher.UseVisualStyleBackColor = true;
            this.btnUniversitySearcher.Click += new System.EventHandler(this.btnUniversitySearcher_Click);
            // 
            // textBoxUniversitySearcher
            // 
            this.textBoxUniversitySearcher.Location = new System.Drawing.Point(137, 30);
            this.textBoxUniversitySearcher.Name = "textBoxUniversitySearcher";
            this.textBoxUniversitySearcher.Size = new System.Drawing.Size(199, 26);
            this.textBoxUniversitySearcher.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "To display university stats, you must search for a school.";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(689, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log Out";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 721);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelMainNewUser);
            this.Controls.Add(this.btnMainLogin);
            this.Controls.Add(this.mainPWTextbox);
            this.Controls.Add(this.mainUNTextbox);
            this.Name = "UCMain";
            this.Text = "University Classifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainUNTextbox;
        private System.Windows.Forms.TextBox mainPWTextbox;
        private System.Windows.Forms.Button btnMainLogin;
        private System.Windows.Forms.LinkLabel linkLabelMainNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButtonAINo;
        private System.Windows.Forms.RadioButton radioButtonAIYes;
        private System.Windows.Forms.Button btnUMainAISubmit;
        private System.Windows.Forms.Button btnUMainAICancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUMainTOEFL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUMainSoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUMainGPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUMainLoR;
        private System.Windows.Forms.TextBox textBoxUMainGRE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUpdateUserPWVerify;
        private System.Windows.Forms.TextBox textBoxUpdateUserEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUpdateUserPW;
        private System.Windows.Forms.Button btnUpdateProfileCancel;
        private System.Windows.Forms.TextBox textBoxUniversitySearcher;
        private System.Windows.Forms.Button btnUniversitySearcher;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dgvUniStats;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}

