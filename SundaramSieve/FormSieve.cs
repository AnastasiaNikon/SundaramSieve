using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SundaramSieve
{
    public partial class FormSieve : Form
    {
        public FormSieve()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            string message = "Решето Сундарама – детерминированный алгоритм нахождения всех простых чисел до некоторого целого числа N." +
                "\nДанная программа немного модифицирует базовый алгоритм и предлагает поиск первых N-простых чисел.\n" +
                "\nДля построения решета необходимо ввести значение N в диапазоне [1; 50] в соответствующее поле и нажать на кнопку \"Найти N-простых чисел\"." +
                "После данных действий программа построит решето и выведет его на экран." +
                "\nВы можете сохранить данное решето при помощи кнопки \"Сохранить решето\".\n" +
                "\n(C)ТУСУР, ФБ, КИБЭВС, 720-1, А. Никоронова";
            string handler = "О программе";

            ShowMessage(message, handler);
        }

        private void buildSieveButton_Click(object sender, EventArgs e)
        {
            uint n = (uint)valueNumeric.Value; // считали значение N
            ShowSieve(n); // получили ответ
        }

        private void saveSieveButton_Click(object sender, EventArgs e)
        {
            SaveImage(решетоGroupBox);
        }

        /// <summary>
        /// Вычисляет и показывает решето на экране 
        /// </summary>
        /// <param name="n">Количество n-простых чисел</param>
        private void ShowSieve(uint n)
        {
            Sundaram sundaram;
            List<uint> primes = new List<uint>();
            uint size = n - 1;
            while (primes.Count != n)
            {
                size++;
                sundaram = new Sundaram(size); // инициализировали экземпляр класса
                primes = new List<uint>();

                do
                {
                    primes.Add(sundaram.NextPrime);
                } while (primes[primes.Count - 1] != 0); // пока не получили 0 забираем числа

                primes.Remove(0); // удаляем 0
            }

            int column = 5; // количество столбцов с таблице
            int row = 1; // начальное количество строк

            // задаем количество строк и столбцов
            sieveDataGridView.RowCount = row;
            sieveDataGridView.ColumnCount = column;

            int count = 3;
            bool flag = false;
            for (int i = 0; i < row && !flag; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sieveDataGridView.Rows[i].Cells[j].Value = count;
                    if (count >= primes[primes.Count - 1])
                    {
                        flag = true;
                        break;
                    }
                    count++;
                }
                if (!flag)
                    sieveDataGridView.RowCount = ++row;
            }

            // убираем фокус с ячеек
            sieveDataGridView.ClearSelection();
            sieveDataGridView.CurrentCell = null;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(sieveDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        uint temp = Convert.ToUInt32(sieveDataGridView[j, i].Value);
                        if (primes.Remove(temp))
                        {
                            sieveDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            sieveDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Сохраняет заданную область формы в файл в виде изображения .png
        /// </summary>
        /// <param name="control">Заданная область формы</param>
        private void SaveImage(Control control)
        {
            if(sieveDataGridView.RowCount > 0)
            {
                Bitmap bitmap = new Bitmap(control.Width, control.Height);
                control.DrawToBitmap(bitmap, control.ClientRectangle);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить изображение как...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.PNG)|*.PNG";
                sfd.ShowHelp = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(sfd.FileName);
                }
            }
            else
            {
                ShowMessage("Сначала постройте решето!", "Ошибка сохранения файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Показывает на экран заданное сообщение
        /// </summary>
        /// <param name="main">Основной текст</param>
        /// <param name="handler">Шапка сообщения</param>
        /// <param name="button">Необходимые кнопки. По умолчанию ОК</param>
        /// <param name="icon">Иконка сообщения. По умолчанию Информация</param>
        private void ShowMessage(string main, string handler, MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(main, handler, button, icon);
        }

        private void sieveDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            ((DataGridView)sender).CurrentCell = null;
        }

        private void sieveDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (MouseButtons != System.Windows.Forms.MouseButtons.None)
                ((DataGridView)sender).CurrentCell = null;
        }
    }
}
