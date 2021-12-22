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
    public partial class Form3 : FormPattern
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void trackBarImage_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBarImage.Value)
            {
                case 1:
                    pictureBoxImage.Image = Properties.Resources.brazil as Image;
                    labelImage.Text = "1";
                    break;
                case 2:
                    pictureBoxImage.Image = Properties.Resources.banco_banespa as Image;
                    labelImage.Text = "2";
                    break;
                case 3:
                    pictureBoxImage.Image = Properties.Resources.ibirapuera_park_lake as Image;
                    labelImage.Text = "3";
                    break;
                case 4:
                    pictureBoxImage.Image = Properties.Resources.marathon_image as Image;
                    labelImage.Text = "4";
                    break;
                case 5:
                    pictureBoxImage.Image = Properties.Resources.teatro_municipal as Image;
                    labelImage.Text = "5";
                    break;
            }
        }
        private void FormInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }
        private void trackBarImage_Scroll(object sender, EventArgs e)
        {

        }
       
    }
}
