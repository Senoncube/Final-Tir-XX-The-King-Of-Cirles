namespace Tir1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cstimer = new System.Windows.Forms.Timer(this.components);
            this.cslabel = new System.Windows.Forms.Label();
            this.gtimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Счёт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(562, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Залишилось часу:";
            // 
            // schet
            // 
            this.schet.AutoSize = true;
            this.schet.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schet.Location = new System.Drawing.Point(200, 14);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(36, 39);
            this.schet.TabIndex = 3;
            this.schet.Text = "0";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timer.Location = new System.Drawing.Point(870, 14);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(83, 39);
            this.timer.TabIndex = 4;
            this.timer.Text = "15.0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 46);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(982, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPic);
            this.Controls.Add(this.cslabel);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 654);
            this.MinimumSize = new System.Drawing.Size(1000, 654);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MainPic;
        private Label label1;
        private Label label2;
        private Label schet;
        private Label timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer cstimer;
        private Label cslabel;
        private System.Windows.Forms.Timer gtimer;
        private Button button1;
    }
}