using ExceptionHandler;
using hotelprocessing;
using hotelprocessing.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHotel.FORMS
{
    /// <summary>
    /// Настройка отеля
    /// </summary>
    public partial class Form_HotelInfo : Form
    {        
        #region Fields
        /// <summary>
        /// Отель
        /// </summary>
        public HotelInfo Hotel { get; private set; }
        /// <summary>
        /// Список номеров отеля(по этажам)
        /// </summary>
        public Dictionary<short, List<HotelNumber>> HotelNumbers { set; get; }
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Данные об отеле, null - создание нового</param>
        public Form_HotelInfo(HotelInfo info = null)
        {
            InitializeComponent();

            HotelNumbers = new Dictionary<short, List<HotelNumber>>();

            if (info == null) // Создание нового отеля
            {
                this.Button_Director.Text = "Не зарегистрирован";
                Hotel = new HotelInfo
                {
                    HotelWorker = new HotelWorker()
                };
                AddDefaultRow();
            }
            else // Инициализация входных данных
            {
                Hotel = info;

                if (Hotel.HotelWorker == null)
                {
                    throw new MyException("Form_HotelInfo| director == null");
                }

                InitializeDictionary(Hotel.HotelNumbers);

                this.Button_Director.Text = $"{Hotel.HotelWorker.Surname} {Hotel.HotelWorker.Name} {Hotel.HotelWorker.Patronymic}";
                this.TextBox_Phonenumbers.Text = Hotel.PhoneNumber;
                this.TextBox_Address.Text = Hotel.Address;
                this.TextBox_HotelName.Text = Hotel.Name;
                this.TrackBar_Stars.Value = Hotel.Stars;
                this.Label_StarsData.Text = this.TrackBar_Stars.Value.ToString();
            }
        }
        private void TrackBar_Stars_Scroll(object sender, EventArgs e)
        {
            this.Label_StarsData.Text = this.TrackBar_Stars.Value.ToString();
        }

        #region My Methods
        /// <summary>
        /// Обновление словаря новыми данными
        /// </summary>
        /// <param name="hotelNumbers">Списки номеров отеля</param>
        private void UpdateDictionary(short floor, List<HotelNumber> hotelNumbers)
        {
            this.HotelNumbers[floor] = hotelNumbers;
            this.DataGridView[1, floor - 1].Value = this.HotelNumbers[floor].Count;
        }

        private void ReIndexDictionary()
        {
            Dictionary<short, List<HotelNumber>> temp = new Dictionary<short, List<HotelNumber>>(this.HotelNumbers.Count);

            short count = 0;

            foreach (var j in HotelNumbers)
            {
                count++;
                temp.Add(count, j.Value);
            }
            this.HotelNumbers = temp;
            temp = null;
        }

        private void InitializeDictionary(ICollection<HotelNumber> hotelNumbers)
        {
            this.HotelNumbers.Clear();

            foreach (var item in hotelNumbers) // Перибираем номера
            {
                if (HotelNumbers.ContainsKey(item.FloorIndex)) // Если номер с таким этажом сушествует, значит добавляем номер на этот этаж
                    HotelNumbers[item.FloorIndex].Add(item);
                else // Создаем новый этаж и ложим туда номер
                    HotelNumbers.Add(item.FloorIndex, new List<HotelNumber>() { item });
            }

            this.DataGridView.Rows.Clear();// Очистка элемента управления этажами
            foreach (var key in this.HotelNumbers) // Добавление информации
                this.DataGridView.Rows.Add(key.Key, key.Value.Count);
        }

        /// <summary>
        /// Получение элементов из словаря идущих друг за другом
        /// </summary>
        /// <returns>Коллекция элементов типа "Номер Отеля"</returns>
        private ICollection<HotelNumber> GetCollection()
        {
            List<HotelNumber> temp = new List<HotelNumber>(HotelNumbers.Count); // Инициализация списка с длиной равной количеством элементов в словаре
            foreach (var item in HotelNumbers.Values) // Прохождение по всем элементам
                foreach (var subitem in item)
                    temp.Add(subitem);
            return temp;
        }
        #endregion

        /// <summary>
        /// Обновление лейбла при перемещении ползунка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region DataGridView Hotel Info

        /// <summary>
        /// Добавить строку по-умолчанию
        /// </summary>
        private void AddDefaultRow()
        {
            // Создание номера по-умолчанию на определенном этаже
            var temp = HotelCreator.CreateDefaultNumber((short)(DataGridView.RowCount + 1)); 
            // Добавление в список словаря
            HotelNumbers.Add((short)(DataGridView.RowCount + 1), new List<HotelNumber>() { temp });
            // Добавление в элемент управления нового элемента
            DataGridView.Rows.Add(DataGridView.RowCount + 1, 1);
        }

        /// <summary>
        /// Обработка нажатия на элемент управления этажами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // В зависимости от нажатой колонки
            switch (e.ColumnIndex)
            {
                // Кнопка добавить
                case 2:
                    AddDefaultRow();
                    break;
                case 3: // Кнопка удалить, нельзя удалить все элементы, так как в отели не может быть 0 этажей и номеров
                    if (DataGridView.Rows.Count > 1)
                    {
                        DataGridView.Rows.RemoveAt(e.RowIndex);
                        HotelNumbers.Remove((short)(e.RowIndex + 1));
                        for (int i = 0; i < DataGridView.Rows.Count; i++)
                        {
                            this.DataGridView[0, i].Value = i + 1;                           
                        }
                        ReIndexDictionary();
                    }
                    break;
                case 4: // Редактировать
                    //Получаем из словаря элемент
                    Options_FloorEdit formEdit = new Options_FloorEdit(HotelNumbers[short.Parse(this.DataGridView[0,e.RowIndex].Value.ToString())]);
                    if (formEdit.ShowDialog() == DialogResult.OK) // В случае если изменения после редактирования сохранены
                        UpdateDictionary(short.Parse(this.DataGridView[0, e.RowIndex].Value.ToString()), formEdit.HotelNumbers); // Изменяем текущую инофрмацию об этажах и номерах на них
                    break;
            }
        }
        #endregion

        #region Buttons
        /// <summary>
        /// Кнопка, нажатие на "Работники отеля"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Workers_Click(object sender, EventArgs e)
        {
            // Получение списка работников отеля
            Options_Workers workers = new Options_Workers(Hotel.HotelWorkers.Where(x => x.AcessLvl > 0).ToArray());
            if (workers.ShowDialog() == DialogResult.OK) // В случае сохранение результатов
                this.Hotel.HotelWorkers = workers.ListWorkers; // Пересвоение данных
        }
        /// <summary>
        /// Кнопка, "Ур. Комфорта"
        /// Предназначена для редактирования информации об условиях комфорта отеля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Comfort_Click(object sender, EventArgs e)
        {
            FormEditHotelData form = new FormEditHotelData(1);
            form.ShowDialog();
        }
        /// <summary>
        /// Кнопка, Мебель
        /// Предназначена для редактирования доступной мебели в отели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Furniture_Click(object sender, EventArgs e)
        {
            FormEditHotelData form = new FormEditHotelData();
            form.ShowDialog();
        }
        /// <summary>
        /// Кнопка, Директор
        /// Предназначена для создания/редактирования администратора отеля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Director_Click(object sender, EventArgs e)
        {            
            // Создаем/Обновляем админа
            Options_Director form = new Options_Director(Hotel.HotelWorker);
            if (form.ShowDialog() == DialogResult.OK) // В случае сохранение результата - пересохранение
            {
                this.Hotel.HotelWorker = form.WorkerInfo;                
                this.Button_Director.Text = $"{this.Hotel.HotelWorker.Surname} {this.Hotel.HotelWorker.Name} {this.Hotel.HotelWorker.Patronymic}";
            }
        }
      
        /// <summary>
        /// Кнопка, Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Сохранение результатов деятельности в переменную "Отель"
                this.Hotel.FloorCount = (short)HotelNumbers.Count();
                this.Hotel.HotelNumbers = GetCollection();
                this.Hotel.Stars = (byte)this.TrackBar_Stars.Value;
                this.Hotel.Name = this.TextBox_HotelName.Text;
                this.Hotel.Address = this.TextBox_Address.Text;
                this.Hotel.PhoneNumber = this.TextBox_Phonenumbers.Text;
                if (HotelCreator.IsContains(this.Hotel))
                {
                    if (MessageBox.Show("Такой отель существует! Заменить?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Работа с БД.
                        HotelCreator.AddOrUpdate(this.Hotel);
                        //Выход
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    //Работа с БД.
                    HotelCreator.AddOrUpdate(this.Hotel);
                    //Выход
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}