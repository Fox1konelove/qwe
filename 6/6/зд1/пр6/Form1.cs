using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Введите текст в textBox1!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите строку для удаления");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения!");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("tags.txt"))
                {
                    int q = listBox1.Items.Count;
                    sw.WriteLine(q);

                    foreach (string z in listBox1.Items)
                    {
                        sw.WriteLine(z);
                    }
                }
                MessageBox.Show("Сохранено в tags.txt!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!File.Exists("tags.txt"))
            {
                MessageBox.Show("Файл tags.txt не найден");
            }
            else
            {
                listBox1.Items.Clear();

                using (StreamReader sr = new StreamReader("tags.txt"))
                {
                    string d = sr.ReadLine();

                    if (d != null)
                    {
                        int q = Convert.ToInt32(d);

                        for (int w = 0; w < q; w++)
                        {
                            string r = sr.ReadLine();
                            if (r != null)
                            {
                                listBox1.Items.Add(r);
                            }
                        }
                    }
                }
                MessageBox.Show("Загружено из tags.txt!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                textBox2.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] stroki = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    stroki[i] = listBox1.Items[i].ToString();
                }
                File.WriteAllLines(dlg.FileName, stroki);
                MessageBox.Show("Сохранено!");
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] stroki = File.ReadAllLines(dlg.FileName);
                foreach (string s in stroki)
                {
                    listBox1.Items.Add(s);
                }
                MessageBox.Show("Загружено!");
            }
        }
    }
}