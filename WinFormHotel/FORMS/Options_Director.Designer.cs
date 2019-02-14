namespace WinFormHotel.FORMS
{
    partial class Options_Director
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
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Label_Surname = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Patronymic = new System.Windows.Forms.Label();
            this.GroupBox_Entry = new System.Windows.Forms.GroupBox();
            this.Label_Phonenumber = new System.Windows.Forms.Label();
            this.TextBox_Phonenumber = new System.Windows.Forms.TextBox();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.GroupBox_PersonalInfo = new System.Windows.Forms.GroupBox();
            this.TextBox_Surname = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Patronymic = new System.Windows.Forms.TextBox();
            this.TextBox_Post = new System.Windows.Forms.TextBox();
            this.Label_Post = new System.Windows.Forms.Label();
            this.Label_AccessLvl = new System.Windows.Forms.Label();
            this.ComboBox_Access = new System.Windows.Forms.ComboBox();
            this.GroupBox_Entry.SuspendLayout();
            this.GroupBox_PersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.Location = new System.Drawing.Point(506, 160);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(100, 28);
            this.Button_Exit.TabIndex = 10;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(398, 160);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(100, 28);
            this.Button_Save.TabIndex = 9;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_Surname
            // 
            this.Label_Surname.AutoSize = true;
            this.Label_Surname.Location = new System.Drawing.Point(7, 30);
            this.Label_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Surname.Name = "Label_Surname";
            this.Label_Surname.Size = new System.Drawing.Size(70, 16);
            this.Label_Surname.TabIndex = 3;
            this.Label_Surname.Text = "Фамилия:";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(7, 58);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(37, 16);
            this.Label_Name.TabIndex = 4;
            this.Label_Name.Text = "Имя:";
            // 
            // Label_Patronymic
            // 
            this.Label_Patronymic.AutoSize = true;
            this.Label_Patronymic.Location = new System.Drawing.Point(7, 86);
            this.Label_Patronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Patronymic.Name = "Label_Patronymic";
            this.Label_Patronymic.Size = new System.Drawing.Size(74, 16);
            this.Label_Patronymic.TabIndex = 5;
            this.Label_Patronymic.Text = "Отчество:";
            // 
            // GroupBox_Entry
            // 
            this.GroupBox_Entry.Controls.Add(this.Label_Phonenumber);
            this.GroupBox_Entry.Controls.Add(this.TextBox_Phonenumber);
            this.GroupBox_Entry.Controls.Add(this.TextBox_Login);
            this.GroupBox_Entry.Controls.Add(this.TextBox_Password);
            this.GroupBox_Entry.Controls.Add(this.Label_Login);
            this.GroupBox_Entry.Controls.Add(this.Label_Password);
            this.GroupBox_Entry.Location = new System.Drawing.Point(312, 12);
            this.GroupBox_Entry.Name = "GroupBox_Entry";
            this.GroupBox_Entry.Size = new System.Drawing.Size(294, 111);
            this.GroupBox_Entry.TabIndex = 6;
            this.GroupBox_Entry.TabStop = false;
            this.GroupBox_Entry.Text = "Данные для входа";
            // 
            // Label_Phonenumber
            // 
            this.Label_Phonenumber.AutoSize = true;
            this.Label_Phonenumber.Location = new System.Drawing.Point(7, 86);
            this.Label_Phonenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Phonenumber.Name = "Label_Phonenumber";
            this.Label_Phonenumber.Size = new System.Drawing.Size(71, 16);
            this.Label_Phonenumber.TabIndex = 8;
            this.Label_Phonenumber.Text = "Телефон:";
            // 
            // TextBox_Phonenumber
            // 
            this.TextBox_Phonenumber.Location = new System.Drawing.Point(100, 83);
            this.TextBox_Phonenumber.Name = "TextBox_Phonenumber";
            this.TextBox_Phonenumber.Size = new System.Drawing.Size(159, 22);
            this.TextBox_Phonenumber.TabIndex = 7;
            this.TextBox_Phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Phonenumber_KeyPress);
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(100, 27);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(159, 22);
            this.TextBox_Login.TabIndex = 5;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(100, 55);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(159, 22);
            this.TextBox_Password.TabIndex = 6;
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Location = new System.Drawing.Point(7, 30);
            this.Label_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(50, 16);
            this.Label_Login.TabIndex = 5;
            this.Label_Login.Text = "Логин:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(7, 58);
            this.Label_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(60, 16);
            this.Label_Password.TabIndex = 6;
            this.Label_Password.Text = "Пароль:";
            // 
            // GroupBox_PersonalInfo
            // 
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Surname);
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Name);
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Patronymic);
            this.GroupBox_PersonalInfo.Controls.Add(this.Label_Surname);
            this.GroupBox_PersonalInfo.Controls.Add(this.Label_Name);
            this.GroupBox_PersonalInfo.Controls.Add(this.Label_Patronymic);
            this.GroupBox_PersonalInfo.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_PersonalInfo.Name = "GroupBox_PersonalInfo";
            this.GroupBox_PersonalInfo.Size = new System.Drawing.Size(294, 111);
            this.GroupBox_PersonalInfo.TabIndex = 7;
            this.GroupBox_PersonalInfo.TabStop = false;
            this.GroupBox_PersonalInfo.Text = "Личные данные";
            // 
            // TextBox_Surname
            // 
            this.TextBox_Surname.Location = new System.Drawing.Point(103, 27);
            this.TextBox_Surname.Name = "TextBox_Surname";
            this.TextBox_Surname.Size = new System.Drawing.Size(159, 22);
            this.TextBox_Surname.TabIndex = 1;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(103, 55);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(159, 22);
            this.TextBox_Name.TabIndex = 2;
            // 
            // TextBox_Patronymic
            // 
            this.TextBox_Patronymic.Location = new System.Drawing.Point(103, 83);
            this.TextBox_Patronymic.Name = "TextBox_Patronymic";
            this.TextBox_Patronymic.Size = new System.Drawing.Size(159, 22);
            this.TextBox_Patronymic.TabIndex = 3;
            // 
            // TextBox_Post
            // 
            this.TextBox_Post.Location = new System.Drawing.Point(115, 129);
            this.TextBox_Post.Name = "TextBox_Post";
            this.TextBox_Post.Size = new System.Drawing.Size(191, 22);
            this.TextBox_Post.TabIndex = 4;
            // 
            // Label_Post
            // 
            this.Label_Post.AutoSize = true;
            this.Label_Post.Location = new System.Drawing.Point(19, 132);
            this.Label_Post.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Post.Name = "Label_Post";
            this.Label_Post.Size = new System.Drawing.Size(82, 16);
            this.Label_Post.TabIndex = 11;
            this.Label_Post.Text = "Должность:";
            // 
            // Label_AccessLvl
            // 
            this.Label_AccessLvl.AutoSize = true;
            this.Label_AccessLvl.Location = new System.Drawing.Point(319, 132);
            this.Label_AccessLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_AccessLvl.Name = "Label_AccessLvl";
            this.Label_AccessLvl.Size = new System.Drawing.Size(86, 16);
            this.Label_AccessLvl.TabIndex = 13;
            this.Label_AccessLvl.Text = "Ур. Доступа";
            // 
            // ComboBox_Access
            // 
            this.ComboBox_Access.FormattingEnabled = true;
            this.ComboBox_Access.Items.AddRange(new object[] {
            "Администратор",
            "Работник"});
            this.ComboBox_Access.Location = new System.Drawing.Point(412, 127);
            this.ComboBox_Access.Name = "ComboBox_Access";
            this.ComboBox_Access.Size = new System.Drawing.Size(194, 24);
            this.ComboBox_Access.TabIndex = 14;
            // 
            // Options_Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 201);
            this.Controls.Add(this.ComboBox_Access);
            this.Controls.Add(this.Label_AccessLvl);
            this.Controls.Add(this.TextBox_Post);
            this.Controls.Add(this.Label_Post);
            this.Controls.Add(this.GroupBox_PersonalInfo);
            this.Controls.Add(this.GroupBox_Entry);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Options_Director";
            this.Text = "Работник";
            this.GroupBox_Entry.ResumeLayout(false);
            this.GroupBox_Entry.PerformLayout();
            this.GroupBox_PersonalInfo.ResumeLayout(false);
            this.GroupBox_PersonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label Label_Surname;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Patronymic;
        private System.Windows.Forms.GroupBox GroupBox_Entry;
        private System.Windows.Forms.Label Label_Phonenumber;
        private System.Windows.Forms.TextBox TextBox_Phonenumber;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.GroupBox GroupBox_PersonalInfo;
        private System.Windows.Forms.TextBox TextBox_Surname;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_Patronymic;
        private System.Windows.Forms.TextBox TextBox_Post;
        private System.Windows.Forms.Label Label_Post;
        private System.Windows.Forms.Label Label_AccessLvl;
        private System.Windows.Forms.ComboBox ComboBox_Access;
    }
}