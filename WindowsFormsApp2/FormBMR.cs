using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormBMR : FormPattern
    {
        public FormBMR()
        {
            InitializeComponent();
        }

        private void FormBMR_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.DarkRed)
            {
                pictureBox3.BackColor = Color.DarkRed;
                pictureBox2.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                pictureBox3.BackColor = Color.DarkRed;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.DarkRed)
            {
                pictureBox2.BackColor = Color.DarkRed;
                pictureBox3.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                pictureBox2.BackColor = Color.DarkRed;
            }
        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DarkSeaGreen;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.DarkSeaGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            double height = Convert.ToDouble(textBox8.Text);
            double weight = Convert.ToDouble(textBox9.Text);
            double age = Convert.ToDouble(textBox7.Text);
            double bmr; 
            double sit; 
            double small; 
            double mid; 
            double high;
            double max;


            if (pictureBox2.BackColor == Color.DarkRed)
            {
                if (height >= 100 && weight >= 35 && age <= 102)
                {
                    bmr = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
                    maskedTextBox9.Text = Convert.ToString(bmr);

                    sit = bmr * 1.2;
                    small = bmr * 1.375;
                    mid = bmr * 1.55;
                    high = bmr * 1.725;
                    max = bmr * 1.9;

                    maskedTextBox8.Text = Convert.ToString(sit);
                    maskedTextBox7.Text = Convert.ToString(small);
                    maskedTextBox6.Text = Convert.ToString(mid);
                    maskedTextBox5.Text = Convert.ToString(high);
                    maskedTextBox4.Text = Convert.ToString(max);
                }
                else
                {
                    MessageBox.Show("Вы ввели некорректное значение", "Выберите пол", MessageBoxButtons.OK); 
                }
            }
            else if (pictureBox3.BackColor == Color.DarkRed)
            {
                bmr = 65 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
                maskedTextBox9.Text = Convert.ToString(bmr);

                sit = bmr * 1.2;
                small = bmr * 1.375;
                mid = bmr * 1.55;
                high = bmr * 1.725;
                max = bmr * 1.9;

                maskedTextBox8.Text = Convert.ToString(sit);
                maskedTextBox7.Text = Convert.ToString(small);
                maskedTextBox6.Text = Convert.ToString(mid);
                maskedTextBox5.Text = Convert.ToString(high);
                maskedTextBox4.Text = Convert.ToString(max);
            }
            else
            {
                MessageBox.Show("Выберите пол", "Вы ввели некорректное значение", MessageBoxButtons.OK);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox9.Clear();
            textBox7.Clear();
            pictureBox2.BackColor = Color.DarkSeaGreen;
            pictureBox3.BackColor = Color.DarkSeaGreen;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Подтверждение выхода", "Вы уверены, что хотите выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes
                )
            {
                Application.Exit();
            }

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Подтверждение выхода", "Вы уверены, что хотите выйти?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;

                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();

        }
    }

}

