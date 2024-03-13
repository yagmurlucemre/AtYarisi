namespace AtYarisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Saha = new Panel();
            at3 = new PictureBox();
            at2 = new PictureBox();
            at1 = new PictureBox();
            bitis = new PictureBox();
            btnBaslat = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSpiker = new Label();
            Saha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)at3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bitis).BeginInit();
            SuspendLayout();
            // 
            // Saha
            // 
            Saha.BackColor = Color.ForestGreen;
            Saha.Controls.Add(at3);
            Saha.Controls.Add(at2);
            Saha.Controls.Add(at1);
            Saha.Controls.Add(bitis);
            Saha.Location = new Point(41, 12);
            Saha.Name = "Saha";
            Saha.Size = new Size(707, 365);
            Saha.TabIndex = 0;
            // 
            // at3
            // 
            at3.Image = (Image)resources.GetObject("at3.Image");
            at3.Location = new Point(0, 270);
            at3.Name = "at3";
            at3.Size = new Size(125, 78);
            at3.SizeMode = PictureBoxSizeMode.Zoom;
            at3.TabIndex = 2;
            at3.TabStop = false;
            at3.Tag = "3";
            // 
            // at2
            // 
            at2.Image = (Image)resources.GetObject("at2.Image");
            at2.Location = new Point(0, 152);
            at2.Name = "at2";
            at2.Size = new Size(125, 78);
            at2.SizeMode = PictureBoxSizeMode.Zoom;
            at2.TabIndex = 1;
            at2.TabStop = false;
            at2.Tag = "2";
            // 
            // at1
            // 
            at1.Image = (Image)resources.GetObject("at1.Image");
            at1.Location = new Point(0, 34);
            at1.Name = "at1";
            at1.Size = new Size(125, 78);
            at1.SizeMode = PictureBoxSizeMode.Zoom;
            at1.TabIndex = 0;
            at1.TabStop = false;
            at1.Tag = "1";
            // 
            // bitis
            // 
            bitis.Image = (Image)resources.GetObject("bitis.Image");
            bitis.Location = new Point(609, 0);
            bitis.Name = "bitis";
            bitis.Size = new Size(78, 365);
            bitis.TabIndex = 3;
            bitis.TabStop = false;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(334, 461);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(112, 34);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblSpiker
            // 
            lblSpiker.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpiker.ForeColor = Color.OliveDrab;
            lblSpiker.Location = new Point(41, 392);
            lblSpiker.Name = "lblSpiker";
            lblSpiker.Size = new Size(707, 59);
            lblSpiker.TabIndex = 2;
            lblSpiker.Text = "Atlar yarışa hazır...";
            lblSpiker.TextAlign = ContentAlignment.MiddleCenter;
            lblSpiker.Click += lblSpiker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(lblSpiker);
            Controls.Add(btnBaslat);
            Controls.Add(Saha);
            Name = "Form1";
            Text = "At Yarışı";
            Saha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)at3).EndInit();
            ((System.ComponentModel.ISupportInitialize)at2).EndInit();
            ((System.ComponentModel.ISupportInitialize)at1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bitis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Saha;
        private PictureBox at1;
        private PictureBox at3;
        private PictureBox at2;
        private PictureBox bitis;
        private Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private Label lblSpiker;
    }
}
