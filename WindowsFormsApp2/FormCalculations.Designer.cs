
namespace WindowsFormsApp2
{
    partial class FormCalculations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculations));
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.button1Date = new System.Windows.Forms.Button();
            this.comboBoxRussia = new System.Windows.Forms.ComboBox();
            this.buttonVivod = new System.Windows.Forms.Button();
            this.buttonDobavit = new System.Windows.Forms.Button();
            this.buttonOchist = new System.Windows.Forms.Button();
            this.textBoxComboBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(13, 100);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBirth.TabIndex = 2;
            this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePickerBirth_ValueChanged);
            // 
            // button1Date
            // 
            this.button1Date.Location = new System.Drawing.Point(13, 126);
            this.button1Date.Name = "button1Date";
            this.button1Date.Size = new System.Drawing.Size(101, 29);
            this.button1Date.TabIndex = 4;
            this.button1Date.Text = "Вывести дату";
            this.button1Date.UseVisualStyleBackColor = true;
            this.button1Date.Click += new System.EventHandler(this.button1Date_Click);
            // 
            // comboBoxRussia
            // 
            this.comboBoxRussia.FormattingEnabled = true;
            this.comboBoxRussia.Location = new System.Drawing.Point(260, 100);
            this.comboBoxRussia.Name = "comboBoxRussia";
            this.comboBoxRussia.Size = new System.Drawing.Size(136, 21);
            this.comboBoxRussia.TabIndex = 5;
            this.comboBoxRussia.SelectedIndexChanged += new System.EventHandler(this.comboBoxRussia_SelectedIndexChanged);
            // 
            // buttonVivod
            // 
            this.buttonVivod.Location = new System.Drawing.Point(260, 132);
            this.buttonVivod.Name = "buttonVivod";
            this.buttonVivod.Size = new System.Drawing.Size(136, 23);
            this.buttonVivod.TabIndex = 6;
            this.buttonVivod.Text = "Вывести из ComboBox";
            this.buttonVivod.UseVisualStyleBackColor = true;
            this.buttonVivod.Click += new System.EventHandler(this.buttonVivod_Click);
            // 
            // buttonDobavit
            // 
            this.buttonDobavit.Location = new System.Drawing.Point(260, 203);
            this.buttonDobavit.Name = "buttonDobavit";
            this.buttonDobavit.Size = new System.Drawing.Size(149, 23);
            this.buttonDobavit.TabIndex = 7;
            this.buttonDobavit.Text = "Добавить в ComboBox";
            this.buttonDobavit.UseVisualStyleBackColor = true;
            this.buttonDobavit.Click += new System.EventHandler(this.buttonDobavit_Click);
            // 
            // buttonOchist
            // 
            this.buttonOchist.Location = new System.Drawing.Point(260, 232);
            this.buttonOchist.Name = "buttonOchist";
            this.buttonOchist.Size = new System.Drawing.Size(149, 23);
            this.buttonOchist.TabIndex = 8;
            this.buttonOchist.Text = "Очистить список";
            this.buttonOchist.UseVisualStyleBackColor = true;
            this.buttonOchist.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxComboBox
            // 
            this.textBoxComboBox.Location = new System.Drawing.Point(260, 178);
            this.textBoxComboBox.Name = "textBoxComboBox";
            this.textBoxComboBox.Size = new System.Drawing.Size(149, 20);
            this.textBoxComboBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.radioButtonWoman);
            this.groupBox1.Controls.Add(this.radioButtonMan);
            this.groupBox1.Location = new System.Drawing.Point(13, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(6, 43);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(75, 17);
            this.radioButtonWoman.TabIndex = 1;
            this.radioButtonWoman.Text = "Женщина";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Checked = true;
            this.radioButtonMan.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMan.TabIndex = 0;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Мужской";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.LightPink;
            this.buttonNazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNazad.BackgroundImage")));
            this.buttonNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNazad.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.buttonNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazad.Location = new System.Drawing.Point(11, 335);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(72, 23);
            this.buttonNazad.TabIndex = 11;
            this.buttonNazad.Text = "Отмена";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(238, 299);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(166, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Подтвердить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(238, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(218, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Я согласен с условиями регистрации";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(219, 106);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 13);
            this.labelDate.TabIndex = 3;
            // 
            // FormCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxComboBox);
            this.Controls.Add(this.buttonOchist);
            this.Controls.Add(this.buttonDobavit);
            this.Controls.Add(this.buttonVivod);
            this.Controls.Add(this.comboBoxRussia);
            this.Controls.Add(this.button1Date);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Name = "FormCalculations";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Controls.SetChildIndex(this.dateTimePickerBirth, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.button1Date, 0);
            this.Controls.SetChildIndex(this.comboBoxRussia, 0);
            this.Controls.SetChildIndex(this.buttonVivod, 0);
            this.Controls.SetChildIndex(this.buttonDobavit, 0);
            this.Controls.SetChildIndex(this.buttonOchist, 0);
            this.Controls.SetChildIndex(this.textBoxComboBox, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.buttonNazad, 0);
            this.Controls.SetChildIndex(this.buttonOk, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Button button1Date;
        private System.Windows.Forms.ComboBox comboBoxRussia;
        private System.Windows.Forms.Button buttonVivod;
        private System.Windows.Forms.Button buttonDobavit;
        private System.Windows.Forms.Button buttonOchist;
        private System.Windows.Forms.TextBox textBoxComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDate;
    }
}