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
    /// Получение информация об номере
    /// </summary>
    public partial class Options_HotelNumber : Form
    {
        #region Fields
        /// <summary>
        /// Номер для редактирования
        /// </summary>
        public HotelNumber HotelNumber { private set; get; }
        /// <summary>
        /// Все уровни комфорта
        /// </summary>
        List<RoomType> collectionOfTypes;
       
        /// <summary>
        /// Left - фурнитура, которая есть, Right - которая выбрана
        /// </summary>
        List<string> leftArgs = new List<string>(), rightArgs = new List<string>();
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="number"></param>
        public Options_HotelNumber(HotelNumber number)
        {
            InitializeComponent();
            
            this.HotelNumber = number;
            // Обновление 
            UpdateCollectionOfRoomTypes();

            if (number == null)
            {                
                this.HotelNumber = new HotelNumber
                {
                    RoomType = new RoomType()
                };
            }
            else
            {
                this.Label_FloorRoom.Text = $"{number.FloorIndex}/{number.RoomIndex}";
                this.TextBox_Price.Text = number.Price.ToString();
                this.NumericUpDown_BedCount.Value = number.BedCount;
                this.ComboBox_RoomTypes.Text = number.Comfortable;
                this.ComboBox_RoomTypes.SelectedIndex = GetIndex(number.Comfortable);
                this.TextBox_Furniture.Text = number.Furniture;
                this.NumericUpDown_BedCount.Value = number.BedCount;
                UpdateDataGridView();
            }
        }

        #region Additioanal functions
        /// <summary>
        /// Получить номер в котором храниться ур.комфорта
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        private int GetIndex(string level)
        {
            for (int i = 0; i < this.collectionOfTypes.Count; i++)
            {
                if (this.collectionOfTypes[i].Level.Equals(level))
                    return i;
            }
            return 0;
        }

        /// <summary>
        /// Обновление информации об ур. комфорта
        /// </summary>
        private void UpdateCollectionOfRoomTypes()
        {
            this.collectionOfTypes = HotelCreator.EntityConnection.RoomTypes.ToList();
            this.ComboBox_RoomTypes.Items.Clear();
            this.ComboBox_RoomTypes.Items.AddRange(collectionOfTypes.Select(x => x.Level).ToArray());
        }
        /// <summary>
        /// Изменение индекса ур. комфорта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = this.collectionOfTypes.ElementAt(this.ComboBox_RoomTypes.SelectedIndex);
            this.TextBox_Description.Text = room.Description;
            this.TextBox_AdditionalServices.Text = room.AdditionalServices;
        }
        #endregion

        #region Buttons

        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            HotelNumber.Price = decimal.Parse(this.TextBox_Price.Text);
            HotelNumber.BedCount = (byte)this.NumericUpDown_BedCount.Value;    
            HotelNumber.Comfortable = HotelCreator.AddOrUpdate(this.collectionOfTypes.ElementAt(this.ComboBox_RoomTypes.SelectedIndex)).Level;
            HotelNumber.Furniture = this.TextBox_Furniture.Text;
            DialogResult = DialogResult.OK;
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
        /// Редактирования информации об ур. комфорта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_EditRoomType_Click(object sender, EventArgs e)
        {
            FormEditHotelData form = new FormEditHotelData(1);

            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateCollectionOfRoomTypes();
            }
        }

        /// <summary>
        /// Редактирование мебели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddFurniture_Click(object sender, EventArgs e)
        {
            leftArgs.AddRange(HotelCreator.EntityConnection.HotelFurnitures.Select(x => x.Name));
            rightArgs.AddRange(this.HotelNumber?.Furniture?.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries) ?? new string[] { });

            FormEditFurniture form = new FormEditFurniture(leftArgs, rightArgs);
            if (form.ShowDialog() == DialogResult.OK)
            {
                rightArgs = form.RightArgs;
                foreach (var item in rightArgs)
                {
                    this.TextBox_Furniture.Text += $"{item};";
                }
            }
        }
        #endregion

        #region DataGridView
        /// <summary>
        /// Обновление инофрмации об постояльцах
        /// </summary>
        private void UpdateDataGridView()
        {
            this.DataGridView_Guests.Rows.Clear();
            if (this.HotelNumber.Guest != null)
                this.DataGridView_Guests.Rows.Add($"{this.HotelNumber.Guest.SecondName} {this.HotelNumber.Guest.FirstName} {this.HotelNumber.Guest.LastName}", this.HotelNumber.Guest.PhoneNumber, this.HotelNumber.Guest.Arrival, this.HotelNumber.Guest.Departure);
        }
        /// <summary>
        /// Обработка нажатия на элемент управления постояльцев
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_Guests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4:
                    FormCreateNewUser user = new FormCreateNewUser(this.HotelNumber.Guest);
                    if (user.ShowDialog() == DialogResult.OK)
                    {
                        UpdateDataGridView();
                    }
                    break;
                case 5:
                    if (e.RowIndex >= 0)
                    {
                        this.HotelNumber.Guest = null;
                        this.HotelNumber.GuestID = null;
                        this.DataGridView_Guests.Rows.RemoveAt(e.RowIndex);
                    }
                    break;
                default:
                    break;
            }
        }
        private void DataGridView_Guests_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Изменяем текст кнопок
            this.DataGridView_Guests.Rows[e.RowIndex].Cells[4].Value = "Детали";
            this.DataGridView_Guests.Rows[e.RowIndex].Cells[5].Value = "Освободить";
        }
        #endregion
    }
}
