namespace Tir1
{
    partial class EditAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAcc));
            this.label3 = new System.Windows.Forms.Label();
            this.pasteye = new System.Windows.Forms.PictureBox();
            this.neweye = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.nickTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pastpassTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.newpassTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pasteye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neweye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Відредагувати аккаунт";
            // 
            // pasteye
            // 
            this.pasteye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pasteye.Image = global::Tir1.Properties.Resources.closed_eyes;
            this.pasteye.Location = new System.Drawing.Point(368, 155);
            this.pasteye.Name = "pasteye";
            this.pasteye.Size = new System.Drawing.Size(43, 41);
            this.pasteye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pasteye.TabIndex = 38;
            this.pasteye.TabStop = false;
            this.pasteye.MouseLeave += new System.EventHandler(this.pasteye_MouseLeave);
            this.pasteye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pasteye_MouseMove);
            // 
            // neweye
            // 
            this.neweye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.neweye.Image = global::Tir1.Properties.Resources.closed_eyes;
            this.neweye.Location = new System.Drawing.Point(368, 218);
            this.neweye.Name = "neweye";
            this.neweye.Size = new System.Drawing.Size(43, 41);
            this.neweye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.neweye.TabIndex = 39;
            this.neweye.TabStop = false;
            this.neweye.MouseLeave += new System.EventHandler(this.neweye_MouseLeave);
            this.neweye.MouseMove += new System.Windows.Forms.MouseEventHandler(this.neweye_MouseMove);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(5, 7);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(63, 64);
            this.BackButton.TabIndex = 45;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // nickTB
            // 
            this.nickTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickTB.Location = new System.Drawing.Point(27, 91);
            this.nickTB.Name = "nickTB";
            this.nickTB.Size = new System.Drawing.Size(384, 53);
            this.nickTB.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nickTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nickTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nickTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nickTB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nickTB.StateCommon.Border.Rounding = 20;
            this.nickTB.StateCommon.Border.Width = 1;
            this.nickTB.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.nickTB.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.nickTB.TabIndex = 46;
            // 
            // pastpassTB
            // 
            this.pastpassTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastpassTB.Location = new System.Drawing.Point(27, 150);
            this.pastpassTB.Name = "pastpassTB";
            this.pastpassTB.Size = new System.Drawing.Size(324, 57);
            this.pastpassTB.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.pastpassTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pastpassTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pastpassTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pastpassTB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pastpassTB.StateCommon.Border.Rounding = 20;
            this.pastpassTB.StateCommon.Border.Width = 2;
            this.pastpassTB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.pastpassTB.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastpassTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pastpassTB.TabIndex = 47;
            this.pastpassTB.Text = "Введіть пароль";
            this.pastpassTB.Enter += new System.EventHandler(this.pastpassTB_Enter);
            this.pastpassTB.Leave += new System.EventHandler(this.pastpassTB_Leave);
            // 
            // newpassTB
            // 
            this.newpassTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpassTB.Location = new System.Drawing.Point(27, 213);
            this.newpassTB.Name = "newpassTB";
            this.newpassTB.Size = new System.Drawing.Size(324, 57);
            this.newpassTB.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.newpassTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newpassTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newpassTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.newpassTB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.newpassTB.StateCommon.Border.Rounding = 20;
            this.newpassTB.StateCommon.Border.Width = 2;
            this.newpassTB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.newpassTB.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpassTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.newpassTB.TabIndex = 48;
            this.newpassTB.Text = "Введіть новий пароль";
            this.newpassTB.Enter += new System.EventHandler(this.newpassTB_Enter);
            this.newpassTB.Leave += new System.EventHandler(this.newpassTB_Leave);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(117, 296);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(294, 53);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 20;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton1.StateTracking.Back.ColorAngle = 135F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton1.StateTracking.Border.ColorAngle = 135F;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 20;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.TabIndex = 49;
            this.kryptonButton1.Values.Text = "Змінити";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ProfilePic
            // 
            this.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProfilePic.Location = new System.Drawing.Point(26, 277);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(85, 85);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 50;
            this.ProfilePic.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 384);
            this.button2.Name = "button2";
            this.button2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button2.OverrideDefault.Border.Color1 = System.Drawing.Color.Tomato;
            this.button2.OverrideDefault.Border.Color2 = System.Drawing.Color.Tomato;
            this.button2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.OverrideDefault.Border.Rounding = 20;
            this.button2.OverrideDefault.Border.Width = 1;
            this.button2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Tomato;
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button2.Size = new System.Drawing.Size(186, 63);
            this.button2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.button2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.button2.StateCommon.Border.Color1 = System.Drawing.Color.Tomato;
            this.button2.StateCommon.Border.Color2 = System.Drawing.Color.Tomato;
            this.button2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.StateCommon.Border.Rounding = 20;
            this.button2.StateCommon.Border.Width = 3;
            this.button2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Tomato;
            this.button2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Tomato;
            this.button2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.button2.StatePressed.Back.Color2 = System.Drawing.Color.Firebrick;
            this.button2.StatePressed.Back.ColorAngle = 135F;
            this.button2.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.button2.StatePressed.Border.Color2 = System.Drawing.Color.Firebrick;
            this.button2.StatePressed.Border.ColorAngle = 135F;
            this.button2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StatePressed.Border.Rounding = 20;
            this.button2.StatePressed.Border.Width = 1;
            this.button2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button2.StateTracking.Back.Color1 = System.Drawing.Color.Tomato;
            this.button2.StateTracking.Back.Color2 = System.Drawing.Color.Tomato;
            this.button2.StateTracking.Back.ColorAngle = 135F;
            this.button2.StateTracking.Border.Color1 = System.Drawing.Color.Tomato;
            this.button2.StateTracking.Border.Color2 = System.Drawing.Color.Tomato;
            this.button2.StateTracking.Border.ColorAngle = 135F;
            this.button2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.StateTracking.Border.Rounding = 20;
            this.button2.StateTracking.Border.Width = 1;
            this.button2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button2.TabIndex = 51;
            this.button2.Values.Text = "Видалити аккаунт";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(27, 384);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton2.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton2.OverrideDefault.Border.Width = 1;
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(197, 63);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 20;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Border.Rounding = 20;
            this.kryptonButton2.StatePressed.Border.Width = 1;
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton2.StateTracking.Back.ColorAngle = 135F;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.kryptonButton2.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.kryptonButton2.StateTracking.Border.ColorAngle = 135F;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateTracking.Border.Rounding = 20;
            this.kryptonButton2.StateTracking.Border.Width = 1;
            this.kryptonButton2.TabIndex = 52;
            this.kryptonButton2.Values.Text = "Зберегти";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // EditAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(442, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.ProfilePic);
            this.Controls.Add(this.newpassTB);
            this.Controls.Add(this.pastpassTB);
            this.Controls.Add(this.nickTB);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.neweye);
            this.Controls.Add(this.pasteye);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(460, 513);
            this.MinimumSize = new System.Drawing.Size(460, 513);
            this.Name = "EditAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAcc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditAcc_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pasteye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neweye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private PictureBox pasteye;
        private PictureBox neweye;
        private Button BackButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nickTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pastpassTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox newpassTB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private PictureBox ProfilePic;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}