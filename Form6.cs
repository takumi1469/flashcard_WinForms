using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Takumi_Saito_Project
{
    public partial class Form6 : Form //Screen to edit the cards or review in four different ways
    {
        private bool ShowRight { get; set; } = true; //To be used in Review mode (false) to hide right page
        private int Mode { get; }
        private User CurrentUser { get; }
        private Subject CurrentSubject { get; }
        private Deck CurrentDeck { get; set; }
        private Deck OriginalDeck { get;}
        private Deck ShuffledDeck { get; set; }
        private int CurrentPage { get; set; } = 0; //Determines which card to show
        private ToolStripMenuItem menuItemDelete;

        public Form6(User user, Subject subject, Deck deck, int mode)
        {
            InitializeComponent();
            CurrentUser = user;
            CurrentSubject = subject;
            CurrentDeck = deck; //The deck initially passed by previous Forms. All edit/review activities are done on CurrentDeck

            OriginalDeck = new Deck(CurrentDeck.Name);
            OriginalDeck.Cards = CurrentDeck.Cards.ToList(); //Copy the initial deck and hold it as original
            ShuffledDeck = new Deck(CurrentDeck.Name);
            ShuffledDeck.Cards = CurrentDeck.Cards.ToList(); //Copy the initial deck, to be shuffled later
            Mode = mode;
            if (mode != 1)
                ShowRight = false;
            lbl_EscapeInstructionRight.Hide();
            lbl_EscapeInstructionLeft.Hide();
            lbl_RightPage.MouseDoubleClick += lbl_RightPage_MouseDoubleClick;
            lbl_LeftPage.MouseDoubleClick += lbl_LeftPage_MouseDoubleClick;
            tbx_RightPageEdit.KeyDown += tbx_RightPageEdit_KeyDown;
            tbx_LeftPageEdit.KeyDown += tbx_LeftPageEdit_KeyDown;
            tbx_TargetPage.KeyDown += tbx_TargetPage_KeyDown;
            this.KeyDown += Form6_KeyDown;
            this.KeyPreview = true;
            btn_BackToDeckMenu.PreviewKeyDown += btn_BackToDeckMenu_PreviewKeyDown;
            btn_PreviousPage.PreviewKeyDown += btn_PreviousPage_PreviewKeyDown;
            btn_NextPage.PreviewKeyDown += btn_NextPage_PreviewKeyDown;
            btn_SaveToFile.PreviewKeyDown += btn_SaveToFile_PreviewKeyDown;
            this.FormClosed += Form6_FormClosed;
            this.Click += Form6_Click;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            InitializeContextMenu();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - Program.HorizontalOffset,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - Program.VerticalOffset);

            lbl_CurrentDeck.Text = "Subject: " + CurrentSubject.Name + "  Deck: " + CurrentDeck.Name;

            if (Mode > 1)　//User should be able to save data to file in Edit mode (Mode==1) only
                btn_SaveToFile.Visible = false;
            if (Mode > 3) //Mode 4 and 5 are for reviewing in shuffled order
            {
                ShuffledDeck.Shuffle(); //Shuffle the ShuffledDeck, which was just a copy of initial deck
                CurrentDeck = ShuffledDeck; //Assign ShuffledDeck as the CurrentDeck
            }
            RefreshPage();
        }
        private void Form6_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //context menu for deleting cards, written with help of ChatGPT
        private void InitializeContextMenu()
        {
            if (Mode == 1)
            {
                cms_Delete = new ContextMenuStrip();
                menuItemDelete = new ToolStripMenuItem("Delete this card");
                menuItemDelete.Click += MenuItemDelete_Click;
                cms_Delete.Items.Add(menuItemDelete);
                lbl_RightPage.ContextMenuStrip = cms_Delete;
                tbx_RightPageEdit.ContextMenuStrip = cms_Delete;
            }
        }
        private void MenuItemDelete_Click(object sender, EventArgs e) //Delete cards
        {
            if (CurrentPage != CurrentDeck.Cards.Count()) //Not at last page
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this card?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Card deleted :)");
                    CurrentDeck.Cards.RemoveAt(CurrentPage);
                    RefreshPage();
                }
                else
                    MessageBox.Show("OK :)");
            }
            else // at last page (which is the new blank page)
                MessageBox.Show("New page cannot be deleted");

            cms_Delete.Close();
        }

        private void Form6_Click(object? sender, EventArgs e) //Finish editing cards
        {
            if (tbx_RightPageEdit.Visible == true)
                SaveRightPageEdit();
            if (tbx_LeftPageEdit.Visible == true)
                SaveLeftPageEdit();
        }

        private void tbx_LeftPageEdit_KeyDown(object sender, KeyEventArgs e) //Finish editing left page
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                SaveLeftPageEdit();
            }
        }
        private void tbx_RightPageEdit_KeyDown(object sender, KeyEventArgs e) //Finish editing right page
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                SaveRightPageEdit();
            }
        }
        private void SaveLeftPageEdit()
        {
            //Empty the Meanings first because tbx_LeftPageEdit will be displaying the existing meanings already
            CurrentDeck.Cards[CurrentPage - 1].Meanings.Clear();

            string allMeanings = tbx_LeftPageEdit.Text;
            int start = 0;
            int end = 0;
            while (end < (allMeanings.Length))
            {
                while ((allMeanings[end] != '\n') && (end < (allMeanings.Length - 1)))
                {
                    end++;
                }//end stops at the index of '\n'

                if (allMeanings[end] == '\n')
                    CurrentDeck.Cards[CurrentPage - 1].Meanings.Add(new Meaning(allMeanings[start..end]));
                else
                    CurrentDeck.Cards[CurrentPage - 1].Meanings.Add(new Meaning(allMeanings[start..(end + 1)]));
                end++;
                start = end;
            }
            tbx_LeftPageEdit.Visible = false;
            lbl_EscapeInstructionLeft.Hide();
            btn_NextPage.Show();
            btn_PreviousPage.Show();
            RefreshPage();
        }
        private void SaveRightPageEdit()
        {
            if (CurrentPage != CurrentDeck.Cards.Count())//Page is not last, editing
            {
                if (tbx_RightPageEdit.Text.Length > 0)
                    CurrentDeck.Cards[CurrentPage].Word = tbx_RightPageEdit.Text;
                else
                    CurrentDeck.Cards[CurrentPage].Word = "(blank)";
            }

            else //Page is last, adding
            {
                if (tbx_RightPageEdit.Text.Length > 0)
                    CurrentDeck.Cards.Add(new Card(tbx_RightPageEdit.Text));
            }

            tbx_RightPageEdit.Visible = false;
            lbl_EscapeInstructionRight.Hide();
            btn_NextPage.Show();
            btn_PreviousPage.Show();
            RefreshPage();
        }

        private void GoPreviousPage()
        {
            if (CurrentPage != 0)
            {
                CurrentPage--;
                RefreshPage();
            }
        }

        private void GoNextPage()
        {
            if (Mode == 1)
            {
                if (CurrentPage != CurrentDeck.Cards.Count())
                {
                    CurrentPage++;
                    RefreshPage();
                }
            }
            else
            {
                if (CurrentPage + 1 != CurrentDeck.Cards.Count())
                {
                    CurrentPage++;
                    RefreshPage();
                }
            }
        }

        //These "PreviewKeyDown"s are for not letting the buttons to take focus by left key and right key to move pages
        private void btn_BackToDeckMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.IsInputKey = true;
        }
        private void btn_PreviousPage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.IsInputKey = true;
        }
        private void btn_NextPage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.IsInputKey = true;
        }

        private void btn_SaveToFile_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                e.IsInputKey = true;
        }


        private void tbx_TargetPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//input validation for moving to user-specified page
                if (int.TryParse(tbx_TargetPage.Text, out int targetPage)) //user input is integer?
                {
                    if (targetPage <= CurrentDeck.Cards.Count() && targetPage > 0) //user input page actually exists?
                    {
                        CurrentPage = targetPage - 1;
                        RefreshPage();
                    }
                }
            }
        }

        public void RefreshPage()
        {
            switch (Mode)
            {
                case 1: RefreshPage1(); break; // Edit cards
                case 2: RefreshPage2(); break; // Word to Meaning in Normal Order
                case 3: RefreshPage3(); break; // Meaning to Word in Normal Order
                case 4: RefreshPage2(); break; // Word to Meaning in Shuffled Order
                case 5: RefreshPage3(); break; // Meaning to Word in Shuffled Order
            }
        }


        public void RefreshPage1() //Mode to edit cards
        {
            tbx_LeftPageEdit.Hide();
            tbx_RightPageEdit.Hide();

            //to show at the bottom "current page/total pages"
            if (CurrentPage == 0 && CurrentDeck.Cards.Count() == 0)
                lbl_CurrentPage.Text = string.Empty;
            else
                lbl_CurrentPage.Text = (CurrentPage + 1).ToString() + "/" + (CurrentDeck.Cards.Count() + 1).ToString();

            //hide left page and Previous Page button at the start
            if (CurrentPage == 0)
            {
                lbl_LeftPage.Hide();
                btn_PreviousPage.Hide();
            }
            else
            {
                lbl_LeftPage.Show();
                btn_PreviousPage.Show();
            }

            //What to show on right page (Word)
            if (CurrentPage != CurrentDeck.Cards.Count()) // Page is not last
            {
                lbl_RightPage.Text = CurrentDeck.Cards[CurrentPage].Word;
                btn_NextPage.Show();
            }
            else //Page is last
            {
                lbl_RightPage.Text = "Double click to add word";
                btn_NextPage.Hide();
            }

            //what to show on left page (Meanings)
            if (CurrentPage > 0) //page is not first
            {
                if (CurrentDeck.Cards[CurrentPage - 1].Meanings.Count() != 0)
                    ShowMeanings(true);
                else //The word has no meanings saved
                {
                    lbl_LeftPage.Text = "Double click to add meanings";
                }
            }
        }

        public void RefreshPage2() //Mode to review in "guess meaning from word" fashion
        {
            tbx_LeftPageEdit.Hide();
            tbx_RightPageEdit.Hide();

            if (ShowRight == false)
                btn_NextPage.Text = "Show meanings!";
            else
                btn_NextPage.Text = "Next";

            //to show at the bottom "current page/total pages"
            lbl_CurrentPage.Text = (CurrentPage + 1).ToString() + "/" + (CurrentDeck.Cards.Count()).ToString();

            //hide Previous Page button at the start
            if (CurrentPage == 0)
                btn_PreviousPage.Hide();
            else
                btn_PreviousPage.Show();

            //hide Next Page button at the end
            if (CurrentPage + 1 == CurrentDeck.Cards.Count() && ShowRight == true)
                btn_NextPage.Hide();
            else
                btn_NextPage.Show();


            //what to show on left page (Word)
            lbl_LeftPage.Text = CurrentDeck.Cards[CurrentPage].Word;

            //What to show on right page (Meanings)
            if (ShowRight == false) //Right side will be hidden for review
                lbl_RightPage.Text = "?";
            else
            {
                if (CurrentDeck.Cards[CurrentPage].Meanings.Count() != 0)
                    ShowMeanings(false);
                else //The word has no meanings saved
                    lbl_RightPage.Text = "No meanings saved";
            }
        }

        public void RefreshPage3() //Mode to review in "guess word from meaning" fashion
        {
            tbx_LeftPageEdit.Hide();
            tbx_RightPageEdit.Hide();

            if (ShowRight == false)
                btn_NextPage.Text = "Show word!";
            else
                btn_NextPage.Text = "Next";

            //to show at the bottom "current page/total pages"
            lbl_CurrentPage.Text = (CurrentPage + 1).ToString() + "/" + (CurrentDeck.Cards.Count()).ToString();

            //hide Previous Page button at the start
            if (CurrentPage == 0)
                btn_PreviousPage.Hide();
            else
                btn_PreviousPage.Show();

            //hide Next Page button at the end
            if (CurrentPage + 1 == CurrentDeck.Cards.Count() && ShowRight == true)
                btn_NextPage.Hide();
            else
                btn_NextPage.Show();

            //what to show on left page (Meaning)
            if (CurrentDeck.Cards[CurrentPage].Meanings.Count() != 0)
                ShowMeanings(true);
            else //The word has no meanings saved
                lbl_LeftPage.Text = "No meanings saved";

            //What to show on right page (Word)
            if (ShowRight == false) //Right side will be hidden for review
                lbl_RightPage.Text = "?";
            else
                lbl_RightPage.Text = CurrentDeck.Cards[CurrentPage].Word;
        }


        private void ShowMeanings(bool left)
        {
            int offset = 0;
            if (Mode == 1)
                offset = 1;
            string meanings = string.Empty;
            int n = 1; //nth meaning of the word
            foreach (Meaning meaning in CurrentDeck.Cards[CurrentPage - offset].Meanings)
            {
                meanings += Convert.ToString(n) + ". " + meaning.Translation + "\n";
                n++;
            }
            meanings = meanings.Substring(0, meanings.Length - 1); //deleting the last \n
            if (left == true)
            {
                lbl_LeftPage.Text = meanings;
                lbl_LeftPage.Show();
            }
            else
            {
                lbl_RightPage.Text = meanings;
                lbl_RightPage.Show();
            }
        }

        private void lbl_RightPage_MouseDoubleClick(object sender, EventArgs e)
        {//to be used in Mode1 only, allows the user to add word or edit existing words
            if (Mode == 1)
            {
                lbl_EscapeInstructionRight.Show();

                if (CurrentPage != CurrentDeck.Cards.Count()) //not the last page, populate text box with existing word
                    tbx_RightPageEdit.Text = lbl_RightPage.Text;
                else //last page, the text box shall be empty
                    tbx_RightPageEdit.Text = string.Empty;

                tbx_RightPageEdit.Show();
                tbx_RightPageEdit.Focus();
                tbx_RightPageEdit.SelectionStart = tbx_RightPageEdit.Text.Length;
                btn_NextPage.Hide();
                btn_PreviousPage.Hide();
            }
        }

        private void lbl_LeftPage_MouseDoubleClick(object sender, EventArgs e)
        {//to be used in Mode1 only, allows the user to add or edit meanings
            if (Mode == 1)
            {
                lbl_EscapeInstructionLeft.Show();

                if (CurrentDeck.Cards[CurrentPage - 1].Meanings.Count() > 0) //Some meanings registered
                {
                    string meanings = string.Empty;
                    foreach (Meaning meaning in CurrentDeck.Cards[CurrentPage - 1].Meanings)
                    {
                        meanings += meaning.Translation + "\n";
                    }
                    tbx_LeftPageEdit.Text = meanings.Substring(0, meanings.Length - 1);
                    tbx_LeftPageEdit.Show();
                }
                else
                    tbx_LeftPageEdit.Text = string.Empty; //No meanings registered

                tbx_LeftPageEdit.Show();
                tbx_LeftPageEdit.Focus();
                tbx_LeftPageEdit.SelectionStart = tbx_LeftPageEdit.Text.Length;
                btn_NextPage.Hide();
                btn_PreviousPage.Hide();
            }
        }


        private void btn_BackToDeckMenu_Click(object sender, EventArgs e)
        {
            if (Mode > 3) //user was reviewing in shuffled mode
                CurrentDeck = OriginalDeck; //put back the shuffled deck to original order
            Form5 form5 = new Form5(CurrentUser, CurrentSubject, CurrentDeck);
            form5.Show();
            this.Hide();
        }

        private void btn_PreviousPage_Click(object sender, EventArgs e)
        {
            ShowRight = false;
            GoPreviousPage();
        }
        private void btn_NextPage_Click(object sender, EventArgs e)
        {
            ActionOfNextStep();
        }

        private void ActionOfNextStep()
        {
            if (Mode == 1)
                GoNextPage();
            else
            {
                if (ShowRight == true)
                {
                    ShowRight = false;
                    GoNextPage();
                }
                else
                {
                    ShowRight = true;
                    RefreshPage();
                }
            }
        }

        private void Form6_KeyDown(object? sender, KeyEventArgs e)
        {
            if(lbl_EscapeInstructionLeft.Visible==false && lbl_EscapeInstructionRight.Visible == false)
            {//While editing cards, left/right key should not be used for moving to different page
                if (e.KeyCode == Keys.Right)
                    ActionOfNextStep();

                if (e.KeyCode == Keys.Left)
                    GoPreviousPage();
            }
        }

        private void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            WordCardSystem.JsonOutput();
        }

        private void tbx_TargetPage_TextChanged(object sender, EventArgs e)
        {
        }

        private void cms_Delete_Opening(object sender, CancelEventArgs e)
        {

        }
        private void lbl_CurrentDeck_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CurrentPage_Click(object sender, EventArgs e)
        {
        }

        private void tbx_RightPageEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_LeftPageEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_EscapeInstructionRight_Click(object sender, EventArgs e)
        {
        }

        private void lbl_EscapeInstructionLeft_Click(object sender, EventArgs e)
        {

        }
        private void lbl_RightPage_Click(object sender, EventArgs e)
        {
        }

        private void lbl_LeftPage_Click(object sender, EventArgs e)
        {
        }


    }
}
