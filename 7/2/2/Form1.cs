using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Яблоки", "50", "120", "");
            dataGridView1.Rows.Add("Бананы", "30", "150", "");
            dataGridView1.Rows.Add("Апельсины", "0", "200", "");
            dataGridView1.Rows.Add("Груши", "25", "180", "");
            dataGridView1.Rows.Add("Киви", "0", "250", "");
            dataGridView1.Rows.Add("Виноград", "40", "300", "");

            dataGridView1.Columns["t"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["k"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["c"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["f"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void Schet()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string kol = dataGridView1.Rows[i].Cells["k"].Value?.ToString();
                string cena = dataGridView1.Rows[i].Cells["c"].Value?.ToString();

                if (kol != "" && cena != "")
                {
                    double k = Convert.ToDouble(kol);
                    double c = Convert.ToDouble(cena);
                    double s = k * c;
                    dataGridView1.Rows[i].Cells["f"].Value = s.ToString();
                }
                else
                {
                    dataGridView1.Rows[i].Cells["f"].Value = "0";
                }
            }
            Sklad();
        }

        private void Krasit()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string kol = dataGridView1.Rows[i].Cells["k"].Value?.ToString();

                if (kol != "")
                {
                    double k = Convert.ToDouble(kol);

                    if (k == 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void Sklad()
        {
            double vsego = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string s = dataGridView1.Rows[i].Cells["f"].Value?.ToString();

                if (s != "" && s != null)
                {
                    vsego = vsego + Convert.ToDouble(s);
                }
            }

            label1.Text = "Общая стоимость склада: " + vsego + " руб.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string cena = dataGridView1.Rows[i].Cells["c"].Value?.ToString();

                if (cena != "")
                {
                    double c = Convert.ToDouble(cena);
                    double newc = c * 1.1;
                    dataGridView1.Rows[i].Cells["c"].Value = Math.Round(newc, 2).ToString();
                }
            }
            Schet();
            Krasit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {

                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    string kol = dataGridView1.Rows[i].Cells["k"].Value?.ToString();
                    if (!string.IsNullOrEmpty(kol))
                    {
                        double k = Convert.ToDouble(kol);

                        if (k == 0)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }
                }
            }
            Schet();
            Krasit();
        }
    }
}
