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
    public partial class Form5 : Form //Menu to choose what to do in the deck: edit or review in several ways
    {
        private User CurrentUser { get; }
        private Subject CurrentSubject { get; }
        private Deck CurrentDeck { get; }

        public Form5(User user, Subject subject, Deck deck)
        {
            InitializeComponent();
            CurrentUser= user;
            CurrentSubject= subject;
            CurrentDeck= deck;
            this.FormClosed += Form5_FormClosed;
        }

        private void Form5_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lbl_CurrentDeck.Text = "Subject: " + CurrentSubject.Name + " Deck: " + CurrentDeck.Name;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - Program.HorizontalOffset, 
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - Program.VerticalOffset);

            if (CurrentDeck.Cards.Count() == 0) //No cards saved in the deck
            {
                lbl_NormalWordToMeaning.Hide();
                lbl_NormalMeaningToWord.Hide();
                lbl_ShuffleWordToMeaning.Hide();
                lbl_ShuffleMeaningToWord.Hide();
            }
            else
            {
                lbl_NormalWordToMeaning.Show();
                lbl_NormalMeaningToWord.Show();
                lbl_ShuffleWordToMeaning.Show();
                lbl_ShuffleMeaningToWord.Show();
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

        private void btn_GoBackToDeck_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(CurrentUser, CurrentSubject);
            form4.Show();
            this.Hide();
        }
        private void StartReviewAndHide(int mode)
        {//Form6 has multiple functionalities in one form, and the mode parameter dictates which functionality is used
            Form6 form6 = new Form6(CurrentUser, CurrentSubject, CurrentDeck, mode);
            form6.Show();
            this.Hide();
        }
        private void lbl_EditCards_Click(object sender, EventArgs e)
        {
            StartReviewAndHide(1);
        }

        private void lbl_NormalWordToMeaning_Click(object sender, EventArgs e)
        {
            StartReviewAndHide(2);
        }

        private void lbl_NormalMeaningToWord_Click(object sender, EventArgs e)
        {
            StartReviewAndHide(3);
        }

        private void lbl_ShuffleWordToMeaning_Click(object sender, EventArgs e)
        {
            StartReviewAndHide(4);
        }

        private void lbl_ShuffleMeaningToWord_Click(object sender, EventArgs e)
        {
            StartReviewAndHide(5);
        }
        private void lbl_DeckMenuTitle_Click(object sender, EventArgs e)
        {

        }
        private void lbl_CurrentDeck_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PleaseChooseMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
