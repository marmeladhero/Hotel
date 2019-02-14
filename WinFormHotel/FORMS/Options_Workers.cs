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
    /// Информация об работниках
    /// </summary>
    public partial class Options_Workers : Form
    {
        #region Fields

        /// <summary>
        /// Работники
        /// </summary>
        public List<HotelWorker> ListWorkers { private set; get; }
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="workers">Информация об работниках</param>
        public Options_Workers(ICollection<HotelWorker> workers)
        {
            InitializeComponent();
            if (workers == null)
                ListWorkers = new List<HotelWorker>();
            else
            {
                ListWorkers = workers.ToList();
                UpdateList(ListWorkers); // Обновить значение в листе
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="workers"></param>
        private void UpdateList(List<HotelWorker> workers)
        {
            this.ListWorkers = workers;
            this.DataGridView.Rows.Clear();
            foreach (var worker in ListWorkers)
            {
                this.DataGridView.Rows.Add($"{worker.Name} {worker.Surname} {worker.Patronymic}", worker.ThePost, worker.AcessLvl);
            }
        }

        /// <summary>
        /// Обновление нажатия кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {                
                case 3: //Добавить
                    Options_Director newMember = new Options_Director(ListWorkers);
                    if (newMember.ShowDialog() == DialogResult.OK)
                        UpdateList(newMember.ListWorkers);
                    break;
                case 4: //Удалить
                    if (this.ListWorkers.Count > 0)
                    {
                        this.DataGridView.Rows.RemoveAt(e.RowIndex);
                        this.ListWorkers.RemoveAt(e.RowIndex);
                    }
                    break;
                case 5: //Редакт           
                    if (this.ListWorkers.Count > 0)
                    {
                        Options_Director formNumber = new Options_Director(ListWorkers, e.RowIndex);
                        if (formNumber.ShowDialog() == DialogResult.OK)
                            UpdateList(formNumber.ListWorkers);
                    }
                    break;
                default:
                    break;
            }
        }

        #region Buttons
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
        /// <summary>
        /// Выйти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
        #endregion

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.DataGridView[3, e.RowIndex].Value = "Добавить";
            this.DataGridView[4, e.RowIndex].Value = "-";
            this.DataGridView[5, e.RowIndex].Value = "-";
        }
    }
}
