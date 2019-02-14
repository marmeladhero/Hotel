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
    /// Создание пользователя
    /// </summary>
    public partial class Options_Director : Form
    {
        #region Fields

        /// <summary>
        /// Информацию о админе
        /// </summary>
        public HotelWorker WorkerInfo { get; private set; }
        /// <summary>
        /// Информцию о работниках
        /// </summary>
        public List<HotelWorker> ListWorkers { get; private set; }

        EnumWorkerType workerType;
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        public Options_Director()
        {
            InitializeComponent();

            this.ComboBox_Access.Enabled = false;
        }

        /// <summary>
        /// Директор
        /// </summary>
        /// <param name="admin"></param>
        public Options_Director(HotelWorker admin) : this()
        {
            // Если админ
            if (admin == null)
            {
                WorkerInfo = new HotelWorker();
            }
            else
            {
                Update(admin);
            }

            WorkerInfo = admin;
            WorkerInfo.AcessLvl = 0;
            workerType = EnumWorkerType.Admin;
            this.ComboBox_Access.SelectedIndex = 0;
        }

        /// <summary>
        /// Для работников
        /// </summary>
        /// <param name="workers">список работников</param>
        /// <param name="index">номер работника</param>
        public Options_Director(ICollection<HotelWorker> workers, int index = -1) : this()
        {
            if (workers != null)
                ListWorkers = workers.ToList();
            else
                ListWorkers = new List<HotelWorker>();

            workerType = EnumWorkerType.Worker;

            this.ComboBox_Access.SelectedIndex = 1;

            this.TextBox_Login.Enabled = false;
            this.TextBox_Password.Enabled = false;

            if (index != -1)
            {
                WorkerInfo = workers.ElementAt(index);
                Update(WorkerInfo);
            }
            else
                this.WorkerInfo = new HotelWorker();
        }

        #region Additional functions
        /// <summary>
        /// Заполнение данных в форму
        /// </summary>
        /// <param name="worker"></param>
        private void Update(HotelWorker worker)
        {
            this.TextBox_Surname.Text = worker.Surname;
            this.TextBox_Name.Text = worker.Name;
            this.TextBox_Patronymic.Text = worker.Patronymic;
            this.TextBox_Login.Text = worker.Login;
            this.TextBox_Password.Text = worker.Password;
            this.TextBox_Phonenumber.Text = worker.Phonenumber.ToString();
            this.TextBox_Post.Text = worker.ThePost;
            this.ComboBox_Access.SelectedIndex = worker.AcessLvl;
        }

        /// <summary>
        /// Проверка на существование Директора
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool IsLocalWorkerExist(string name, string surname, string patronymic)
        {
            if (ListWorkers.Where(x => x.Name.Equals(name) && x.Surname.Equals(surname) && x.Patronymic.Equals(patronymic)).Count() > 0)
                return true;
            return false;
        }
 
        /// <summary>
        /// Заполнить данные из формы
        /// </summary>
        private void FillWorker()
        {
            this.WorkerInfo.Surname = this.TextBox_Surname.Text;
            this.WorkerInfo.Name = this.TextBox_Name.Text;
            this.WorkerInfo.Patronymic = this.TextBox_Patronymic.Text;
            this.WorkerInfo.Login = this.TextBox_Login.Text;
            this.WorkerInfo.Password = this.TextBox_Password.Text;
            this.WorkerInfo.Phonenumber = long.Parse(this.TextBox_Phonenumber.Text);
            this.WorkerInfo.ThePost = this.TextBox_Post.Text;
            this.WorkerInfo.AcessLvl = (short)this.ComboBox_Access.SelectedIndex;
            this.WorkerInfo.Password = this.TextBox_Password.Text;
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
            FillWorker();
            // В зависимости от ур. доступа
            switch (workerType)
            {               
                case EnumWorkerType.Worker:
                    if (IsLocalWorkerExist(this.TextBox_Name.Text, this.TextBox_Surname.Text, this.TextBox_Patronymic.Text))
                    {
                        if (MessageBox.Show("Работник с таким именем существует! Заменить запись?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.ListWorkers.Remove(this.ListWorkers.Where(x => x.Login.Equals(this.TextBox_Login.Text) && x.Password.Equals(this.TextBox_Password.Text)).First());
                            this.ListWorkers.Add(this.WorkerInfo);
                        }
                    }
                    else
                    {
                        this.ListWorkers.Add(this.WorkerInfo);
                    }
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Выйти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
        #endregion

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
