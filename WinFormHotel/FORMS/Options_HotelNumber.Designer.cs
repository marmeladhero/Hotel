namespace WinFormHotel.FORMS
{
    partial class Options_HotelNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_FloorRoom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_RoomTypes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumericUpDown_BedCount = new System.Windows.Forms.NumericUpDown();
            this.TextBox_AdditionalServices = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Furniture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_AddFurniture = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_EditRoomType = new System.Windows.Forms.Button();
            this.DataGridView_Guests = new System.Windows.Forms.DataGridView();
            this.Column_PersonalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_BedCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Guests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Этаж/Номер:";
            // 
            // Label_FloorRoom
            // 
            this.Label_FloorRoom.AutoSize = true;
            this.Label_FloorRoom.Location = new System.Drawing.Point(122, 22);
            this.Label_FloorRoom.Name = "Label_FloorRoom";
            this.Label_FloorRoom.Size = new System.Drawing.Size(26, 16);
            this.Label_FloorRoom.TabIndex = 3;
            this.Label_FloorRoom.Text = "0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип номера:";
            // 
            // ComboBox_RoomTypes
            // 
            this.ComboBox_RoomTypes.FormattingEnabled = true;
            this.ComboBox_RoomTypes.Location = new System.Drawing.Point(125, 75);
            this.ComboBox_RoomTypes.Name = "ComboBox_RoomTypes";
            this.ComboBox_RoomTypes.Size = new System.Drawing.Size(239, 24);
            this.ComboBox_RoomTypes.TabIndex = 6;
            this.ComboBox_RoomTypes.SelectedIndexChanged += new System.EventHandler(this.ComboBox_RoomTypes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Описание:";
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Enabled = false;
            this.TextBox_Description.Location = new System.Drawing.Point(125, 105);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(330, 68);
            this.TextBox_Description.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Цена за номер:";
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.Location = new System.Drawing.Point(125, 46);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(109, 22);
            this.TextBox_Price.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Кол-во мест:";
            // 
            // NumericUpDown_BedCount
            // 
            this.NumericUpDown_BedCount.Location = new System.Drawing.Point(347, 47);
            this.NumericUpDown_BedCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_BedCount.Name = "NumericUpDown_BedCount";
            this.NumericUpDown_BedCount.Size = new System.Drawing.Size(108, 22);
            this.NumericUpDown_BedCount.TabIndex = 12;
            this.NumericUpDown_BedCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBox_AdditionalServices
            // 
            this.TextBox_AdditionalServices.Enabled = false;
            this.TextBox_AdditionalServices.Location = new System.Drawing.Point(125, 179);
            this.TextBox_AdditionalServices.Multiline = true;
            this.TextBox_AdditionalServices.Name = "TextBox_AdditionalServices";
            this.TextBox_AdditionalServices.Size = new System.Drawing.Size(330, 47);
            this.TextBox_AdditionalServices.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Доп.услуги:";
            // 
            // TextBox_Furniture
            // 
            this.TextBox_Furniture.Enabled = false;
            this.TextBox_Furniture.Location = new System.Drawing.Point(125, 234);
            this.TextBox_Furniture.Multiline = true;
            this.TextBox_Furniture.Name = "TextBox_Furniture";
            this.TextBox_Furniture.Size = new System.Drawing.Size(239, 54);
            this.TextBox_Furniture.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Фурнитура:";
            // 
            // Button_AddFurniture
            // 
            this.Button_AddFurniture.Location = new System.Drawing.Point(370, 234);
            this.Button_AddFurniture.Name = "Button_AddFurniture";
            this.Button_AddFurniture.Size = new System.Drawing.Size(85, 24);
            this.Button_AddFurniture.TabIndex = 17;
            this.Button_AddFurniture.Text = "Редакт.";
            this.Button_AddFurniture.UseVisualStyleBackColor = true;
            this.Button_AddFurniture.Click += new System.EventHandler(this.Button_AddFurniture_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(370, 294);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(85, 24);
            this.Button_Save.TabIndex = 18;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Exit.Location = new System.Drawing.Point(289, 294);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 24);
            this.Button_Exit.TabIndex = 19;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_EditRoomType
            // 
            this.Button_EditRoomType.Location = new System.Drawing.Point(369, 75);
            this.Button_EditRoomType.Name = "Button_EditRoomType";
            this.Button_EditRoomType.Size = new System.Drawing.Size(85, 24);
            this.Button_EditRoomType.TabIndex = 20;
            this.Button_EditRoomType.Text = "Редакт.";
            this.Button_EditRoomType.UseVisualStyleBackColor = true;
            this.Button_EditRoomType.Click += new System.EventHandler(this.Button_EditRoomType_Click);
            // 
            // DataGridView_Guests
            // 
            this.DataGridView_Guests.AllowUserToAddRows = false;
            this.DataGridView_Guests.AllowUserToDeleteRows = false;
            this.DataGridView_Guests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Guests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Guests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PersonalInfo,
            this.Column_PhoneNumber,
            this.Column_From,
            this.Column_To,
            this.Column_Details,
            this.Column_Remove});
            this.DataGridView_Guests.Location = new System.Drawing.Point(461, 48);
            this.DataGridView_Guests.Name = "DataGridView_Guests";
            this.DataGridView_Guests.ReadOnly = true;
            this.DataGridView_Guests.RowHeadersVisible = false;
            this.DataGridView_Guests.Size = new System.Drawing.Size(716, 270);
            this.DataGridView_Guests.TabIndex = 21;
            this.DataGridView_Guests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Guests_CellContentClick);
            this.DataGridView_Guests.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_Guests_RowsAdded);
            // 
            // Column_PersonalInfo
            // 
            this.Column_PersonalInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PersonalInfo.HeaderText = "Ф.И.О";
            this.Column_PersonalInfo.Name = "Column_PersonalInfo";
            this.Column_PersonalInfo.ReadOnly = true;
            // 
            // Column_PhoneNumber
            // 
            this.Column_PhoneNumber.HeaderText = "Номер телефона";
            this.Column_PhoneNumber.Name = "Column_PhoneNumber";
            this.Column_PhoneNumber.ReadOnly = true;
            // 
            // Column_From
            // 
            this.Column_From.HeaderText = "Прибытия";
            this.Column_From.Name = "Column_From";
            this.Column_From.ReadOnly = true;
            // 
            // Column_To
            // 
            this.Column_To.HeaderText = "Выезд";
            this.Column_To.Name = "Column_To";
            this.Column_To.ReadOnly = true;
            // 
            // Column_Details
            // 
            this.Column_Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Details.HeaderText = "Детали";
            this.Column_Details.Name = "Column_Details";
            this.Column_Details.ReadOnly = true;
            this.Column_Details.Width = 62;
            // 
            // Column_Remove
            // 
            this.Column_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Remove.HeaderText = "Освободить";
            this.Column_Remove.Name = "Column_Remove";
            this.Column_Remove.ReadOnly = true;
            this.Column_Remove.Width = 93;
            // 
            // Options_HotelNumber
            // 
            this.AcceptButton = this.Button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Exit;
            this.ClientSize = new System.Drawing.Size(1189, 338);
            this.Controls.Add(this.DataGridView_Guests);
            this.Controls.Add(this.Button_EditRoomType);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_AddFurniture);
            this.Controls.Add(this.TextBox_Furniture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_AdditionalServices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericUpDown_BedCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBox_Price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBox_RoomTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Label_FloorRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options_HotelNumber";
            this.Text = "Номер ";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_BedCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Guests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_FloorRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_RoomTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBox_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumericUpDown_BedCount;
        private System.Windows.Forms.TextBox TextBox_AdditionalServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Furniture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_AddFurniture;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_EditRoomType;
        private System.Windows.Forms.DataGridView DataGridView_Guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PersonalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_To;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Details;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Remove;
    }
}