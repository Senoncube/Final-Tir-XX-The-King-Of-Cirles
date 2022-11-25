namespace Tir1
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cstimer = new System.Windows.Forms.Timer(this.components);
            this.gtimer = new System.Windows.Forms.Timer(this.components);
            this.cslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            this.SuspendLayout();
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
            // gtimer
            // 
            this.gtimer.Interval = 10;
            this.gtimer.Tick += new System.EventHandler(this.gtimer_Tick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "lvl:";
            // 
            // schet
            // 
            this.schet.AutoSize = true;
            this.schet.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.schet.Location = new System.Drawing.Point(180, 9);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(36, 39);
            this.schet.TabIndex = 7;
            this.schet.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(552, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Залишилось часу:";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timer.Location = new System.Drawing.Point(860, 9);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(83, 39);
            this.timer.TabIndex = 9;
            this.timer.Text = "15.0";
            // 
            // MainPic
            // 
            this.MainPic.Location = new System.Drawing.Point(12, 66);
            this.MainPic.Name = "MainPic";
            this.MainPic.Size = new System.Drawing.Size(958, 529);
            this.MainPic.TabIndex = 10;
            this.MainPic.TabStop = false;
            this.MainPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseClick_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 46);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(982, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainPic);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cslabel);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 654);
            this.MinimumSize = new System.Drawing.Size(1000, 654);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer cstimer;
        private System.Windows.Forms.Timer gtimer;
        private Label cslabel;
        private Label label1;
        private Label schet;
        private Label label2;
        private Label timer;
        private PictureBox MainPic;
        private Button button1;
    }
}