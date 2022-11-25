using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Tir1.@class;

namespace Tir1
{
    public partial class MiniGamesF : KryptonForm
    {
        account ac;
        int type;
        public bool closegame = false;
        bool back = false;
        KryptonButton[] buttons;
        KryptonGroupBox[] gbs;
        KryptonLabel[] labels;
        PictureBox[] pbs;
        List<string> acs;
        List<int> arr;
        FileInfo[] files;
        public MiniGamesF(int type)
        {
            ac = new account();
            acs = new List<string>();
            this.Palette = new KryptoPaleta().kryptonPalette1;
            this.type = type;
            InitializeComponent();
            files = new DirectoryInfo("accounts/").GetFiles();
            TypeBox.SelectedIndex = 0;
            if (type == 0)
            {
                label1.Text = "Осу - рекорд";
                if (ac.osurecord > 0)
                    label4.Text = ac.osurecord.ToString();
                if (ac.osuatt > 0)
                    label5.Text = ac.osuatt.ToString();
            }
            else if (type == 1)
            {
                label1.Text = "Влучність";
                if (ac.aimrecord > 0)
                    label4.Text = ac.aimrecord.ToString();
                if (ac.aimatt > 0)
                    label5.Text = ac.aimatt.ToString();
            }
            else
            {
                label1.Text = "Увага";
                if (ac.testrecord > 0)
                    label4.Text = ac.testrecord.ToString();
                if (ac.testatt > 0)  
                    label5.Text = ac.testatt.ToString();
                kryptonNumericUpDown1.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void MiniGames_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                osugame f = new osugame(null, 0);
                this.Hide();
                f.ShowDialog();
                if (f.menu || f.closegame)
                {
                    back = f.menu;
                    closegame = f.closegame;
                    this.Close();
                    return;
                }
                this.Show();
            }
            else if (type == 1)
            {
                Form1 f = new Form1();
                f.ShowDialog();
                if (f.menu || f.closegame)
                {
                    back = f.menu;
                    closegame = f.closegame;
                    this.Close();
                    return;
                }
                this.Show();
            }
            else
            {
                GameForm f = new GameForm((int)kryptonNumericUpDown1.Value);
                this.Hide();
                f.ShowDialog();
                if (f.menu || f.closegame)
                {
                    back = f.menu;
                    closegame = f.closegame;
                    this.Close();
                    return;
                }
                this.Show();
            }
            
            
        }

        private void TypeBox_DropDownClosed(object sender, EventArgs e)
        {
            button3.Focus();
        }

        private void kryptonNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (kryptonNumericUpDown1.Value > ac.testrecord + 1) kryptonNumericUpDown1.Value--;
        }
        public void SetAcs()
        {
            if (TypeBox.SelectedIndex == -1)
                return;
            acs.Clear();
            if (TypeBox.SelectedIndex == 1)
            {
                acs.Add(ac.nick);
                for (int i = 0; i < ac.friends.Count; i++)
                    acs.Add(ac.friends[i]);
            }
            else
                for (int i = 0; i < files.Length; i++)
                    acs.Add(files[i].Name.Substring(0, files[i].Name.Length - 5));
            arr = new List<int>();
            for (int i = 0; i < acs.Count; i++)
            {
                account tempac = new account();
                tempac.GetAccount(acs[i]);
                if (type == 0)
                    arr.Add(tempac.osurecord);
                if (type == 1)
                    arr.Add(tempac.aimrecord);
                if (type == 2)
                    arr.Add(tempac.testrecord);
            }
            for (int i = arr.Count - 1; i >= 0; i--)
                if (arr[i] == 0)
                {
                    acs.RemoveAt(i);
                    arr.RemoveAt(i);
                }
            for (int i = 0; i < arr.Count; i++)
                for (int j = i + 1; j < arr.Count; j++)
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        string temps = (string)acs[j].Clone();
                        acs[j] = (string)acs[i].Clone();
                        acs[i] = temps;
                    }
        }
        public void SetButtons()
        {
            if (buttons != null)
                for (int i = 0; i < buttons.Length; i++)
                {
                    pbs[i].Dispose();
                    labels[i].Dispose();
                    buttons[i].Dispose();
                    gbs[i].Dispose();

                }
            buttons = new KryptonButton[acs.Count];
            gbs = new KryptonGroupBox[acs.Count];
            labels = new KryptonLabel[acs.Count];
            pbs = new PictureBox[acs.Count];
            for (int i = 0; i < acs.Count; i++)
            {


                account tempac = new account();
                tempac.GetAccount(acs[i]);
                pbs[i] = new PictureBox();
                pbs[i].Image = Image.FromFile(tempac.picpath);
                pbs[i].Location = new System.Drawing.Point(26, 21 + (94 * i));
                pbs[i].Name = "pictureBox1";
                pbs[i].Size = new System.Drawing.Size(76, 76);
                pbs[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                AcsPanel.Controls.Add(pbs[i]);

                labels[i] = new KryptonLabel();
                labels[i].Location = new System.Drawing.Point(121, 38 + (94 * i));
                labels[i].Name = "kryptonLabel1";
                labels[i].Size = new System.Drawing.Size(191, 44);
                labels[i].StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                labels[i].TabIndex = 4;
                labels[i].Text = (i + 1).ToString() + ". " + acs[i] + " — " + arr[i];
                AcsPanel.Controls.Add(labels[i]);

                buttons[i] = new KryptonButton();
                buttons[i].Location = new System.Drawing.Point(427, 26 + (94 * i));
                buttons[i].Name = acs[i];
                buttons[i].OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                buttons[i].OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                buttons[i].OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                buttons[i].OverrideDefault.Border.Rounding = 45;
                buttons[i].OverrideDefault.Border.Width = 1;
                buttons[i].OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                buttons[i].Size = new System.Drawing.Size(68, 68);
                buttons[i].StateCommon.Back.Color1 = System.Drawing.Color.White;
                buttons[i].StateCommon.Back.Color2 = System.Drawing.Color.White;
                buttons[i].StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                buttons[i].StateCommon.Border.Rounding = 45;
                buttons[i].StateCommon.Border.Width = 1;
                buttons[i].StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
                buttons[i].StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
                buttons[i].StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                buttons[i].StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateDisabled.Border.Rounding = 45;
                buttons[i].StateDisabled.Border.Width = 1;
                buttons[i].StateDisabled.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateNormal.Border.Rounding = 45;
                buttons[i].StateNormal.Border.Width = 1;
                buttons[i].StateNormal.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                buttons[i].StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                buttons[i].StatePressed.Back.ColorAngle = 135F;
                buttons[i].StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                buttons[i].StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                buttons[i].StatePressed.Border.ColorAngle = 135F;
                buttons[i].StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StatePressed.Border.Rounding = 45;
                buttons[i].StatePressed.Border.Width = 1;
                buttons[i].StatePressed.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                buttons[i].StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                buttons[i].StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].StateTracking.Back.ColorAngle = 135F;
                buttons[i].StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].StateTracking.Border.ColorAngle = 135F;
                buttons[i].StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                buttons[i].StateTracking.Border.Rounding = 45;
                buttons[i].StateTracking.Border.Width = 1;
                buttons[i].StateTracking.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                buttons[i].StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
                buttons[i].TabIndex = 3;
                buttons[i].Values.Text = "▶";
                buttons[i].Click += AccClick;
                AcsPanel.Controls.Add(buttons[i]);

                gbs[i] = new KryptonGroupBox();
                gbs[i].Location = new System.Drawing.Point(4, 14 + (94 * i));
                gbs[i].Name = "kryptonGroupBox1";
                gbs[i].Size = new System.Drawing.Size(498, 88);
                gbs[i].StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                gbs[i].StateCommon.Border.Color1 = System.Drawing.Color.Black;
                gbs[i].StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
                gbs[i].StateCommon.Border.Rounding = 20;
                gbs[i].StateCommon.Border.Width = 3;
                if (i == 0)
                    gbs[i].StateCommon.Border.Color1 = Color.Gold;
                if (i == 1)
                    gbs[i].StateCommon.Border.Color1 = Color.Silver;
                if (i == 2)
                    gbs[i].StateCommon.Border.Color1 = Color.Salmon;
                gbs[i].Values.Heading = "";
                AcsPanel.Controls.Add(gbs[i]);
                /*buttons[i] = new Button();
                buttons[i].Name = acs[i];
                buttons[i].Text = (i + 1).ToString() + ". " + acs[i] + " — " + arr[i] + " " + marks[i];
                buttons[i].Location = new Point(12, 181 + (53 * i));
                buttons[i].Size = new Size(344, 47);
                buttons[i].TextAlign = ContentAlignment.MiddleLeft;
                buttons[i].Font = new Font("Arial", 15);
                buttons[i].Click += AccClick;
                this.Controls.Add(buttons[i]);*/
            }
            if (acs.Count > 0)
                AcsPanel.Size = new Size(507, gbs[gbs.Length - 1].Location.Y + gbs[gbs.Length - 1].Size.Height);
        }
        private void AccClick(object sender, EventArgs e)
        {
            var but = (KryptonButton)sender;
            bool fl = false;
            if (ac.nick == but.Name) fl = true;
            AccountForm f = new AccountForm(but.Name, fl);
            this.Hide();
            f.ShowDialog();
            if (f.closegme)
            {
                f.Close();
                this.Close();
                return;
            }
            this.Show();
            SetAcs();
            SetButtons();
            ac = new account();
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAcs();
            SetButtons();
        }
    }
}
