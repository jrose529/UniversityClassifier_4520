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
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelMainNewUser);
            this.Controls.Add(this.btnMainLogin);
            this.Controls.Add(this.mainPWTextbox);
            this.Controls.Add(this.mainUNTextbox);
            this.Name = "UCMain";
            this.Text = "University Classifier";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

