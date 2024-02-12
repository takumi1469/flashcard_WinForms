using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takumi_Saito_Project
{
    public partial class Form2 : Form //Sign-Up screen
    {
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.FormClosed += Form2_FormClosed;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_UsernameCheckMessage.Text = string.Empty;
            lbl_PasswordCheckMessage.Text = string.Empty;
            lbl_MatchCheck.Text = string.Empty;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - Program.HorizontalOffset,
                                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - Program.VerticalOffset);
        }
        private void Form2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_GoToYourCards_Click(object sender, EventArgs e)
        {
            int checkResults = 0;
            string username = box_UserName.Text;
            string password = box_Password.Text;
            string repeatPassword = box_RepeatPassword.Text;

            //input validation for username
            if (username.Length == 0)
                lbl_UsernameCheckMessage.Text = "Please enter username";
            else if (username.Length > 31)
                lbl_UsernameCheckMessage.Text = "Username must be shorter than 32 characters";
            else if (WordCardSystem.CheckExistingUser(username) != -1)
                lbl_UsernameCheckMessage.Text = "That username already exists";
            else
            {
                lbl_UsernameCheckMessage.Text = string.Empty;
                checkResults++;
            }

            //input validation for password
            if (password.Length == 0)
                lbl_PasswordCheckMessage.Text = "Please enter password";
            else if (password.Length > 31)
                lbl_PasswordCheckMessage.Text = "Password must be shorter than 32 characters";
            else
            {
                lbl_PasswordCheckMessage.Text = string.Empty;
                checkResults++;
            }

            //input validation for password matching
            if (password != repeatPassword)
                lbl_MatchCheck.Text = "Password doesn't match,\nplease check :)";
            else
                checkResults++;

            if(checkResults == 3) //All the inputs are fine, move to Form3 for subject menu as a new user
            {
                lbl_MatchCheck.Text = "Match :) ";
                WordCardSystem.Users.Add(new User(username, password));
                Form3 form3 = new Form3(WordCardSystem.Users[WordCardSystem.Users.Count() - 1]);
                form3.Show();
                this.Hide();
            }
            else
            {
                checkResults = 0;
            }
        }

        private void lbl_GoBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lbl_MatchCheck_Click(object sender, EventArgs e)
        {

        }

        private void lbl_UsernameCheckMessage_Click(object sender, EventArgs e)
        {

        }

        private void box_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_RepeatPassword_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
