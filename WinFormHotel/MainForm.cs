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
using WinFormHotel.FORMS;

namespace WinFormHotel
{
    /// <summary>
    /// Главная форма, точка входа в приложение
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        /// <summary>
        /// Информация об отеле
        /// </summary>
        HotelInfo hotelInfo;
        /// <summary>
        /// Список номеров отеля, отсортированный по этажам, т.е. ключ - этаж, значение - номера на этаже
        /// </summary>
        Dictionary<short, List<HotelNumber>> dictFloors;
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {            
            InitialLogin(); // Регистрация или вход /Выбор отеля
        }

        #region Additional functions
        /// <summary>
        /// Метод для инициализации нового пользователя
        /// </summary>
        private void InitialLogin()
        {
            //Форма для заполнения данных для входа
            Form_Login form = new Form_Login();

            if (form.ShowDialog() == DialogResult.OK) // Если вход успешен, значит регистрация прошла и отель существует;
            {
                hotelInfo = form.Director.HotelInfo; // Получаем заполненные данные из формы
                this.Text += hotelInfo.Name;
                dictFloors = new Dictionary<short, List<HotelNumber>>(); // Инициализация переменной
                ComboBox_Comfortable.Items.Clear();
                ComboBox_Comfortable.Items.AddRange(HotelCreator.GetComfortData());
                ComboBox_Comfortable.SelectedIndex = 0;
                UpdateDictionary(hotelInfo);
                UpdateListViewHotel(this.dictFloors);
            }
            else // В случае если нажата кнопка выйти
            {
                this.Close();
            }
        }
        /// <summary>
        /// Получить номера из строки. Этаж № 1, получить 1
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private short GetIndex(string text)
        {
            return short.Parse(text.Substring(text.LastIndexOf(' ')));
        }
        #endregion

        /// <summary>
        /// Обработка нажатия кнопки по элементу управления номерами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewHotel_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ListViewHotel.SelectedIndices.Count > 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var item = this.ListViewHotel.SelectedItems[0];
                    short floorIndex = GetIndex(item.Group.Header);
                    short roomIndex = GetIndex(item.Text);

                    var number = dictFloors[floorIndex].Where(x => x.RoomIndex == roomIndex).First();
                    FormCreateNewUser form = new FormCreateNewUser(number.Guest);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        HotelCreator.AddGuestToHotel(this.hotelInfo, number, HotelCreator.AddOrUpdate(form.NewGuest));
                        UpdateDictionary(hotelInfo);
                        UpdateListViewHotel(this.dictFloors);
                    }
                }
            }
        }

        #region Filter

        /// <summary>
        /// Приминение фильтра
        /// </summary>
        /// <param name="IsFree"></param>
        /// <param name="bedCount"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private Dictionary<short, List<HotelNumber>> ApplyFilter(bool IsFree, short bedCount, string level)
        {
            Dictionary<short, List<HotelNumber>> tempDict = new Dictionary<short, List<HotelNumber>>();
            // Фильтруем содержание по фильтрам
            foreach (var floor in this.dictFloors)
            {
                foreach (var roomList in dictFloors[floor.Key])
                {
                    if (IsFree)
                    {
                        if (roomList.IsEmpty && roomList.BedCount >= bedCount && roomList.Comfortable.Equals(level))
                        {
                            if (tempDict.ContainsKey(floor.Key))
                            {
                                tempDict[floor.Key].Add(roomList);
                            }
                            else
                            {
                                tempDict.Add(floor.Key, new List<HotelNumber>() { roomList });
                            }
                        }
                    }
                    else
                    {
                        if (roomList.BedCount >= bedCount && roomList.Comfortable.Equals(level))
                        {
                            if (tempDict.ContainsKey(floor.Key))
                            {
                                tempDict[floor.Key].Add(roomList);
                            }
                            else
                            {
                                tempDict.Add(floor.Key, new List<HotelNumber>() { roomList });
                            }
                        }

                    }
                
                    
                }
            }
            this.Label_FilterCount.Text = tempDict.Count.ToString();
            return tempDict;
        }
      
        /// <summary>
        /// Кнопка поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Search_Click(object sender, EventArgs e)
        {
            UpdateListViewHotel(ApplyFilter(this.CheckBox_OnlyEmpty.Checked, (short)this.NumericUpDown_BedCount.Value, this.ComboBox_Comfortable.Text));
        }
        
        /// <summary>
        /// Кнопка показать все
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ShowAll_Click(object sender, EventArgs e)
        {
            UpdateListViewHotel(this.dictFloors);
        }
        #endregion

        #region Dictionary
        /// <summary>
        /// Обновить словарь по данным из отеля
        /// </summary>
        /// <param name="hotel"></param>
        private void UpdateDictionary(HotelInfo hotel)
        {
            this.dictFloors.Clear(); // Очищаем словарь
            // Заполняем словарь
            foreach (var number in hotel.HotelNumbers)
            {
                if (dictFloors.ContainsKey(number.FloorIndex))
                {
                    dictFloors[number.FloorIndex].Add(number);
                }
                else
                {
                    dictFloors.Add(number.FloorIndex, new List<HotelNumber>
                    {
                        number
                    });
                }
            }            
        }

        /// <summary>
        /// Обновить отели по словарю
        /// </summary>
        /// <param name="floorsDict"></param>
        private void UpdateListViewHotel(Dictionary<short,List<HotelNumber>> floorsDict)
        {
            this.ListViewHotel.Groups.Clear();
            this.ListViewHotel.Items.Clear();

            foreach (var item in floorsDict)
            {
                ListViewGroup floor = new ListViewGroup($"Этаж № {item.Key}");

                foreach (var number in item.Value)
                {
                    if (number.IsEmpty)
                        this.ListViewHotel.Items.Add(new ListViewItem($"Комната № {number.RoomIndex}", 0, floor));
                    else
                        this.ListViewHotel.Items.Add(new ListViewItem($"Комната № {number.RoomIndex}", 1, floor));
                }
                this.ListViewHotel.Groups.Add(floor);
            }
        }

        /// <summary>
        /// Обновить значение в словаре
        /// </summary>
        /// <param name="floor">Этаж который надо обновить</param>
        /// <param name="roomIndex">Комната которую надо обновить</param>
        /// <param name="newValue">Комната</param>
        private void UpdateDictionaryValue(short floor, short roomIndex, HotelNumber newValue)
        {
            for (int i = 0; i < this.dictFloors[floor].Count; i++)
            {
                if (dictFloors[floor][i].RoomIndex == roomIndex)
                {
                    dictFloors[floor][i] = newValue;
                    break;
                }
            }
        }
        #endregion
        
        #region Context Menu Number
      
        /// <summary>
        /// Пр.кн. мыши Детали номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewHotel.SelectedIndices.Count > 0)
            {
                var item = this.ListViewHotel.SelectedItems[0]; // Получаем элемент который надо получить

                if (item != null)
                {
                    short floorIndex = GetIndex(item.Group.Header); // Получаем этаж
                    short roomIndex = GetIndex(item.Text); // Получаем комнату

                    Options_HotelNumber form = new Options_HotelNumber(HotelCreator.GetHotelNumber(this.hotelInfo.Id, floorIndex, roomIndex));

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        UpdateDictionaryValue(floorIndex, roomIndex, HotelCreator.AddOrUpdate(form.HotelNumber));
                        UpdateListViewHotel(this.dictFloors);
                    }
                }
            }
        }
        /// <summary>
        /// Освободить номер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberFreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewHotel.SelectedIndices.Count > 0)
            {
                var item = this.ListViewHotel.SelectedItems[0];
                if (item != null)
                {
                    //Получаем номер
                    HotelNumber number = HotelCreator.GetHotelNumber(this.hotelInfo.Id, GetIndex(item.Group.Header), GetIndex(item.Text));
                    if (number != null && !number.IsEmpty)
                    {
                        //Обновляем
                        UpdateDictionaryValue(number.FloorIndex, number.RoomIndex, HotelCreator.ReleaseNumber(number));
                        ListViewHotel.Items[this.ListViewHotel.SelectedIndices[0]].ImageIndex = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Настройки этажа, нажимать на НОМЕР
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FloorSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListViewHotel.SelectedIndices.Count > 0)
            {
                var item = this.ListViewHotel.SelectedItems[0];
                if (item != null)
                {
                    Options_FloorEdit floor = new Options_FloorEdit(this.dictFloors[GetIndex(item.Group.Header)]);
                     
                    if (floor.ShowDialog() == DialogResult.OK)
                    {
                        // Обновляем БД и получаем из обновлённой БД номера по этажу
                        dictFloors[GetIndex(item.Group.Header)] = HotelCreator.AddOrUpdate(floor.HotelNumbers);
                        // Обновляем
                        UpdateListViewHotel(this.dictFloors);
                    }
                }
            }
        }
        #endregion  

        #region Options
        /// <summary>
        /// Настройки отеля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HotelInfo form = new Form_HotelInfo(this.hotelInfo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.hotelInfo = form.Hotel;
                //Обновление всех данных
                UpdateDictionary(this.hotelInfo);
                UpdateListViewHotel(this.dictFloors);
            }
        }

        /// <summary>
        /// Обновление данных по работникам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Options_Workers form = new Options_Workers(this.hotelInfo.HotelWorkers.Where(x=>x.AcessLvl > 0).ToArray());
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.hotelInfo.HotelWorkers = form.ListWorkers;
            }
        }

        /// <summary>
        /// Настройки ур. комфорта в отели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComfortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditHotelData data = new FormEditHotelData(1);

            if (data.ShowDialog() == DialogResult.OK)
            {
                //TODO: Upd
                this.ComboBox_Comfortable.Items.Clear();
                this.ComboBox_Comfortable.Items.AddRange(HotelCreator.GetComfortData());
            }
        }
       /// <summary>
       /// Настройка мебели в отели
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void FurnitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditHotelData data = new FormEditHotelData();
            if (data.ShowDialog() == DialogResult.OK)
            {
            }
        }
        /// <summary>
        /// Инициализировать вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitialLogin();
        }

        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}