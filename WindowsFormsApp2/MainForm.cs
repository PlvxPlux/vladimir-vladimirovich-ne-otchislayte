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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            RegForm MainForm = new RegForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
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

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void ButtonAuf_Click(object sender, EventArgs e)
        {
            AufForm MainForm = new AufForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void buttonMar_Click(object sender, EventArgs e)
        {
            FormInfo MainForm = new FormInfo();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVes MainForm = new FormVes();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBMR MainForm = new FormBMR();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтверждение закрытия?", "Вы уверены что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void перейтиКToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AufForm MainForm = new AufForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegForm MainForm = new RegForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void информацияОМарафонеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo MainForm = new FormInfo();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void bMIКалькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVes MainForm = new FormVes();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void вычисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculations MainForm = new FormCalculations();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void насколькоДолгийМарафонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlinaspeed MainForm = new dlinaspeed();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void интерактивнаяКартаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMap MainForm = new FormMap();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBMIinfo MainForm = new FormBMIinfo();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAbout MainForm = new FormAbout();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMap pointsForm = new FormMap();

            pointsForm.Owner = this;
            pointsForm.Show();
            this.Hide();
        }

        private void информацияОМарафонеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo pointsForm = new FormInfo();

            pointsForm.Owner = this;
            pointsForm.Show();
            this.Hide();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripButton2.BackColor == Color.DarkRed)
            {
                toolStripButton3.BackColor = Color.DarkRed;
                toolStripButton2.BackColor = Color.White;
            }
            else
            {
                toolStripButton3.BackColor = Color.DarkRed;
            }

        }
        private void toolStripButton3_DoubleClick(object sender, EventArgs e)
        {
            toolStripButton3.BackColor = Color.White;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripButton3.BackColor == Color.DarkRed)
            {
                toolStripButton2.BackColor = Color.DarkRed;
                toolStripButton3.BackColor = Color.White;
            }
            else
            {
                toolStripButton2.BackColor = Color.DarkRed;
            }
        }
        private void toolStripButton2_DoubleClick(object sender, EventArgs e)
        {
            toolStripButton2.BackColor = Color.White;
        }

        private void регистрацияНаФорумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculations MainForm = new FormCalculations();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }
    }
}
