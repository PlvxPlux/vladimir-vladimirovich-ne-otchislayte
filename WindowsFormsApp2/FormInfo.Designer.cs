
namespace WindowsFormsApp2
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonOtmena = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.trackBarImage = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 247);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonOtmena);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonOtmena
            // 
            this.ButtonOtmena.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOtmena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOtmena.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold);
            this.ButtonOtmena.Location = new System.Drawing.Point(557, 3);
            this.ButtonOtmena.Name = "ButtonOtmena";
            this.ButtonOtmena.Size = new System.Drawing.Size(75, 23);
            this.ButtonOtmena.TabIndex = 3;
            this.ButtonOtmena.Text = "Отмена";
            this.ButtonOtmena.UseVisualStyleBackColor = false;
            this.ButtonOtmena.Click += new System.EventHandler(this.ButtonOtmena_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(632, 148);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelImage);
            this.tabPage2.Controls.Add(this.pictureBoxImage);
            this.tabPage2.Controls.Add(this.trackBarImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Галерея";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(6, 10);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(13, 13);
            this.labelImage.TabIndex = 4;
            this.labelImage.Text = "1";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::WindowsFormsApp2.Properties.Resources.brazil;
            this.pictureBoxImage.Location = new System.Drawing.Point(71, 2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(465, 219);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 3;
            this.pictureBoxImage.TabStop = false;
            // 
            // trackBarImage
            // 
            this.trackBarImage.Location = new System.Drawing.Point(6, 26);
            this.trackBarImage.Maximum = 5;
            this.trackBarImage.Minimum = 1;
            this.trackBarImage.Name = "trackBarImage";
            this.trackBarImage.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarImage.Size = new System.Drawing.Size(45, 192);
            this.trackBarImage.TabIndex = 2;
            this.trackBarImage.Value = 1;
            this.trackBarImage.Scroll += new System.EventHandler(this.trackBarImage_Scroll);
            this.trackBarImage.ValueChanged += new System.EventHandler(this.trackBarImage_ValueChanged);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TrackBar trackBarImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonOtmena;
    }
}