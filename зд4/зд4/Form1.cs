using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace зд4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] mas = new double[8];
        int n = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            {
                if (n > 0)
                {
                    double summa = 0;
                    for (int i = 0; i < n; i++)
                    {
                        summa = summa + mas[i];
                    }
                    txt_sum.Text = Convert.ToString(summa);

                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            {
                if (n < 8)
                {
                    if (num.Text != "")
                    {
                        mas[n] = Convert.ToDouble(num.Text);
                        mass.Text = mass.Text + mas[n] + "\r\n";
                        

                        num.Clear();
                        n = n + 1;
                    }
                }
                else
                {
                    MessageBox.Show("Массив уже полный!");
                }
            }
        }
    }
}
