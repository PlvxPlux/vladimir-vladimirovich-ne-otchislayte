
namespace WindowsFormsApp2
{
    partial class RegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.ButtonOtmena = new System.Windows.Forms.Button();
            this.RegButton2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOtmena
            // 
            this.ButtonOtmena.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOtmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOtmena.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold);
            this.ButtonOtmena.Location = new System.Drawing.Point(255, 421);
            this.ButtonOtmena.Name = "ButtonOtmena";
            this.ButtonOtmena.Size = new System.Drawing.Size(75, 23);
            this.ButtonOtmena.TabIndex = 1;
            this.ButtonOtmena.Text = "Отмена";
            this.ButtonOtmena.UseVisualStyleBackColor = false;
            this.ButtonOtmena.Click += new System.EventHandler(this.ButtonOtmena_Click);
            // 
            // RegButton2
            // 
            this.RegButton2.BackColor = System.Drawing.Color.Transparent;
            this.RegButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegButton2.FlatAppearance.BorderSize = 0;
            this.RegButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton2.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Bold);
            this.RegButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegButton2.Location = new System.Drawing.Point(240, 149);
            this.RegButton2.Name = "RegButton2";
            this.RegButton2.Size = new System.Drawing.Size(175, 57);
            this.RegButton2.TabIndex = 0;
            this.RegButton2.Text = "Регистрация";
            this.RegButton2.UseVisualStyleBackColor = false;
            this.RegButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelLogin.Location = new System.Drawing.Point(247, 192);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(40, 15);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPass.Location = new System.Drawing.Point(235, 217);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(48, 15);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Пароль";
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPass2.Location = new System.Drawing.Point(180, 243);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(107, 15);
            this.labelPass2.TabIndex = 5;
            this.labelPass2.Text = "Повторите пароль";
            this.labelPass2.Click += new System.EventHandler(this.labelPass2_Click);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelFIO.Location = new System.Drawing.Point(252, 270);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(31, 15);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "ФИО";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(303, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(303, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(303, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelData.Location = new System.Drawing.Point(199, 302);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(88, 15);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "Дата рождения";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 323);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.label3.Location = new System.Drawing.Point(174, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Вступительный взнос";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(303, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 56);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelPhoto.Location = new System.Drawing.Point(205, 360);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(82, 15);
            this.labelPhoto.TabIndex = 15;
            this.labelPhoto.Text = "Вставьте Фото";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1269, 585);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelPass2);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonOtmena);
            this.Controls.Add(this.RegButton2);
            this.ForeColor = System.Drawing.Color.Linen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.Controls.SetChildIndex(this.RegButton2, 0);
            this.Controls.SetChildIndex(this.ButtonOtmena, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.labelLogin, 0);
            this.Controls.SetChildIndex(this.labelPass, 0);
            this.Controls.SetChildIndex(this.labelPass2, 0);
            this.Controls.SetChildIndex(this.labelFIO, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.labelData, 0);
            this.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.labelPhoto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonOtmena;
        private System.Windows.Forms.Button RegButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelPhoto;
    }
}