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
    public partial class dlinaspeed : FormPattern
    {
        List<MarathonObjects>
               mo = new List<MarathonObjects>();
        public dlinaspeed()
        {
            InitializeComponent();


            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox3",
                Name = "Слизняка",
                Length = 0.01,
                Speed = 0.01,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.slug }
            });

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox8",
                Name = "Болида",
                Length = 3.5,
                Speed = 345,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.f1_car }
            });

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox4",
                Name = "Ишака",
                Length = 1.6,
                Speed = 24,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.horse }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox5",
                Name = "Ленивца",
                Length = 0.4,
                Speed = 4,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.sloth }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox6",
                Name = "Капибары",
                Length = 1.3,
                Speed = 35,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.capybara }
            });

            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox7",
                Name = "Ягуара",
                Length = 1.8,
                Speed = 80,
                Type = 1,
                Picture = new PictureBox { Image = Properties.Resources.jaguar }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox13",
                Name = "Автобус",
                Length = 10,
                Type = 0,
                Picture = new PictureBox { Image = Properties.Resources.bus }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox9",
                Name = "Тапочки",
                Length = 0.3,
                Type = 0,
                Picture = new PictureBox { Image = Properties.Resources.pair_of_havaianas }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox10",
                Name = "Аэробус а380",
                Length = 37.5,
                Type = 0,
                Picture = new PictureBox { Image = Properties.Resources.airbus_a380 }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox11",
                Name = "Футбольный стадион",
                Length = 105,
                Type = 0,
                Picture = new PictureBox { Image = Properties.Resources.football_field }
            });
            mo.Add(new MarathonObjects
            {
                ObjectName = "pictureBox12",
                Name = "Роналдиньо",
                Length = 1.81,
                Type = 0,
                Picture = new PictureBox { Image = Properties.Resources.ronaldinho }
            });
        }

        public class MarathonObjects
        {
            public string ObjectName;
            public string Name;
            public double Length;
            public double Speed;
            public int Type;
            public PictureBox Picture;
        }

        private void dlinaspeed_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)

        {
            PictureBox CurrentPicture = sender as PictureBox;

            var m = mo.Where(p => p.ObjectName == CurrentPicture.Name).Single();


            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox2.Image = m.Picture.Image;
            }

            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox2.Image = m.Picture.Image;
            }

            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 1)
            {
                label4.Text = "Скорость " + m.Name + " составляет " + m.Speed + " км/ч. Потребуется " + (42 * 60 / m.Speed).ToString("0.") + " минут, чтобы преодолеть на весь марафон";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 0)
            {
                label4.Text = "Длина " + m.Name + " составляет " + m.Length + ". Это займёт " + (42000 / m.Length).ToString("0.") + " шт, чтобы покрыть расстояние в 42 км марафона";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 0)
            {
                label4.Text = "Длина " + m.Name + " составляет " + m.Length + ". Это займёт " + (42000 / m.Length).ToString("0.") + " шт, чтобы покрыть расстояние в 42 км марафона";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 0)
            {
                label4.Text = "Длина " + m.Name + " составляет " + m.Length + ". Это займёт " + (42000 / m.Length).ToString("0.") + " шт, чтобы покрыть расстояние в 42 км марафона";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 0)
            {
                label4.Text = "Длина " + m.Name + " составляет " + m.Length + ". Это займёт " + (42000 / m.Length).ToString("0.") + " шт, чтобы покрыть расстояние в 42 км марафона";
                pictureBox2.Image = m.Picture.Image;
            }
            if (m.Type == 0)
            {
                label4.Text = "Длина " + m.Name + " составляет " + m.Length + ". Это займёт " + (42000 / m.Length).ToString("0.") + " шт, чтобы покрыть расстояние в 42 км марафона";
                pictureBox2.Image = m.Picture.Image;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
            FormMap MainForm = new FormMap();
            MainForm.Owner = this;
            MainForm.Show();
            this.Hide();
        }
    }
}
