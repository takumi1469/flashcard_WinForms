namespace Takumi_Saito_Project
{
    partial class Form2
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
            this.UserID = new System.Windows.Forms.Label();
            this.box_UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_RepeatPassword = new System.Windows.Forms.TextBox();
            this.btn_GoToYourCards = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Label();
            this.lbl_MatchCheck = new System.Windows.Forms.Label();
            this.lbl_UsernameCheckMessage = new System.Windows.Forms.Label();
            this.lbl_PasswordCheckMessage = new System.Windows.Forms.Label();
            this.lbl_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserID.Location = new System.Drawing.Point(176, 22);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(188, 35);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "Enter username";
            // 
            // box_UserName
            // 
            this.box_UserName.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_UserName.Location = new System.Drawing.Point(176, 68);
            this.box_UserName.Name = "box_UserName";
            this.box_UserName.Size = new System.Drawing.Size(396, 41);
            this.box_UserName.TabIndex = 1;
            this.box_UserName.TextChanged += new System.EventHandler(this.box_UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(176, 134);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(186, 35);
            this.Password.TabIndex = 2;
            this.Password.Text = "Enter password";
            // 
            // box_Password
            // 
            this.box_Password.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_Password.Location = new System.Drawing.Point(176, 185);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(396, 41);
            this.box_Password.TabIndex = 3;
            this.box_Password.TextChanged += new System.EventHandler(this.box_Password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Repeat password";
            // 
            // box_RepeatPassword
            // 
            this.box_RepeatPassword.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_RepeatPassword.Location = new System.Drawing.Point(176, 299);
            this.box_RepeatPassword.Name = "box_RepeatPassword";
            this.box_RepeatPassword.Size = new System.Drawing.Size(396, 41);
            this.box_RepeatPassword.TabIndex = 5;
            this.box_RepeatPassword.TextChanged += new System.EventHandler(this.box_RepeatPassword_TextChanged);
            // 
            // btn_GoToYourCards
            // 
            this.btn_GoToYourCards.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GoToYourCards.Location = new System.Drawing.Point(186, 360);
            this.btn_GoToYourCards.Name = "btn_GoToYourCards";
            this.btn_GoToYourCards.Size = new System.Drawing.Size(374, 65);
            this.btn_GoToYourCards.TabIndex = 6;
            this.btn_GoToYourCards.Text = "Register and go to your cards";
            this.btn_GoToYourCards.UseVisualStyleBackColor = true;
            this.btn_GoToYourCards.Click += new System.EventHandler(this.btn_GoToYourCards_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.BackColor = System.Drawing.Color.LimeGreen;
            this.SignUp.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUp.Location = new System.Drawing.Point(13, 22);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(137, 46);
            this.SignUp.TabIndex = 7;
            this.SignUp.Text = "Sign Up";
            // 
            // lbl_MatchCheck
            // 
            this.lbl_MatchCheck.AutoSize = true;
            this.lbl_MatchCheck.Location = new System.Drawing.Point(578, 314);
            this.lbl_MatchCheck.Name = "lbl_MatchCheck";
            this.lbl_MatchCheck.Size = new System.Drawing.Size(166, 20);
            this.lbl_MatchCheck.TabIndex = 8;
            this.lbl_MatchCheck.Text = "Password Repeat Result";
            this.lbl_MatchCheck.Click += new System.EventHandler(this.lbl_MatchCheck_Click);
            // 
            // lbl_UsernameCheckMessage
            // 
            this.lbl_UsernameCheckMessage.AutoSize = true;
            this.lbl_UsernameCheckMessage.Location = new System.Drawing.Point(578, 83);
            this.lbl_UsernameCheckMessage.Name = "lbl_UsernameCheckMessage";
            this.lbl_UsernameCheckMessage.Size = new System.Drawing.Size(118, 20);
            this.lbl_UsernameCheckMessage.TabIndex = 9;
            this.lbl_UsernameCheckMessage.Text = "Username Check";
            this.lbl_UsernameCheckMessage.Click += new System.EventHandler(this.lbl_UsernameCheckMessage_Click);
            // 
            // lbl_PasswordCheckMessage
            // 
            this.lbl_PasswordCheckMessage.AutoSize = true;
            this.lbl_PasswordCheckMessage.Location = new System.Drawing.Point(578, 200);
            this.lbl_PasswordCheckMessage.Name = "lbl_PasswordCheckMessage";
            this.lbl_PasswordCheckMessage.Size = new System.Drawing.Size(114, 20);
            this.lbl_PasswordCheckMessage.TabIndex = 10;
            this.lbl_PasswordCheckMessage.Text = "Password Check";
            // 
            // lbl_GoBack
            // 
            this.lbl_GoBack.Location = new System.Drawing.Point(13, 102);
            this.lbl_GoBack.Name = "lbl_GoBack";
            this.lbl_GoBack.Size = new System.Drawing.Size(137, 41);
            this.lbl_GoBack.TabIndex = 11;
            this.lbl_GoBack.Text = "Go Back to Start";
            this.lbl_GoBack.UseVisualStyleBackColor = true;
            this.lbl_GoBack.Click += new System.EventHandler(this.lbl_GoBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_GoBack);
            this.Controls.Add(this.lbl_PasswordCheckMessage);
            this.Controls.Add(this.lbl_UsernameCheckMessage);
            this.Controls.Add(this.lbl_MatchCheck);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.btn_GoToYourCards);
            this.Controls.Add(this.box_RepeatPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.box_UserName);
            this.Controls.Add(this.UserID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UserID;
        private TextBox box_UserName;
        private Label Password;
        private TextBox box_Password;
        private Label label1;
        private TextBox box_RepeatPassword;
        private Button btn_GoToYourCards;
        private Label SignUp;
        private Label lbl_MatchCheck;
        private Label lbl_UsernameCheckMessage;
        private Label lbl_PasswordCheckMessage;
        private Button lbl_GoBack;
    }
}