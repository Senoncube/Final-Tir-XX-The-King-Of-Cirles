namespace Tir1
{
    partial class osugame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osugame));
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.Label();
            this.cstimer = new System.Windows.Forms.Timer(this.components);
            this.cslabel = new System.Windows.Forms.Label();
            this.gtimer = new System.Windows.Forms.Timer(this.components);
            this.fps = new System.Windows.Forms.Timer(this.components);
            this.PicBar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combolabel = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.PauseBuuton = new System.Windows.Forms.Button();
            this.coinpb = new System.Windows.Forms.PictureBox();
            this.CoinLabel = new System.Windows.Forms.Label();
            this.shieldpb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldpb)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPic
            // 
            this.MainPic.Location = new System.Drawing.Point(12, 66);
            this.MainPic.Name = "MainPic";
            this.MainPic.Size = new System.Drawing.Size(958, 529);
            this.MainPic.TabIndex = 0;
            this.MainPic.TabStop = false;
            this.MainPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseClick);
            this.MainPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseDown);
            this.MainPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Счёт:";
            // 
            // schet
            // 
            this.schet.AutoSize = true;
            this.schet.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schet.Location = new System.Drawing.Point(163, 19);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(32, 35);
            this.schet.TabIndex = 3;
            this.schet.Text = "0";
            // 
            // cstimer
            // 
            this.cstimer.Interval = 1000;
            this.cstimer.Tick += new System.EventHandler(this.cstimer_Tick);
            // 
            // cslabel
            // 
            this.cslabel.AutoSize = true;
            this.cslabel.Font = new System.Drawing.Font("Arial", 350F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cslabel.Location = new System.Drawing.Point(200, 9);
            this.cslabel.MaximumSize = new System.Drawing.Size(1833, 653);
            this.cslabel.MinimumSize = new System.Drawing.Size(1833, 653);
            this.cslabel.Name = "cslabel";
            this.cslabel.Size = new System.Drawing.Size(1833, 653);
            this.cslabel.TabIndex = 5;
            this.cslabel.Text = "label3";
            this.cslabel.Visible = false;
            // 
            // gtimer
            // 
            this.gtimer.Interval = 10;
            this.gtimer.Tick += new System.EventHandler(this.gtimer_Tick);
            // 
            // fps
            // 
            this.fps.Interval = 10;
            this.fps.Tick += new System.EventHandler(this.fps_Tick);
            // 
            // PicBar
            // 
            this.PicBar.Location = new System.Drawing.Point(12, 601);
            this.PicBar.Name = "PicBar";
            this.PicBar.Size = new System.Drawing.Size(958, 61);
            this.PicBar.TabIndex = 6;
            this.PicBar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Комбо:";
            // 
            // combolabel
            // 
            this.combolabel.AutoSize = true;
            this.combolabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combolabel.Location = new System.Drawing.Point(391, 19);
            this.combolabel.Name = "combolabel";
            this.combolabel.Size = new System.Drawing.Size(118, 35);
            this.combolabel.TabIndex = 8;
            this.combolabel.Text = "1x (0%)";
            // 
            // heart1
            // 
            this.heart1.Image = ((System.Drawing.Image)(resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(755, 9);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(49, 51);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart1.TabIndex = 9;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(810, 9);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(49, 51);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart2.TabIndex = 10;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.Image = ((System.Drawing.Image)(resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(865, 9);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(49, 51);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heart3.TabIndex = 11;
            this.heart3.TabStop = false;
            // 
            // PauseBuuton
            // 
            this.PauseBuuton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseBuuton.BackgroundImage")));
            this.PauseBuuton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PauseBuuton.FlatAppearance.BorderSize = 0;
            this.PauseBuuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBuuton.Location = new System.Drawing.Point(19, 11);
            this.PauseBuuton.Name = "PauseBuuton";
            this.PauseBuuton.Size = new System.Drawing.Size(52, 46);
            this.PauseBuuton.TabIndex = 12;
            this.PauseBuuton.UseVisualStyleBackColor = true;
            this.PauseBuuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // coinpb
            // 
            this.coinpb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coinpb.BackgroundImage")));
            this.coinpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coinpb.Location = new System.Drawing.Point(608, 11);
            this.coinpb.Name = "coinpb";
            this.coinpb.Size = new System.Drawing.Size(63, 51);
            this.coinpb.TabIndex = 14;
            this.coinpb.TabStop = false;
            // 
            // CoinLabel
            // 
            this.CoinLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoinLabel.Location = new System.Drawing.Point(666, 17);
            this.CoinLabel.Name = "CoinLabel";
            this.CoinLabel.Size = new System.Drawing.Size(83, 39);
            this.CoinLabel.TabIndex = 13;
            this.CoinLabel.Text = "0";
            this.CoinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shieldpb
            // 
            this.shieldpb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shieldpb.BackgroundImage")));
            this.shieldpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shieldpb.Location = new System.Drawing.Point(920, 9);
            this.shieldpb.Name = "shieldpb";
            this.shieldpb.Size = new System.Drawing.Size(50, 51);
            this.shieldpb.TabIndex = 15;
            this.shieldpb.TabStop = false;
            // 
            // osugame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.shieldpb);
            this.Controls.Add(this.coinpb);
            this.Controls.Add(this.CoinLabel);
            this.Controls.Add(this.PauseBuuton);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.combolabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicBar);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPic);
            this.Controls.Add(this.cslabel);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "osugame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.osugame_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.osugame_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.osugame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MainPic;
        private Label label1;
        private Label schet;
        private System.Windows.Forms.Timer cstimer;
        private Label cslabel;
        private System.Windows.Forms.Timer gtimer;
        private System.Windows.Forms.Timer fps;
        private PictureBox PicBar;
        private Label label2;
        private Label combolabel;
        private PictureBox heart1;
        private PictureBox heart2;
        private PictureBox heart3;
        private Button PauseBuuton;
        private PictureBox coinpb;
        private Label CoinLabel;
        private PictureBox shieldpb;
    }
}