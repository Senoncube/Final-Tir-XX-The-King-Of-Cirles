namespace Tir1
{
    partial class LeaderbordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderbordForm));
            this.button1 = new System.Windows.Forms.Button();
            this.SortBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.TypeBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.AcsPanel = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SortBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcsPanel)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Size = new System.Drawing.Size(79, 77);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SortBox
            // 
            this.SortBox.DisplayMember = "0";
            this.SortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortBox.DropDownWidth = 243;
            this.SortBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortBox.Items.AddRange(new object[] {
            "по результату",
            "по результату практики"});
            this.SortBox.Location = new System.Drawing.Point(155, 85);
            this.SortBox.Name = "SortBox";
            this.SortBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SortBox.Size = new System.Drawing.Size(259, 41);
            this.SortBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SortBox.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SortBox.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SortBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SortBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.SortBox.StateCommon.ComboBox.Border.Width = 2;
            this.SortBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.SortBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.SortBox.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.SortBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.SortBox.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortBox.TabIndex = 39;
            this.SortBox.ValueMember = "0";
            this.SortBox.DropDownClosed += new System.EventHandler(this.SortBox_DropDownClosed);
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // TypeBox
            // 
            this.TypeBox.DisplayMember = "0";
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.DropDownWidth = 195;
            this.TypeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.Items.AddRange(new object[] {
            "Всі аккаунти",
            "Друзі"});
            this.TypeBox.Location = new System.Drawing.Point(176, 24);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TypeBox.Size = new System.Drawing.Size(211, 41);
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
            this.TypeBox.TabIndex = 38;
            this.TypeBox.ValueMember = "0";
            this.TypeBox.DropDownClosed += new System.EventHandler(this.TypeBox_DropDownClosed);
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // AcsPanel
            // 
            this.AcsPanel.Location = new System.Drawing.Point(2, 145);
            this.AcsPanel.Name = "AcsPanel";
            this.AcsPanel.Size = new System.Drawing.Size(520, 408);
            this.AcsPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AcsPanel.TabIndex = 104;
            // 
            // LeaderbordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(524, 555);
            this.Controls.Add(this.AcsPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.TypeBox);
            this.MaximumSize = new System.Drawing.Size(542, 602);
            this.MinimumSize = new System.Drawing.Size(542, 602);
            this.Name = "LeaderbordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaderbordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LeaderbordForm_FormClosed);
            this.Load += new System.EventHandler(this.LeaderbordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SortBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcsPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox SortBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox TypeBox;
        private Krypton.Toolkit.KryptonPanel AcsPanel;
    }
}