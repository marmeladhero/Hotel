namespace WinFormHotel.FORMS
{
    partial class FormEditFurniture
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
            this.ListBox_Right = new System.Windows.Forms.ListBox();
            this.ListBox_Left = new System.Windows.Forms.ListBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.AddCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AddCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox_Right
            // 
            this.ListBox_Right.FormattingEnabled = true;
            this.ListBox_Right.ItemHeight = 16;
            this.ListBox_Right.Location = new System.Drawing.Point(392, 13);
            this.ListBox_Right.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_Right.Name = "ListBox_Right";
            this.ListBox_Right.Size = new System.Drawing.Size(231, 516);
            this.ListBox_Right.TabIndex = 0;
            // 
            // ListBox_Left
            // 
            this.ListBox_Left.FormattingEnabled = true;
            this.ListBox_Left.ItemHeight = 16;
            this.ListBox_Left.Location = new System.Drawing.Point(13, 13);
            this.ListBox_Left.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_Left.Name = "ListBox_Left";
            this.ListBox_Left.Size = new System.Drawing.Size(231, 516);
            this.ListBox_Left.TabIndex = 1;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(251, 162);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(90, 33);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Location = new System.Drawing.Point(251, 201);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(90, 33);
            this.Button_Remove.TabIndex = 3;
            this.Button_Remove.Text = "Удалить";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(251, 240);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(90, 33);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Сохранить";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Exit.Location = new System.Drawing.Point(251, 279);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(90, 33);
            this.Button_Exit.TabIndex = 5;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // AddCount
            // 
            this.AddCount.Location = new System.Drawing.Point(347, 168);
            this.AddCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AddCount.Name = "AddCount";
            this.AddCount.Size = new System.Drawing.Size(38, 22);
            this.AddCount.TabIndex = 6;
            this.AddCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormEditFurniture
            // 
            this.AcceptButton = this.Button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Exit;
            this.ClientSize = new System.Drawing.Size(642, 544);
            this.Controls.Add(this.AddCount);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.ListBox_Left);
            this.Controls.Add(this.ListBox_Right);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditFurniture";
            this.Text = "Редактор мебели";
            this.Load += new System.EventHandler(this.FormEditFurniture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Right;
        private System.Windows.Forms.ListBox ListBox_Left;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.NumericUpDown AddCount;
    }
}