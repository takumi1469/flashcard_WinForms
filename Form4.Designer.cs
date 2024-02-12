namespace Takumi_Saito_Project
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.lbl_ChooseDeckTitle = new System.Windows.Forms.Label();
            this.lbl_Deck1 = new System.Windows.Forms.Label();
            this.lbl_Deck4 = new System.Windows.Forms.Label();
            this.lbl_Deck2 = new System.Windows.Forms.Label();
            this.lbl_Deck3 = new System.Windows.Forms.Label();
            this.lbl_ChooseDeck = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_AddDeck = new System.Windows.Forms.Label();
            this.lbl_DeckNameInstruction = new System.Windows.Forms.Label();
            this.box_AddDeckName = new System.Windows.Forms.TextBox();
            this.btn_AddDeck = new System.Windows.Forms.Button();
            this.lbl_CurrentSubject = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_GoBackToSubject = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.cms_DeleteEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbl_ChooseDeckTitle
            // 
            this.lbl_ChooseDeckTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_ChooseDeckTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ChooseDeckTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_ChooseDeckTitle.Location = new System.Drawing.Point(26, 9);
            this.lbl_ChooseDeckTitle.Name = "lbl_ChooseDeckTitle";
            this.lbl_ChooseDeckTitle.Size = new System.Drawing.Size(135, 103);
            this.lbl_ChooseDeckTitle.TabIndex = 0;
            this.lbl_ChooseDeckTitle.Text = "Choose Deck";
            // 
            // lbl_Deck1
            // 
            this.lbl_Deck1.AutoSize = true;
            this.lbl_Deck1.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Deck1.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Deck1.Location = new System.Drawing.Point(138, 178);
            this.lbl_Deck1.Name = "lbl_Deck1";
            this.lbl_Deck1.Size = new System.Drawing.Size(181, 73);
            this.lbl_Deck1.TabIndex = 3;
            this.lbl_Deck1.Text = "deck 1";
            this.lbl_Deck1.Click += new System.EventHandler(this.lbl_Deck1_Click);
            // 
            // lbl_Deck4
            // 
            this.lbl_Deck4.AutoSize = true;
            this.lbl_Deck4.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Deck4.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Deck4.Location = new System.Drawing.Point(466, 289);
            this.lbl_Deck4.Name = "lbl_Deck4";
            this.lbl_Deck4.Size = new System.Drawing.Size(196, 73);
            this.lbl_Deck4.TabIndex = 4;
            this.lbl_Deck4.Text = "deck 4";
            this.lbl_Deck4.Click += new System.EventHandler(this.lbl_Deck4_Click);
            // 
            // lbl_Deck2
            // 
            this.lbl_Deck2.AutoSize = true;
            this.lbl_Deck2.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Deck2.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Deck2.Location = new System.Drawing.Point(466, 178);
            this.lbl_Deck2.Name = "lbl_Deck2";
            this.lbl_Deck2.Size = new System.Drawing.Size(196, 73);
            this.lbl_Deck2.TabIndex = 5;
            this.lbl_Deck2.Text = "deck 2";
            this.lbl_Deck2.Click += new System.EventHandler(this.lbl_Deck2_Click);
            // 
            // lbl_Deck3
            // 
            this.lbl_Deck3.AutoSize = true;
            this.lbl_Deck3.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Deck3.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Deck3.Location = new System.Drawing.Point(138, 289);
            this.lbl_Deck3.Name = "lbl_Deck3";
            this.lbl_Deck3.Size = new System.Drawing.Size(196, 73);
            this.lbl_Deck3.TabIndex = 6;
            this.lbl_Deck3.Text = "deck 3";
            this.lbl_Deck3.Click += new System.EventHandler(this.lbl_Deck3_Click);
            // 
            // lbl_ChooseDeck
            // 
            this.lbl_ChooseDeck.AutoSize = true;
            this.lbl_ChooseDeck.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ChooseDeck.Location = new System.Drawing.Point(228, 62);
            this.lbl_ChooseDeck.Name = "lbl_ChooseDeck";
            this.lbl_ChooseDeck.Size = new System.Drawing.Size(293, 35);
            this.lbl_ChooseDeck.TabIndex = 7;
            this.lbl_ChooseDeck.Text = "Please choose the deck :)";
            this.lbl_ChooseDeck.Click += new System.EventHandler(this.lbl_ChooseDeck_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(346, 118);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(102, 33);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(346, 394);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(102, 33);
            this.btn_Next.TabIndex = 10;
            this.btn_Next.Text = "More";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_AddDeck
            // 
            this.lbl_AddDeck.AutoSize = true;
            this.lbl_AddDeck.BackColor = System.Drawing.Color.Gold;
            this.lbl_AddDeck.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AddDeck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AddDeck.Location = new System.Drawing.Point(574, 18);
            this.lbl_AddDeck.Name = "lbl_AddDeck";
            this.lbl_AddDeck.Size = new System.Drawing.Size(187, 35);
            this.lbl_AddDeck.TabIndex = 11;
            this.lbl_AddDeck.Text = "Add decks here";
            // 
            // lbl_DeckNameInstruction
            // 
            this.lbl_DeckNameInstruction.AutoSize = true;
            this.lbl_DeckNameInstruction.Location = new System.Drawing.Point(574, 62);
            this.lbl_DeckNameInstruction.Name = "lbl_DeckNameInstruction";
            this.lbl_DeckNameInstruction.Size = new System.Drawing.Size(192, 20);
            this.lbl_DeckNameInstruction.TabIndex = 12;
            this.lbl_DeckNameInstruction.Text = "deck name(1-15 characters)";
            this.lbl_DeckNameInstruction.Click += new System.EventHandler(this.lbl_DeckNameInstruction_Click);
            // 
            // box_AddDeckName
            // 
            this.box_AddDeckName.Location = new System.Drawing.Point(574, 85);
            this.box_AddDeckName.Name = "box_AddDeckName";
            this.box_AddDeckName.Size = new System.Drawing.Size(214, 27);
            this.box_AddDeckName.TabIndex = 13;
            this.box_AddDeckName.TextChanged += new System.EventHandler(this.box_AddDeckName_TextChanged);
            // 
            // btn_AddDeck
            // 
            this.btn_AddDeck.Location = new System.Drawing.Point(631, 118);
            this.btn_AddDeck.Name = "btn_AddDeck";
            this.btn_AddDeck.Size = new System.Drawing.Size(94, 31);
            this.btn_AddDeck.TabIndex = 14;
            this.btn_AddDeck.Text = "Add!";
            this.btn_AddDeck.UseVisualStyleBackColor = true;
            this.btn_AddDeck.Click += new System.EventHandler(this.btn_AddDeck_Click);
            // 
            // lbl_CurrentSubject
            // 
            this.lbl_CurrentSubject.AutoSize = true;
            this.lbl_CurrentSubject.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CurrentSubject.Location = new System.Drawing.Point(228, 17);
            this.lbl_CurrentSubject.Name = "lbl_CurrentSubject";
            this.lbl_CurrentSubject.Size = new System.Drawing.Size(260, 35);
            this.lbl_CurrentSubject.TabIndex = 15;
            this.lbl_CurrentSubject.Text = "This is Current Subject";
            this.lbl_CurrentSubject.Click += new System.EventHandler(this.lbl_CurrentSubject_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(26, 121);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(83, 30);
            this.btn_LogOut.TabIndex = 16;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_GoBackToSubject
            // 
            this.btn_GoBackToSubject.Location = new System.Drawing.Point(26, 166);
            this.btn_GoBackToSubject.Name = "btn_GoBackToSubject";
            this.btn_GoBackToSubject.Size = new System.Drawing.Size(83, 53);
            this.btn_GoBackToSubject.TabIndex = 17;
            this.btn_GoBackToSubject.Text = "Back to Subjects";
            this.btn_GoBackToSubject.UseVisualStyleBackColor = true;
            this.btn_GoBackToSubject.Click += new System.EventHandler(this.btn_GoBackToSubject_Click);
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(683, 387);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(105, 40);
            this.btn_SaveToFile.TabIndex = 18;
            this.btn_SaveToFile.Text = "Save to File";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // cms_DeleteEdit
            // 
            this.cms_DeleteEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_DeleteEdit.Name = "cms_DeleteEdit";
            this.cms_DeleteEdit.Size = new System.Drawing.Size(211, 32);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.btn_GoBackToSubject);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.lbl_CurrentSubject);
            this.Controls.Add(this.btn_AddDeck);
            this.Controls.Add(this.box_AddDeckName);
            this.Controls.Add(this.lbl_DeckNameInstruction);
            this.Controls.Add(this.lbl_AddDeck);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_ChooseDeck);
            this.Controls.Add(this.lbl_Deck3);
            this.Controls.Add(this.lbl_Deck2);
            this.Controls.Add(this.lbl_Deck4);
            this.Controls.Add(this.lbl_Deck1);
            this.Controls.Add(this.lbl_ChooseDeckTitle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ChooseDeckTitle;
        private Label lbl_Deck1;
        private Label lbl_Deck4;
        private Label lbl_Deck2;
        private Label lbl_Deck3;
        private Label lbl_ChooseDeck;
        private Button btn_Back;
        private Button btn_Next;
        private Label lbl_AddDeck;
        private Label lbl_DeckNameInstruction;
        private TextBox box_AddDeckName;
        private Button btn_AddDeck;
        private Label lbl_CurrentSubject;
        private Button btn_LogOut;
        private Button btn_GoBackToSubject;
        private Button btn_SaveToFile;
        private ContextMenuStrip cms_DeleteEdit;
    }
}