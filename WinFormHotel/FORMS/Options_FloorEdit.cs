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
    /// Управление настройками этажа
    /// </summary>
    public partial class Options_FloorEdit : Form
    {
        #region Fields
        /// <summary>
        /// Информация об номерах на этаже
        /// </summary>
        public List<HotelNumber> HotelNumbers {  private set; get; }
        /// <summary>
        /// Номер этажа
        /// </summary>
        short floor = 0;
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="hotelNumbers">Инфо об номерах на этаже</param>
        public Options_FloorEdit(IEnumerable<HotelNumber> hotelNumbers)
        {
            InitializeComponent();

            this.HotelNumbers = new List<HotelNumber>();
            //Если инфы нет, то заполняем по дефолту
            if (hotelNumbers != null && hotelNumbers.Count() > 0)
            {
                this.Text += floor = hotelNumbers.First().FloorIndex;
                this.HotelNumbers.AddRange(hotelNumbers);
                UpdateDataGridView();
            }
            else
            {
                AddDefaultRow();
            }
        }

        /// <summary>
        /// Если комната существует
        /// </summary>
        /// <param name="roomIndex"></param>
        /// <returns></returns>
        private bool IsRoomExist(short roomIndex)
        {
            foreach (var item in this.HotelNumbers)
            {
                if (item.RoomIndex == roomIndex)
                    return true;
            }
            return false;
        }

        #region DataGridView
        /// <summary>
        /// Добавить строку по-умолчанию
        /// </summary>
        private void AddDefaultRow()
        {
            string level = HotelCreator.EntityConnection.RoomTypes.First().Level; // Получаем информацию об ур. комфорта по-умолчанию
            // Создание комнаты по-умолчанию
            var room = HotelCreator.CreateDefaultNumber(floor);
            room.Comfortable = level;
            DataGridView.Rows.Add(DataGridView.RowCount + 1, 1, level, room.Price, "(нету)", "Добавить", "Удалить", "Редакт.");
            room.RoomIndex = (short)(DataGridView.RowCount);
            // Добавление в список
            this.HotelNumbers.Add(room);
        }

        /// <summary>
        /// Обновление элемента управления в зависимости от данных
        /// </summary>
        private void UpdateDataGridView()
        {
            foreach (var item in this.HotelNumbers)
            {
                if (item.Furniture != null)
                {
                    this.DataGridView.Rows.Add(item.RoomIndex, item.BedCount, item.RoomType.Level, item.Price, item.Furniture.Length > 0 ? "(есть)" : "(нету)");
                }
                else
                {
                    this.DataGridView.Rows.Add(item.RoomIndex, item.BedCount, item.RoomType.Level, item.Price, "(нету)");
                }
            }
        }  
        /// <summary>
        /// Обработка нажатия кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5: // Добавить
                    AddDefaultRow();
                    break;
                case 6: // Удалить
                    if (this.DataGridView.Rows.Count > 1) // Все элементы удалить нельзя
                    {
                        this.DataGridView.Rows.RemoveAt(e.RowIndex);
                        this.HotelNumbers.RemoveAt(e.RowIndex);
                    }
                    break;
                case 7: // Редактировать                    
                    Options_HotelNumber formNumber = new Options_HotelNumber(HotelNumbers[e.RowIndex]);
                    if (formNumber.ShowDialog() == DialogResult.OK)
                    {
                        this.DataGridView[0, e.RowIndex].Value = this.HotelNumbers[e.RowIndex].RoomIndex = formNumber.HotelNumber.RoomIndex;
                        this.DataGridView[1, e.RowIndex].Value = this.HotelNumbers[e.RowIndex].BedCount = formNumber.HotelNumber.BedCount;
                        this.DataGridView[2, e.RowIndex].Value = this.HotelNumbers[e.RowIndex].Comfortable = formNumber.HotelNumber.Comfortable;
                        //this.HotelNumbers[e.RowIndex].RoomType = HotelCreator.EntityConnection.RoomTypes.Where(x => x.Level.Equals(formNumber.HotelNumber.Comfortable)).First();
                        this.DataGridView[3, e.RowIndex].Value = this.HotelNumbers[e.RowIndex].Price = formNumber.HotelNumber.Price;
                        this.HotelNumbers[e.RowIndex].Furniture = formNumber.HotelNumber.Furniture;
                        if (formNumber.HotelNumber.Furniture != null)
                            this.DataGridView[4, e.RowIndex].Value = formNumber.HotelNumber.Furniture.Count() > 0 ? "(есть)" : "(нету)";
                        else
                            this.DataGridView[4, e.RowIndex].Value = "(нету)";
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// После завершения редактирования значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0: // Номер комнаты
                    if (!IsRoomExist(short.Parse(this.DataGridView[0, e.RowIndex].Value.ToString())))
                        this.HotelNumbers[e.RowIndex].RoomIndex = short.Parse(this.DataGridView[0, e.RowIndex].Value.ToString()); // Если комната существует заменить значение, на кол.во этажей
                    else // Если номера нет, то разрешить редактирования                        
                        this.DataGridView[0, e.RowIndex].Value = this.HotelNumbers[e.RowIndex].RoomIndex = (short)(this.DataGridView.Rows.Count);
                    break;
                case 1://Редактирование кол-во комнат
                    this.HotelNumbers[e.RowIndex].BedCount = byte.Parse(this.DataGridView[1, e.RowIndex].Value.ToString());
                    break;
                case 2://Ур.Комфорта
                    this.HotelNumbers[e.RowIndex].Comfortable = this.HotelNumbers[e.RowIndex].RoomType.Level;
                    break;
                case 3://Цена
                    this.HotelNumbers[e.RowIndex].Price = decimal.Parse(this.DataGridView[3, e.RowIndex].Value.ToString());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// При добавление отеля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.DataGridView.Rows[e.RowIndex].Cells[5].Value = "Добавить";
            this.DataGridView.Rows[e.RowIndex].Cells[6].Value = "Удалить";
            this.DataGridView.Rows[e.RowIndex].Cells[7].Value = "Редакт.";
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Выйти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
        #endregion
    }
}