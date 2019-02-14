using hotelprocessing;
using hotelprocessing.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHotel.FORMS
{
    /// <summary>
    /// Форма для входа
    /// </summary>
    public partial class Form_Login : Form
    {
        /// <summary>
        /// Администратор отеля
        /// </summary>
        public HotelWorker Director { get; private set; }  
    
        /// <summary>
       /// Конструктор
       /// </summary>
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            // Обновляем из БД
            this.ComboBox_Hotels.Items.AddRange(HotelCreator.GetHotelData());
        }

        #region Button's
        private void Button_Enter_Click(object sender, EventArgs e)
        {
            //Проверка на существование пользователя
            if (HotelCreator.IsUserExists(this.TextBox_Login.Text, this.ComboBox_Hotels.Text))
            {
                // Если существует то не будет null
                Director = HotelCreator.IsUserCorrect(this.TextBox_Login.Text, this.TextBox_Password.Text, this.ComboBox_Hotels.Text);

                if (Director != null)
                {
                    if (Director.AcessLvl == 0) //Ур.доступа
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Доступ ограничен");
                    }
                }
                else
                {
                    MessageBox.Show("Пароль введен не правильно!");
                    this.TextBox_Password.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        /// <summary>
        /// Выйти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Регистрация нового отеля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Registration_Click(object sender, EventArgs e)
        {
            Form_HotelInfo form = new Form_HotelInfo(); // Создаем отель

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.ComboBox_Hotels.Items.Add(form.Hotel.Name); // Добавляем отель(не обновляем информацию из базы данных, а берем инф непосредственно из формы
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Ошибка во время регистрации");
            }
        }
        #endregion
    }
}
