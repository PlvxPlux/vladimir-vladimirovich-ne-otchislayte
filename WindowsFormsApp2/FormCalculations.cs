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
    public partial class FormCalculations : FormPattern
    {
        
        BindingList<string> list = new BindingList<string>();
        public FormCalculations()
        {
            InitializeComponent();
            list.Add("Мужской");
            list.Add("Женский");
            comboBoxRussia.DataSource = list;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            labelDate.Text = dateTimePickerBirth.Value.ToString("MMM");
        }

        private void button1Date_Click(object sender, EventArgs e)
        {
            TimeSpan diap = DateTime.Now - dateTimePickerBirth.Value;
            string sss = diap.TotalDays.ToString("0.") + " дней\n" + diap.TotalHours.ToString("0.") + " часов\n" + diap.TotalHours.ToString("0.") + " минут";
            MessageBox.Show(sss);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
        }

        private void comboBoxRussia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonVivod_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxRussia.SelectedIndex.ToString());
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            list.Add(textBoxComboBox.Text);
            textBoxComboBox.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Вы не согласились с условиями регистрации!");
            }
            else
            {
                MessageBox.Show("Спасибо за согласие!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                dlinaspeed regForm = new dlinaspeed();
                regForm.Owner = this;
                regForm.Show();
                this.Hide();
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMan.Checked)
            {
                pictureBox2.Image = Properties.Resources.male as Image;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.female as Image;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegForm MainForm = new RegForm();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
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
    }
}
