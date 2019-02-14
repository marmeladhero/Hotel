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
    /// Форма для добавления мебели
    /// </summary>
    public partial class FormEditFurniture : Form
    {
        #region Fields                
        /// <summary>
        /// Существующая мебель
        /// </summary>
        public List<string> LeftArgs { private set; get; }
        /// <summary>
        /// Добавленная
        /// </summary>
        public List<string> RightArgs { private set; get; }

        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="leftArgs">Существующая мебель</param>
        /// <param name="rightArgs">Добавленная</param>
        public FormEditFurniture(List<string>leftArgs, List<string>rightArgs)
        {            
            InitializeComponent();
            LeftArgs = leftArgs;
            RightArgs = rightArgs;
        }

        /// <summary>
        /// Добавляем мебель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditFurniture_Load(object sender, EventArgs e)
        {
            this.ListBox_Left.Items.AddRange(LeftArgs.ToArray());
            this.ListBox_Right.Items.AddRange(RightArgs.ToArray());
        }

        #region Button's

        /// <summary>
        /// Добавление в существующую мебель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Add_Click(object sender, EventArgs e)
        {            
                  
            if (this.ListBox_Left.SelectedIndex == -1 || this.ListBox_Left.SelectedIndex == this.ListBox_Left.Items.Count - 1)
            {
                this.ListBox_Left.SelectedIndex = 0;
            }
            else
            {
                this.ListBox_Left.SelectedIndex++;
            }

            string value = LeftArgs[this.ListBox_Left.SelectedIndex];

            for (int count = 0; count < AddCount.Value; count++)
            {
                RightArgs.Add(value);
                this.ListBox_Right.Items.Add(value);
            }
        }

        /// <summary>
        /// Удаление из существующей мебели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if (this.ListBox_Right.Items.Count > 0)
            {
                if (this.ListBox_Right.SelectedIndex == -1)
                {
                    this.ListBox_Right.SelectedIndex = 0;
                }
                RightArgs.RemoveAt(this.ListBox_Right.SelectedIndex);

                this.ListBox_Right.Items.RemoveAt(this.ListBox_Right.SelectedIndex);
            }
        }

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
    }
}
