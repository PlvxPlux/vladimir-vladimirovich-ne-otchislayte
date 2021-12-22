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
    public partial class RegForm : FormPattern
    {
        
        public RegForm()
        {
            InitializeComponent();
        }

        private void ButtonOtmena_Click(object sender, EventArgs e)
        {
            MainForm regForm = new MainForm();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormCalculations MainForm = new FormCalculations();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Подтверждение выхода", "Вы уверены, что хотите выйти из системы?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPass2_Click(object sender, EventArgs e)
        {

        }
    }
}
