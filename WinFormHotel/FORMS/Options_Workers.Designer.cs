namespace WinFormHotel.FORMS
{
    partial class Options_Workers
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column_FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
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
            this.Column_FIO,
            this.Column_Post,
            this.Column_Level,
            this.Column_Add,
            this.Column_Remove,
            this.ColumnEdit});
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.Size = new System.Drawing.Size(785, 316);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.DataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            // 
            // Column_FIO
            // 
            this.Column_FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_FIO.HeaderText = "Ф.И.О";
            this.Column_FIO.Name = "Column_FIO";
            this.Column_FIO.ReadOnly = true;
            // 
            // Column_Post
            // 
            this.Column_Post.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_Post.HeaderText = "Должность";
            this.Column_Post.Name = "Column_Post";
            this.Column_Post.ReadOnly = true;
            this.Column_Post.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Post.Width = 104;
            // 
            // Column_Level
            // 
            this.Column_Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column_Level.HeaderText = "Ур. доступа";
            this.Column_Level.Name = "Column_Level";
            this.Column_Level.Width = 110;
            // 
            // Column_Add
            // 
            this.Column_Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Add.HeaderText = "Добавить";
            this.Column_Add.Name = "Column_Add";
            this.Column_Add.Text = "Добавить";
            this.Column_Add.UseColumnTextForButtonValue = true;
            this.Column_Add.Width = 77;
            // 
            // Column_Remove
            // 
            this.Column_Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Remove.HeaderText = "Удалить";
            this.Column_Remove.Name = "Column_Remove";
            this.Column_Remove.Text = "Удалить";
            this.Column_Remove.UseColumnTextForButtonValue = true;
            this.Column_Remove.Width = 69;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnEdit.HeaderText = "Редактировать";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Text = "Редактировать";
            this.ColumnEdit.UseColumnTextForButtonValue = true;
            this.ColumnEdit.Width = 115;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Exit.Location = new System.Drawing.Point(722, 334);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 29);
            this.Button_Exit.TabIndex = 1;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(625, 334);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(91, 29);
            this.Button_Save.TabIndex = 2;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Options_Workers
            // 
            this.AcceptButton = this.Button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Exit;
            this.ClientSize = new System.Drawing.Size(809, 375);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options_Workers";
            this.Text = "Работники гостиницы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Level;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Add;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Remove;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
    }
}