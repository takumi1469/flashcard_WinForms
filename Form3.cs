using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takumi_Saito_Project
{
    public partial class Form3 : Form //Subject menu screen. Maximum four subjects are displayed at once.
    {
        private User CurrentUser { get; }
        private int SubjectCount { get; set; }
        private int CurrentPage { get; set; } = 0;

        private TextBox inputTextBox;
        private ToolStripMenuItem menuItemEdit;
        private ToolStripMenuItem menuItemDelete;
        private Label TemporaryLabel { get; set; } //This holds the information about which subject was right-clicked
        public Form3(User user)
        {
            InitializeComponent();
            InitializeContextMenu();

            CurrentUser = user;
            SubjectCount = CurrentUser.Subjects.Count();
            TemporaryLabel = new Label();

            this.FormClosed += Form3_FormClosed;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_WelcomeUser.Text = "Welcome, " + CurrentUser.UserName + "!";
            HideOrShow(SubjectCount, 0);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - Program.HorizontalOffset,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - Program.VerticalOffset);
        }
        private void Form3_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //context menu for editing/deleting subjects, written with help of ChatGPT
        private void InitializeContextMenu()
        {
            cms_DeleteEdit = new ContextMenuStrip();

            menuItemEdit = new ToolStripMenuItem("Edit subject (enter new name)");
            menuItemDelete = new ToolStripMenuItem("Delete subject");

            inputTextBox = new TextBox();            
            ToolStripControlHost textBoxHost = new ToolStripControlHost(inputTextBox);

            menuItemDelete.Click += MenuItemDelete_Click;

            cms_DeleteEdit.Items.Add(menuItemEdit);
            cms_DeleteEdit.Items.Add(menuItemDelete);

            menuItemEdit.DropDownItems.Add(textBoxHost);
            menuItemEdit.DropDownItems.Add("Change to this name", null, EditFinalize);

            textBoxHost.Enter += TextBoxHost_Enter;

            lbl_Subject1.ContextMenuStrip = cms_DeleteEdit;
            lbl_Subject2.ContextMenuStrip = cms_DeleteEdit;
            lbl_Subject3.ContextMenuStrip = cms_DeleteEdit;
            lbl_Subject4.ContextMenuStrip = cms_DeleteEdit;

            cms_DeleteEdit.Opening += Cms_DeleteEdit_Opening;
        }

       
        private void TextBoxHost_Enter(object sender, EventArgs e)
        {
            inputTextBox.ReadOnly = false;
            inputTextBox.Focus();
        }

        private void Cms_DeleteEdit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Set initial text of the inputTextBox to the current subject name
            Control c = cms_DeleteEdit.SourceControl as Label;
            TemporaryLabel = c as Label;
            inputTextBox.Text = c.Text;
        }


        private void EditFinalize(object sender, EventArgs e) //Change the name of subject according to user input and refresh the page
        {
            if (TemporaryLabel == lbl_Subject1)
                CurrentUser.Subjects[CurrentPage * 4].Name = inputTextBox.Text;
            if (TemporaryLabel == lbl_Subject2)
                CurrentUser.Subjects[CurrentPage * 4 + 1].Name = inputTextBox.Text;
            if (TemporaryLabel == lbl_Subject3)
                CurrentUser.Subjects[CurrentPage * 4 + 2].Name = inputTextBox.Text;
            if (TemporaryLabel == lbl_Subject4)
                CurrentUser.Subjects[CurrentPage * 4 + 3].Name = inputTextBox.Text;

            HideOrShow(SubjectCount, CurrentPage);
            cms_DeleteEdit.Close();
        }

        private void MenuItemDelete_Click(object sender, EventArgs e) //Delete subject
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (TemporaryLabel == lbl_Subject1)
                    CurrentUser.Subjects.RemoveAt(CurrentPage * 4);
                if (TemporaryLabel == lbl_Subject2)
                    CurrentUser.Subjects.RemoveAt(CurrentPage * 4 + 1);
                if (TemporaryLabel == lbl_Subject3)
                    CurrentUser.Subjects.RemoveAt(CurrentPage * 4 + 2);
                if (TemporaryLabel == lbl_Subject4)
                    CurrentUser.Subjects.RemoveAt(CurrentPage * 4 + 3);
                MessageBox.Show("Subject deleted :)");
                SubjectCount = CurrentUser.Subjects.Count(); //Refresh the SubjectCount
            }
            else
            {
                MessageBox.Show("OK :)");
            }
            HideOrShow(SubjectCount, CurrentPage);
            cms_DeleteEdit.Close();
        }
        private void HideOrShow(int count, int page) //Method to determine what should be shown on screen depending on the number of existing subjects and current page
        {
            lbl_Subject1.Hide();
            lbl_Subject2.Hide();
            lbl_Subject3.Hide();
            lbl_Subject4.Hide();
            btn_Back.Hide();
            btn_Next.Hide();

            if (page > 0)
                btn_Back.Show();
            if ((page + 1) * 4 < count)
                btn_Next.Show();

            int neededPage;
            if (count % 4 == 0)
                neededPage = count / 4 - 1;
            else
                neededPage = count / 4;

            int subjectsToShow;
            if (page < neededPage)
                subjectsToShow = 4;
            else if (page == neededPage && count % 4 == 0)
                subjectsToShow = 4;
            else //(page == neededPage)
                subjectsToShow = count % 4;

            if (subjectsToShow == 4)
            {
                lbl_Subject4.Text = CurrentUser.Subjects[page * 4 + 3].Name;
                lbl_Subject4.Show();
            }
            if (subjectsToShow >= 3)
            {
                lbl_Subject3.Text = CurrentUser.Subjects[page * 4 + 2].Name;
                lbl_Subject3.Show();
            }
            if (subjectsToShow >= 2)
            {
                lbl_Subject2.Text = CurrentUser.Subjects[page * 4 + 1].Name;
                lbl_Subject2.Show();
            }
            if (subjectsToShow >= 1)
            {
                lbl_Subject1.Text = CurrentUser.Subjects[page * 4 + 0].Name;
                lbl_Subject1.Show();
            }

        }

        private void lbl_Subject1_Click(object sender, EventArgs e)
        {
            OpenSubjectAndHide(0);
        }

        private void lbl_Subject2_Click(object sender, EventArgs e)
        {
            OpenSubjectAndHide(1);
        }

        private void lbl_Subject3_Click(object sender, EventArgs e)
        {
            OpenSubjectAndHide(2);
        }

        private void lbl_Subject4_Click(object sender, EventArgs e)
        {
            OpenSubjectAndHide(3);
        }

        private void OpenSubjectAndHide(int offset)
        {
            Form4 form4 = new Form4(CurrentUser, CurrentUser.Subjects[CurrentPage * 4 + offset]);
            form4.Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            HideOrShow(SubjectCount, ++CurrentPage);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            HideOrShow(SubjectCount, --CurrentPage);
        }

        private void btn_AddSubject_Click(object sender, EventArgs e)
        {
            if (box_AddSubjectName.Text.Length > 0 && box_AddSubjectName.Text.Length < 16)
            {
                CurrentUser.Subjects.Add(new Subject(box_AddSubjectName.Text));
                SubjectCount = CurrentUser.Subjects.Count(); //Need to refresh the SubjectCount
                CurrentPage = SubjectCount / 4;
                if (SubjectCount % 4 == 0) CurrentPage--;
                box_AddSubjectName.Text = string.Empty;
                HideOrShow(SubjectCount, CurrentPage);
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            WordCardSystem.JsonOutput();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cms_DeleteEdit_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lbl_Test_Click(object sender, EventArgs e)
        {

        }
        private void lbl_WelcomeUser_Click(object sender, EventArgs e)
        {

        }

        private void lbl_AddSubject_Click(object sender, EventArgs e)
        {

        }

        private void box_AddSubjectName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
