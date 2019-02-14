namespace WinFormHotel.FORMS
{
    partial class Form_HotelInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_HotelName = new System.Windows.Forms.Label();
            this.TextBox_HotelName = new System.Windows.Forms.TextBox();
            this.Label_Address = new System.Windows.Forms.Label();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Label_Director = new System.Windows.Forms.Label();
            this.Button_Director = new System.Windows.Forms.Button();
            this.Label_Phonenumbers = new System.Windows.Forms.Label();
            this.TextBox_Phonenumbers = new System.Windows.Forms.TextBox();
            this.TrackBar_Stars = new System.Windows.Forms.TrackBar();
            this.Label_StarsData = new System.Windows.Forms.Label();
            this.Label_Stars = new System.Windows.Forms.Label();
            this.Button_Workers = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Button_Comfort = new System.Windows.Forms.Button();
            this.Button_Furniture = new System.Windows.Forms.Button();
            this.Column_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_BtnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Stars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_HotelName
            // 
            this.Label_HotelName.AutoSize = true;
            this.Label_HotelName.Location = new System.Drawing.Point(9, 79);
            this.Label_HotelName.Name = "Label_HotelName";
            this.Label_HotelName.Size = new System.Drawing.Size(118, 16);
            this.Label_HotelName.TabIndex = 0;
            this.Label_HotelName.Text = "Название отеля:";
            // 
            // TextBox_HotelName
            // 
            this.TextBox_HotelName.Location = new System.Drawing.Point(145, 76);
            this.TextBox_HotelName.Name = "TextBox_HotelName";
            this.TextBox_HotelName.Size = new System.Drawing.Size(279, 22);
            this.TextBox_HotelName.TabIndex = 1;
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.Location = new System.Drawing.Point(9, 107);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(51, 16);
            this.Label_Address.TabIndex = 2;
            this.Label_Address.Text = "Адрес:";
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.Location = new System.Drawing.Point(145, 104);
            this.TextBox_Address.Multiline = true;
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(279, 52);
            this.TextBox_Address.TabIndex = 3;
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(431, 336);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(86, 28);
            this.Button_Save.TabIndex = 5;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Exit.Location = new System.Drawing.Point(523, 336);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 28);
            this.Button_Exit.TabIndex = 6;
            this.Button_Exit.Text = "Вийти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Label_Director
            // 
            this.Label_Director.AutoSize = true;
            this.Label_Director.Location = new System.Drawing.Point(9, 22);
            this.Label_Director.Name = "Label_Director";
            this.Label_Director.Size = new System.Drawing.Size(74, 16);
            this.Label_Director.TabIndex = 8;
            this.Label_Director.Text = "Директор:";
            // 
            // Button_Director
            // 
            this.Button_Director.Location = new System.Drawing.Point(145, 19);
            this.Button_Director.Name = "Button_Director";
            this.Button_Director.Size = new System.Drawing.Size(279, 23);
            this.Button_Director.TabIndex = 9;
            this.Button_Director.UseVisualStyleBackColor = true;
            this.Button_Director.Click += new System.EventHandler(this.Button_Director_Click);
            // 
            // Label_Phonenumbers
            // 
            this.Label_Phonenumbers.AutoSize = true;
            this.Label_Phonenumbers.Location = new System.Drawing.Point(9, 51);
            this.Label_Phonenumbers.Name = "Label_Phonenumbers";
            this.Label_Phonenumbers.Size = new System.Drawing.Size(130, 16);
            this.Label_Phonenumbers.TabIndex = 10;
            this.Label_Phonenumbers.Text = "Номера приемной:";
            // 
            // TextBox_Phonenumbers
            // 
            this.TextBox_Phonenumbers.Location = new System.Drawing.Point(145, 48);
            this.TextBox_Phonenumbers.Name = "TextBox_Phonenumbers";
            this.TextBox_Phonenumbers.Size = new System.Drawing.Size(279, 22);
            this.TextBox_Phonenumbers.TabIndex = 11;
            // 
            // TrackBar_Stars
            // 
            this.TrackBar_Stars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBar_Stars.LargeChange = 1;
            this.TrackBar_Stars.Location = new System.Drawing.Point(553, 19);
            this.TrackBar_Stars.Maximum = 5;
            this.TrackBar_Stars.Minimum = 1;
            this.TrackBar_Stars.Name = "TrackBar_Stars";
            this.TrackBar_Stars.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBar_Stars.Size = new System.Drawing.Size(45, 137);
            this.TrackBar_Stars.TabIndex = 12;
            this.TrackBar_Stars.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBar_Stars.Value = 1;
            this.TrackBar_Stars.Scroll += new System.EventHandler(this.TrackBar_Stars_Scroll);
            // 
            // Label_StarsData
            // 
            this.Label_StarsData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StarsData.AutoSize = true;
            this.Label_StarsData.Location = new System.Drawing.Point(513, 19);
            this.Label_StarsData.Name = "Label_StarsData";
            this.Label_StarsData.Size = new System.Drawing.Size(15, 16);
            this.Label_StarsData.TabIndex = 13;
            this.Label_StarsData.Text = "1";
            // 
            // Label_Stars
            // 
            this.Label_Stars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Stars.AutoSize = true;
            this.Label_Stars.Location = new System.Drawing.Point(455, 19);
            this.Label_Stars.Name = "Label_Stars";
            this.Label_Stars.Size = new System.Drawing.Size(52, 16);
            this.Label_Stars.TabIndex = 14;
            this.Label_Stars.Text = "Звезд:";
            // 
            // Button_Workers
            // 
            this.Button_Workers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Workers.Location = new System.Drawing.Point(431, 38);
            this.Button_Workers.Name = "Button_Workers";
            this.Button_Workers.Size = new System.Drawing.Size(116, 50);
            this.Button_Workers.TabIndex = 15;
            this.Button_Workers.Text = "Работники отеля";
            this.Button_Workers.UseVisualStyleBackColor = true;
            this.Button_Workers.Click += new System.EventHandler(this.Button_Workers_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Index,
            this.Column_Number,
            this.Column_Add,
            this.Column_BtnRemove,
            this.Column_BtnEdit});
            this.DataGridView.Location = new System.Drawing.Point(12, 162);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(586, 168);
            this.DataGridView.TabIndex = 16;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Button_Comfort
            // 
            this.Button_Comfort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Comfort.Location = new System.Drawing.Point(431, 94);
            this.Button_Comfort.Name = "Button_Comfort";
            this.Button_Comfort.Size = new System.Drawing.Size(116, 29);
            this.Button_Comfort.TabIndex = 17;
            this.Button_Comfort.Text = "Ур. Комфорта";
            this.Button_Comfort.UseVisualStyleBackColor = true;
            this.Button_Comfort.Click += new System.EventHandler(this.Button_Comfort_Click);
            // 
            // Button_Furniture
            // 
            this.Button_Furniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Furniture.Location = new System.Drawing.Point(431, 128);
            this.Button_Furniture.Name = "Button_Furniture";
            this.Button_Furniture.Size = new System.Drawing.Size(116, 28);
            this.Button_Furniture.TabIndex = 18;
            this.Button_Furniture.Text = "Мебель";
            this.Button_Furniture.UseVisualStyleBackColor = true;
            this.Button_Furniture.Click += new System.EventHandler(this.Button_Furniture_Click);
            // 
            // Column_Index
            // 
            this.Column_Index.HeaderText = "Этаж";
            this.Column_Index.Name = "Column_Index";
            this.Column_Index.ReadOnly = true;
            this.Column_Index.Width = 60;
            // 
            // Column_Number
            // 
            this.Column_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Number.HeaderText = "Кол-во номеров";
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            // 
            // Column_Add
            // 
            this.Column_Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Add.HeaderText = "Добавить";
            this.Column_Add.Name = "Column_Add";
            this.Column_Add.ReadOnly = true;
            this.Column_Add.Text = "Добавить";
            this.Column_Add.UseColumnTextForButtonValue = true;
            this.Column_Add.Width = 77;
            // 
            // Column_BtnRemove
            // 
            this.Column_BtnRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_BtnRemove.HeaderText = "Удалить";
            this.Column_BtnRemove.Name = "Column_BtnRemove";
            this.Column_BtnRemove.ReadOnly = true;
            this.Column_BtnRemove.Text = "Удалить";
            this.Column_BtnRemove.UseColumnTextForButtonValue = true;
            this.Column_BtnRemove.Width = 69;
            // 
            // Column_BtnEdit
            // 
            this.Column_BtnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_BtnEdit.HeaderText = "Редакт.";
            this.Column_BtnEdit.Name = "Column_BtnEdit";
            this.Column_BtnEdit.ReadOnly = true;
            this.Column_BtnEdit.Text = "Редакт.";
            this.Column_BtnEdit.UseColumnTextForButtonValue = true;
            this.Column_BtnEdit.Width = 64;
            // 
            // Form_HotelInfo
            // 
            this.AcceptButton = this.Button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Exit;
            this.ClientSize = new System.Drawing.Size(610, 376);
            this.Controls.Add(this.Button_Furniture);
            this.Controls.Add(this.Button_Comfort);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Button_Workers);
            this.Controls.Add(this.Label_Stars);
            this.Controls.Add(this.Label_StarsData);
            this.Controls.Add(this.TrackBar_Stars);
            this.Controls.Add(this.TextBox_Phonenumbers);
            this.Controls.Add(this.Label_Phonenumbers);
            this.Controls.Add(this.Button_Director);
            this.Controls.Add(this.Label_Director);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.Label_Address);
            this.Controls.Add(this.TextBox_HotelName);
            this.Controls.Add(this.Label_HotelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(626, 415);
            this.Name = "Form_HotelInfo";
            this.Text = "Отель";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Stars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_HotelName;
        private System.Windows.Forms.TextBox TextBox_HotelName;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.TextBox TextBox_Address;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Label Label_Director;
        private System.Windows.Forms.Button Button_Director;
        private System.Windows.Forms.Label Label_Phonenumbers;
        private System.Windows.Forms.TextBox TextBox_Phonenumbers;
        private System.Windows.Forms.TrackBar TrackBar_Stars;
        private System.Windows.Forms.Label Label_StarsData;
        private System.Windows.Forms.Label Label_Stars;
        private System.Windows.Forms.Button Button_Workers;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Button_Comfort;
        private System.Windows.Forms.Button Button_Furniture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Add;
        private System.Windows.Forms.DataGridViewButtonColumn Column_BtnRemove;
        private System.Windows.Forms.DataGridViewButtonColumn Column_BtnEdit;
    }
}