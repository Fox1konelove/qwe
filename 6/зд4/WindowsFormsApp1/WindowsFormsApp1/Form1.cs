using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Россия");
            comboBox1.Items.Add("Австралия");
            comboBox1.Items.Add("Бразилия");
            comboBox1.Items.Add("Египет");
            comboBox1.Items.Add("Китай");
            comboBox1.Sorted = true;

            comboBox2.Items.Add("Россия");
            comboBox2.Items.Add("Австралия");
            comboBox2.Items.Add("Бразилия");
            comboBox2.Items.Add("Египет");
            comboBox2.Items.Add("Китай");
            comboBox2.Sorted = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strana = comboBox2.Text;

            if (strana == "Россия")
            {
                textBox2.Text = "Европа и Азия";
            }
            else if (strana == "Австралия")
            {
                textBox2.Text = "Австралия";
            }
            else if (strana == "Бразилия")
            {
                textBox2.Text = "Южная Америка";
            }
            else if (strana == "Египет")
            {
                textBox2.Text = "Африка";
            }
            else if (strana == "Китай")
            {
                textBox2.Text = "Азия";
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strana = comboBox1.Text;

            if (strana == "Россия")
            {
                textBox1.Text = "Москва";
            }
            else if (strana == "Австралия")
            {
                textBox1.Text = "Канберра";
            }
            else if (strana == "Бразилия")
            {
                textBox1.Text = "Бразилиа";
            }
            else if (strana == "Египет")
            {
                textBox1.Text = "Каир";
            }
            else if (strana == "Китай")
            {
                textBox1.Text = "Пекин";
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
