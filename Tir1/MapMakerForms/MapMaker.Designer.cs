namespace Tir1
{
    partial class MapMaker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapMaker));
            this.MainPic = new System.Windows.Forms.PictureBox();
            this.SongTrackBar = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DeleteButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SetStandartButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xTB = new System.Windows.Forms.TextBox();
            this.yTB = new System.Windows.Forms.TextBox();
            this.scTB = new System.Windows.Forms.TextBox();
            this.rTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.res2TB = new System.Windows.Forms.TextBox();
            this.res1TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.speedTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PlayGameButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.button1 = new System.Windows.Forms.Button();
            this.skinb1 = new System.Windows.Forms.Button();
            this.skinb2 = new System.Windows.Forms.Button();
            this.skinb3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPic
            // 
            this.MainPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPic.Location = new System.Drawing.Point(12, 50);
            this.MainPic.Name = "MainPic";
            this.MainPic.Padding = new System.Windows.Forms.Padding(10);
            this.MainPic.Size = new System.Drawing.Size(958, 529);
            this.MainPic.TabIndex = 1;
            this.MainPic.TabStop = false;
            this.MainPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseDown);
            this.MainPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseMove);
            this.MainPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPic_MouseUp);
            // 
            // SongTrackBar
            // 
            this.SongTrackBar.DrawBackground = true;
            this.SongTrackBar.LargeChange = 100;
            this.SongTrackBar.Location = new System.Drawing.Point(220, 12);
            this.SongTrackBar.Maximum = 1000;
            this.SongTrackBar.Name = "SongTrackBar";
            this.SongTrackBar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SongTrackBar.Size = new System.Drawing.Size(672, 27);
            this.SongTrackBar.StateCommon.Position.Color1 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Position.Color2 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Position.Color3 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Position.Color4 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Position.Color5 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Tick.Color1 = System.Drawing.Color.White;
            this.SongTrackBar.StateCommon.Track.Color1 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Track.Color2 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Track.Color3 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Track.Color4 = System.Drawing.Color.Black;
            this.SongTrackBar.StateCommon.Track.Color5 = System.Drawing.Color.Black;
            this.SongTrackBar.TabIndex = 2;
            this.SongTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.SongTrackBar.Scroll += new System.EventHandler(this.SongTrackBar_Scroll);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(95, 12);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(119, 28);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "0";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalTimeLabel.Location = new System.Drawing.Point(898, 12);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(61, 28);
            this.TotalTimeLabel.TabIndex = 4;
            this.TotalTimeLabel.Text = "1:43";
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = global::Tir1.Properties.Resources._375;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(53, 11);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(36, 29);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(768, 585);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.DeleteButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Values.Text = "Видалити";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SetStandartButton
            // 
            this.SetStandartButton.Location = new System.Drawing.Point(768, 620);
            this.SetStandartButton.Name = "SetStandartButton";
            this.SetStandartButton.Size = new System.Drawing.Size(191, 29);
            this.SetStandartButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetStandartButton.TabIndex = 8;
            this.SetStandartButton.Values.Text = "Встановити як стандарт";
            this.SetStandartButton.Click += new System.EventHandler(this.SetStandartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "x = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "y = ";
            // 
            // xTB
            // 
            this.xTB.Location = new System.Drawing.Point(72, 585);
            this.xTB.Name = "xTB";
            this.xTB.Size = new System.Drawing.Size(70, 27);
            this.xTB.TabIndex = 11;
            this.xTB.TextChanged += new System.EventHandler(this.xTB_TextChanged);
            // 
            // yTB
            // 
            this.yTB.Location = new System.Drawing.Point(72, 621);
            this.yTB.Name = "yTB";
            this.yTB.Size = new System.Drawing.Size(70, 27);
            this.yTB.TabIndex = 12;
            this.yTB.TextChanged += new System.EventHandler(this.yTB_TextChanged);
            // 
            // scTB
            // 
            this.scTB.Location = new System.Drawing.Point(236, 620);
            this.scTB.Name = "scTB";
            this.scTB.Size = new System.Drawing.Size(70, 27);
            this.scTB.TabIndex = 16;
            this.scTB.TextChanged += new System.EventHandler(this.scTB_TextChanged);
            // 
            // rTB
            // 
            this.rTB.Location = new System.Drawing.Point(236, 584);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(70, 27);
            this.rTB.TabIndex = 15;
            this.rTB.TextChanged += new System.EventHandler(this.rTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(184, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "sc = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(194, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "r = ";
            // 
            // res2TB
            // 
            this.res2TB.Location = new System.Drawing.Point(419, 620);
            this.res2TB.Name = "res2TB";
            this.res2TB.Size = new System.Drawing.Size(70, 27);
            this.res2TB.TabIndex = 20;
            this.res2TB.TextChanged += new System.EventHandler(this.res2TB_TextChanged);
            // 
            // res1TB
            // 
            this.res1TB.Location = new System.Drawing.Point(419, 584);
            this.res1TB.Name = "res1TB";
            this.res1TB.Size = new System.Drawing.Size(70, 27);
            this.res1TB.TabIndex = 19;
            this.res1TB.TextChanged += new System.EventHandler(this.res1TB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(347, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "res2 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(347, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "res1 = ";
            // 
            // speedTB
            // 
            this.speedTB.Location = new System.Drawing.Point(611, 584);
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(70, 27);
            this.speedTB.TabIndex = 22;
            this.speedTB.TextChanged += new System.EventHandler(this.speedTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(537, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "speed =";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 10;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(495, 620);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(270, 28);
            this.ErrorLabel.TabIndex = 23;
            this.ErrorLabel.Text = "Неправильні зачення!";
            this.ErrorLabel.Visible = false;
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.Location = new System.Drawing.Point(868, 585);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(91, 29);
            this.PlayGameButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayGameButton.TabIndex = 24;
            this.PlayGameButton.Values.Text = "Грати";
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinb1
            // 
            this.skinb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinb1.BackgroundImage")));
            this.skinb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinb1.FlatAppearance.BorderSize = 0;
            this.skinb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinb1.Location = new System.Drawing.Point(19, 584);
            this.skinb1.Name = "skinb1";
            this.skinb1.Size = new System.Drawing.Size(70, 65);
            this.skinb1.TabIndex = 26;
            this.skinb1.UseVisualStyleBackColor = true;
            this.skinb1.Click += new System.EventHandler(this.button2_Click);
            // 
            // skinb2
            // 
            this.skinb2.BackgroundImage = global::Tir1.Properties.Resources.heartskin2;
            this.skinb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinb2.FlatAppearance.BorderSize = 0;
            this.skinb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinb2.Location = new System.Drawing.Point(95, 584);
            this.skinb2.Name = "skinb2";
            this.skinb2.Size = new System.Drawing.Size(70, 65);
            this.skinb2.TabIndex = 27;
            this.skinb2.UseVisualStyleBackColor = true;
            this.skinb2.Click += new System.EventHandler(this.skinb2_Click);
            // 
            // skinb3
            // 
            this.skinb3.BackgroundImage = global::Tir1.Properties.Resources.shiel2;
            this.skinb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinb3.FlatAppearance.BorderSize = 0;
            this.skinb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinb3.Location = new System.Drawing.Point(171, 584);
            this.skinb3.Name = "skinb3";
            this.skinb3.Size = new System.Drawing.Size(70, 65);
            this.skinb3.TabIndex = 28;
            this.skinb3.UseVisualStyleBackColor = true;
            this.skinb3.Click += new System.EventHandler(this.skinb3_Click);
            // 
            // MapMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.skinb3);
            this.Controls.Add(this.skinb2);
            this.Controls.Add(this.skinb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayGameButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.res2TB);
            this.Controls.Add(this.res1TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scTB);
            this.Controls.Add(this.rTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yTB);
            this.Controls.Add(this.xTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetStandartButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.TotalTimeLabel);
            this.Controls.Add(this.MainPic);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SongTrackBar);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MapMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapMaker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapMaker_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MainPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox MainPic;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar SongTrackBar;
        private Label TimeLabel;
        private Label TotalTimeLabel;
        private Button PlayButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeleteButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SetStandartButton;
        private Label label1;
        private Label label2;
        private TextBox xTB;
        private TextBox yTB;
        private TextBox scTB;
        private TextBox rTB;
        private Label label3;
        private Label label4;
        private TextBox res2TB;
        private TextBox res1TB;
        private Label label5;
        private Label label6;
        private TextBox speedTB;
        private Label label7;
        private System.Windows.Forms.Timer MainTimer;
        private Label ErrorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton PlayGameButton;
        private Button button1;
        private Button skinb1;
        private Button skinb2;
        private Button skinb3;
    }
}