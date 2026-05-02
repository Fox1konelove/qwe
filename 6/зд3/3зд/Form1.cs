using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3зд
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("алюминий");
            comboBox1.Items.Add("пластик");
            comboBox1.Items.Add("ткань");
            comboBox1.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите высоту!");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите ширину!");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите материал!");
                return;
            }

            string v = textBox1.Text; 
            string sh = textBox2.Text;  
            string m = comboBox1.SelectedItem.ToString(); 
            int a = Convert.ToInt32(v);
            int b = Convert.ToInt32(sh); 

            int s = a * b;  
            double s2 = s / 10000.0;  

            double c = 0;  

            if (m == "алюминий")
            {
                c = 900;
            }
            if (m == "пластик")
            {
                c = 550;
            }
            if (m == "ткань")
            {
                c = 750;
            }

            double itog = s2 * c;


            label4.Text = "Размеры: " + a + " x " + b + " см" + Environment.NewLine;
            label4.Text = label4.Text + "Цена (р/м.кв): " + c + " руб" + Environment.NewLine;
            label4.Text = label4.Text + "Общая цена: " + itog + " руб";
        }
    }
}
