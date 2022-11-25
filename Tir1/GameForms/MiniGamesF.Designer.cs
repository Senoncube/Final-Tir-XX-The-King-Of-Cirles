namespace Tir1
{
    partial class MiniGamesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniGamesF));
            this.TypeBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.AcsPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeBox
            // 
            this.TypeBox.DisplayMember = "0";
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.DropDownWidth = 150;
            this.TypeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.Items.AddRange(new object[] {
            "Всі",
            "Друзі"});
            this.TypeBox.Location = new System.Drawing.Point(321, 320);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TypeBox.Size = new System.Drawing.Size(174, 41);
            this.TypeBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TypeBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.TypeBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TypeBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TypeBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.TypeBox.StateCommon.ComboBox.Border.Width = 2;
            this.TypeBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.TypeBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TypeBox.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TypeBox.StateCommon.Item.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.TypeBox.StateCommon.Item.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TypeBox.StateCommon.Item.Back.ColorAngle = 45F;
            this.TypeBox.StateCommon.Item.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.TypeBox.StateCommon.Item.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TypeBox.StateCommon.Item.Border.ColorAngle = 45F;
            this.TypeBox.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TypeBox.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.TypeBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.TabIndex = 61;
            this.TypeBox.ValueMember = "0";
            this.TypeBox.DropDownClosed += new System.EventHandler(this.TypeBox_DropDownClosed);
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 28);
            this.label6.TabIndex = 60;
            this.label6.Text = "Результати інших гравців:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(163, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 39);
            this.label5.TabIndex = 59;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(163, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 39);
            this.label4.TabIndex = 58;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 57;
            this.label3.Text = "Спроб:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 39);
            this.label2.TabIndex = 56;
            this.label2.Text = "Рекорд:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.playbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playbutton.BackgroundImage")));
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playbutton.FlatAppearance.BorderSize = 0;
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbutton.Location = new System.Drawing.Point(310, 115);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(132, 129);
            this.playbutton.TabIndex = 55;
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 42);
            this.label1.TabIndex = 54;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 53;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(247, 87);
            this.kryptonNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonNumericUpDown1.ReadOnly = true;
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(52, 35);
            this.kryptonNumericUpDown1.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonNumericUpDown1.TabIndex = 62;
            this.kryptonNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Visible = false;
            this.kryptonNumericUpDown1.ValueChanged += new System.EventHandler(this.kryptonNumericUpDown1_ValueChanged);
            // 
            // AcsPanel
            // 
            this.AcsPanel.Location = new System.Drawing.Point(2, 375);
            this.AcsPanel.Name = "AcsPanel";
            this.AcsPanel.Size = new System.Drawing.Size(505, 172);
            this.AcsPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AcsPanel.TabIndex = 105;
            // 
            // MiniGamesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(528, 566);
            this.Controls.Add(this.AcsPanel);
            this.Controls.Add(this.kryptonNumericUpDown1);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Location = new System.Drawing.Point(546, 613);
            this.MinimumSize = new System.Drawing.Size(546, 613);
            this.Name = "MiniGamesF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGamesF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiniGames_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcsPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox TypeBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button playbutton;
        private Label label1;
        private Button button3;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private Krypton.Toolkit.KryptonPanel AcsPanel;
    }
}