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
    public partial class FormVes : FormPattern
    {
        public FormVes()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;
        }

        private void FormVes_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
        //private void trackBar1_ValueChanged(object sender, EventArgs e)
        //{
        //    switch (trackBar1.Value)
        //    {
        //        case 1:
        //            pictureBox4.Image = Properties.Resources.small as Image;
        //            label9.Text = "Недостаточный";
        //            break;
        //        case 2:
        //            pictureBox4.Image = Properties.Resources.normal as Image;
        //            label9.Text = "Норма";
        //            break;
        //        case 3:
        //            pictureBox4.Image = Properties.Resources.fat as Image;
        //            label9.Text = "Избыточный";
        //            break;
        //        case 4:
        //            pictureBox4.Image = Properties.Resources.fattest as Image;
        //            label9.Text = "Ожирение";
        //            break;
        //    }
        //}


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double rost;
            double ves;
            double bmi;
            rost = Convert.ToInt32(textBox1.Text);
            ves = Convert.ToInt32(textBox2.Text);
            if ((pictureBox2.BackColor == Color.DarkRed) || (pictureBox3.BackColor == Color.DarkRed))
            {

                if (rost >= 100 && ves >= 40)
                {
                    bmi = (ves) / ((rost / 100) * (rost / 100));
                    if (bmi < 18.5)
                    {
                        label9.Text = bmi.ToString("0.") + "недовес";
                        pictureBox4.Image = Properties.Resources.small;
                        trackBar1.Value = 0;

                    }
                    else if (bmi > 18.5 && bmi < 25)
                    {
                        label9.Text = bmi.ToString("0.") + "нормальный вес ";
                        pictureBox4.Image = Properties.Resources.normal;
                        trackBar1.Value = 1;

                    }
                    else if (bmi > 25 && bmi < 30)
                    {
                        label9.Text = bmi.ToString("0.") + "избыточный вес ";
                        pictureBox4.Image = Properties.Resources.fat;
                        trackBar1.Value = 2;
                    }

                    else if (bmi > 30)
                    {
                        label9.Text = bmi.ToString("0.") + "ожирение ";
                        pictureBox4.Image = Properties.Resources.fattest;
                        trackBar1.Value = 3;
                    }
                }
                else
                {
                    label9.Text = "Введите подходящее число";
                }
            }
            else
            {
                MessageBox.Show("Выберите пол", "Вы ввели некорректное значение", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        public void pictureBox2_Click(object sender, EventArgs e)
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
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DarkSeaGreen;
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

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }
    }
}
