using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tovari = { "Яблоки", "Бананы", "Апельсины", "Груши", "Киви", "Виноград", "Манго", "Персики" };
            int[] koli = { 50, 30, 0, 25, 0, 40, 15, 20 };
            double[] ceni = { 120, 150, 200, 180, 250, 300, 350, 280 };

            for (int i = 0; i < tovari.Length; i++)
            {
                dataGridView1.Rows.Add(tovari[i], koli[i].ToString(), ceni[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vsego = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Visible == true)
                {
                    if (dataGridView1.Rows[i].Cells["kol"].Value != null &&
                        dataGridView1.Rows[i].Cells["cena"].Value != null)
                    {
                        string kolText = dataGridView1.Rows[i].Cells["kol"].Value.ToString();
                        string cenaText = dataGridView1.Rows[i].Cells["cena"].Value.ToString();

                        if (kolText != "" && cenaText != "")
                        {
                            double kol = Convert.ToDouble(kolText);
                            double cena = Convert.ToDouble(cenaText);

                            double sum = kol * cena;
                            vsego = vsego + sum;
                        }
                    }
                }
            }
            label1.Text = "Сумма: " + vsego + " руб.";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["cena"].Value != null)
                    {
                        string cenaText = dataGridView1.Rows[i].Cells["cena"].Value.ToString();
                        if (cenaText != "")
                        {
                            double cena = Convert.ToDouble(cenaText);

                            if (cena > 200)
                            {
                                dataGridView1.Rows[i].Visible = true;  
                            }
                            else
                            {
                                dataGridView1.Rows[i].Visible = false; 
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
            label1.Text = "Сумма: 0";
        }
    }
}
