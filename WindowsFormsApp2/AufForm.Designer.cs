
namespace WindowsFormsApp2
{
    partial class AufForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AufForm));
            this.ButtonOtmena2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOtmena2
            // 
            this.ButtonOtmena2.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOtmena2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOtmena2.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold);
            this.ButtonOtmena2.Location = new System.Drawing.Point(709, 446);
            this.ButtonOtmena2.Name = "ButtonOtmena2";
            this.ButtonOtmena2.Size = new System.Drawing.Size(75, 23);
            this.ButtonOtmena2.TabIndex = 0;
            this.ButtonOtmena2.Text = "Отмена";
            this.ButtonOtmena2.UseVisualStyleBackColor = false;
            this.ButtonOtmena2.Click += new System.EventHandler(this.ButtonOtmena2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(165, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(495, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "Регистрация на Марафон";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AufForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonOtmena2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AufForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.AufForm_Load);
            this.Controls.SetChildIndex(this.ButtonOtmena2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOtmena2;
        private System.Windows.Forms.Button button1;
    }
}