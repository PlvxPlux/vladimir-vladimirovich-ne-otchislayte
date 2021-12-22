
namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonAuf = new System.Windows.Forms.Button();
            this.ButtonReg = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.buttonMar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОМарафонеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bMIКалькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.насколькоДолгийМарафонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интерактивнаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияНаФорумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОМарафонеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAuf
            // 
            this.ButtonAuf.BackColor = System.Drawing.Color.Peru;
            this.ButtonAuf.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonAuf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.ButtonAuf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAuf.Location = new System.Drawing.Point(190, 130);
            this.ButtonAuf.Name = "ButtonAuf";
            this.ButtonAuf.Size = new System.Drawing.Size(95, 23);
            this.ButtonAuf.TabIndex = 0;
            this.ButtonAuf.Text = "Авторизация";
            this.ButtonAuf.UseVisualStyleBackColor = false;
            this.ButtonAuf.Click += new System.EventHandler(this.ButtonAuf_Click);
            // 
            // ButtonReg
            // 
            this.ButtonReg.BackColor = System.Drawing.Color.Peru;
            this.ButtonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReg.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.ButtonReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonReg.Location = new System.Drawing.Point(312, 130);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(97, 23);
            this.ButtonReg.TabIndex = 1;
            this.ButtonReg.Text = "Регистрация";
            this.ButtonReg.UseVisualStyleBackColor = false;
            this.ButtonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Peru;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.ButtonExit.ForeColor = System.Drawing.Color.Snow;
            this.ButtonExit.Location = new System.Drawing.Point(269, 312);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(59, 22);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonMar
            // 
            this.buttonMar.BackColor = System.Drawing.Color.Peru;
            this.buttonMar.FlatAppearance.BorderSize = 0;
            this.buttonMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonMar.Location = new System.Drawing.Point(227, 235);
            this.buttonMar.Name = "buttonMar";
            this.buttonMar.Size = new System.Drawing.Size(153, 23);
            this.buttonMar.TabIndex = 3;
            this.buttonMar.Text = "Информация о марафоне";
            this.buttonMar.UseVisualStyleBackColor = false;
            this.buttonMar.Click += new System.EventHandler(this.buttonMar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button1.Location = new System.Drawing.Point(398, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ves";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button2.Location = new System.Drawing.Point(129, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "BMR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Peru;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.перейтиКToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // перейтиКToolStripMenuItem
            // 
            this.перейтиКToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem,
            this.регистрацияToolStripMenuItem,
            this.информацияОМарафонеToolStripMenuItem1,
            this.bMIКалькуляторToolStripMenuItem,
            this.вычисленияToolStripMenuItem,
            this.насколькоДолгийМарафонToolStripMenuItem,
            this.интерактивнаяКартаToolStripMenuItem,
            this.регистрацияНаФорумToolStripMenuItem});
            this.перейтиКToolStripMenuItem.Name = "перейтиКToolStripMenuItem";
            this.перейтиКToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.перейтиКToolStripMenuItem.Text = "Перейти к...";
            this.перейтиКToolStripMenuItem.Click += new System.EventHandler(this.перейтиКToolStripMenuItem_Click);
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // информацияОМарафонеToolStripMenuItem1
            // 
            this.информацияОМарафонеToolStripMenuItem1.Name = "информацияОМарафонеToolStripMenuItem1";
            this.информацияОМарафонеToolStripMenuItem1.Size = new System.Drawing.Size(230, 22);
            this.информацияОМарафонеToolStripMenuItem1.Text = "Информация о марафоне";
            this.информацияОМарафонеToolStripMenuItem1.Click += new System.EventHandler(this.информацияОМарафонеToolStripMenuItem1_Click);
            // 
            // bMIКалькуляторToolStripMenuItem
            // 
            this.bMIКалькуляторToolStripMenuItem.Name = "bMIКалькуляторToolStripMenuItem";
            this.bMIКалькуляторToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.bMIКалькуляторToolStripMenuItem.Text = "BMI - калькулятор";
            this.bMIКалькуляторToolStripMenuItem.Click += new System.EventHandler(this.bMIКалькуляторToolStripMenuItem_Click);
            // 
            // вычисленияToolStripMenuItem
            // 
            this.вычисленияToolStripMenuItem.Name = "вычисленияToolStripMenuItem";
            this.вычисленияToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.вычисленияToolStripMenuItem.Text = "Вычисления";
            this.вычисленияToolStripMenuItem.Click += new System.EventHandler(this.вычисленияToolStripMenuItem_Click);
            // 
            // насколькоДолгийМарафонToolStripMenuItem
            // 
            this.насколькоДолгийМарафонToolStripMenuItem.Name = "насколькоДолгийМарафонToolStripMenuItem";
            this.насколькоДолгийМарафонToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.насколькоДолгийМарафонToolStripMenuItem.Text = "Насколько долгий марафон";
            this.насколькоДолгийМарафонToolStripMenuItem.Click += new System.EventHandler(this.насколькоДолгийМарафонToolStripMenuItem_Click);
            // 
            // интерактивнаяКартаToolStripMenuItem
            // 
            this.интерактивнаяКартаToolStripMenuItem.Name = "интерактивнаяКартаToolStripMenuItem";
            this.интерактивнаяКартаToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.интерактивнаяКартаToolStripMenuItem.Text = "Интерактивная карта";
            this.интерактивнаяКартаToolStripMenuItem.Click += new System.EventHandler(this.интерактивнаяКартаToolStripMenuItem_Click);
            // 
            // регистрацияНаФорумToolStripMenuItem
            // 
            this.регистрацияНаФорумToolStripMenuItem.Name = "регистрацияНаФорумToolStripMenuItem";
            this.регистрацияНаФорумToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.регистрацияНаФорумToolStripMenuItem.Text = "Регистрация На форум";
            this.регистрацияНаФорумToolStripMenuItem.Click += new System.EventHandler(this.регистрацияНаФорумToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Справка";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem2.Text = "О программе";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Peru;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1075, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WindowsFormsApp2.Properties.Resources.man;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton1";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApp2.Properties.Resources.woman;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картаToolStripMenuItem,
            this.информацияОМарафонеToolStripMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.картаToolStripMenuItem.Text = "Карта";
            this.картаToolStripMenuItem.Click += new System.EventHandler(this.картаToolStripMenuItem_Click);
            // 
            // информацияОМарафонеToolStripMenuItem
            // 
            this.информацияОМарафонеToolStripMenuItem.Name = "информацияОМарафонеToolStripMenuItem";
            this.информацияОМарафонеToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.информацияОМарафонеToolStripMenuItem.Text = "Информация о марафоне";
            this.информацияОМарафонеToolStripMenuItem.Click += new System.EventHandler(this.информацияОМарафонеToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Text = "Навигация...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(130, 22);
            this.toolStripLabel1.Text = "Проект: Медведев М.Р";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 435);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMar);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonReg);
            this.Controls.Add(this.ButtonAuf);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAuf;
        private System.Windows.Forms.Button ButtonReg;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button buttonMar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОМарафонеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bMIКалькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem насколькоДолгийМарафонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерактивнаяКартаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОМарафонеToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem регистрацияНаФорумToolStripMenuItem;
    }
}

