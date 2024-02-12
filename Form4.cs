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
    public partial class Form4 : Form //Card deck menu screen. Maximum four decks are displayed at once. 
                                      //Almost identical to Form3, so could be integrated to Form3.
    {
        private User CurrentUser { get; }
        private Subject CurrentSubject { get;  }
        private int DeckCount { get; set; }
        private int CurrentPage { get; set; } = 0;

        private Label TemporaryLabel { get; set; }

        private TextBox inputTextBox;
        private ToolStripMenuItem menuItemEdit;
        private ToolStripMenuItem menuItemDelete;

        public Form4(User user, Subject subject)
        {
            InitializeComponent();
            InitializeContextMenu();

            CurrentUser = user;
            CurrentSubject = subject;
            TemporaryLabel = new Label();
            DeckCount = CurrentSubject.Decks.Count();

            this.FormClosed += Form4_FormClosed;
        }

        private void Form4_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbl_CurrentSubject.Text = "Subject: " + CurrentSubject.Name;
            HideOrShow(DeckCount, 0);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - Program.HorizontalOffset, 
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - Program.VerticalOffset);
        }

        //context menu for editing/deleting decks, written with help of ChatGPT
        private void InitializeContextMenu()
        {
            cms_DeleteEdit = new ContextMenuStrip();

            menuItemEdit = new ToolStripMenuItem("Edit deck (enter new name)");
            menuItemDelete = new ToolStripMenuItem("Delete deck");

            inputTextBox = new TextBox();
            inputTextBox.Text = " ";
            ToolStripControlHost textBoxHost = new ToolStripControlHost(inputTextBox);

            menuItemDelete.Click += MenuItemDelete_Click;

            cms_DeleteEdit.Items.Add(menuItemEdit);
            cms_DeleteEdit.Items.Add(menuItemDelete);

            menuItemEdit.DropDownItems.Add(textBoxHost);
            menuItemEdit.DropDownItems.Add("Change to this name", null, EditFinalize);

            textBoxHost.Enter += TextBoxHost_Enter;

            lbl_Deck1.ContextMenuStrip = cms_DeleteEdit;
            lbl_Deck2.ContextMenuStrip = cms_DeleteEdit;
            lbl_Deck3.ContextMenuStrip = cms_DeleteEdit;
            lbl_Deck4.ContextMenuStrip = cms_DeleteEdit;

            cms_DeleteEdit.Opening += Cms_DeleteEdit_Opening;
        }

        private void Cms_DeleteEdit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Control c = cms_DeleteEdit.SourceControl as Label;
            TemporaryLabel = c as Label;
            inputTextBox.Text = c.Text;
        }
        private void TextBoxHost_Enter(object sender, EventArgs e)
        {
            inputTextBox.ReadOnly = false;
            inputTextBox.Focus();
        }

        private void EditFinalize(object sender, EventArgs e)
        {
            if (TemporaryLabel == lbl_Deck1)
                CurrentSubject.Decks[CurrentPage * 4].Name = inputTextBox.Text;
            if (TemporaryLabel == lbl_Deck2)
                CurrentSubject.Decks[CurrentPage * 4 + 1].Name = inputTextBox.Text;
            if (TemporaryLabel == lbl_Deck3)
                CurrentSubject.Decks[CurrentPage * 4 + 2].Name = inputTextBox.Text;
            if (TemporaryLabel == lbl_Deck4)
                CurrentSubject.Decks[CurrentPage * 4 + 3].Name = inputTextBox.Text;

            HideOrShow(DeckCount, CurrentPage);
            cms_DeleteEdit.Close();
        }

        private void MenuItemDelete_Click(object sender, EventArgs e) //Delete deck
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this deck?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (TemporaryLabel == lbl_Deck1)
                    CurrentSubject.Decks.RemoveAt(CurrentPage * 4);
                if (TemporaryLabel == lbl_Deck2)
                    CurrentSubject.Decks.RemoveAt(CurrentPage * 4 + 1);
                if (TemporaryLabel == lbl_Deck3)
                    CurrentSubject.Decks.RemoveAt(CurrentPage * 4 + 2);
                if (TemporaryLabel == lbl_Deck4)
                    CurrentSubject.Decks.RemoveAt(CurrentPage * 4 + 3);
                MessageBox.Show("Deck deleted :)");
                DeckCount = CurrentSubject.Decks.Count();
            }
            else
            {
                MessageBox.Show("OK :)");
            }
            HideOrShow(DeckCount, CurrentPage);
            cms_DeleteEdit.Close();
        }
        private void HideOrShow(int count, int page)
        {
            lbl_Deck1.Hide();
            lbl_Deck2.Hide();
            lbl_Deck3.Hide();
            lbl_Deck4.Hide();
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
            else
                subjectsToShow = count % 4;

            if (subjectsToShow == 4)
            {
                lbl_Deck4.Text = CurrentSubject.Decks[page * 4 + 3].Name;
                lbl_Deck4.Show();
            }
            if (subjectsToShow >= 3)
            {
                lbl_Deck3.Text = CurrentSubject.Decks[page * 4 + 2].Name;
                lbl_Deck3.Show();
            }
            if (subjectsToShow >= 2)
            {
                lbl_Deck2.Text = CurrentSubject.Decks[page * 4 + 1].Name;
                lbl_Deck2.Show();
            }
            if (subjectsToShow >= 1)
            {
                lbl_Deck1.Text = CurrentSubject.Decks[page * 4 + 0].Name;
                lbl_Deck1.Show();
            }

        }

        private void lbl_Deck1_Click(object sender, EventArgs e)
        {
            OpenDeckAndHide(0);
        }

        private void lbl_Deck2_Click(object sender, EventArgs e)
        {
            OpenDeckAndHide(1);
        }

        private void lbl_Deck3_Click(object sender, EventArgs e)
        {
            OpenDeckAndHide(2);
        }

        private void lbl_Deck4_Click(object sender, EventArgs e)
        {
            OpenDeckAndHide(3);
        }

        private void OpenDeckAndHide(int offset)
        {
            Form5 form5 = new Form5(CurrentUser, CurrentSubject, CurrentSubject.Decks[CurrentPage * 4 + offset]);
            form5.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            HideOrShow(DeckCount, --CurrentPage);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            HideOrShow(DeckCount, ++CurrentPage);
        }

        private void btn_AddDeck_Click(object sender, EventArgs e)
        {
            if (box_AddDeckName.Text.Length > 0 && box_AddDeckName.Text.Length < 16)
            {
                CurrentSubject.Decks.Add(new Deck(box_AddDeckName.Text));
                DeckCount = CurrentSubject.Decks.Count(); //Need to refresh the SubjectCount
                CurrentPage = DeckCount / 4;
                if (DeckCount % 4 == 0) CurrentPage--;
                box_AddDeckName.Text = string.Empty;
                HideOrShow(DeckCount, CurrentPage);
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_GoBackToSubject_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(CurrentUser);
            form3.Show();
            this.Hide();
        }

        private void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            WordCardSystem.JsonOutput();
        }

        private void lbl_ChooseDeck_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DeckNameInstruction_Click(object sender, EventArgs e)
        {

        }
        private void lbl_CurrentSubject_Click(object sender, EventArgs e)
        {

        }
        private void box_AddDeckName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
