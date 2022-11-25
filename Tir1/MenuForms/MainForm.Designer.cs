namespace Tir1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CoinLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CircleButton = new Krypton.Toolkit.KryptonButton();
            this.KryptoPanel = new Krypton.Toolkit.KryptonPanel();
            this.nickbutton = new Krypton.Toolkit.KryptonLabel();
            this.profileimg = new System.Windows.Forms.PictureBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.AccountButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.FriendsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ExitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AnimTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OsuButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MiniButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.StoreButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SettingsButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ExxitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CircleHitBox = new Krypton.Toolkit.KryptonPanel();
            this.BoxStoreBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MySkinsBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SkinStorBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.OsuRecordBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TestBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AIMbut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BackBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MainLvlsBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NewLvlBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.MyLvlsBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.UserLvlsBut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.CircleAnimTimer = new System.Windows.Forms.Timer(this.components);
            this.SwapMenuTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KryptoPanel)).BeginInit();
            this.KryptoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleHitBox)).BeginInit();
            this.CircleHitBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoinLabel
            // 
            this.CoinLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoinLabel.Location = new System.Drawing.Point(741, 19);
            this.CoinLabel.Name = "CoinLabel";
            this.CoinLabel.Size = new System.Drawing.Size(109, 32);
            this.CoinLabel.TabIndex = 10;
            this.CoinLabel.Text = "label1";
            this.CoinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(856, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 38);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(41, 3);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(422, 414);
            this.CircleButton.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.CircleButton.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.CircleButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.CircleButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.CircleButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CircleButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CircleButton.StateCommon.Border.Rounding = 1000F;
            this.CircleButton.StateCommon.Border.Width = 3;
            this.CircleButton.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.CircleButton.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.CircleButton.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.CircleButton.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CircleButton.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.CircleButton.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.CircleButton.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CircleButton.TabIndex = 16;
            this.CircleButton.Values.Text = "kryptonButton1";
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            this.CircleButton.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.CircleButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // KryptoPanel
            // 
            this.KryptoPanel.Controls.Add(this.nickbutton);
            this.KryptoPanel.Controls.Add(this.profileimg);
            this.KryptoPanel.Controls.Add(this.kryptonGroup1);
            this.KryptoPanel.Controls.Add(this.AccountButton);
            this.KryptoPanel.Controls.Add(this.FriendsButton);
            this.KryptoPanel.Controls.Add(this.ExitButton);
            this.KryptoPanel.Location = new System.Drawing.Point(2, 3);
            this.KryptoPanel.Name = "KryptoPanel";
            this.KryptoPanel.Size = new System.Drawing.Size(258, 106);
            this.KryptoPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.KryptoPanel.TabIndex = 17;
            this.KryptoPanel.MouseLeave += new System.EventHandler(this.KryptoPanel_MouseLeave);
            this.KryptoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KryptoPanel_MouseMove);
            // 
            // nickbutton
            // 
            this.nickbutton.AutoSize = false;
            this.nickbutton.Enabled = false;
            this.nickbutton.Location = new System.Drawing.Point(108, 33);
            this.nickbutton.Name = "nickbutton";
            this.nickbutton.Size = new System.Drawing.Size(127, 32);
            this.nickbutton.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickbutton.StateDisabled.ShortText.Color1 = System.Drawing.Color.Black;
            this.nickbutton.TabIndex = 19;
            this.nickbutton.Values.Text = "kryptonLabel1";
            // 
            // profileimg
            // 
            this.profileimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileimg.Enabled = false;
            this.profileimg.Location = new System.Drawing.Point(29, 15);
            this.profileimg.Name = "profileimg";
            this.profileimg.Size = new System.Drawing.Size(74, 74);
            this.profileimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileimg.TabIndex = 18;
            this.profileimg.TabStop = false;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Enabled = false;
            this.kryptonGroup1.Location = new System.Drawing.Point(10, 9);
            this.kryptonGroup1.Name = "kryptonGroup1";
            this.kryptonGroup1.Size = new System.Drawing.Size(234, 88);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 10F;
            this.kryptonGroup1.StateCommon.Border.Width = 3;
            this.kryptonGroup1.TabIndex = 23;
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(10, 16);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AccountButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AccountButton.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.AccountButton.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AccountButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AccountButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AccountButton.OverrideDefault.Border.Rounding = 20;
            this.AccountButton.OverrideDefault.Border.Width = 1;
            this.AccountButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.AccountButton.Size = new System.Drawing.Size(234, 62);
            this.AccountButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.AccountButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.AccountButton.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.AccountButton.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AccountButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AccountButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AccountButton.StateCommon.Border.Rounding = 20;
            this.AccountButton.StateCommon.Border.Width = 1;
            this.AccountButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.AccountButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.AccountButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.AccountButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.AccountButton.StatePressed.Back.ColorAngle = 135F;
            this.AccountButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.AccountButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.AccountButton.StatePressed.Border.ColorAngle = 135F;
            this.AccountButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AccountButton.StatePressed.Border.Rounding = 20;
            this.AccountButton.StatePressed.Border.Width = 1;
            this.AccountButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AccountButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AccountButton.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.AccountButton.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AccountButton.StateTracking.Back.ColorAngle = 135F;
            this.AccountButton.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.AccountButton.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AccountButton.StateTracking.Border.ColorAngle = 135F;
            this.AccountButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AccountButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AccountButton.StateTracking.Border.Rounding = 20;
            this.AccountButton.StateTracking.Border.Width = 1;
            this.AccountButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AccountButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AccountButton.TabIndex = 18;
            this.AccountButton.Values.Text = "Аккаунт";
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            this.AccountButton.MouseLeave += new System.EventHandler(this.KryptoPanel_MouseLeave);
            this.AccountButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KryptoPanel_MouseMove);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Location = new System.Drawing.Point(10, 16);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FriendsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FriendsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.FriendsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.FriendsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FriendsButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.FriendsButton.OverrideDefault.Border.Rounding = 20;
            this.FriendsButton.OverrideDefault.Border.Width = 1;
            this.FriendsButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.FriendsButton.Size = new System.Drawing.Size(234, 62);
            this.FriendsButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.FriendsButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.FriendsButton.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.FriendsButton.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.FriendsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FriendsButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.FriendsButton.StateCommon.Border.Rounding = 20;
            this.FriendsButton.StateCommon.Border.Width = 1;
            this.FriendsButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.FriendsButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.FriendsButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FriendsButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.FriendsButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.FriendsButton.StatePressed.Back.ColorAngle = 135F;
            this.FriendsButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.FriendsButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.FriendsButton.StatePressed.Border.ColorAngle = 135F;
            this.FriendsButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FriendsButton.StatePressed.Border.Rounding = 20;
            this.FriendsButton.StatePressed.Border.Width = 1;
            this.FriendsButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.FriendsButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.FriendsButton.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.FriendsButton.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.FriendsButton.StateTracking.Back.ColorAngle = 135F;
            this.FriendsButton.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.FriendsButton.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.FriendsButton.StateTracking.Border.ColorAngle = 135F;
            this.FriendsButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.FriendsButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.FriendsButton.StateTracking.Border.Rounding = 20;
            this.FriendsButton.StateTracking.Border.Width = 1;
            this.FriendsButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.FriendsButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.FriendsButton.TabIndex = 21;
            this.FriendsButton.Values.Text = "Друзі";
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            this.FriendsButton.MouseLeave += new System.EventHandler(this.KryptoPanel_MouseLeave);
            this.FriendsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KryptoPanel_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(10, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ExitButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ExitButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExitButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Tomato;
            this.ExitButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExitButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ExitButton.OverrideDefault.Border.Rounding = 20;
            this.ExitButton.OverrideDefault.Border.Width = 1;
            this.ExitButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ExitButton.Size = new System.Drawing.Size(234, 62);
            this.ExitButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ExitButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.ExitButton.StateCommon.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExitButton.StateCommon.Border.Color2 = System.Drawing.Color.Tomato;
            this.ExitButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExitButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ExitButton.StateCommon.Border.Rounding = 20;
            this.ExitButton.StateCommon.Border.Width = 1;
            this.ExitButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Tomato;
            this.ExitButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Tomato;
            this.ExitButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.ExitButton.StatePressed.Back.Color2 = System.Drawing.Color.Firebrick;
            this.ExitButton.StatePressed.Back.ColorAngle = 135F;
            this.ExitButton.StatePressed.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExitButton.StatePressed.Border.Color2 = System.Drawing.Color.Tomato;
            this.ExitButton.StatePressed.Border.ColorAngle = 135F;
            this.ExitButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExitButton.StatePressed.Border.Rounding = 20;
            this.ExitButton.StatePressed.Border.Width = 1;
            this.ExitButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ExitButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ExitButton.StateTracking.Back.Color1 = System.Drawing.Color.Tomato;
            this.ExitButton.StateTracking.Back.Color2 = System.Drawing.Color.Tomato;
            this.ExitButton.StateTracking.Back.ColorAngle = 135F;
            this.ExitButton.StateTracking.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExitButton.StateTracking.Border.Color2 = System.Drawing.Color.Tomato;
            this.ExitButton.StateTracking.Border.ColorAngle = 135F;
            this.ExitButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExitButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ExitButton.StateTracking.Border.Rounding = 20;
            this.ExitButton.StateTracking.Border.Width = 1;
            this.ExitButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ExitButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Values.Text = "Вийти";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseLeave += new System.EventHandler(this.KryptoPanel_MouseLeave);
            this.ExitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KryptoPanel_MouseMove);
            // 
            // AnimTimer
            // 
            this.AnimTimer.Interval = 1;
            this.AnimTimer.Tick += new System.EventHandler(this.AnimTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OsuButton
            // 
            this.OsuButton.Location = new System.Drawing.Point(416, 17);
            this.OsuButton.Name = "OsuButton";
            this.OsuButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.OsuButton.Size = new System.Drawing.Size(293, 60);
            this.OsuButton.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.OsuButton.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.OsuButton.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.OsuButton.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.OsuButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OsuButton.StateCommon.Border.Rounding = 20;
            this.OsuButton.StateCommon.Border.Width = 1;
            this.OsuButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.OsuButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.OsuButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OsuButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuButton.StatePressed.Border.Rounding = 20;
            this.OsuButton.StatePressed.Border.Width = 1;
            this.OsuButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OsuButton.StateTracking.Border.Rounding = 20;
            this.OsuButton.StateTracking.Border.Width = 1;
            this.OsuButton.TabIndex = 18;
            this.OsuButton.Values.Text = "Осу";
            this.OsuButton.Click += new System.EventHandler(this.button4_Click);
            this.OsuButton.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.OsuButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // MiniButton
            // 
            this.MiniButton.Location = new System.Drawing.Point(478, 100);
            this.MiniButton.Name = "MiniButton";
            this.MiniButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MiniButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MiniButton.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MiniButton.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MiniButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MiniButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MiniButton.OverrideDefault.Border.Rounding = 20;
            this.MiniButton.OverrideDefault.Border.Width = 1;
            this.MiniButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.MiniButton.Size = new System.Drawing.Size(286, 60);
            this.MiniButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.MiniButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.MiniButton.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.MiniButton.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MiniButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MiniButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MiniButton.StateCommon.Border.Rounding = 20;
            this.MiniButton.StateCommon.Border.Width = 1;
            this.MiniButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.MiniButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.MiniButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MiniButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.MiniButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.MiniButton.StatePressed.Back.ColorAngle = 135F;
            this.MiniButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.MiniButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.MiniButton.StatePressed.Border.ColorAngle = 135F;
            this.MiniButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MiniButton.StatePressed.Border.Rounding = 20;
            this.MiniButton.StatePressed.Border.Width = 1;
            this.MiniButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MiniButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MiniButton.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.MiniButton.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MiniButton.StateTracking.Back.ColorAngle = 135F;
            this.MiniButton.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MiniButton.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MiniButton.StateTracking.Border.ColorAngle = 135F;
            this.MiniButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MiniButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MiniButton.StateTracking.Border.Rounding = 20;
            this.MiniButton.StateTracking.Border.Width = 1;
            this.MiniButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MiniButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MiniButton.TabIndex = 19;
            this.MiniButton.Values.Text = "Міні ігри";
            this.MiniButton.Click += new System.EventHandler(this.button1_Click);
            this.MiniButton.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.MiniButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // StoreButton
            // 
            this.StoreButton.Location = new System.Drawing.Point(532, 182);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StoreButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StoreButton.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.StoreButton.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StoreButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StoreButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StoreButton.OverrideDefault.Border.Rounding = 20;
            this.StoreButton.OverrideDefault.Border.Width = 1;
            this.StoreButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StoreButton.Size = new System.Drawing.Size(284, 60);
            this.StoreButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StoreButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StoreButton.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.StoreButton.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StoreButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StoreButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StoreButton.StateCommon.Border.Rounding = 20;
            this.StoreButton.StateCommon.Border.Width = 1;
            this.StoreButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StoreButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StoreButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoreButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.StoreButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.StoreButton.StatePressed.Back.ColorAngle = 135F;
            this.StoreButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.StoreButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.StoreButton.StatePressed.Border.ColorAngle = 135F;
            this.StoreButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StoreButton.StatePressed.Border.Rounding = 20;
            this.StoreButton.StatePressed.Border.Width = 1;
            this.StoreButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StoreButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StoreButton.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.StoreButton.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StoreButton.StateTracking.Back.ColorAngle = 135F;
            this.StoreButton.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.StoreButton.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StoreButton.StateTracking.Border.ColorAngle = 135F;
            this.StoreButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StoreButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StoreButton.StateTracking.Border.Rounding = 20;
            this.StoreButton.StateTracking.Border.Width = 1;
            this.StoreButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StoreButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StoreButton.TabIndex = 20;
            this.StoreButton.Values.Text = "Магазин";
            this.StoreButton.Click += new System.EventHandler(this.button2_Click);
            this.StoreButton.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.StoreButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(478, 263);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SettingsButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SettingsButton.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SettingsButton.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SettingsButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SettingsButton.OverrideDefault.Border.Rounding = 20;
            this.SettingsButton.OverrideDefault.Border.Width = 1;
            this.SettingsButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SettingsButton.Size = new System.Drawing.Size(286, 60);
            this.SettingsButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.SettingsButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.SettingsButton.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.SettingsButton.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SettingsButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SettingsButton.StateCommon.Border.Rounding = 20;
            this.SettingsButton.StateCommon.Border.Width = 1;
            this.SettingsButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.SettingsButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.SettingsButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.SettingsButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.SettingsButton.StatePressed.Back.ColorAngle = 135F;
            this.SettingsButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.SettingsButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.SettingsButton.StatePressed.Border.ColorAngle = 135F;
            this.SettingsButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsButton.StatePressed.Border.Rounding = 20;
            this.SettingsButton.StatePressed.Border.Width = 1;
            this.SettingsButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SettingsButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SettingsButton.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.SettingsButton.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SettingsButton.StateTracking.Back.ColorAngle = 135F;
            this.SettingsButton.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SettingsButton.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SettingsButton.StateTracking.Border.ColorAngle = 135F;
            this.SettingsButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SettingsButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SettingsButton.StateTracking.Border.Rounding = 20;
            this.SettingsButton.StateTracking.Border.Width = 1;
            this.SettingsButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SettingsButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SettingsButton.TabIndex = 21;
            this.SettingsButton.Values.Text = "Налаштування";
            this.SettingsButton.Click += new System.EventHandler(this.button3_Click);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.SettingsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // ExxitButton
            // 
            this.ExxitButton.Location = new System.Drawing.Point(416, 346);
            this.ExxitButton.Name = "ExxitButton";
            this.ExxitButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ExxitButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ExxitButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExxitButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Tomato;
            this.ExxitButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExxitButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ExxitButton.OverrideDefault.Border.Rounding = 20;
            this.ExxitButton.OverrideDefault.Border.Width = 3;
            this.ExxitButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ExxitButton.Size = new System.Drawing.Size(293, 60);
            this.ExxitButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.ExxitButton.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.ExxitButton.StateCommon.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExxitButton.StateCommon.Border.Color2 = System.Drawing.Color.Tomato;
            this.ExxitButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExxitButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ExxitButton.StateCommon.Border.Rounding = 20;
            this.ExxitButton.StateCommon.Border.Width = 3;
            this.ExxitButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Tomato;
            this.ExxitButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Tomato;
            this.ExxitButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExxitButton.StatePressed.Back.Color1 = System.Drawing.Color.IndianRed;
            this.ExxitButton.StatePressed.Back.Color2 = System.Drawing.Color.Firebrick;
            this.ExxitButton.StatePressed.Back.ColorAngle = 135F;
            this.ExxitButton.StatePressed.Border.Color1 = System.Drawing.Color.IndianRed;
            this.ExxitButton.StatePressed.Border.Color2 = System.Drawing.Color.Firebrick;
            this.ExxitButton.StatePressed.Border.ColorAngle = 135F;
            this.ExxitButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExxitButton.StatePressed.Border.Rounding = 20;
            this.ExxitButton.StatePressed.Border.Width = 1;
            this.ExxitButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ExxitButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ExxitButton.StateTracking.Back.Color1 = System.Drawing.Color.Tomato;
            this.ExxitButton.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.ExxitButton.StateTracking.Back.ColorAngle = 45F;
            this.ExxitButton.StateTracking.Border.Color1 = System.Drawing.Color.Tomato;
            this.ExxitButton.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.ExxitButton.StateTracking.Border.ColorAngle = 45F;
            this.ExxitButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExxitButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ExxitButton.StateTracking.Border.Rounding = 20;
            this.ExxitButton.StateTracking.Border.Width = 1;
            this.ExxitButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ExxitButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ExxitButton.TabIndex = 22;
            this.ExxitButton.Values.Text = "Вийти";
            this.ExxitButton.Click += new System.EventHandler(this.button5_Click);
            this.ExxitButton.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.ExxitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // CircleHitBox
            // 
            this.CircleHitBox.Controls.Add(this.BoxStoreBut);
            this.CircleHitBox.Controls.Add(this.MySkinsBut);
            this.CircleHitBox.Controls.Add(this.SkinStorBut);
            this.CircleHitBox.Controls.Add(this.OsuRecordBut);
            this.CircleHitBox.Controls.Add(this.TestBut);
            this.CircleHitBox.Controls.Add(this.AIMbut);
            this.CircleHitBox.Controls.Add(this.BackBut);
            this.CircleHitBox.Controls.Add(this.MainLvlsBut);
            this.CircleHitBox.Controls.Add(this.NewLvlBut);
            this.CircleHitBox.Controls.Add(this.MyLvlsBut);
            this.CircleHitBox.Controls.Add(this.UserLvlsBut);
            this.CircleHitBox.Controls.Add(this.OsuButton);
            this.CircleHitBox.Controls.Add(this.ExxitButton);
            this.CircleHitBox.Controls.Add(this.SettingsButton);
            this.CircleHitBox.Controls.Add(this.StoreButton);
            this.CircleHitBox.Controls.Add(this.CircleButton);
            this.CircleHitBox.Controls.Add(this.MiniButton);
            this.CircleHitBox.Location = new System.Drawing.Point(12, 115);
            this.CircleHitBox.Name = "CircleHitBox";
            this.CircleHitBox.Size = new System.Drawing.Size(890, 442);
            this.CircleHitBox.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.CircleHitBox.TabIndex = 23;
            this.CircleHitBox.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.CircleHitBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // BoxStoreBut
            // 
            this.BoxStoreBut.Location = new System.Drawing.Point(1465, 30);
            this.BoxStoreBut.Name = "BoxStoreBut";
            this.BoxStoreBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BoxStoreBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.BoxStoreBut.Size = new System.Drawing.Size(293, 60);
            this.BoxStoreBut.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.BoxStoreBut.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.BoxStoreBut.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.BoxStoreBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.BoxStoreBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BoxStoreBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BoxStoreBut.StateCommon.Border.Rounding = 20;
            this.BoxStoreBut.StateCommon.Border.Width = 1;
            this.BoxStoreBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BoxStoreBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BoxStoreBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BoxStoreBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BoxStoreBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BoxStoreBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BoxStoreBut.StatePressed.Border.Rounding = 20;
            this.BoxStoreBut.StatePressed.Border.Width = 1;
            this.BoxStoreBut.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BoxStoreBut.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BoxStoreBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BoxStoreBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BoxStoreBut.StateTracking.Border.Rounding = 20;
            this.BoxStoreBut.StateTracking.Border.Width = 1;
            this.BoxStoreBut.TabIndex = 32;
            this.BoxStoreBut.Values.Text = "Бокси";
            this.BoxStoreBut.Click += new System.EventHandler(this.kryptonButton5_Click);
            this.BoxStoreBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.BoxStoreBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // MySkinsBut
            // 
            this.MySkinsBut.Location = new System.Drawing.Point(1539, 235);
            this.MySkinsBut.Name = "MySkinsBut";
            this.MySkinsBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MySkinsBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MySkinsBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MySkinsBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MySkinsBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MySkinsBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MySkinsBut.OverrideDefault.Border.Rounding = 20;
            this.MySkinsBut.OverrideDefault.Border.Width = 1;
            this.MySkinsBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.MySkinsBut.Size = new System.Drawing.Size(284, 60);
            this.MySkinsBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.MySkinsBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.MySkinsBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.MySkinsBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MySkinsBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MySkinsBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MySkinsBut.StateCommon.Border.Rounding = 20;
            this.MySkinsBut.StateCommon.Border.Width = 1;
            this.MySkinsBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.MySkinsBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.MySkinsBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MySkinsBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.MySkinsBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.MySkinsBut.StatePressed.Back.ColorAngle = 135F;
            this.MySkinsBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.MySkinsBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.MySkinsBut.StatePressed.Border.ColorAngle = 135F;
            this.MySkinsBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MySkinsBut.StatePressed.Border.Rounding = 20;
            this.MySkinsBut.StatePressed.Border.Width = 1;
            this.MySkinsBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MySkinsBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MySkinsBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.MySkinsBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MySkinsBut.StateTracking.Back.ColorAngle = 135F;
            this.MySkinsBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MySkinsBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MySkinsBut.StateTracking.Border.ColorAngle = 135F;
            this.MySkinsBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MySkinsBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MySkinsBut.StateTracking.Border.Rounding = 20;
            this.MySkinsBut.StateTracking.Border.Width = 1;
            this.MySkinsBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MySkinsBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MySkinsBut.TabIndex = 34;
            this.MySkinsBut.Values.Text = "Мої скіни";
            this.MySkinsBut.Click += new System.EventHandler(this.MySkinsBut_Click);
            this.MySkinsBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.MySkinsBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // SkinStorBut
            // 
            this.SkinStorBut.Location = new System.Drawing.Point(1537, 131);
            this.SkinStorBut.Name = "SkinStorBut";
            this.SkinStorBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SkinStorBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.SkinStorBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SkinStorBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SkinStorBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SkinStorBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SkinStorBut.OverrideDefault.Border.Rounding = 20;
            this.SkinStorBut.OverrideDefault.Border.Width = 1;
            this.SkinStorBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SkinStorBut.Size = new System.Drawing.Size(286, 60);
            this.SkinStorBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.SkinStorBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.SkinStorBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.SkinStorBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SkinStorBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SkinStorBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SkinStorBut.StateCommon.Border.Rounding = 20;
            this.SkinStorBut.StateCommon.Border.Width = 1;
            this.SkinStorBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.SkinStorBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.SkinStorBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SkinStorBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.SkinStorBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.SkinStorBut.StatePressed.Back.ColorAngle = 135F;
            this.SkinStorBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.SkinStorBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.SkinStorBut.StatePressed.Border.ColorAngle = 135F;
            this.SkinStorBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SkinStorBut.StatePressed.Border.Rounding = 20;
            this.SkinStorBut.StatePressed.Border.Width = 1;
            this.SkinStorBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SkinStorBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SkinStorBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.SkinStorBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SkinStorBut.StateTracking.Back.ColorAngle = 135F;
            this.SkinStorBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.SkinStorBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.SkinStorBut.StateTracking.Border.ColorAngle = 135F;
            this.SkinStorBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SkinStorBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SkinStorBut.StateTracking.Border.Rounding = 20;
            this.SkinStorBut.StateTracking.Border.Width = 1;
            this.SkinStorBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SkinStorBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SkinStorBut.TabIndex = 33;
            this.SkinStorBut.Values.Text = "Купити скін";
            this.SkinStorBut.Click += new System.EventHandler(this.SkinStorBut_Click);
            this.SkinStorBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.SkinStorBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // OsuRecordBut
            // 
            this.OsuRecordBut.Location = new System.Drawing.Point(1116, 30);
            this.OsuRecordBut.Name = "OsuRecordBut";
            this.OsuRecordBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuRecordBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.OsuRecordBut.Size = new System.Drawing.Size(293, 60);
            this.OsuRecordBut.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.OsuRecordBut.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.OsuRecordBut.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.OsuRecordBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.OsuRecordBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuRecordBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OsuRecordBut.StateCommon.Border.Rounding = 20;
            this.OsuRecordBut.StateCommon.Border.Width = 1;
            this.OsuRecordBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.OsuRecordBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.OsuRecordBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OsuRecordBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuRecordBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuRecordBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuRecordBut.StatePressed.Border.Rounding = 20;
            this.OsuRecordBut.StatePressed.Border.Width = 1;
            this.OsuRecordBut.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuRecordBut.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.OsuRecordBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.OsuRecordBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.OsuRecordBut.StateTracking.Border.Rounding = 20;
            this.OsuRecordBut.StateTracking.Border.Width = 1;
            this.OsuRecordBut.TabIndex = 28;
            this.OsuRecordBut.Values.Text = "Осу (рекорд)";
            this.OsuRecordBut.Click += new System.EventHandler(this.OsuRecordBut_Click);
            this.OsuRecordBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.OsuRecordBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // TestBut
            // 
            this.TestBut.Location = new System.Drawing.Point(1188, 235);
            this.TestBut.Name = "TestBut";
            this.TestBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TestBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TestBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.TestBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TestBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TestBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TestBut.OverrideDefault.Border.Rounding = 20;
            this.TestBut.OverrideDefault.Border.Width = 1;
            this.TestBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TestBut.Size = new System.Drawing.Size(284, 60);
            this.TestBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.TestBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.TestBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.TestBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TestBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TestBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TestBut.StateCommon.Border.Rounding = 20;
            this.TestBut.StateCommon.Border.Width = 1;
            this.TestBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.TestBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.TestBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TestBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.TestBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.TestBut.StatePressed.Back.ColorAngle = 135F;
            this.TestBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.TestBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.TestBut.StatePressed.Border.ColorAngle = 135F;
            this.TestBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TestBut.StatePressed.Border.Rounding = 20;
            this.TestBut.StatePressed.Border.Width = 1;
            this.TestBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.TestBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.TestBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.TestBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TestBut.StateTracking.Back.ColorAngle = 135F;
            this.TestBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.TestBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.TestBut.StateTracking.Border.ColorAngle = 135F;
            this.TestBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TestBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TestBut.StateTracking.Border.Rounding = 20;
            this.TestBut.StateTracking.Border.Width = 1;
            this.TestBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.TestBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.TestBut.TabIndex = 30;
            this.TestBut.Values.Text = "Тест на увагу";
            this.TestBut.Click += new System.EventHandler(this.TestBut_Click);
            this.TestBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.TestBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // AIMbut
            // 
            this.AIMbut.Location = new System.Drawing.Point(1188, 131);
            this.AIMbut.Name = "AIMbut";
            this.AIMbut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AIMbut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.AIMbut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.AIMbut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AIMbut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AIMbut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AIMbut.OverrideDefault.Border.Rounding = 20;
            this.AIMbut.OverrideDefault.Border.Width = 1;
            this.AIMbut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.AIMbut.Size = new System.Drawing.Size(286, 60);
            this.AIMbut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.AIMbut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.AIMbut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.AIMbut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AIMbut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AIMbut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AIMbut.StateCommon.Border.Rounding = 20;
            this.AIMbut.StateCommon.Border.Width = 1;
            this.AIMbut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.AIMbut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.AIMbut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AIMbut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.AIMbut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.AIMbut.StatePressed.Back.ColorAngle = 135F;
            this.AIMbut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.AIMbut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.AIMbut.StatePressed.Border.ColorAngle = 135F;
            this.AIMbut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AIMbut.StatePressed.Border.Rounding = 20;
            this.AIMbut.StatePressed.Border.Width = 1;
            this.AIMbut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AIMbut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AIMbut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.AIMbut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AIMbut.StateTracking.Back.ColorAngle = 135F;
            this.AIMbut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.AIMbut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.AIMbut.StateTracking.Border.ColorAngle = 135F;
            this.AIMbut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AIMbut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AIMbut.StateTracking.Border.Rounding = 20;
            this.AIMbut.StateTracking.Border.Width = 1;
            this.AIMbut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AIMbut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.AIMbut.TabIndex = 29;
            this.AIMbut.Values.Text = "Аім тест";
            this.AIMbut.Click += new System.EventHandler(this.AIMbut_Click);
            this.AIMbut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.AIMbut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // BackBut
            // 
            this.BackBut.Location = new System.Drawing.Point(773, 346);
            this.BackBut.Name = "BackBut";
            this.BackBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BackBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BackBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.BackBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.BackBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BackBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BackBut.OverrideDefault.Border.Rounding = 20;
            this.BackBut.OverrideDefault.Border.Width = 1;
            this.BackBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.BackBut.Size = new System.Drawing.Size(286, 60);
            this.BackBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.BackBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.BackBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.BackBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.BackBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BackBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BackBut.StateCommon.Border.Rounding = 20;
            this.BackBut.StateCommon.Border.Width = 1;
            this.BackBut.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.BackBut.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.BackBut.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.BackBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.BackBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.BackBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.BackBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.BackBut.StatePressed.Back.ColorAngle = 135F;
            this.BackBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.BackBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.BackBut.StatePressed.Border.ColorAngle = 135F;
            this.BackBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BackBut.StatePressed.Border.Rounding = 20;
            this.BackBut.StatePressed.Border.Width = 1;
            this.BackBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BackBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BackBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.BackBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.BackBut.StateTracking.Back.ColorAngle = 135F;
            this.BackBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.BackBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.BackBut.StateTracking.Border.ColorAngle = 135F;
            this.BackBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BackBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BackBut.StateTracking.Border.Rounding = 20;
            this.BackBut.StateTracking.Border.Width = 1;
            this.BackBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.BackBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.BackBut.TabIndex = 27;
            this.BackBut.Values.ImageStates.ImageCheckedNormal = null;
            this.BackBut.Values.ImageStates.ImageCheckedPressed = null;
            this.BackBut.Values.ImageStates.ImageCheckedTracking = null;
            this.BackBut.Values.ImageStates.ImageNormal = global::Tir1.Properties.Resources.closed_eyes;
            this.BackBut.Values.Text = "Назад";
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            this.BackBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.BackBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // MainLvlsBut
            // 
            this.MainLvlsBut.Location = new System.Drawing.Point(773, 17);
            this.MainLvlsBut.Name = "MainLvlsBut";
            this.MainLvlsBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainLvlsBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.MainLvlsBut.Size = new System.Drawing.Size(293, 60);
            this.MainLvlsBut.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.MainLvlsBut.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MainLvlsBut.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MainLvlsBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MainLvlsBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainLvlsBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainLvlsBut.StateCommon.Border.Rounding = 20;
            this.MainLvlsBut.StateCommon.Border.Width = 1;
            this.MainLvlsBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MainLvlsBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MainLvlsBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLvlsBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainLvlsBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainLvlsBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainLvlsBut.StatePressed.Border.Rounding = 20;
            this.MainLvlsBut.StatePressed.Border.Width = 1;
            this.MainLvlsBut.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainLvlsBut.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainLvlsBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainLvlsBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainLvlsBut.StateTracking.Border.Rounding = 20;
            this.MainLvlsBut.StateTracking.Border.Width = 1;
            this.MainLvlsBut.TabIndex = 23;
            this.MainLvlsBut.Values.Text = "Офіційні рівні";
            this.MainLvlsBut.Click += new System.EventHandler(this.MainLvlsBut_Click);
            this.MainLvlsBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.MainLvlsBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // NewLvlBut
            // 
            this.NewLvlBut.Location = new System.Drawing.Point(836, 269);
            this.NewLvlBut.Name = "NewLvlBut";
            this.NewLvlBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.NewLvlBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.NewLvlBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.NewLvlBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.NewLvlBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NewLvlBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.NewLvlBut.OverrideDefault.Border.Rounding = 20;
            this.NewLvlBut.OverrideDefault.Border.Width = 1;
            this.NewLvlBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.NewLvlBut.Size = new System.Drawing.Size(286, 60);
            this.NewLvlBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.NewLvlBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.NewLvlBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.NewLvlBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.NewLvlBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NewLvlBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.NewLvlBut.StateCommon.Border.Rounding = 20;
            this.NewLvlBut.StateCommon.Border.Width = 1;
            this.NewLvlBut.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.NewLvlBut.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.NewLvlBut.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.NewLvlBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.NewLvlBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.NewLvlBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewLvlBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.NewLvlBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.NewLvlBut.StatePressed.Back.ColorAngle = 135F;
            this.NewLvlBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.NewLvlBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.NewLvlBut.StatePressed.Border.ColorAngle = 135F;
            this.NewLvlBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NewLvlBut.StatePressed.Border.Rounding = 20;
            this.NewLvlBut.StatePressed.Border.Width = 1;
            this.NewLvlBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.NewLvlBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.NewLvlBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.NewLvlBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.NewLvlBut.StateTracking.Back.ColorAngle = 135F;
            this.NewLvlBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.NewLvlBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.NewLvlBut.StateTracking.Border.ColorAngle = 135F;
            this.NewLvlBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NewLvlBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.NewLvlBut.StateTracking.Border.Rounding = 20;
            this.NewLvlBut.StateTracking.Border.Width = 1;
            this.NewLvlBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.NewLvlBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.NewLvlBut.TabIndex = 26;
            this.NewLvlBut.Values.ImageStates.ImageCheckedNormal = null;
            this.NewLvlBut.Values.ImageStates.ImageCheckedPressed = null;
            this.NewLvlBut.Values.ImageStates.ImageCheckedTracking = null;
            this.NewLvlBut.Values.ImageStates.ImageNormal = global::Tir1.Properties.Resources.closed_eyes;
            this.NewLvlBut.Values.Text = "Створити рівень";
            this.NewLvlBut.Click += new System.EventHandler(this.NewLvlBut_Click);
            this.NewLvlBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.NewLvlBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // MyLvlsBut
            // 
            this.MyLvlsBut.Location = new System.Drawing.Point(868, 183);
            this.MyLvlsBut.Name = "MyLvlsBut";
            this.MyLvlsBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyLvlsBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MyLvlsBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MyLvlsBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MyLvlsBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyLvlsBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MyLvlsBut.OverrideDefault.Border.Rounding = 20;
            this.MyLvlsBut.OverrideDefault.Border.Width = 1;
            this.MyLvlsBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.MyLvlsBut.Size = new System.Drawing.Size(284, 60);
            this.MyLvlsBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.MyLvlsBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.MyLvlsBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.MyLvlsBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MyLvlsBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyLvlsBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MyLvlsBut.StateCommon.Border.Rounding = 20;
            this.MyLvlsBut.StateCommon.Border.Width = 1;
            this.MyLvlsBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.MyLvlsBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.MyLvlsBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyLvlsBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.MyLvlsBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.MyLvlsBut.StatePressed.Back.ColorAngle = 135F;
            this.MyLvlsBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.MyLvlsBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.MyLvlsBut.StatePressed.Border.ColorAngle = 135F;
            this.MyLvlsBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyLvlsBut.StatePressed.Border.Rounding = 20;
            this.MyLvlsBut.StatePressed.Border.Width = 1;
            this.MyLvlsBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MyLvlsBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MyLvlsBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.MyLvlsBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MyLvlsBut.StateTracking.Back.ColorAngle = 135F;
            this.MyLvlsBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.MyLvlsBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.MyLvlsBut.StateTracking.Border.ColorAngle = 135F;
            this.MyLvlsBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MyLvlsBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MyLvlsBut.StateTracking.Border.Rounding = 20;
            this.MyLvlsBut.StateTracking.Border.Width = 1;
            this.MyLvlsBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.MyLvlsBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.MyLvlsBut.TabIndex = 25;
            this.MyLvlsBut.Values.Text = "Мої рівні";
            this.MyLvlsBut.Click += new System.EventHandler(this.MyLvlsBut_Click);
            this.MyLvlsBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.MyLvlsBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // UserLvlsBut
            // 
            this.UserLvlsBut.Location = new System.Drawing.Point(836, 96);
            this.UserLvlsBut.Name = "UserLvlsBut";
            this.UserLvlsBut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.UserLvlsBut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.UserLvlsBut.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.UserLvlsBut.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.UserLvlsBut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserLvlsBut.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UserLvlsBut.OverrideDefault.Border.Rounding = 20;
            this.UserLvlsBut.OverrideDefault.Border.Width = 1;
            this.UserLvlsBut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.UserLvlsBut.Size = new System.Drawing.Size(286, 60);
            this.UserLvlsBut.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.UserLvlsBut.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.UserLvlsBut.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.UserLvlsBut.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.UserLvlsBut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserLvlsBut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UserLvlsBut.StateCommon.Border.Rounding = 20;
            this.UserLvlsBut.StateCommon.Border.Width = 1;
            this.UserLvlsBut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.UserLvlsBut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.UserLvlsBut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLvlsBut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.UserLvlsBut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.UserLvlsBut.StatePressed.Back.ColorAngle = 135F;
            this.UserLvlsBut.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.UserLvlsBut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.UserLvlsBut.StatePressed.Border.ColorAngle = 135F;
            this.UserLvlsBut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserLvlsBut.StatePressed.Border.Rounding = 20;
            this.UserLvlsBut.StatePressed.Border.Width = 1;
            this.UserLvlsBut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UserLvlsBut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UserLvlsBut.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.UserLvlsBut.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.UserLvlsBut.StateTracking.Back.ColorAngle = 135F;
            this.UserLvlsBut.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.UserLvlsBut.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.UserLvlsBut.StateTracking.Border.ColorAngle = 135F;
            this.UserLvlsBut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UserLvlsBut.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.UserLvlsBut.StateTracking.Border.Rounding = 20;
            this.UserLvlsBut.StateTracking.Border.Width = 1;
            this.UserLvlsBut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.UserLvlsBut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.UserLvlsBut.TabIndex = 24;
            this.UserLvlsBut.Values.Text = "Рівні гравців";
            this.UserLvlsBut.Click += new System.EventHandler(this.UserLvlsBut_Click);
            this.UserLvlsBut.MouseLeave += new System.EventHandler(this.CircleHitBox_MouseLeave);
            this.UserLvlsBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CircleHitBox_MouseMove);
            // 
            // CircleAnimTimer
            // 
            this.CircleAnimTimer.Interval = 1;
            this.CircleAnimTimer.Tick += new System.EventHandler(this.CircleAnimTimer_Tick);
            // 
            // SwapMenuTimer
            // 
            this.SwapMenuTimer.Interval = 1;
            this.SwapMenuTimer.Tick += new System.EventHandler(this.SwapMenuTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(917, 557);
            this.Controls.Add(this.KryptoPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CoinLabel);
            this.Controls.Add(this.CircleHitBox);
            this.MaximumSize = new System.Drawing.Size(935, 604);
            this.MinimumSize = new System.Drawing.Size(935, 604);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KryptoPanel)).EndInit();
            this.KryptoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleHitBox)).EndInit();
            this.CircleHitBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label CoinLabel;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton CircleButton;
        private Krypton.Toolkit.KryptonPanel KryptoPanel;
        private Krypton.Toolkit.KryptonLabel nickbutton;
        private PictureBox profileimg;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ExitButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton FriendsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AccountButton;
        private System.Windows.Forms.Timer AnimTimer;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OsuButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MiniButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton StoreButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SettingsButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ExxitButton;
        private Krypton.Toolkit.KryptonPanel CircleHitBox;
        private System.Windows.Forms.Timer CircleAnimTimer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BackBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MainLvlsBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton NewLvlBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MyLvlsBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton UserLvlsBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BoxStoreBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton MySkinsBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SkinStorBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton OsuRecordBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton TestBut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AIMbut;
        private System.Windows.Forms.Timer SwapMenuTimer;
    }
}