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
    public partial class FormMap : FormPattern
    {
        public FormMap()
        {
            InitializeComponent();
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
        }

        private void FormMap_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 4;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 7;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 6;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 5;
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Подтверждение выхода", "Вы уверены, что хотите выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes
                )
            {
                Application.Exit();
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
