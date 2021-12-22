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
    public partial class AufForm : FormPattern
    {
        public AufForm()
        {
            InitializeComponent();
        }

        private void ButtonOtmena2_Click(object sender, EventArgs e)
        {
            MainForm regAuf = new MainForm();
            regAuf.Owner = this;
            regAuf.Show();
            this.Hide();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Подтверждение выхода", "Вы уверены, что хотите закрыть приложение?", MessageBoxButtons.YesNo) == DialogResult.No)
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
            FormCalculations MainForm = new FormCalculations();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }

        private void AufForm_Load(object sender, EventArgs e)
        {

        }
    }
}
