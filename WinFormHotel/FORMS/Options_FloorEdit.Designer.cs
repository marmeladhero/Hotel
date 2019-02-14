namespace WinFormHotel.FORMS
{
    partial class Options_FloorEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options_FloorEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ImgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Comfortable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Furniture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgListLarge
            // 
            this.ImgListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListLarge.ImageStream")));
            this.ImgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListLarge.Images.SetKeyName(0, "Checked32x.ico");
            this.ImgListLarge.Images.SetKeyName(1, "Unchecked32x.ico");
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(697, 329);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(87, 27);
            this.Button_Save.TabIndex = 2;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Exit.Location = new System.Drawing.Point(790, 329);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 27);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
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
            this.Column_Room,
            this.Column_BedCount,
            this.Column_Comfortable,
            this.Column_Price,
            this.Column_Furniture,
            this.Column_Add,
            this.Column_Remove,
            this.Column_Edit});
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.Size = new System.Drawing.Size(853, 311);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.DataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellEndEdit);
            this.DataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            // 
            // Column_Room
            // 
            this.Column_Room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Room.HeaderText = "Комната";
            this.Column_Room.Name = "Column_Room";
            this.Column_Room.Width = 89;
            // 
            // Column_BedCount
            // 
            this.Column_BedCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_BedCount.HeaderText = "Кол-во мест";
            this.Column_BedCount.Name = "Column_BedCount";
            this.Column_BedCount.Width = 102;
            // 
            // Column_Comfortable
            // 
            this.Column_Comfortable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Comfortable.HeaderText = "Ур. Комфортности";
            this.Column_Comfortable.Name = "Column_Comfortable";
            this.Column_Comfortable.ReadOnly = true;
            this.Column_Comfortable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column_Price
            // 
            this.Column_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Price.HeaderText = "Цена";
            this.Column_Price.Name = "Column_Price";
            // 
            // Column_Furniture
            // 
            this.Column_Furniture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_Furniture.HeaderText = "Мебель";
            this.Column_Furniture.Name = "Column_Furniture";
            this.Column_Furniture.ReadOnly = true;
            this.Column_Furniture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Furniture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_Furniture.Width = 64;
            // 
            // Column_Add
            // 
            this.Column_Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Add.HeaderText = "Добавить";
            this.Column_Add.Name = "Column_Add";
            this.Column_Add.Width = 77;
            // 
            // Column_Remove
            // 
            this.Column_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Remove.HeaderText = "Удалить";
            this.Column_Remove.Name = "Column_Remove";
            this.Column_Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Remove.Width = 88;
            // 
            // Column_Edit
            // 
            this.Column_Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Edit.HeaderText = "Редакт.";
            this.Column_Edit.Name = "Column_Edit";
            this.Column_Edit.Width = 64;
            // 
            // Options_FloorEdit
            // 
            this.AcceptButton = this.Button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Exit;
            this.ClientSize = new System.Drawing.Size(877, 368);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options_FloorEdit";
            this.Text = "Этаж: ";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImgListLarge;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Comfortable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Furniture;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Add;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Remove;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Edit;
    }
}