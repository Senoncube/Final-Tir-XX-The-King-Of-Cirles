namespace Tir1
{
    partial class FriendsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsForm));
            this.TypeBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.SortBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FindTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kp = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.AcsPanel = new Krypton.Toolkit.KryptonPanel();
            this.nofriends = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcsPanel)).BeginInit();
            this.AcsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeBox
            // 
            this.TypeBox.DisplayMember = "0";
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.DropDownWidth = 199;
            this.TypeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.Items.AddRange(new object[] {
            "Друзі",
            "Всі аккаунти"});
            this.TypeBox.Location = new System.Drawing.Point(73, 30);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TypeBox.Size = new System.Drawing.Size(186, 37);
            this.TypeBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TypeBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.TypeBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TypeBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TypeBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.TypeBox.StateCommon.ComboBox.Border.Width = 1;
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
            this.TypeBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.TypeBox.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.TypeBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.TabIndex = 100;
            this.TypeBox.ValueMember = "0";
            this.TypeBox.DropDownClosed += new System.EventHandler(this.TypeBox_DropDownClosed);
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // SortBox
            // 
            this.SortBox.DisplayMember = "0";
            this.SortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortBox.DropDownWidth = 247;
            this.SortBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortBox.Items.AddRange(new object[] {
            "по алфівіту",
            "по рейтингу",
            "по кількості пройдених рівнів",
            "по кількості кліків",
            "по кількості спроб",
            "по кількості монет",
            "по кількості скінів"});
            this.SortBox.Location = new System.Drawing.Point(267, 30);
            this.SortBox.Name = "SortBox";
            this.SortBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SortBox.Size = new System.Drawing.Size(233, 37);
            this.SortBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SortBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SortBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SortBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SortBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.SortBox.StateCommon.ComboBox.Border.Width = 1;
            this.SortBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.SortBox.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SortBox.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SortBox.StateCommon.Item.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.SortBox.StateCommon.Item.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SortBox.StateCommon.Item.Back.ColorAngle = 45F;
            this.SortBox.StateCommon.Item.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SortBox.StateCommon.Item.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SortBox.StateCommon.Item.Border.ColorAngle = 45F;
            this.SortBox.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SortBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.SortBox.TabIndex = 101;
            this.SortBox.ValueMember = "0";
            this.SortBox.DropDownClosed += new System.EventHandler(this.SortBox_DropDownClosed);
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 57);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindTB
            // 
            this.FindTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindTB.Location = new System.Drawing.Point(123, 94);
            this.FindTB.Name = "FindTB";
            this.FindTB.Size = new System.Drawing.Size(275, 47);
            this.FindTB.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.FindTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FindTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FindTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FindTB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.FindTB.StateCommon.Border.Rounding = 20;
            this.FindTB.StateCommon.Border.Width = 1;
            this.FindTB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.FindTB.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FindTB.TabIndex = 102;
            this.FindTB.Text = "🔍";
            this.FindTB.TextChanged += new System.EventHandler(this.FindTB_TextChanged);
            this.FindTB.Enter += new System.EventHandler(this.FindTB_Enter);
            this.FindTB.Leave += new System.EventHandler(this.FindTB_Leave);
            // 
            // kp
            // 
            this.kp.Navigator.StateCommon.Bar.BarPaddingInside = new System.Windows.Forms.Padding(10);
            this.kp.Navigator.StateCommon.Bar.ButtonEdgeInside = 20;
            this.kp.Navigator.StateCommon.Bar.ButtonPadding = new System.Windows.Forms.Padding(-1, 20, -1, -1);
            // 
            // AcsPanel
            // 
            this.AcsPanel.Controls.Add(this.nofriends);
            this.AcsPanel.Location = new System.Drawing.Point(2, 147);
            this.AcsPanel.Name = "AcsPanel";
            this.AcsPanel.Size = new System.Drawing.Size(507, 398);
            this.AcsPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AcsPanel.TabIndex = 103;
            // 
            // nofriends
            // 
            this.nofriends.Location = new System.Drawing.Point(71, 32);
            this.nofriends.Name = "nofriends";
            this.nofriends.Size = new System.Drawing.Size(349, 44);
            this.nofriends.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nofriends.TabIndex = 0;
            this.nofriends.Values.Text = "У вас немає друзів :(";
            this.nofriends.Visible = false;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(510, 588);
            this.Controls.Add(this.AcsPanel);
            this.Controls.Add(this.FindTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.TypeBox);
            this.MaximumSize = new System.Drawing.Size(528, 635);
            this.MinimumSize = new System.Drawing.Size(528, 635);
            this.Name = "FriendsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FriendsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FriendsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcsPanel)).EndInit();
            this.AcsPanel.ResumeLayout(false);
            this.AcsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox TypeBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox SortBox;
        private Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox FindTB;
        private Krypton.Toolkit.KryptonPanel AcsPanel;
        private Krypton.Toolkit.KryptonLabel nofriends;
    }
}