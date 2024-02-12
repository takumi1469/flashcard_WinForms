namespace Takumi_Saito_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_UserId = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SignUpMessage = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CheckMessage = new System.Windows.Forms.Label();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.lbl_LoadingResult = new System.Windows.Forms.Label();
            this.cbx_PasswordShowHide = new System.Windows.Forms.CheckBox();
            this.lbl_UserNameCheck = new System.Windows.Forms.Label();
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.cbx_RememberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // box_UserId
            // 
            this.box_UserId.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_UserId.Location = new System.Drawing.Point(185, 142);
            this.box_UserId.Name = "box_UserId";
            this.box_UserId.Size = new System.Drawing.Size(423, 41);
            this.box_UserId.TabIndex = 0;
            this.box_UserId.TextChanged += new System.EventHandler(this.box_UserId_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(185, 104);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(127, 35);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(185, 211);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 35);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // box_Password
            // 
            this.box_Password.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_Password.Location = new System.Drawing.Point(185, 250);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(423, 41);
            this.box_Password.TabIndex = 3;
            this.box_Password.TextChanged += new System.EventHandler(this.box_Password_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(304, 317);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(174, 54);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // SignUpMessage
            // 
            this.SignUpMessage.AutoSize = true;
            this.SignUpMessage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpMessage.Location = new System.Drawing.Point(236, 383);
            this.SignUpMessage.Name = "SignUpMessage";
            this.SignUpMessage.Size = new System.Drawing.Size(431, 28);
            this.SignUpMessage.TabIndex = 5;
            this.SignUpMessage.Text = "If you haven\'t signed up yet, sign up from here :)";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SignUp.Location = new System.Drawing.Point(304, 423);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(174, 52);
            this.btn_SignUp.TabIndex = 6;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckMessage
            // 
            this.lbl_CheckMessage.AutoSize = true;
            this.lbl_CheckMessage.Location = new System.Drawing.Point(488, 351);
            this.lbl_CheckMessage.Name = "lbl_CheckMessage";
            this.lbl_CheckMessage.Size = new System.Drawing.Size(102, 20);
            this.lbl_CheckMessage.TabIndex = 8;
            this.lbl_CheckMessage.Text = "(Check Result)";
            this.lbl_CheckMessage.Click += new System.EventHandler(this.lbl_CheckMessage_Click);
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoadFromFile.Location = new System.Drawing.Point(27, 140);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(103, 106);
            this.btn_LoadFromFile.TabIndex = 9;
            this.btn_LoadFromFile.Text = "Load from File";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // lbl_LoadingResult
            // 
            this.lbl_LoadingResult.AutoSize = true;
            this.lbl_LoadingResult.Location = new System.Drawing.Point(27, 250);
            this.lbl_LoadingResult.Name = "lbl_LoadingResult";
            this.lbl_LoadingResult.Size = new System.Drawing.Size(117, 20);
            this.lbl_LoadingResult.TabIndex = 10;
            this.lbl_LoadingResult.Text = "(Loading Result)";
            this.lbl_LoadingResult.Click += new System.EventHandler(this.lbl_LoadingResult_Click);
            // 
            // cbx_PasswordShowHide
            // 
            this.cbx_PasswordShowHide.BackColor = System.Drawing.Color.Transparent;
            this.cbx_PasswordShowHide.Location = new System.Drawing.Point(614, 250);
            this.cbx_PasswordShowHide.Name = "cbx_PasswordShowHide";
            this.cbx_PasswordShowHide.Size = new System.Drawing.Size(110, 52);
            this.cbx_PasswordShowHide.TabIndex = 11;
            this.cbx_PasswordShowHide.Text = "Show/Hide Password";
            this.cbx_PasswordShowHide.UseVisualStyleBackColor = false;
            this.cbx_PasswordShowHide.CheckedChanged += new System.EventHandler(this.cbx_PasswordShowHide_CheckedChanged);
            // 
            // lbl_UserNameCheck
            // 
            this.lbl_UserNameCheck.AutoSize = true;
            this.lbl_UserNameCheck.Location = new System.Drawing.Point(614, 157);
            this.lbl_UserNameCheck.Name = "lbl_UserNameCheck";
            this.lbl_UserNameCheck.Size = new System.Drawing.Size(118, 20);
            this.lbl_UserNameCheck.TabIndex = 12;
            this.lbl_UserNameCheck.Text = "Username Check";
            this.lbl_UserNameCheck.Click += new System.EventHandler(this.lbl_UserNameCheck_Click);
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.Font = new System.Drawing.Font("Segoe Print", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AppTitle.Location = new System.Drawing.Point(185, 9);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(449, 81);
            this.lbl_AppTitle.TabIndex = 13;
            this.lbl_AppTitle.Text = "FLASH CARD";
            this.lbl_AppTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_AppTitle.Click += new System.EventHandler(this.lbl_AppTitle_Click);
            // 
            // cbx_RememberMe
            // 
            this.cbx_RememberMe.AutoSize = true;
            this.cbx_RememberMe.Location = new System.Drawing.Point(489, 324);
            this.cbx_RememberMe.Name = "cbx_RememberMe";
            this.cbx_RememberMe.Size = new System.Drawing.Size(233, 24);
            this.cbx_RememberMe.TabIndex = 14;
            this.cbx_RememberMe.Text = "Remember me and loaded file";
            this.cbx_RememberMe.UseVisualStyleBackColor = true;
            this.cbx_RememberMe.CheckedChanged += new System.EventHandler(this.cbx_RememberMe_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.cbx_RememberMe);
            this.Controls.Add(this.lbl_AppTitle);
            this.Controls.Add(this.lbl_UserNameCheck);
            this.Controls.Add(this.cbx_PasswordShowHide);
            this.Controls.Add(this.lbl_LoadingResult);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.lbl_CheckMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.SignUpMessage);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.box_UserId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox box_UserId;
        private Label Username;
        private Label Password;
        private TextBox box_Password;
        private Button btn_Login;
        private Label SignUpMessage;
        private Button btn_SignUp;
        private Label label1;
        private Label lbl_CheckMessage;
        private Button btn_LoadFromFile;
        private Label lbl_LoadingResult;
        private CheckBox cbx_PasswordShowHide;
        private Label lbl_UserNameCheck;
        private Label lbl_AppTitle;
        private CheckBox cbx_RememberMe;
    }
}