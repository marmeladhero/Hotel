namespace WinFormHotel.FORMS
{
    partial class FormCreateNewUser
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
            this.GroupBox_PersonalInfo = new System.Windows.Forms.GroupBox();
            this.TextBox_Phonenumber = new System.Windows.Forms.TextBox();
            this.TextBox_Patronymic = new System.Windows.Forms.TextBox();
            this.TextBox_Surname = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePicker_Departure = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_Other = new System.Windows.Forms.TextBox();
            this.TextBox_Pasport = new System.Windows.Forms.TextBox();
            this.DataGridView_Childs = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.GroupBox_PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Childs)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_PersonalInfo
            // 
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Phonenumber);
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Patronymic);
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Surname);
            this.GroupBox_PersonalInfo.Controls.Add(this.TextBox_Name);
            this.GroupBox_PersonalInfo.Controls.Add(this.label1);
            this.GroupBox_PersonalInfo.Controls.Add(this.label4);
            this.GroupBox_PersonalInfo.Controls.Add(this.label5);
            this.GroupBox_PersonalInfo.Controls.Add(this.label6);
            this.GroupBox_PersonalInfo.Location = new System.Drawing.Point(15, 12);
            this.GroupBox_PersonalInfo.Name = "GroupBox_PersonalInfo";
            this.GroupBox_PersonalInfo.Size = new System.Drawing.Size(388, 155);
            this.GroupBox_PersonalInfo.TabIndex = 1;
            this.GroupBox_PersonalInfo.TabStop = false;
            this.GroupBox_PersonalInfo.Text = "Личные данные";
            // 
            // TextBox_Phonenumber
            // 
            this.TextBox_Phonenumber.Location = new System.Drawing.Point(157, 113);
            this.TextBox_Phonenumber.Name = "TextBox_Phonenumber";
            this.TextBox_Phonenumber.Size = new System.Drawing.Size(219, 24);
            this.TextBox_Phonenumber.TabIndex = 4;
            this.TextBox_Phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Phonenumber_KeyPress);
            // 
            // TextBox_Patronymic
            // 
            this.TextBox_Patronymic.Location = new System.Drawing.Point(157, 83);
            this.TextBox_Patronymic.Name = "TextBox_Patronymic";
            this.TextBox_Patronymic.Size = new System.Drawing.Size(219, 24);
            this.TextBox_Patronymic.TabIndex = 3;
            // 
            // TextBox_Surname
            // 
            this.TextBox_Surname.Location = new System.Drawing.Point(157, 53);
            this.TextBox_Surname.Name = "TextBox_Surname";
            this.TextBox_Surname.Size = new System.Drawing.Size(219, 24);
            this.TextBox_Surname.TabIndex = 2;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(157, 23);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(219, 24);
            this.TextBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер телефона:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Фамилия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Паспортные данные:";
            // 
            // DateTimePicker_Departure
            // 
            this.DateTimePicker_Departure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker_Departure.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_Departure.Location = new System.Drawing.Point(172, 452);
            this.DateTimePicker_Departure.Name = "DateTimePicker_Departure";
            this.DateTimePicker_Departure.Size = new System.Drawing.Size(219, 24);
            this.DateTimePicker_Departure.TabIndex = 8;
            // 
            // DateTimePicker_From
            // 
            this.DateTimePicker_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker_From.CustomFormat = "";
            this.DateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_From.Location = new System.Drawing.Point(172, 422);
            this.DateTimePicker_From.Name = "DateTimePicker_From";
            this.DateTimePicker_From.Size = new System.Drawing.Size(219, 24);
            this.DateTimePicker_From.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Время заезда:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Время уезда:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Доп. инфо.";
            // 
            // TextBox_Other
            // 
            this.TextBox_Other.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_Other.Location = new System.Drawing.Point(172, 203);
            this.TextBox_Other.Multiline = true;
            this.TextBox_Other.Name = "TextBox_Other";
            this.TextBox_Other.Size = new System.Drawing.Size(219, 213);
            this.TextBox_Other.TabIndex = 6;
            // 
            // TextBox_Pasport
            // 
            this.TextBox_Pasport.Location = new System.Drawing.Point(172, 173);
            this.TextBox_Pasport.Name = "TextBox_Pasport";
            this.TextBox_Pasport.Size = new System.Drawing.Size(219, 24);
            this.TextBox_Pasport.TabIndex = 5;
            // 
            // DataGridView_Childs
            // 
            this.DataGridView_Childs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Childs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Childs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Surname,
            this.Column_Patronymic,
            this.Column_Phone,
            this.Column_Remove});
            this.DataGridView_Childs.Location = new System.Drawing.Point(409, 17);
            this.DataGridView_Childs.Name = "DataGridView_Childs";
            this.DataGridView_Childs.Size = new System.Drawing.Size(466, 423);
            this.DataGridView_Childs.TabIndex = 9;
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Name.HeaderText = "Имя";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Surname
            // 
            this.Column_Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Surname.HeaderText = "Фамилия";
            this.Column_Surname.Name = "Column_Surname";
            // 
            // Column_Patronymic
            // 
            this.Column_Patronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Patronymic.HeaderText = "Отчество";
            this.Column_Patronymic.Name = "Column_Patronymic";
            // 
            // Column_Phone
            // 
            this.Column_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Phone.HeaderText = "Телефон";
            this.Column_Phone.Name = "Column_Phone";
            // 
            // Column_Remove
            // 
            this.Column_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Remove.HeaderText = "Удалить";
            this.Column_Remove.Name = "Column_Remove";
            this.Column_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Remove.Width = 92;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.Location = new System.Drawing.Point(800, 446);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 30);
            this.Button_Exit.TabIndex = 11;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(698, 446);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(96, 30);
            this.Button_Save.TabIndex = 10;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // FormCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 488);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.DataGridView_Childs);
            this.Controls.Add(this.TextBox_Pasport);
            this.Controls.Add(this.TextBox_Other);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateTimePicker_From);
            this.Controls.Add(this.DateTimePicker_Departure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GroupBox_PersonalInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(780, 384);
            this.Name = "FormCreateNewUser";
            this.Text = "Информация о жители";
            this.GroupBox_PersonalInfo.ResumeLayout(false);
            this.GroupBox_PersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Childs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_PersonalInfo;
        private System.Windows.Forms.TextBox TextBox_Phonenumber;
        private System.Windows.Forms.TextBox TextBox_Patronymic;
        private System.Windows.Forms.TextBox TextBox_Surname;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Departure;
        private System.Windows.Forms.DateTimePicker DateTimePicker_From;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBox_Other;
        private System.Windows.Forms.TextBox TextBox_Pasport;
        private System.Windows.Forms.DataGridView DataGridView_Childs;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Phone;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Remove;
    }
}