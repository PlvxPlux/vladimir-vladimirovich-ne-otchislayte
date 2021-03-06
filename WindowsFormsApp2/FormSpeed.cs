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
    public partial class FormSpeed : FormPattern

    {
        public FormSpeed()
        {
            InitializeComponent();
        }

        private void FormSpeed_Load(object sender, EventArgs e)
        {

        }
        private void DescAndPic(Label lab, PictureBox picB, string desc)
        {
            labelTitlePic.Text = lab.Text;
            pictureBox2.Image = picB.Image;
            labelDesc.Text = desc;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DescAndPic(label13, pictureBox13, "Максимальная скорость F1 Car - 345 km/h. Это займёт примерно 7 минут чтобы завершить 42km.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DescAndPic(label13, pictureBox13, "Максимальная скорость F1 Car - 345 km/h. Это займёт примерно 7 минут чтобы завершить 42km.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DescAndPic(label7, pictureBox3, "Максимальная скорость улитки - 7 sm/m.");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DescAndPic(label7, pictureBox3, "Максимальная скорость улитки - 7 sm/m.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DescAndPic(label3, pictureBox4, "Максимальная скорость лошади - 50-60 km/h.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DescAndPic(label3, pictureBox4, "Максимальная скорость лошади - 50-60 km/h.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DescAndPic(label4, pictureBox5, "Максимальная скорость Ленивца - до 40 km/h.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DescAndPic(label4, pictureBox5, "Максимальная скорость Ленивца - до 40 km/h.");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DescAndPic(label5, pictureBox6, "Максимальная скорость капибары - 45 km/h.");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DescAndPic(label5, pictureBox6, "Максимальная скорость капибары - 45 km/h.");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DescAndPic(label6, pictureBox7, "Максимальная скорость ягуара - 100 km/h.");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DescAndPic(label6, pictureBox7, "Максимальная скорость ягуара - 100 km/h.");
        }

        private void FormSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DescAndPic(label7, pictureBox8, "Длина Bus 10 метров. Это займёт 4200 м из них, чтобы покрыть расстояние в 42 км марафона.");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DescAndPic(label7, pictureBox8, "Длина Bus 10 метров. Это займёт 4200 м из них, чтобы покрыть расстояние в 42 км марафона.");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DescAndPic(label8, pictureBox9, "");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DescAndPic(label8, pictureBox9, "");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DescAndPic(label9, pictureBox10, "");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DescAndPic(label9, pictureBox10, "");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DescAndPic(label10, pictureBox11, "");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DescAndPic(label10, pictureBox11, "");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DescAndPic(label11, pictureBox12, "");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DescAndPic(label11, pictureBox12, "");
        }
    }
}

