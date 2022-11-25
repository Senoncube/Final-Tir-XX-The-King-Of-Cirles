namespace Tir1
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.trackBar2 = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new Krypton.Toolkit.KryptonButton();
            this.textBox2 = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Налаштування";
            // 
            // trackBar1
            // 
            this.trackBar1.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.trackBar1.DrawBackground = true;
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(107, 152);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.trackBar1.Size = new System.Drawing.Size(473, 33);
            this.trackBar1.StateCommon.Position.Color1 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Position.Color2 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Position.Color3 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Position.Color4 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Position.Color5 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.White;
            this.trackBar1.StateCommon.Tick.Color2 = System.Drawing.Color.White;
            this.trackBar1.StateCommon.Tick.Color3 = System.Drawing.Color.White;
            this.trackBar1.StateCommon.Tick.Color4 = System.Drawing.Color.White;
            this.trackBar1.StateCommon.Tick.Color5 = System.Drawing.Color.White;
            this.trackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Black;
            this.trackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Black;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.DrawBackground = true;
            this.trackBar2.LargeChange = 50;
            this.trackBar2.Location = new System.Drawing.Point(107, 213);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.trackBar2.Size = new System.Drawing.Size(473, 33);
            this.trackBar2.StateCommon.Position.Color1 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Position.Color2 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Position.Color3 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Position.Color4 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Position.Color5 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Tick.Color1 = System.Drawing.Color.White;
            this.trackBar2.StateCommon.Track.Color1 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Track.Color2 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Track.Color3 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Track.Color4 = System.Drawing.Color.Black;
            this.trackBar2.StateCommon.Track.Color5 = System.Drawing.Color.Black;
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.Value = 1000;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(97, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "(щоб змінити наведіть і нажміть потрібну кнопку)";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 70);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox1.Size = new System.Drawing.Size(200, 58);
            this.textBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox1.StateCommon.Border.Rounding = 20F;
            this.textBox1.StateCommon.Border.Width = 2;
            this.textBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.StatePressed.Border.Color1 = System.Drawing.Color.Gold;
            this.textBox1.StatePressed.Border.Color2 = System.Drawing.Color.SandyBrown;
            this.textBox1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox1.StateTracking.Border.Color1 = System.Drawing.Color.Gold;
            this.textBox1.StateTracking.Border.Color2 = System.Drawing.Color.SandyBrown;
            this.textBox1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox1.TabIndex = 29;
            this.textBox1.Values.Text = "kryptonButton1";
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(349, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox2.Size = new System.Drawing.Size(200, 58);
            this.textBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox2.StateCommon.Border.Rounding = 20F;
            this.textBox2.StateCommon.Border.Width = 2;
            this.textBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.StatePressed.Border.Color1 = System.Drawing.Color.Gold;
            this.textBox2.StatePressed.Border.Color2 = System.Drawing.Color.SandyBrown;
            this.textBox2.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox2.StateTracking.Border.Color1 = System.Drawing.Color.Gold;
            this.textBox2.StateTracking.Border.Color2 = System.Drawing.Color.SandyBrown;
            this.textBox2.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox2.TabIndex = 30;
            this.textBox2.Values.Text = "kryptonButton2";
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.textBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(610, 379);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(628, 426);
            this.MinimumSize = new System.Drawing.Size(628, 426);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar trackBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar trackBar2;
        private Label label5;
        private Button button1;
        private Krypton.Toolkit.KryptonButton textBox1;
        private Krypton.Toolkit.KryptonButton textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}