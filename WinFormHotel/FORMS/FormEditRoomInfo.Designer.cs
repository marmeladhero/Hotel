namespace WinFormHotel.FORMS
{
    partial class FormEditHotelData
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
            this.DataGridView_Furniture = new System.Windows.Forms.DataGridView();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage_Furniture = new System.Windows.Forms.TabPage();
            this.Button_Furniture_All = new System.Windows.Forms.Button();
            this.Button_Furniture_Bukcet = new System.Windows.Forms.Button();
            this.Label_Furniture_BukcetData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPage_RoomTypes = new System.Windows.Forms.TabPage();
            this.Button_RoomType_All = new System.Windows.Forms.Button();
            this.Button_RoomType_Bukcet = new System.Windows.Forms.Button();
            this.Label_RoomType_BukcetData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView_RoomTypes = new System.Windows.Forms.DataGridView();
            this.RColumn_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RColumn_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RColumn_AdditionalServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RColumn_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FColumn_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FColumn_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Furniture)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPage_Furniture.SuspendLayout();
            this.TabPage_RoomTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RoomTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Furniture
            // 
            this.DataGridView_Furniture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Furniture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Furniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Furniture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FColumn_Name,
            this.FColumn_Remove});
            this.DataGridView_Furniture.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Furniture.Name = "DataGridView_Furniture";
            this.DataGridView_Furniture.RowHeadersVisible = false;
            this.DataGridView_Furniture.Size = new System.Drawing.Size(779, 243);
            this.DataGridView_Furniture.TabIndex = 1;
            this.DataGridView_Furniture.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_Furniture_CellBeginEdit);
            this.DataGridView_Furniture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Furniture_CellContentClick);
            this.DataGridView_Furniture.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Furniture_CellEndEdit);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.Location = new System.Drawing.Point(724, 325);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 23);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(632, 325);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(86, 23);
            this.Button_Save.TabIndex = 3;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabPage_Furniture);
            this.TabControl.Controls.Add(this.TabPage_RoomTypes);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(787, 307);
            this.TabControl.TabIndex = 4;
            // 
            // TabPage_Furniture
            // 
            this.TabPage_Furniture.Controls.Add(this.Button_Furniture_All);
            this.TabPage_Furniture.Controls.Add(this.Button_Furniture_Bukcet);
            this.TabPage_Furniture.Controls.Add(this.Label_Furniture_BukcetData);
            this.TabPage_Furniture.Controls.Add(this.label1);
            this.TabPage_Furniture.Controls.Add(this.DataGridView_Furniture);
            this.TabPage_Furniture.Location = new System.Drawing.Point(4, 25);
            this.TabPage_Furniture.Name = "TabPage_Furniture";
            this.TabPage_Furniture.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Furniture.Size = new System.Drawing.Size(779, 278);
            this.TabPage_Furniture.TabIndex = 0;
            this.TabPage_Furniture.Text = "Мебель";
            this.TabPage_Furniture.UseVisualStyleBackColor = true;
            // 
            // Button_Furniture_All
            // 
            this.Button_Furniture_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Furniture_All.Enabled = false;
            this.Button_Furniture_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Furniture_All.Location = new System.Drawing.Point(692, 249);
            this.Button_Furniture_All.Name = "Button_Furniture_All";
            this.Button_Furniture_All.Size = new System.Drawing.Size(81, 23);
            this.Button_Furniture_All.TabIndex = 9;
            this.Button_Furniture_All.Text = "Все";
            this.Button_Furniture_All.UseVisualStyleBackColor = true;
            this.Button_Furniture_All.Click += new System.EventHandler(this.Button_Furniture_All_Click);
            // 
            // Button_Furniture_Bukcet
            // 
            this.Button_Furniture_Bukcet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Furniture_Bukcet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Furniture_Bukcet.Location = new System.Drawing.Point(605, 249);
            this.Button_Furniture_Bukcet.Name = "Button_Furniture_Bukcet";
            this.Button_Furniture_Bukcet.Size = new System.Drawing.Size(81, 23);
            this.Button_Furniture_Bukcet.TabIndex = 8;
            this.Button_Furniture_Bukcet.Text = "Корзина";
            this.Button_Furniture_Bukcet.UseVisualStyleBackColor = true;
            this.Button_Furniture_Bukcet.Click += new System.EventHandler(this.Button_Furniture_Bukcet_Click);
            // 
            // Label_Furniture_BukcetData
            // 
            this.Label_Furniture_BukcetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Furniture_BukcetData.AutoSize = true;
            this.Label_Furniture_BukcetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Furniture_BukcetData.Location = new System.Drawing.Point(92, 249);
            this.Label_Furniture_BukcetData.Name = "Label_Furniture_BukcetData";
            this.Label_Furniture_BukcetData.Size = new System.Drawing.Size(61, 20);
            this.Label_Furniture_BukcetData.TabIndex = 3;
            this.Label_Furniture_BukcetData.Text = "(пусто)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Корзина: ";
            // 
            // TabPage_RoomTypes
            // 
            this.TabPage_RoomTypes.Controls.Add(this.Button_RoomType_All);
            this.TabPage_RoomTypes.Controls.Add(this.Button_RoomType_Bukcet);
            this.TabPage_RoomTypes.Controls.Add(this.Label_RoomType_BukcetData);
            this.TabPage_RoomTypes.Controls.Add(this.label4);
            this.TabPage_RoomTypes.Controls.Add(this.DataGridView_RoomTypes);
            this.TabPage_RoomTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabPage_RoomTypes.Location = new System.Drawing.Point(4, 25);
            this.TabPage_RoomTypes.Name = "TabPage_RoomTypes";
            this.TabPage_RoomTypes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_RoomTypes.Size = new System.Drawing.Size(779, 278);
            this.TabPage_RoomTypes.TabIndex = 1;
            this.TabPage_RoomTypes.Text = "Тип комнат";
            this.TabPage_RoomTypes.UseVisualStyleBackColor = true;
            // 
            // Button_RoomType_All
            // 
            this.Button_RoomType_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RoomType_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_RoomType_All.Location = new System.Drawing.Point(692, 249);
            this.Button_RoomType_All.Name = "Button_RoomType_All";
            this.Button_RoomType_All.Size = new System.Drawing.Size(81, 23);
            this.Button_RoomType_All.TabIndex = 7;
            this.Button_RoomType_All.Text = "Все";
            this.Button_RoomType_All.UseVisualStyleBackColor = true;
            this.Button_RoomType_All.Click += new System.EventHandler(this.Button_RoomType_All_Click);
            // 
            // Button_RoomType_Bukcet
            // 
            this.Button_RoomType_Bukcet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RoomType_Bukcet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_RoomType_Bukcet.Location = new System.Drawing.Point(605, 249);
            this.Button_RoomType_Bukcet.Name = "Button_RoomType_Bukcet";
            this.Button_RoomType_Bukcet.Size = new System.Drawing.Size(81, 23);
            this.Button_RoomType_Bukcet.TabIndex = 6;
            this.Button_RoomType_Bukcet.Text = "Корзина";
            this.Button_RoomType_Bukcet.UseVisualStyleBackColor = true;
            this.Button_RoomType_Bukcet.Click += new System.EventHandler(this.Button_RoomType_Bukcet_Click);
            // 
            // Label_RoomType_BukcetData
            // 
            this.Label_RoomType_BukcetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_RoomType_BukcetData.AutoSize = true;
            this.Label_RoomType_BukcetData.Location = new System.Drawing.Point(92, 249);
            this.Label_RoomType_BukcetData.Name = "Label_RoomType_BukcetData";
            this.Label_RoomType_BukcetData.Size = new System.Drawing.Size(61, 20);
            this.Label_RoomType_BukcetData.TabIndex = 5;
            this.Label_RoomType_BukcetData.Text = "(пусто)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Корзина: ";
            // 
            // DataGridView_RoomTypes
            // 
            this.DataGridView_RoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_RoomTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_RoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_RoomTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RColumn_Level,
            this.RColumn_Description,
            this.RColumn_AdditionalServices,
            this.RColumn_Remove});
            this.DataGridView_RoomTypes.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_RoomTypes.Name = "DataGridView_RoomTypes";
            this.DataGridView_RoomTypes.RowHeadersVisible = false;
            this.DataGridView_RoomTypes.Size = new System.Drawing.Size(779, 243);
            this.DataGridView_RoomTypes.TabIndex = 2;
            this.DataGridView_RoomTypes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_RoomTypes_CellBeginEdit);
            this.DataGridView_RoomTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RoomTypes_CellContentClick);
            this.DataGridView_RoomTypes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RoomTypes_CellEndEdit);
            // 
            // RColumn_Level
            // 
            this.RColumn_Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RColumn_Level.HeaderText = "Ур. Комфортности";
            this.RColumn_Level.Name = "RColumn_Level";
            this.RColumn_Level.Width = 161;
            // 
            // RColumn_Description
            // 
            this.RColumn_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RColumn_Description.HeaderText = "Описание";
            this.RColumn_Description.Name = "RColumn_Description";
            // 
            // RColumn_AdditionalServices
            // 
            this.RColumn_AdditionalServices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RColumn_AdditionalServices.HeaderText = "Доп. услуги";
            this.RColumn_AdditionalServices.Name = "RColumn_AdditionalServices";
            // 
            // RColumn_Remove
            // 
            this.RColumn_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RColumn_Remove.HeaderText = "Удалить";
            this.RColumn_Remove.Name = "RColumn_Remove";
            this.RColumn_Remove.Text = "Удалить";
            this.RColumn_Remove.UseColumnTextForButtonValue = true;
            this.RColumn_Remove.Width = 82;
            // 
            // FColumn_Name
            // 
            this.FColumn_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FColumn_Name.HeaderText = "Имя";
            this.FColumn_Name.Name = "FColumn_Name";
            // 
            // FColumn_Remove
            // 
            this.FColumn_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FColumn_Remove.HeaderText = "Удалить";
            this.FColumn_Remove.Name = "FColumn_Remove";
            this.FColumn_Remove.Text = "Удалить";
            this.FColumn_Remove.UseColumnTextForButtonValue = true;
            this.FColumn_Remove.Width = 69;
            // 
            // FormEditHotelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 360);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(605, 316);
            this.Name = "FormEditHotelData";
            this.Text = "Настройки отеля";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Furniture)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPage_Furniture.ResumeLayout(false);
            this.TabPage_Furniture.PerformLayout();
            this.TabPage_RoomTypes.ResumeLayout(false);
            this.TabPage_RoomTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RoomTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Furniture;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage_Furniture;
        private System.Windows.Forms.TabPage TabPage_RoomTypes;
        private System.Windows.Forms.DataGridView DataGridView_RoomTypes;
        private System.Windows.Forms.Label Label_Furniture_BukcetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_RoomType_BukcetData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Furniture_All;
        private System.Windows.Forms.Button Button_Furniture_Bukcet;
        private System.Windows.Forms.Button Button_RoomType_All;
        private System.Windows.Forms.Button Button_RoomType_Bukcet;
        private System.Windows.Forms.DataGridViewTextBoxColumn FColumn_Name;
        private System.Windows.Forms.DataGridViewButtonColumn FColumn_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn RColumn_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn RColumn_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RColumn_AdditionalServices;
        private System.Windows.Forms.DataGridViewButtonColumn RColumn_Remove;
    }
}