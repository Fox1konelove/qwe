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

namespace пр5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int attempts = 0;
        int at = 10;
        int rdn = 0;
        Random rd = new Random();
        int[] mas = new int[7];
        int n = 0;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pasw.Text == "" || login.Text == "")
            {
                MessageBox.Show("Введте логин или пороль!");
            }
            else
            {
                string login1 = login.Text;
                string password = pasw.Text;
                int pass = Convert.ToInt32(password);
                int correct = 1234;

                if (password == "")
                {
                    MessageBox.Show("Введите логин и пороль");
                }

                if (pass == correct)
                {
                    MessageBox.Show($"Добро пожаловать\n{login1}!");
                }
                else
                {
                    attempts++;
                    if (attempts < 3)
                    {
                        MessageBox.Show("Неверный пароль \nУ вас осталось " + (3 - attempts));
                    }
                    else
                    {
                        MessageBox.Show("Попытки закончились");
                        Application.Exit();
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (rdn == 0)
            {
                rdn = rd.Next(1, 100);
                at = 10;
            }

            int res = Convert.ToInt32(textBox1.Text);
            at--;


            if (res == rdn)
            {
                MessageBox.Show($"Вы угадал!\n Это было число {rdn}");
                rdn = 0;
            }
            else if (at <= 0)
            {
                MessageBox.Show($"Попытки кончились! Вы проиграли.\n Было загадано: {rdn}");
                rdn = 0;
            }
            else if (res > rdn)
            {
                MessageBox.Show($"Мимо! Бери меньше.\n Осталось попыток: {at}");

            }
            else if (res < rdn)
            {
                MessageBox.Show($"Мимо! Бери больше.\n Осталось попыток: {at}");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);


            if (b != 0)
            {
                double res = (double)a / b;
                textBox4.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка: На 0 делить нельзя");
            }
        }

        private void pasw_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
