namespace Takumi_Saito_Project
{
    partial class Form3
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
            this.ChooseSubject = new System.Windows.Forms.Label();
            this.lbl_WelcomeUser = new System.Windows.Forms.Label();
            this.lbl_Subject1 = new System.Windows.Forms.Label();
            this.lbl_SubjectMenu = new System.Windows.Forms.Label();
            this.lbl_Subject2 = new System.Windows.Forms.Label();
            this.lbl_Subject3 = new System.Windows.Forms.Label();
            this.lbl_Subject4 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_AddSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_AddSubjectName = new System.Windows.Forms.TextBox();
            this.btn_AddSubject = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.cms_DeleteEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // ChooseSubject
            // 
            this.ChooseSubject.AutoSize = true;
            this.ChooseSubject.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseSubject.Location = new System.Drawing.Point(203, 67);
            this.ChooseSubject.Name = "ChooseSubject";
            this.ChooseSubject.Size = new System.Drawing.Size(320, 35);
            this.ChooseSubject.TabIndex = 0;
            this.ChooseSubject.Text = "Please choose the subject :)";
            // 
            // lbl_WelcomeUser
            // 
            this.lbl_WelcomeUser.AutoSize = true;
            this.lbl_WelcomeUser.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_WelcomeUser.Location = new System.Drawing.Point(203, 18);
            this.lbl_WelcomeUser.Name = "lbl_WelcomeUser";
            this.lbl_WelcomeUser.Size = new System.Drawing.Size(276, 35);
            this.lbl_WelcomeUser.TabIndex = 1;
            this.lbl_WelcomeUser.Text = "Welcome, Current User!";
            this.lbl_WelcomeUser.Click += new System.EventHandler(this.lbl_WelcomeUser_Click);
            // 
            // lbl_Subject1
            // 
            this.lbl_Subject1.AutoSize = true;
            this.lbl_Subject1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Subject1.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subject1.Location = new System.Drawing.Point(65, 179);
            this.lbl_Subject1.Name = "lbl_Subject1";
            this.lbl_Subject1.Size = new System.Drawing.Size(251, 73);
            this.lbl_Subject1.TabIndex = 2;
            this.lbl_Subject1.Text = "subject 1";
            this.lbl_Subject1.Click += new System.EventHandler(this.lbl_Subject1_Click);
            // 
            // lbl_SubjectMenu
            // 
            this.lbl_SubjectMenu.AutoSize = true;
            this.lbl_SubjectMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_SubjectMenu.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SubjectMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SubjectMenu.Location = new System.Drawing.Point(12, 18);
            this.lbl_SubjectMenu.Name = "lbl_SubjectMenu";
            this.lbl_SubjectMenu.Size = new System.Drawing.Size(145, 46);
            this.lbl_SubjectMenu.TabIndex = 3;
            this.lbl_SubjectMenu.Text = "Subjects";
            // 
            // lbl_Subject2
            // 
            this.lbl_Subject2.AutoSize = true;
            this.lbl_Subject2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Subject2.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subject2.Location = new System.Drawing.Point(443, 179);
            this.lbl_Subject2.Name = "lbl_Subject2";
            this.lbl_Subject2.Size = new System.Drawing.Size(266, 73);
            this.lbl_Subject2.TabIndex = 4;
            this.lbl_Subject2.Text = "subject 2";
            this.lbl_Subject2.Click += new System.EventHandler(this.lbl_Subject2_Click);
            // 
            // lbl_Subject3
            // 
            this.lbl_Subject3.AutoSize = true;
            this.lbl_Subject3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Subject3.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subject3.Location = new System.Drawing.Point(65, 290);
            this.lbl_Subject3.Name = "lbl_Subject3";
            this.lbl_Subject3.Size = new System.Drawing.Size(266, 73);
            this.lbl_Subject3.TabIndex = 5;
            this.lbl_Subject3.Text = "subject 3";
            this.lbl_Subject3.Click += new System.EventHandler(this.lbl_Subject3_Click);
            // 
            // lbl_Subject4
            // 
            this.lbl_Subject4.AutoSize = true;
            this.lbl_Subject4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Subject4.Font = new System.Drawing.Font("Ink Free", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Subject4.Location = new System.Drawing.Point(442, 290);
            this.lbl_Subject4.Name = "lbl_Subject4";
            this.lbl_Subject4.Size = new System.Drawing.Size(266, 73);
            this.lbl_Subject4.TabIndex = 6;
            this.lbl_Subject4.Text = "subject 4";
            this.lbl_Subject4.Click += new System.EventHandler(this.lbl_Subject4_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(355, 392);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(102, 33);
            this.btn_Next.TabIndex = 7;
            this.btn_Next.Text = "More";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(355, 118);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(102, 33);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_AddSubject
            // 
            this.lbl_AddSubject.AutoSize = true;
            this.lbl_AddSubject.BackColor = System.Drawing.Color.Gold;
            this.lbl_AddSubject.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AddSubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AddSubject.Location = new System.Drawing.Point(553, 18);
            this.lbl_AddSubject.Name = "lbl_AddSubject";
            this.lbl_AddSubject.Size = new System.Drawing.Size(214, 35);
            this.lbl_AddSubject.TabIndex = 9;
            this.lbl_AddSubject.Text = "Add subjects here";
            this.lbl_AddSubject.Click += new System.EventHandler(this.lbl_AddSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "subject name (1-15 characters)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // box_AddSubjectName
            // 
            this.box_AddSubjectName.Location = new System.Drawing.Point(553, 85);
            this.box_AddSubjectName.Name = "box_AddSubjectName";
            this.box_AddSubjectName.Size = new System.Drawing.Size(214, 27);
            this.box_AddSubjectName.TabIndex = 11;
            this.box_AddSubjectName.TextChanged += new System.EventHandler(this.box_AddSubjectName_TextChanged);
            // 
            // btn_AddSubject
            // 
            this.btn_AddSubject.Location = new System.Drawing.Point(615, 120);
            this.btn_AddSubject.Name = "btn_AddSubject";
            this.btn_AddSubject.Size = new System.Drawing.Size(94, 31);
            this.btn_AddSubject.TabIndex = 12;
            this.btn_AddSubject.Text = "Add!";
            this.btn_AddSubject.UseVisualStyleBackColor = true;
            this.btn_AddSubject.Click += new System.EventHandler(this.btn_AddSubject_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(40, 83);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(83, 30);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(683, 388);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(105, 40);
            this.btn_SaveToFile.TabIndex = 14;
            this.btn_SaveToFile.Text = "Save to File";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // cms_DeleteEdit
            // 
            this.cms_DeleteEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_DeleteEdit.Name = "cms_DeleteEdit";
            this.cms_DeleteEdit.Size = new System.Drawing.Size(61, 4);
            this.cms_DeleteEdit.Opening += new System.ComponentModel.CancelEventHandler(this.cms_DeleteEdit_Opening);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_AddSubject);
            this.Controls.Add(this.box_AddSubjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AddSubject);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lbl_Subject4);
            this.Controls.Add(this.lbl_Subject3);
            this.Controls.Add(this.lbl_Subject2);
            this.Controls.Add(this.lbl_SubjectMenu);
            this.Controls.Add(this.lbl_Subject1);
            this.Controls.Add(this.lbl_WelcomeUser);
            this.Controls.Add(this.ChooseSubject);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ChooseSubject;
        private Label lbl_WelcomeUser;
        private Label lbl_Subject1;
        private Label lbl_SubjectMenu;
        private Label lbl_Subject2;
        private Label lbl_Subject3;
        private Label lbl_Subject4;
        private Button btn_Next;
        private Button btn_Back;
        private Label lbl_AddSubject;
        private Label label1;
        private TextBox box_AddSubjectName;
        private Button btn_AddSubject;
        private Button btn_LogOut;
        private Button btn_SaveToFile;
        private ContextMenuStrip cms_DeleteEdit;
    }
}