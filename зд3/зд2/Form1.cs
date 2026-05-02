using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace зд2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            double ves1 = Convert.ToDouble(ves.Text);
            double rost1 = Convert.ToDouble(rost.Text);

            double a = rost1 - 100;

            if (ves1 > a)
            {
                result.Text = $"Вам надо похудеть на {ves1 - a} кг";
            }
            else if (ves1 < a)
            {
                result.Text = $"Вам надо поправиться на {a - ves1} кг";
            }
            else
            {
                result.Text = $"Вы в полном порядке!";
            }
        }

        private void ves_TextChanged(object sender, EventArgs e)
        {

        }

        private void rost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
