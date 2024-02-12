using System.Globalization;

namespace Takumi_Saito_Project
{
    public partial class Form1 : Form //Login screen
    {
        public Form1() 
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_LoadingResult.Hide();
            lbl_CheckMessage.Hide();
            lbl_UserNameCheck.Text = string.Empty;
            box_Password.PasswordChar = 'Åú';

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - Program.HorizontalOffset,
                                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - Program.VerticalOffset);
        }

        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit(); //When any form is closed, the application itself is terminated
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = box_UserId.Text;
            string password = box_Password.Text;
            int userCheckResult = WordCardSystem.CheckExistingUser(username);

            //input validation
            if (username.Length == 0)
                lbl_UserNameCheck.Text = "Please enter username";
            else
                lbl_UserNameCheck.Text = string.Empty;

            if (userCheckResult == -1) //no user with the entered username found
            {
                lbl_CheckMessage.Show();
                lbl_CheckMessage.Text = "Sorry, that username does not exist.";
            }
            else //user found
            {
                if (WordCardSystem.Users[userCheckResult].PasswordCheck(password))
                {
                    if (cbx_RememberMe.Checked == true) //User chose to do automatic login, so initial config file will be created
                    {
                        AutomaticLoginWrite(WordCardSystem.Users[userCheckResult].UserName, WordCardSystem.Users[userCheckResult].Password);
                    }
                    Form3 form3 = new Form3(WordCardSystem.Users[userCheckResult]);
                    form3.Show(); //Move to the Subject menu as the logged in user
                    this.Hide();
                }
                else
                {
                    lbl_CheckMessage.Show();
                    if (password.Length == 0)
                        lbl_CheckMessage.Text = "Please enter password.";
                    else
                        lbl_CheckMessage.Text = "Sorry, password doesn't match.";
                }
            }
        }

        private void AutomaticLoginWrite(string username, string password) //Method to write config file on user's desktop
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "flashcardconfig.txt";
            string filePath = Path.Combine(desktopPath, fileName);
            FileStream stream = File.Open(filePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.Write($"{username},{password},{Program.DefaultInputPath},");
            writer.Close();
        }


        private void cbx_PasswordShowHide_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the PasswordChar property based on whether the checkbox is checked
            box_Password.PasswordChar = cbx_PasswordShowHide.Checked ? '\0' : 'Åú';//Åú gave an error to Prof.Brozek
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); 
            form2.Show(); //Move to the Sign-in menu
            this.Hide();
        }

        private void btn_LoadFromFile_Click(object sender, EventArgs e) 
        {
            string inputPath = WordCardSystem.OpenFile();
            int inputResult = WordCardSystem.JsonInput(inputPath);

            if (inputResult == 1) //Input file was good
            {
                lbl_LoadingResult.Text = "Loading success :)";
                Program.DefaultInputPath = inputPath;
                //save inputPath to Program class (not in a variable within this form) for the following reason:
                //If the inputPath was saved inside this form, and if user loads a file and log in without checking Remember me,
                //and then come back to login screen(Form1),then the data from file will remain but inputPath would be gone.
                //This is because forms are always made as new ones.
            }
            else if (inputResult == 2) //Input file was not good
                lbl_LoadingResult.Text = "Loading failed :/";
            else lbl_LoadingResult.Text = "";
            lbl_LoadingResult.Show();
        }

        private void lbl_LoadingResult_Click(object sender, EventArgs e)
        {

        }

        private void lbl_UserNameCheck_Click(object sender, EventArgs e)
        {

        }

        private void cbx_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void lbl_CheckMessage_Click(object sender, EventArgs e)
        {

        }

        private void box_Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void box_UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_AppTitle_Click(object sender, EventArgs e)
        {

        }
    }
}