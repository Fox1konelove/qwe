using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Война и мир", "Лев Толстой", "1869");
            dataGridView1.Rows.Add("Преступление и наказание", "Федор Достоевский", "1866");
            dataGridView1.Rows.Add("Мастер и Маргарита", "Михаил Булгаков", "1967");
            dataGridView1.Rows.Add("Евгений Онегин", "Александр Пушкин", "1833");
            dataGridView1.Rows.Add("Тихий Дон", "Михаил Шолохов", "1940");

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Columns["god"].ReadOnly = true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["god"].Index && e.RowIndex >= 0)
            {
                string g = dataGridView1.Rows[e.RowIndex].Cells["god"].Value?.ToString();

                if (!string.IsNullOrEmpty(g))
                {
                    int god = Convert.ToInt32(g);

                    if (god < 2000)
                    {
                        e.CellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string kniga = dataGridView1.Rows[e.RowIndex].Cells["naz"].Value.ToString();
                MessageBox.Show("Вы выбрали книгу: " + kniga, "Информация");
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["god"].Index)
            {
                string txt = e.FormattedValue.ToString();
                int res;

                if (!int.TryParse(txt, out res) && !string.IsNullOrEmpty(txt))
                {
                    MessageBox.Show("Год издания должен содержать только цифры!", "Ошибка");
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["a"].Value = "-";
                }
            }
            MessageBox.Show("Авторы очищены!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kol = dataGridView1.Rows.Count;
            MessageBox.Show($"Общее количество книг в таблице: {kol - 1}" , "Статистика");
        }
    }
}
