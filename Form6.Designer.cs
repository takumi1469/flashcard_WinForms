namespace Takumi_Saito_Project
{
    partial class Form6
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
            this.lbl_CurrentDeck = new System.Windows.Forms.Label();
            this.lbl_CurrentPage = new System.Windows.Forms.Label();
            this.lbl_LeftPage = new System.Windows.Forms.Label();
            this.lbl_RightPage = new System.Windows.Forms.Label();
            this.btn_BackToDeckMenu = new System.Windows.Forms.Button();
            this.tbx_RightPageEdit = new System.Windows.Forms.TextBox();
            this.tbx_LeftPageEdit = new System.Windows.Forms.TextBox();
            this.lbl_EscapeInstructionRight = new System.Windows.Forms.Label();
            this.lbl_EscapeInstructionLeft = new System.Windows.Forms.Label();
            this.btn_PreviousPage = new System.Windows.Forms.Button();
            this.btn_NextPage = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.lbl_GoToInstruction = new System.Windows.Forms.Label();
            this.tbx_TargetPage = new System.Windows.Forms.TextBox();
            this.lbl_LeftRightKeyInstruction = new System.Windows.Forms.Label();
            this.cms_Delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbl_CurrentDeck
            // 
            this.lbl_CurrentDeck.AutoSize = true;
            this.lbl_CurrentDeck.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CurrentDeck.Location = new System.Drawing.Point(341, 9);
            this.lbl_CurrentDeck.Name = "lbl_CurrentDeck";
            this.lbl_CurrentDeck.Size = new System.Drawing.Size(217, 46);
            this.lbl_CurrentDeck.TabIndex = 0;
            this.lbl_CurrentDeck.Text = "Current Deck";
            this.lbl_CurrentDeck.Click += new System.EventHandler(this.lbl_CurrentDeck_Click);
            // 
            // lbl_CurrentPage
            // 
            this.lbl_CurrentPage.AutoSize = true;
            this.lbl_CurrentPage.Location = new System.Drawing.Point(506, 460);
            this.lbl_CurrentPage.Name = "lbl_CurrentPage";
            this.lbl_CurrentPage.Size = new System.Drawing.Size(94, 20);
            this.lbl_CurrentPage.TabIndex = 1;
            this.lbl_CurrentPage.Text = "Current Page";
            this.lbl_CurrentPage.Click += new System.EventHandler(this.lbl_CurrentPage_Click);
            // 
            // lbl_LeftPage
            // 
            this.lbl_LeftPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LeftPage.Font = new System.Drawing.Font("Yu Gothic UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_LeftPage.Location = new System.Drawing.Point(12, 117);
            this.lbl_LeftPage.Name = "lbl_LeftPage";
            this.lbl_LeftPage.Size = new System.Drawing.Size(468, 308);
            this.lbl_LeftPage.TabIndex = 2;
            this.lbl_LeftPage.Text = "Meanings";
            this.lbl_LeftPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_LeftPage.Click += new System.EventHandler(this.lbl_LeftPage_Click);
            // 
            // lbl_RightPage
            // 
            this.lbl_RightPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_RightPage.Font = new System.Drawing.Font("Yu Gothic UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_RightPage.Location = new System.Drawing.Point(504, 117);
            this.lbl_RightPage.Name = "lbl_RightPage";
            this.lbl_RightPage.Size = new System.Drawing.Size(488, 308);
            this.lbl_RightPage.TabIndex = 3;
            this.lbl_RightPage.Text = "Word";
            this.lbl_RightPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_RightPage.Click += new System.EventHandler(this.lbl_RightPage_Click);
            // 
            // btn_BackToDeckMenu
            // 
            this.btn_BackToDeckMenu.Location = new System.Drawing.Point(12, 12);
            this.btn_BackToDeckMenu.Name = "btn_BackToDeckMenu";
            this.btn_BackToDeckMenu.Size = new System.Drawing.Size(156, 39);
            this.btn_BackToDeckMenu.TabIndex = 4;
            this.btn_BackToDeckMenu.Text = "Back to Deck Menu";
            this.btn_BackToDeckMenu.UseVisualStyleBackColor = true;
            this.btn_BackToDeckMenu.Click += new System.EventHandler(this.btn_BackToDeckMenu_Click);
            // 
            // tbx_RightPageEdit
            // 
            this.tbx_RightPageEdit.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_RightPageEdit.Location = new System.Drawing.Point(525, 134);
            this.tbx_RightPageEdit.Multiline = true;
            this.tbx_RightPageEdit.Name = "tbx_RightPageEdit";
            this.tbx_RightPageEdit.Size = new System.Drawing.Size(447, 271);
            this.tbx_RightPageEdit.TabIndex = 6;
            this.tbx_RightPageEdit.Text = "(to edit word)";
            this.tbx_RightPageEdit.TextChanged += new System.EventHandler(this.tbx_RightPageEdit_TextChanged);
            // 
            // tbx_LeftPageEdit
            // 
            this.tbx_LeftPageEdit.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_LeftPageEdit.Location = new System.Drawing.Point(32, 134);
            this.tbx_LeftPageEdit.Multiline = true;
            this.tbx_LeftPageEdit.Name = "tbx_LeftPageEdit";
            this.tbx_LeftPageEdit.Size = new System.Drawing.Size(447, 271);
            this.tbx_LeftPageEdit.TabIndex = 7;
            this.tbx_LeftPageEdit.Text = "(to edit meaning)";
            this.tbx_LeftPageEdit.TextChanged += new System.EventHandler(this.tbx_LeftPageEdit_TextChanged);
            // 
            // lbl_EscapeInstructionRight
            // 
            this.lbl_EscapeInstructionRight.AutoSize = true;
            this.lbl_EscapeInstructionRight.Location = new System.Drawing.Point(789, 84);
            this.lbl_EscapeInstructionRight.Name = "lbl_EscapeInstructionRight";
            this.lbl_EscapeInstructionRight.Size = new System.Drawing.Size(203, 20);
            this.lbl_EscapeInstructionRight.TabIndex = 8;
            this.lbl_EscapeInstructionRight.Text = "Press Esc key to finish editing.";
            this.lbl_EscapeInstructionRight.Click += new System.EventHandler(this.lbl_EscapeInstructionRight_Click);
            // 
            // lbl_EscapeInstructionLeft
            // 
            this.lbl_EscapeInstructionLeft.Location = new System.Drawing.Point(12, 68);
            this.lbl_EscapeInstructionLeft.Name = "lbl_EscapeInstructionLeft";
            this.lbl_EscapeInstructionLeft.Size = new System.Drawing.Size(262, 49);
            this.lbl_EscapeInstructionLeft.TabIndex = 9;
            this.lbl_EscapeInstructionLeft.Text = "Press Esc key to finish editing. Separate meanings by line breaks.";
            this.lbl_EscapeInstructionLeft.Click += new System.EventHandler(this.lbl_EscapeInstructionLeft_Click);
            // 
            // btn_PreviousPage
            // 
            this.btn_PreviousPage.Location = new System.Drawing.Point(355, 77);
            this.btn_PreviousPage.Name = "btn_PreviousPage";
            this.btn_PreviousPage.Size = new System.Drawing.Size(124, 34);
            this.btn_PreviousPage.TabIndex = 10;
            this.btn_PreviousPage.Text = "Previous Page";
            this.btn_PreviousPage.UseVisualStyleBackColor = true;
            this.btn_PreviousPage.Click += new System.EventHandler(this.btn_PreviousPage_Click);
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.AutoSize = true;
            this.btn_NextPage.Location = new System.Drawing.Point(506, 78);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(94, 33);
            this.btn_NextPage.TabIndex = 11;
            this.btn_NextPage.Text = "Next Page";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_NextPage_Click);
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(861, 442);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(131, 48);
            this.btn_SaveToFile.TabIndex = 12;
            this.btn_SaveToFile.Text = "Save to File";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // lbl_GoToInstruction
            // 
            this.lbl_GoToInstruction.AutoSize = true;
            this.lbl_GoToInstruction.Location = new System.Drawing.Point(634, 460);
            this.lbl_GoToInstruction.Name = "lbl_GoToInstruction";
            this.lbl_GoToInstruction.Size = new System.Drawing.Size(84, 20);
            this.lbl_GoToInstruction.TabIndex = 13;
            this.lbl_GoToInstruction.Text = "Go to page";
            // 
            // tbx_TargetPage
            // 
            this.tbx_TargetPage.Location = new System.Drawing.Point(724, 453);
            this.tbx_TargetPage.Name = "tbx_TargetPage";
            this.tbx_TargetPage.Size = new System.Drawing.Size(51, 27);
            this.tbx_TargetPage.TabIndex = 14;
            this.tbx_TargetPage.TextChanged += new System.EventHandler(this.tbx_TargetPage_TextChanged);
            // 
            // lbl_LeftRightKeyInstruction
            // 
            this.lbl_LeftRightKeyInstruction.AutoSize = true;
            this.lbl_LeftRightKeyInstruction.Location = new System.Drawing.Point(12, 460);
            this.lbl_LeftRightKeyInstruction.Name = "lbl_LeftRightKeyInstruction";
            this.lbl_LeftRightKeyInstruction.Size = new System.Drawing.Size(215, 20);
            this.lbl_LeftRightKeyInstruction.TabIndex = 15;
            this.lbl_LeftRightKeyInstruction.Text = "You can use Left/Right keys too";
            // 
            // cms_Delete
            // 
            this.cms_Delete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Delete.Name = "cms_Delete";
            this.cms_Delete.Size = new System.Drawing.Size(61, 4);
            this.cms_Delete.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Delete_Opening);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 503);
            this.Controls.Add(this.lbl_LeftRightKeyInstruction);
            this.Controls.Add(this.tbx_TargetPage);
            this.Controls.Add(this.lbl_GoToInstruction);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.btn_NextPage);
            this.Controls.Add(this.btn_PreviousPage);
            this.Controls.Add(this.lbl_EscapeInstructionLeft);
            this.Controls.Add(this.lbl_EscapeInstructionRight);
            this.Controls.Add(this.tbx_LeftPageEdit);
            this.Controls.Add(this.tbx_RightPageEdit);
            this.Controls.Add(this.btn_BackToDeckMenu);
            this.Controls.Add(this.lbl_RightPage);
            this.Controls.Add(this.lbl_LeftPage);
            this.Controls.Add(this.lbl_CurrentPage);
            this.Controls.Add(this.lbl_CurrentDeck);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_CurrentDeck;
        private Label lbl_CurrentPage;
        private Label lbl_LeftPage;
        private Label lbl_RightPage;
        private Button btn_BackToDeckMenu;
        private TextBox tbx_RightPageEdit;
        private TextBox tbx_LeftPageEdit;
        private Label lbl_EscapeInstructionRight;
        private Label lbl_EscapeInstructionLeft;
        private Button btn_PreviousPage;
        private Button btn_NextPage;
        private Button btn_SaveToFile;
        private Label lbl_GoToInstruction;
        private TextBox tbx_TargetPage;
        private Label lbl_LeftRightKeyInstruction;
        private ContextMenuStrip cms_Delete;
    }
}