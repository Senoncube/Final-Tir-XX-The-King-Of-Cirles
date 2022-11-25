namespace Tir1
{
    partial class LogInForm
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
            this.nickTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.passwordTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.logincheck = new Tir1.Switch();
            this.button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.eyepb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eyepb)).BeginInit();
            this.SuspendLayout();
            // 
            // nickTB
            // 
            this.nickTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickTB.Location = new System.Drawing.Point(28, 94);
            this.nickTB.Name = "nickTB";
            this.nickTB.Size = new System.Drawing.Size(324, 53);
            this.nickTB.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nickTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nickTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nickTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nickTB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nickTB.StateCommon.Border.Rounding = 20;
            this.nickTB.StateCommon.Border.Width = 1;
            this.nickTB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.nickTB.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nickTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.nickTB.TabIndex = 15;
            this.nickTB.Text = "Введіть нікнейм";
            this.nickTB.Enter += new System.EventHandler(this.nickTB_Enter);
            this.nickTB.Leave += new System.EventHandler(this.nickTB_Leave);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTB.Location = new System.Drawing.Point(28, 177);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(224, 57);
            this.passwordTB.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.passwordTB.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTB.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTB.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.passwordTB.StateCommon.Border.Rounding = 20;
            this.passwordTB.StateCommon.Border.Width = 2;
            this.passwordTB.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordTB.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.passwordTB.TabIndex = 16;
            this.passwordTB.Text = "Введіть пароль";
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Аккаунт";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 318);
            this.button1.Name = "button1";
            this.button1.OverrideDefault.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.button1.OverrideDefault.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button1.OverrideDefault.Back.ColorAngle = 45F;
            this.button1.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.button1.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button1.OverrideDefault.Border.ColorAngle = 45F;
            this.button1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button1.OverrideDefault.Border.Rounding = 20;
            this.button1.OverrideDefault.Border.Width = 1;
            this.button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button1.Size = new System.Drawing.Size(179, 53);
            this.button1.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.button1.StateCommon.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button1.StateCommon.Back.ColorAngle = 45F;
            this.button1.StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.button1.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button1.StateCommon.Border.ColorAngle = 45F;
            this.button1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button1.StateCommon.Border.Rounding = 20;
            this.button1.StateCommon.Border.Width = 1;
            this.button1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button1.StatePressed.Back.ColorAngle = 135F;
            this.button1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button1.StatePressed.Border.ColorAngle = 135F;
            this.button1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StatePressed.Border.Rounding = 20;
            this.button1.StatePressed.Border.Width = 1;
            this.button1.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.button1.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button1.StateTracking.Back.ColorAngle = 135F;
            this.button1.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.button1.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button1.StateTracking.Border.ColorAngle = 135F;
            this.button1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button1.StateTracking.Border.Rounding = 20;
            this.button1.StateTracking.Border.Width = 1;
            this.button1.TabIndex = 2;
            this.button1.Values.Text = "Увійти";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logincheck
            // 
            this.logincheck.BackColor = System.Drawing.Color.White;
            this.logincheck.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.logincheck.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.logincheck.Checked = false;
            this.logincheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logincheck.Location = new System.Drawing.Point(279, 262);
            this.logincheck.Name = "logincheck";
            this.logincheck.Size = new System.Drawing.Size(43, 25);
            this.logincheck.TabIndex = 6;
            this.logincheck.TextOnChecked = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 318);
            this.button2.Name = "button2";
            this.button2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button2.OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.button2.OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.OverrideDefault.Border.Rounding = 20;
            this.button2.OverrideDefault.Border.Width = 1;
            this.button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button2.Size = new System.Drawing.Size(139, 53);
            this.button2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.button2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.button2.StateCommon.Border.Color1 = System.Drawing.Color.Sienna;
            this.button2.StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.StateCommon.Border.Rounding = 20;
            this.button2.StateCommon.Border.Width = 1;
            this.button2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button2.StatePressed.Back.ColorAngle = 135F;
            this.button2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.button2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.button2.StatePressed.Border.ColorAngle = 135F;
            this.button2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StatePressed.Border.Rounding = 20;
            this.button2.StatePressed.Border.Width = 1;
            this.button2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button2.StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.button2.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button2.StateTracking.Back.ColorAngle = 135F;
            this.button2.StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.button2.StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
            this.button2.StateTracking.Border.ColorAngle = 135F;
            this.button2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button2.StateTracking.Border.Rounding = 20;
            this.button2.StateTracking.Border.Width = 1;
            this.button2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button2.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button2.TabIndex = 2;
            this.button2.Values.Text = "Реєстрація";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eyepb
            // 
            this.eyepb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyepb.Image = global::Tir1.Properties.Resources.closed_eyes;
            this.eyepb.Location = new System.Drawing.Point(278, 186);
            this.eyepb.Name = "eyepb";
            this.eyepb.Size = new System.Drawing.Size(43, 41);
            this.eyepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyepb.TabIndex = 8;
            this.eyepb.TabStop = false;
            this.eyepb.MouseLeave += new System.EventHandler(this.eyepb_MouseLeave);
            this.eyepb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.eyepb_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Запам\'ятати на пристрої";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(379, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eyepb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.logincheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.nickTB);
            this.MaximumSize = new System.Drawing.Size(397, 446);
            this.MinimumSize = new System.Drawing.Size(397, 446);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.eyepb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nickTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordTB;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button1;
        private Switch logincheck;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button2;
        private PictureBox eyepb;
        private Label label4;
    }
}