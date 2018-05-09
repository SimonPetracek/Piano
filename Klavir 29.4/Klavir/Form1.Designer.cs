namespace Klavir
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Noty = new System.Windows.Forms.PictureBox();
            this.pictureBox_Klavesy = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_prev = new System.Windows.Forms.Button();
            this.label_counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Noty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Klavesy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Noty
            // 
            this.pictureBox_Noty.Location = new System.Drawing.Point(0, 35);
            this.pictureBox_Noty.Name = "pictureBox_Noty";
            this.pictureBox_Noty.Size = new System.Drawing.Size(1000, 186);
            this.pictureBox_Noty.TabIndex = 2;
            this.pictureBox_Noty.TabStop = false;
            this.pictureBox_Noty.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Noty_Paint);
            // 
            // pictureBox_Klavesy
            // 
            this.pictureBox_Klavesy.Location = new System.Drawing.Point(20, 220);
            this.pictureBox_Klavesy.Name = "pictureBox_Klavesy";
            this.pictureBox_Klavesy.Size = new System.Drawing.Size(961, 211);
            this.pictureBox_Klavesy.TabIndex = 3;
            this.pictureBox_Klavesy.TabStop = false;
            this.pictureBox_Klavesy.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Klavesy_Paint_1);
            this.pictureBox_Klavesy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Klavesy_MouseDown);
            this.pictureBox_Klavesy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Klavesy_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 37);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(966, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(453, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piano master 2018";
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(905, 482);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 5;
            this.button_prev.Text = "Preview";
            this.button_prev.UseVisualStyleBackColor = true;
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Location = new System.Drawing.Point(735, 482);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(35, 13);
            this.label_counter.TabIndex = 6;
            this.label_counter.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Klavesy);
            this.Controls.Add(this.pictureBox_Noty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Noty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Klavesy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Noty;
        private System.Windows.Forms.PictureBox pictureBox_Klavesy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Label label_counter;
    }
}

