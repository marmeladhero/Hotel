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
    /// Форма для регистрации или получении информации об постояльце
    /// </summary>
    public partial class FormCreateNewUser : Form
    {
        /// <summary>
        /// Постоялец
        /// </summary>
        public Guest NewGuest { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="guest">Постоялец</param>
        public FormCreateNewUser(Guest guest)
        {
            InitializeComponent();
            if (guest == null)
            {
                guest = new Guest();
            }
            else
            {
                Update(guest);
            }
            this.NewGuest = guest;
        }

        /// <summary>
        /// Обновление данных на странице
        /// </summary>
        /// <param name="guest"></param>
        private void Update(Guest guest)
        {
            this.TextBox_Name.Text = guest.FirstName;
            this.TextBox_Surname.Text = guest.LastName;
            this.TextBox_Patronymic.Text = guest.SecondName;

            this.TextBox_Phonenumber.Text = guest.PhoneNumber.ToString();
            this.TextBox_Pasport.Text = guest.PasportNumber;

            this.TextBox_Other.Text = guest.Other;

            this.DateTimePicker_From.Value = guest.Arrival;
            this.DateTimePicker_Departure.Value = guest.Departure;

            foreach (var childs in guest.Child_Guest)
            {
                this.DataGridView_Childs.Rows.Add(childs.FirstName, childs.LastName, childs.SecondName, childs.PhoneNumber);
            }
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            NewGuest.FirstName = this.TextBox_Name.Text ;
            NewGuest.LastName = this.TextBox_Surname.Text;
            NewGuest.SecondName = this.TextBox_Patronymic.Text;

            NewGuest.PhoneNumber = long.Parse(this.TextBox_Phonenumber.Text);
            NewGuest.PasportNumber = this.TextBox_Pasport.Text;

            NewGuest.Other = this.TextBox_Other.Text;

            NewGuest.Arrival = this.DateTimePicker_From.Value;
            NewGuest.Departure = this.DateTimePicker_Departure.Value;
           
            NewGuest.Child_Guest.Clear();

            foreach (DataGridViewRow row in this.DataGridView_Childs.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                    NewGuest.Child_Guest.Add(new Child_Guest() { FirstName = row.Cells[0].Value.ToString(), LastName = row.Cells[1].Value.ToString(), SecondName = row.Cells[2].Value.ToString(), PhoneNumber = long.Parse(row.Cells[3].Value.ToString()) });
            }
            // Сохраняем все данные в переменную типа "Постоялец"
            NewGuest = HotelCreator.AddOrUpdate(NewGuest, NewGuest.Child_Guest);//Добавление или обновление в бд

            DialogResult = DialogResult.OK;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Только цифры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
