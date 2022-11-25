using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class FriendsForm : KryptonForm
    {
        account ac;
        List<String> acs;
        FileInfo[] files;
        KryptonButton[] buttons;
        KryptonGroupBox[] gbs;
        KryptonLabel[] labels;
        PictureBox[] pbs;
        int[] arr;
        public bool closegame = false;
        bool back = false, hark = false;
        string find = "";
        public KryptonPalette kp;
        int maxh, point, formpos = 0;
        public FriendsForm()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            /*kp = new KryptonPalette();
            kp.Navigator.StateCommon.Bar.BarPaddingInside = new Padding(10, 10, 10, 10);
            kp.Navigator.StateCommon.Bar.ButtonEdgeInside = 20;
            kp.Navigator.StateCommon.Bar.ButtonPadding = new Padding(-1,20,-1,-1);*/
            ac = new account();
            acs = new List<String>();
            InitializeComponent();
            //this.MouseWheel += FormMouseWheel;
            //kryptonPanel1.Palette = kp;
            TypeBox.SelectedIndex = 0;
            button1.Focus();
            SortBox.SelectedIndex = 0;
            files = new DirectoryInfo("accounts/").GetFiles();

        }
        public void FormMouseWheel(object sender, MouseEventArgs e)
        {
            /*label1.Text = formpos.ToString();
            if (formpos - e.Delta > 0 && formpos - e.Delta < maxh - this.Height)
                formpos -= e.Delta;
            else
                return;*/
            /*HorizontalScroll.Minimum = 0;
            if (HorizontalScroll.Value - e.Delta > HorizontalScroll.Minimum
                && HorizontalScroll.Value - e.Delta < HorizontalScroll.Maximum)
                HorizontalScroll.Value -= e.Delta;
            else
                return;*/
            //point = point - e.Delta;
            /*int tempformpos = formpos - e.Delta;
            
            if (tempformpos < 0)
                return;
            if (tempformpos > maxh - this.Height)
                return;
            formpos = tempformpos;*/
            /*label1.Location = new Point(label1.Location.X, label1.Location.Y + e.Delta);
            button1.Location = new Point(button1.Location.X, button1.Location.Y + e.Delta);
            TypeBox.Location = new Point(TypeBox.Location.X, TypeBox.Location.Y + e.Delta);
            SortBox.Location = new Point(SortBox.Location.X, SortBox.Location.Y + e.Delta);
            FindTB.Location = new Point(FindTB.Location.X, FindTB.Location.Y + e.Delta);
            for (int i = 0; i < buttons.Length; i++)
                buttons[i].Location = new Point(buttons[i].Location.X, buttons[i].Location.Y + e.Delta);*/
            //DrawBar(maxh, formpos);
        }
        public void SetButtons()
        {
            if (gbs != null)
                for (int i = 0; i < gbs.Length; i++)
                {
                    gbs[i].Dispose();
                    pbs[i].Dispose();
                    labels[i].Dispose();
                    buttons[i].Dispose();
                }
            button1.Location = new Point(12, 10);
            FindTB.Location = new Point(123, 94);
            TypeBox.Location = new Point(73, 30);
            SortBox.Location = new Point(267, 30);
            //label1.Location = new Point(25, 104);
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
                labels[i].StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                labels[i].TabIndex = 4;
                if (hark)
                    labels[i].Text = acs[i] + " — " + arr[i];
                else
                    labels[i].Text = acs[i];
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
                gbs[i].Values.Heading = "";
                AcsPanel.Controls.Add(gbs[i]);
                /*buttons[i] = new Button();
                buttons[i].Name = acs[i];
                
                buttons[i].Location = new Point(12, 181 + (53 * i));
                buttons[i].Size = new Size(344, 47);
                buttons[i].TextAlign = ContentAlignment.MiddleLeft;
                buttons[i].Font = new Font("Arial", 15);
                buttons[i].Click += AccClick;
                this.Controls.Add(buttons[i]);*/
            }
            if (acs.Count > 0)
                AcsPanel.Size = new Size(507, gbs[gbs.Length - 1].Location.Y + gbs[gbs.Length - 1].Size.Height);
            //maxh = buttons[buttons.Length - 1].Location.Y + buttons[buttons.Length - 1].Size.Height + 100;
            /*
            point = 0;
            if (maxh > this.Height)
                DrawBar(maxh, point);*/
        }
        /*public void DrawBar(int maxh, int point)
        {
            Bitmap bmp = new Bitmap(NavigationBar.Width, NavigationBar.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.Gray),
                0, point, NavigationBar.Width,
                (int)(NavigationBar.Height * (NavigationBar.Height / (double)maxh)));
            NavigationBar.Image = bmp;
        }*/
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
            ac = new account();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void FriendsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAcs();
            SetButtons();
        }
        public void SetAcs()
        {
            if (SortBox.SelectedIndex == -1) 
                return;
            acs.Clear();
            if (TypeBox.SelectedIndex == 0)
            {
                if (SortBox.SelectedIndex != 0)
                    acs.Add(ac.nick);
                for (int i = 0; i < ac.friends.Count; i++)
                    acs.Add(ac.friends[i]);
            }
            else
                for (int i = 0; i < files.Length; i++)
                    if (files[i].Name.Substring(0, files[i].Name.Length - 5) != "admin")
                        if (SortBox.SelectedIndex == 0)
                        {
                            if (files[i].Name.Substring(0, files[i].Name.Length - 5) != ac.nick)
                                acs.Add(files[i].Name.Substring(0, files[i].Name.Length - 5));
                        }    
                        else
                            acs.Add(files[i].Name.Substring(0, files[i].Name.Length - 5));
            if (TypeBox.SelectedIndex == 0 && acs.Count == 0)
                nofriends.Visible = true;
            else
                nofriends.Visible = false;
            if (SortBox.SelectedIndex == 0)
            {
                hark = false;
                return;
            }
            hark = true;
            arr = new int[acs.Count];
            for (int i = 0; i < acs.Count; i++)
            {
                account tempac = new account();
                tempac.GetAccount(acs[i]);
                if (SortBox.SelectedIndex == 1)
                    arr[i] = tempac.rating;
                if (SortBox.SelectedIndex == 2)
                {
                    int s = 0;
                    for (int j = 0; j < tempac.lvls.Count; j++)
                        if (tempac.lvls[j].complete)
                            s++;
                    arr[i] = s;
                }
                if (SortBox.SelectedIndex == 3)
                {
                    int s = 0;
                    for (int j = 0; j < tempac.lvls.Count; j++)
                        s += tempac.lvls[j].clickcount;
                    arr[i] = s;
                }
                if (SortBox.SelectedIndex == 4)
                {
                    int s = 0;
                    for (int j = 0; j < tempac.lvls.Count; j++)
                        s += tempac.lvls[j].attcount;
                    s += tempac.osuatt + tempac.aimatt + tempac.testatt;
                    arr[i] = s;
                }
                if (SortBox.SelectedIndex == 5)
                    arr[i] = tempac.coinscount;
                if (SortBox.SelectedIndex == 6)
                {
                    int s = 0;
                    for (int j = 0; j < tempac.skins.Count; j++)
                        if (tempac.skins[j].have)
                            s++;
                    arr[i] = s;
                }
            }
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
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

        private void FindTB_TextChanged(object sender, EventArgs e)
        {
            if (FindTB.Text == "🔍") 
                find = "";
            else 
                find = FindTB.Text;
            SetAcs();
            for (int i = acs.Count - 1; i >= 0; i--)
                if (!acs[i].Contains(find))
                    acs.RemoveAt(i);
            SetButtons();
        }

        private void TypeBox_DropDownClosed(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void SortBox_DropDownClosed(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = AutoScrollPosition.Y.ToString();
            //NavigationBar.Location = new Point(NavigationBar.Location.X,
              //(int)(maxh * ((double)AutoScrollPosition.Y / HorizontalScroll.Maximum)));
            
            //DrawBar(maxh, (int)(NavigationBar.Height * ((double)AutoScrollPosition.Y / HorizontalScroll.Maximum)));
        }

        private void FindTB_Enter(object sender, EventArgs e)
        {
            FindTB.StateCommon.Content.Color1 = Color.Black;
            if (FindTB.Text == "🔍")
                FindTB.Text = "";
        }

        private void FindTB_Leave(object sender, EventArgs e)
        {
            if (FindTB.Text == "")
            {
                FindTB.StateCommon.Content.Color1 = Color.Gray;
                FindTB.Text = "🔍";
            }
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAcs();
            SetButtons();
        }
    }
}
