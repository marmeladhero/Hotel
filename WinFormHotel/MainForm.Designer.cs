namespace WinFormHotel
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListViewHotel = new System.Windows.Forms.ListView();
            this.ContextMenuStrip_Number = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NumberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberFreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FloorSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.ImgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComfortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FurnitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_FilterCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_ShowAll = new System.Windows.Forms.Button();
            this.ComboBox_Comfortable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Search = new System.Windows.Forms.Button();
            this.NumericUpDown_BedCount = new System.Windows.Forms.NumericUpDown();
            this.CheckBox_OnlyEmpty = new System.Windows.Forms.CheckBox();
            this.ContextMenuStrip_Number.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_BedCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewHotel
            // 
            this.ListViewHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewHotel.ContextMenuStrip = this.ContextMenuStrip_Number;
            this.ListViewHotel.LargeImageList = this.ImgListLarge;
            this.ListViewHotel.Location = new System.Drawing.Point(18, 150);
            this.ListViewHotel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ListViewHotel.Name = "ListViewHotel";
            this.ListViewHotel.Size = new System.Drawing.Size(708, 321);
            this.ListViewHotel.SmallImageList = this.ImgListSmall;
            this.ListViewHotel.TabIndex = 0;
            this.ListViewHotel.UseCompatibleStateImageBehavior = false;
            this.ListViewHotel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewHotel_MouseClick);
            // 
            // ContextMenuStrip_Number
            // 
            this.ContextMenuStrip_Number.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumberDetailsToolStripMenuItem,
            this.NumberFreeToolStripMenuItem,
            this.FloorSettingsToolStripMenuItem});
            this.ContextMenuStrip_Number.Name = "ContextMenuStrip_Number";
            this.ContextMenuStrip_Number.Size = new System.Drawing.Size(180, 70);
            // 
            // NumberDetailsToolStripMenuItem
            // 
            this.NumberDetailsToolStripMenuItem.Name = "NumberDetailsToolStripMenuItem";
            this.NumberDetailsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.NumberDetailsToolStripMenuItem.Text = "Детали номера";
            this.NumberDetailsToolStripMenuItem.Click += new System.EventHandler(this.NumberDetailsToolStripMenuItem_Click);
            // 
            // NumberFreeToolStripMenuItem
            // 
            this.NumberFreeToolStripMenuItem.Name = "NumberFreeToolStripMenuItem";
            this.NumberFreeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.NumberFreeToolStripMenuItem.Text = "Освободить номер";
            this.NumberFreeToolStripMenuItem.Click += new System.EventHandler(this.NumberFreeToolStripMenuItem_Click);
            // 
            // FloorSettingsToolStripMenuItem
            // 
            this.FloorSettingsToolStripMenuItem.Name = "FloorSettingsToolStripMenuItem";
            this.FloorSettingsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.FloorSettingsToolStripMenuItem.Text = "Настройки этажа";
            this.FloorSettingsToolStripMenuItem.Click += new System.EventHandler(this.FloorSettingsToolStripMenuItem_Click);
            // 
            // ImgListLarge
            // 
            this.ImgListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListLarge.ImageStream")));
            this.ImgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListLarge.Images.SetKeyName(0, "Checked32x.ico");
            this.ImgListLarge.Images.SetKeyName(1, "Unchecked32x.ico");
            // 
            // ImgListSmall
            // 
            this.ImgListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListSmall.ImageStream")));
            this.ImgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListSmall.Images.SetKeyName(0, "Checked16x.ico");
            this.ImgListSmall.Images.SetKeyName(1, "Uncheked16x.ico");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.OptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(746, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.CloseAppToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ExitToolStripMenuItem.Text = "Выйти";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CloseAppToolStripMenuItem
            // 
            this.CloseAppToolStripMenuItem.Name = "CloseAppToolStripMenuItem";
            this.CloseAppToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.CloseAppToolStripMenuItem.Text = "Закрыть приложение";
            this.CloseAppToolStripMenuItem.Click += new System.EventHandler(this.CloseAppToolStripMenuItem_Click);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HotelToolStripMenuItem,
            this.WorkersToolStripMenuItem,
            this.ComfortToolStripMenuItem,
            this.FurnitureToolStripMenuItem});
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.OptionsToolStripMenuItem.Text = "Настройки";
            // 
            // HotelToolStripMenuItem
            // 
            this.HotelToolStripMenuItem.Name = "HotelToolStripMenuItem";
            this.HotelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.HotelToolStripMenuItem.Text = "Отель";
            this.HotelToolStripMenuItem.Click += new System.EventHandler(this.HotelToolStripMenuItem_Click);
            // 
            // WorkersToolStripMenuItem
            // 
            this.WorkersToolStripMenuItem.Name = "WorkersToolStripMenuItem";
            this.WorkersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.WorkersToolStripMenuItem.Text = "Работники";
            this.WorkersToolStripMenuItem.Click += new System.EventHandler(this.WorkersToolStripMenuItem_Click);
            // 
            // ComfortToolStripMenuItem
            // 
            this.ComfortToolStripMenuItem.Name = "ComfortToolStripMenuItem";
            this.ComfortToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ComfortToolStripMenuItem.Text = "Ур. Комфорта";
            this.ComfortToolStripMenuItem.Click += new System.EventHandler(this.ComfortToolStripMenuItem_Click);
            // 
            // FurnitureToolStripMenuItem
            // 
            this.FurnitureToolStripMenuItem.Name = "FurnitureToolStripMenuItem";
            this.FurnitureToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.FurnitureToolStripMenuItem.Text = "Мебель";
            this.FurnitureToolStripMenuItem.Click += new System.EventHandler(this.FurnitureToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во кроватей:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Label_FilterCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Button_ShowAll);
            this.groupBox1.Controls.Add(this.ComboBox_Comfortable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button_Search);
            this.groupBox1.Controls.Add(this.NumericUpDown_BedCount);
            this.groupBox1.Controls.Add(this.CheckBox_OnlyEmpty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // Label_FilterCount
            // 
            this.Label_FilterCount.AutoSize = true;
            this.Label_FilterCount.Location = new System.Drawing.Point(160, 94);
            this.Label_FilterCount.Name = "Label_FilterCount";
            this.Label_FilterCount.Size = new System.Drawing.Size(16, 18);
            this.Label_FilterCount.TabIndex = 11;
            this.Label_FilterCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кол-во совпадение:";
            // 
            // Button_ShowAll
            // 
            this.Button_ShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ShowAll.Location = new System.Drawing.Point(539, 64);
            this.Button_ShowAll.Name = "Button_ShowAll";
            this.Button_ShowAll.Size = new System.Drawing.Size(78, 29);
            this.Button_ShowAll.TabIndex = 9;
            this.Button_ShowAll.Text = "Все";
            this.Button_ShowAll.UseVisualStyleBackColor = true;
            this.Button_ShowAll.Click += new System.EventHandler(this.Button_ShowAll_Click);
            // 
            // ComboBox_Comfortable
            // 
            this.ComboBox_Comfortable.FormattingEnabled = true;
            this.ComboBox_Comfortable.Location = new System.Drawing.Point(531, 18);
            this.ComboBox_Comfortable.Name = "ComboBox_Comfortable";
            this.ComboBox_Comfortable.Size = new System.Drawing.Size(170, 26);
            this.ComboBox_Comfortable.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ур. Комфорта:";
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.Location = new System.Drawing.Point(623, 64);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(78, 29);
            this.Button_Search.TabIndex = 6;
            this.Button_Search.Text = "Поиск";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // NumericUpDown_BedCount
            // 
            this.NumericUpDown_BedCount.Location = new System.Drawing.Point(140, 49);
            this.NumericUpDown_BedCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_BedCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_BedCount.Name = "NumericUpDown_BedCount";
            this.NumericUpDown_BedCount.Size = new System.Drawing.Size(72, 24);
            this.NumericUpDown_BedCount.TabIndex = 5;
            this.NumericUpDown_BedCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckBox_OnlyEmpty
            // 
            this.CheckBox_OnlyEmpty.AutoSize = true;
            this.CheckBox_OnlyEmpty.Checked = true;
            this.CheckBox_OnlyEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_OnlyEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBox_OnlyEmpty.Location = new System.Drawing.Point(8, 22);
            this.CheckBox_OnlyEmpty.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_OnlyEmpty.Name = "CheckBox_OnlyEmpty";
            this.CheckBox_OnlyEmpty.Size = new System.Drawing.Size(162, 22);
            this.CheckBox_OnlyEmpty.TabIndex = 4;
            this.CheckBox_OnlyEmpty.Text = "Только свободные";
            this.CheckBox_OnlyEmpty.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListViewHotel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Отель: ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContextMenuStrip_Number.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_BedCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewHotel;
        private System.Windows.Forms.ImageList ImgListSmall;
        private System.Windows.Forms.ImageList ImgListLarge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NumericUpDown_BedCount;
        private System.Windows.Forms.CheckBox CheckBox_OnlyEmpty;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.ComboBox ComboBox_Comfortable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Number;
        private System.Windows.Forms.ToolStripMenuItem NumberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumberFreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FloorSettingsToolStripMenuItem;
        private System.Windows.Forms.Button Button_ShowAll;
        private System.Windows.Forms.Label Label_FilterCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComfortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FurnitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAppToolStripMenuItem;
    }
}

