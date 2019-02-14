namespace WinFormHotel.FORMS
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.PictureBox_Login = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Enter = new System.Windows.Forms.Button();
            this.Button_Registration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Hotels = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(97, 156);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(280, 22);
            this.TextBox_Login.TabIndex = 2;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(97, 184);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(280, 22);
            this.TextBox_Password.TabIndex = 3;
            // 
            // PictureBox_Login
            // 
            this.PictureBox_Login.BackgroundImage = global::WinFormHotel.Properties.Resources.UserLogin;
            this.PictureBox_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Login.ErrorImage = null;
            this.PictureBox_Login.Location = new System.Drawing.Point(160, 12);
            this.PictureBox_Login.Name = "PictureBox_Login";
            this.PictureBox_Login.Size = new System.Drawing.Size(113, 108);
            this.PictureBox_Login.TabIndex = 4;
            this.PictureBox_Login.TabStop = false;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(294, 212);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(83, 28);
            this.Button_Exit.TabIndex = 6;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Enter
            // 
            this.Button_Enter.Location = new System.Drawing.Point(205, 212);
            this.Button_Enter.Name = "Button_Enter";
            this.Button_Enter.Size = new System.Drawing.Size(83, 28);
            this.Button_Enter.TabIndex = 4;
            this.Button_Enter.Text = "Войти";
            this.Button_Enter.UseVisualStyleBackColor = true;
            this.Button_Enter.Click += new System.EventHandler(this.Button_Enter_Click);
            // 
            // Button_Registration
            // 
            this.Button_Registration.Location = new System.Drawing.Point(97, 212);
            this.Button_Registration.Name = "Button_Registration";
            this.Button_Registration.Size = new System.Drawing.Size(102, 28);
            this.Button_Registration.TabIndex = 5;
            this.Button_Registration.Text = "Регистрация";
            this.Button_Registration.UseVisualStyleBackColor = true;
            this.Button_Registration.Click += new System.EventHandler(this.Button_Registration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Гостиница:";
            // 
            // ComboBox_Hotels
            // 
            this.ComboBox_Hotels.FormattingEnabled = true;
            this.ComboBox_Hotels.Location = new System.Drawing.Point(97, 126);
            this.ComboBox_Hotels.Name = "ComboBox_Hotels";
            this.ComboBox_Hotels.Size = new System.Drawing.Size(280, 24);
            this.ComboBox_Hotels.TabIndex = 1;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 254);
            this.Controls.Add(this.ComboBox_Hotels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Registration);
            this.Controls.Add(this.Button_Enter);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.PictureBox_Login);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.PictureBox PictureBox_Login;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Enter;
        private System.Windows.Forms.Button Button_Registration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Hotels;
    }
}