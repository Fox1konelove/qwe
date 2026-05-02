using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace зд1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string n = be.Text;

            if (price.Text != "")
            {
                double p = Convert.ToDouble(price.Text);

                for (int i = 1; i <= 10; i++)
                {
                    double total = i * p;
                    txt.Text = txt.Text + n + ": " + i + " шт. = " + total + " руб." + "\r\n";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите цену.");
            }
        }

        private void zk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
