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
    /// Класс для редактирования Мебели и ур. комфорта
    /// </summary>
    public partial class FormEditHotelData : Form
    {
        #region Fields
        /// <summary>
        /// Список ур. комфорта
        /// </summary>
        List<RoomType> LstRoomTypes;
        /// <summary>
        /// Список мебели
        /// </summary>
        List<HotelFurniture> LstHotelFurnitures;
        /// <summary>
        /// Корзина для ур. комфорта
        /// </summary>
        List<RoomType> LstRoomTypes_Bucket = new List<RoomType>();
        /// <summary>
        /// Корзина для мебели
        /// </summary>
        List<HotelFurniture> LstHotelFurnitures_Bucket = new List<HotelFurniture>();
        /// <summary>
        /// Сейчас в корзине мебели или нет
        /// </summary>
        bool IsFurnitureBucket = false;
        /// <summary>
        /// Сейчас в корзине ур. комфорта или нет
        /// </summary>
        bool IsRoomTypeBucket = false;
        #endregion

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="tabIndex">0 - мебель; 1 - комфорт</param>
        public FormEditHotelData(int tabIndex = 0)
        {
            InitializeComponent();

            if (tabIndex < this.TabControl.TabPages.Count && tabIndex >= 0)
            {
                this.TabControl.SelectedIndex = tabIndex;
                this.TabControl.TabIndex = tabIndex;
            }
            // Получаем из БД список всей мебели
            LstHotelFurnitures = new List<HotelFurniture>(HotelCreator.GetHotelFurnitures());
            // Получаем из БД список всех уровней комфорта
            LstRoomTypes = new List<RoomType>(HotelCreator.GetRoomTypes());
            // Обновляем элементы управления
            UpdateDataGridView(LstHotelFurnitures);
            UpdateDataGridView(LstRoomTypes);
        }

        #region DataGridView
        /// <summary>
        /// Обновляем DataGridView для мебели
        /// </summary>
        /// <param name="furnitures">Список мебели</param>
        private void UpdateDataGridView(ICollection<HotelFurniture> furnitures)
        {
            this.DataGridView_Furniture.Rows.Clear();

            foreach (var item in furnitures)
            {
                this.DataGridView_Furniture.Rows.Add(item.Name);
            }
        }
        /// <summary>
        /// Обновляем DataGridView для ур. Комфорта
        /// </summary>
        /// <param name="roomTypes">Список ур. комфорта</param>
        private void UpdateDataGridView(ICollection<RoomType> roomTypes)
        {
            this.DataGridView_RoomTypes.Rows.Clear();

            foreach (var item in roomTypes)
            {
                this.DataGridView_RoomTypes.Rows.Add(item.Level, item.Description, item.AdditionalServices);
            }
        }
        #endregion
        
        #region DGV Furniture
        private void DataGridView_Furniture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                if (IsFurnitureBucket) // если корзина
                {
                    if (this.LstHotelFurnitures_Bucket.Count > 0)
                    {
                        this.DataGridView_Furniture.Rows.RemoveAt(e.RowIndex); // Удаляем из элемента управления элемент
                        this.LstHotelFurnitures.Add(this.LstHotelFurnitures_Bucket.ElementAt(e.RowIndex)); // Добавляем ко ВСЕМ элементам элемент из корзины
                        this.LstHotelFurnitures_Bucket.RemoveAt(e.RowIndex); // Удаляем из корзины элемент
                        this.Label_Furniture_BukcetData.Text = this.LstHotelFurnitures_Bucket.Count.ToString(); // Обновляем надпись                        
                    }
                    else
                    {
                        this.Label_Furniture_BukcetData.Text = "(пусто)";
                    }
                }
                else // если НЕ корзина
                {
                    if (this.LstHotelFurnitures.Count > 0)
                    {
                        this.DataGridView_Furniture.Rows.RemoveAt(e.RowIndex);
                        this.LstHotelFurnitures_Bucket.Add(this.LstHotelFurnitures.ElementAt(e.RowIndex));
                        this.LstHotelFurnitures.RemoveAt(e.RowIndex);
                        this.Label_Furniture_BukcetData.Text = this.LstHotelFurnitures_Bucket.Count.ToString();          
                    }
                }
            }
        }
        private void DataGridView_Furniture_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (IsFurnitureBucket)
                e.Cancel = true;
        }
        private void DataGridView_Furniture_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsFurnitureBucket)
            {
                var furniture = new HotelFurniture() { Name = this.DataGridView_Furniture[0, e.RowIndex].Value.ToString() };

                if (this.LstHotelFurnitures.Count != e.RowIndex)
                    this.LstHotelFurnitures[e.RowIndex].Name = furniture.Name;
                else
                {
                    if (this.LstHotelFurnitures.Where(x => x.Name.Equals(furniture.Name)).Count() == 0)
                        this.LstHotelFurnitures.Add(furniture);
                    else
                    {
                        MessageBox.Show("Такой элемент уже существует!");
                        BeginInvoke(new MethodInvoker(delegate { DataGridView_Furniture.Rows.RemoveAt(e.RowIndex); }));
                    }
                }
            }
        }
        /// <summary>
        /// Кнопка "Корзина"- вывести элементы которые В корзине
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Furniture_Bukcet_Click(object sender, EventArgs e)
        {
            this.IsFurnitureBucket = true;
            this.Button_Furniture_Bukcet.Enabled = false;
            this.Button_Furniture_All.Enabled = true;
            UpdateDataGridView(LstHotelFurnitures_Bucket);
        }
        /// <summary>
        /// Кнопка "Все" - вывести элементы которые НЕ в корзине
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Furniture_All_Click(object sender, EventArgs e)
        {
            this.IsFurnitureBucket = false;
            this.Button_Furniture_Bukcet.Enabled = true;
            this.Button_Furniture_All.Enabled = false;
            UpdateDataGridView(LstHotelFurnitures);
        }
        #endregion

        #region DGV RoomTypes
        private void DataGridView_RoomTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && this.LstRoomTypes.Count > 0)
            {
                if (IsRoomTypeBucket) // если корзина
                {
                    if (this.LstRoomTypes_Bucket.Count > 0)
                    {
                        this.DataGridView_RoomTypes.Rows.RemoveAt(e.RowIndex); // Удаляем из элемента управления элемент
                        this.LstRoomTypes.Add(this.LstRoomTypes_Bucket.ElementAt(e.RowIndex)); // Добавляем ко ВСЕМ элементам элемент из корзины
                        this.LstRoomTypes_Bucket.RemoveAt(e.RowIndex); // Удаляем из корзины элемент
                        this.Label_RoomType_BukcetData.Text = this.LstRoomTypes_Bucket.Count.ToString(); // Обновляем надпись
                    }
                    else
                    {
                        this.Label_RoomType_BukcetData.Text = "(пусто)";
                    }
                }
                else // если НЕ корзина
                {
                    if (this.LstRoomTypes.Count > 0)
                    {
                        this.DataGridView_RoomTypes.Rows.RemoveAt(e.RowIndex);
                        this.LstRoomTypes_Bucket.Add(this.LstRoomTypes.ElementAt(e.RowIndex));
                        this.LstRoomTypes.RemoveAt(e.RowIndex);
                        this.Label_RoomType_BukcetData.Text = this.LstRoomTypes_Bucket.Count.ToString();
                    }
                }
            }
        }        
        /// <summary>
        /// Запретить для корзины изменять имя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_RoomTypes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (IsRoomTypeBucket)
                e.Cancel = true;
        }
        private void DataGridView_RoomTypes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsRoomTypeBucket)
            {
                if (this.DataGridView_RoomTypes[0, e.RowIndex].Value != null && this.DataGridView_RoomTypes[1, e.RowIndex].Value != null && this.DataGridView_RoomTypes[2, e.RowIndex].Value != null)
                {
                    var room = new RoomType()
                    {
                        Level = this.DataGridView_RoomTypes[0, e.RowIndex].Value.ToString(),
                        Description = this.DataGridView_RoomTypes[1, e.RowIndex].Value.ToString(),
                        AdditionalServices = this.DataGridView_RoomTypes[2, e.RowIndex].Value.ToString()
                    };

                    if (this.LstRoomTypes.Count != e.RowIndex)
                    {
                        this.LstRoomTypes[e.RowIndex].AdditionalServices = room.AdditionalServices;
                        this.LstRoomTypes[e.RowIndex].Description = room.Description;
                    }
                    else
                    {
                        if (this.LstRoomTypes.Where(x => x.Level.Equals(room.Level)).Count() == 0)
                            this.LstRoomTypes.Add(room);
                        else
                        {
                            MessageBox.Show("Такой элемент уже существует!");
                            BeginInvoke(new MethodInvoker(delegate { DataGridView_RoomTypes.Rows.RemoveAt(e.RowIndex); }));
                        }
                    }
                }
            }
        }   
        private void Button_RoomType_Bukcet_Click(object sender, EventArgs e)
        {
            this.IsRoomTypeBucket = true;
            this.Button_RoomType_Bukcet.Enabled = false;
            this.Button_RoomType_All.Enabled = true;
            UpdateDataGridView(LstRoomTypes_Bucket);
        }
        private void Button_RoomType_All_Click(object sender, EventArgs e)
        {
            this.IsRoomTypeBucket = false;
            this.Button_RoomType_Bukcet.Enabled = true;
            this.Button_RoomType_All.Enabled = false;
            UpdateDataGridView(LstRoomTypes);
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
            try
            {
                HotelCreator.RemoveRange(LstHotelFurnitures_Bucket);

                foreach (var item in LstHotelFurnitures)
                {
                    HotelCreator.AddOrUpdate(item);
                }

                HotelCreator.RemoveRange(LstRoomTypes_Bucket);

                foreach (var item in LstRoomTypes)
                {
                    HotelCreator.AddOrUpdate(item);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        #endregion
    }
}