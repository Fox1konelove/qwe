using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace зд5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] masF = new int[0];
        private void btn_Click(object sender, EventArgs e)
        {
            int[] masB = new int[masF.Length];
            B.Text = "";

            for (int i = 0; i < masF.Length; i++)
            {
                if (masF[i] % 2 != 0)
                {
                    masB[i] = masF[i] * 2;
                }
                else
                {
                    masB[i] = masF[i];
                }
                B.Text = B.Text + masB[i] + "\r\n";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(add.Text);

            int[] temp = new int[masF.Length + 1];
            for (int i = 0; i < masF.Length; i++)
            {
                temp[i] = masF[i];
            }
            temp[masF.Length] = n;
            masF = temp;

            F.Text = "";
            for (int i = 0; i < masF.Length; i++)
            {
                F.Text = F.Text + masF[i] + "\r\n";
            }

            add.Text = "";
        }
    }
    }

