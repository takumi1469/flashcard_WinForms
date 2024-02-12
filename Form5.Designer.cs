namespace Takumi_Saito_Project
{
    partial class Form5
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
            this.lbl_DeckMenuTitle = new System.Windows.Forms.Label();
            this.lbl_CurrentDeck = new System.Windows.Forms.Label();
            this.lbl_EditCards = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_GoBackToSubject = new System.Windows.Forms.Button();
            this.btn_GoBackToDeck = new System.Windows.Forms.Button();
            this.lbl_NormalOrder = new System.Windows.Forms.Label();
            this.lbl_NormalWordToMeaning = new System.Windows.Forms.Label();
            this.lbl_NormalMeaningToWord = new System.Windows.Forms.Label();
            this.lbl_ShuffledOrder = new System.Windows.Forms.Label();
            this.lbl_ShuffleWordToMeaning = new System.Windows.Forms.Label();
            this.lbl_ShuffleMeaningToWord = new System.Windows.Forms.Label();
            this.lbl_PleaseChooseMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_DeckMenuTitle
            // 
            this.lbl_DeckMenuTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_DeckMenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DeckMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_DeckMenuTitle.Location = new System.Drawing.Point(22, 20);
            this.lbl_DeckMenuTitle.Name = "lbl_DeckMenuTitle";
            this.lbl_DeckMenuTitle.Size = new System.Drawing.Size(114, 95);
            this.lbl_DeckMenuTitle.TabIndex = 1;
            this.lbl_DeckMenuTitle.Text = "Deck Menu";
            this.lbl_DeckMenuTitle.Click += new System.EventHandler(this.lbl_DeckMenuTitle_Click);
            // 
            // lbl_CurrentDeck
            // 
            this.lbl_CurrentDeck.AutoSize = true;
            this.lbl_CurrentDeck.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CurrentDeck.Location = new System.Drawing.Point(280, 9);
            this.lbl_CurrentDeck.Name = "lbl_CurrentDeck";
            this.lbl_CurrentDeck.Size = new System.Drawing.Size(234, 35);
            this.lbl_CurrentDeck.TabIndex = 16;
            this.lbl_CurrentDeck.Text = "This is Current Deck";
            this.lbl_CurrentDeck.Click += new System.EventHandler(this.lbl_CurrentDeck_Click);
            // 
            // lbl_EditCards
            // 
            this.lbl_EditCards.AutoSize = true;
            this.lbl_EditCards.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_EditCards.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EditCards.Location = new System.Drawing.Point(179, 93);
            this.lbl_EditCards.Name = "lbl_EditCards";
            this.lbl_EditCards.Size = new System.Drawing.Size(295, 73);
            this.lbl_EditCards.TabIndex = 17;
            this.lbl_EditCards.Text = "Edit Cards";
            this.lbl_EditCards.Click += new System.EventHandler(this.lbl_EditCards_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(36, 125);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(83, 30);
            this.btn_LogOut.TabIndex = 18;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_GoBackToSubject
            // 
            this.btn_GoBackToSubject.Location = new System.Drawing.Point(36, 161);
            this.btn_GoBackToSubject.Name = "btn_GoBackToSubject";
            this.btn_GoBackToSubject.Size = new System.Drawing.Size(83, 53);
            this.btn_GoBackToSubject.TabIndex = 19;
            this.btn_GoBackToSubject.Text = "Back to Subjects";
            this.btn_GoBackToSubject.UseVisualStyleBackColor = true;
            this.btn_GoBackToSubject.Click += new System.EventHandler(this.btn_GoBackToSubject_Click);
            // 
            // btn_GoBackToDeck
            // 
            this.btn_GoBackToDeck.Location = new System.Drawing.Point(36, 220);
            this.btn_GoBackToDeck.Name = "btn_GoBackToDeck";
            this.btn_GoBackToDeck.Size = new System.Drawing.Size(83, 53);
            this.btn_GoBackToDeck.TabIndex = 20;
            this.btn_GoBackToDeck.Text = "Back to Decks";
            this.btn_GoBackToDeck.UseVisualStyleBackColor = true;
            this.btn_GoBackToDeck.Click += new System.EventHandler(this.btn_GoBackToDeck_Click);
            // 
            // lbl_NormalOrder
            // 
            this.lbl_NormalOrder.AutoSize = true;
            this.lbl_NormalOrder.Location = new System.Drawing.Point(179, 203);
            this.lbl_NormalOrder.Name = "lbl_NormalOrder";
            this.lbl_NormalOrder.Size = new System.Drawing.Size(168, 20);
            this.lbl_NormalOrder.TabIndex = 21;
            this.lbl_NormalOrder.Text = "Review in Normal Order";
            // 
            // lbl_NormalWordToMeaning
            // 
            this.lbl_NormalWordToMeaning.AutoSize = true;
            this.lbl_NormalWordToMeaning.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_NormalWordToMeaning.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NormalWordToMeaning.Location = new System.Drawing.Point(179, 245);
            this.lbl_NormalWordToMeaning.Name = "lbl_NormalWordToMeaning";
            this.lbl_NormalWordToMeaning.Size = new System.Drawing.Size(257, 42);
            this.lbl_NormalWordToMeaning.TabIndex = 22;
            this.lbl_NormalWordToMeaning.Text = "Word to Meaning";
            this.lbl_NormalWordToMeaning.Click += new System.EventHandler(this.lbl_NormalWordToMeaning_Click);
            // 
            // lbl_NormalMeaningToWord
            // 
            this.lbl_NormalMeaningToWord.AutoSize = true;
            this.lbl_NormalMeaningToWord.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_NormalMeaningToWord.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NormalMeaningToWord.Location = new System.Drawing.Point(485, 245);
            this.lbl_NormalMeaningToWord.Name = "lbl_NormalMeaningToWord";
            this.lbl_NormalMeaningToWord.Size = new System.Drawing.Size(257, 42);
            this.lbl_NormalMeaningToWord.TabIndex = 23;
            this.lbl_NormalMeaningToWord.Text = "Meaning to Word";
            this.lbl_NormalMeaningToWord.Click += new System.EventHandler(this.lbl_NormalMeaningToWord_Click);
            // 
            // lbl_ShuffledOrder
            // 
            this.lbl_ShuffledOrder.AutoSize = true;
            this.lbl_ShuffledOrder.Location = new System.Drawing.Point(179, 322);
            this.lbl_ShuffledOrder.Name = "lbl_ShuffledOrder";
            this.lbl_ShuffledOrder.Size = new System.Drawing.Size(171, 20);
            this.lbl_ShuffledOrder.TabIndex = 24;
            this.lbl_ShuffledOrder.Text = "Review in Shuffled Order";
            // 
            // lbl_ShuffleWordToMeaning
            // 
            this.lbl_ShuffleWordToMeaning.AutoSize = true;
            this.lbl_ShuffleWordToMeaning.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_ShuffleWordToMeaning.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ShuffleWordToMeaning.Location = new System.Drawing.Point(179, 358);
            this.lbl_ShuffleWordToMeaning.Name = "lbl_ShuffleWordToMeaning";
            this.lbl_ShuffleWordToMeaning.Size = new System.Drawing.Size(257, 42);
            this.lbl_ShuffleWordToMeaning.TabIndex = 25;
            this.lbl_ShuffleWordToMeaning.Text = "Word to Meaning";
            this.lbl_ShuffleWordToMeaning.Click += new System.EventHandler(this.lbl_ShuffleWordToMeaning_Click);
            // 
            // lbl_ShuffleMeaningToWord
            // 
            this.lbl_ShuffleMeaningToWord.AutoSize = true;
            this.lbl_ShuffleMeaningToWord.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_ShuffleMeaningToWord.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ShuffleMeaningToWord.Location = new System.Drawing.Point(485, 358);
            this.lbl_ShuffleMeaningToWord.Name = "lbl_ShuffleMeaningToWord";
            this.lbl_ShuffleMeaningToWord.Size = new System.Drawing.Size(257, 42);
            this.lbl_ShuffleMeaningToWord.TabIndex = 26;
            this.lbl_ShuffleMeaningToWord.Text = "Meaning to Word";
            this.lbl_ShuffleMeaningToWord.Click += new System.EventHandler(this.lbl_ShuffleMeaningToWord_Click);
            // 
            // lbl_PleaseChooseMessage
            // 
            this.lbl_PleaseChooseMessage.AutoSize = true;
            this.lbl_PleaseChooseMessage.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PleaseChooseMessage.Location = new System.Drawing.Point(280, 44);
            this.lbl_PleaseChooseMessage.Name = "lbl_PleaseChooseMessage";
            this.lbl_PleaseChooseMessage.Size = new System.Drawing.Size(319, 35);
            this.lbl_PleaseChooseMessage.TabIndex = 27;
            this.lbl_PleaseChooseMessage.Text = "Please choose what to do :)";
            this.lbl_PleaseChooseMessage.Click += new System.EventHandler(this.lbl_PleaseChooseMessage_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PleaseChooseMessage);
            this.Controls.Add(this.lbl_ShuffleMeaningToWord);
            this.Controls.Add(this.lbl_ShuffleWordToMeaning);
            this.Controls.Add(this.lbl_ShuffledOrder);
            this.Controls.Add(this.lbl_NormalMeaningToWord);
            this.Controls.Add(this.lbl_NormalWordToMeaning);
            this.Controls.Add(this.lbl_NormalOrder);
            this.Controls.Add(this.btn_GoBackToDeck);
            this.Controls.Add(this.btn_GoBackToSubject);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.lbl_EditCards);
            this.Controls.Add(this.lbl_CurrentDeck);
            this.Controls.Add(this.lbl_DeckMenuTitle);
            this.Name = "Form5";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_DeckMenuTitle;
        private Label lbl_CurrentDeck;
        private Label lbl_EditCards;
        private Button btn_LogOut;
        private Button btn_GoBackToSubject;
        private Button btn_GoBackToDeck;
        private Label lbl_NormalOrder;
        private Label lbl_NormalWordToMeaning;
        private Label lbl_NormalMeaningToWord;
        private Label lbl_ShuffledOrder;
        private Label lbl_ShuffleWordToMeaning;
        private Label lbl_ShuffleMeaningToWord;
        private Label lbl_PleaseChooseMessage;
    }
}