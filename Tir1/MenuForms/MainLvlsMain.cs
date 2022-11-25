using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class MainLvlsMain : KryptonForm
    {
        account ac;
        FileInfo[] files;
        bool[] fl;
        Bitmap bmp;
        int buti, atime, floc1, floc2, floc3;
        bool nap;
        public bool closegame = false;
        bool back = false;
        string[] marks, practicemarks;
        public MainLvlsMain()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            SetFl();
            InitializeComponent();
            buti = 0;
            SetBuutonsName(buti);
            DrawPoints(buti);
        }
        public void SetFl()
        {
            int i1 = 0;
            ac = new account();
            files = new DirectoryInfo("MainLvls/").GetFiles();
            fl = new bool[files.Length];
            marks = new string[files.Length];
            practicemarks = new string[files.Length];
            for (i1 = 0; i1 < fl.Length; i1++)
            {
                bool fl1 = false;
                for (int j = 0; j < ac.lvls.Count; j++)
                    if (ac.lvls[j].name == files[i1].Name.Substring(0, files[i1].Name.Length - 5))
                    {
                        if (ac.lvls[j].complete)
                        {
                            fl[i1] = true;
                            fl1 = true;
                        }
                        else
                        {
                            fl[i1] = false;
                            fl1 = true;
                        }
                        marks[i1] = ac.lvls[j].recordmark;
                        practicemarks[i1] = ac.lvls[j].practicemark;
                        break;
                    }
                if (!fl1)
                {
                    osulvl? o;
                    using (FileStream fs = new FileStream(files[i1].FullName, FileMode.OpenOrCreate))
                    {
                        o = JsonSerializer.Deserialize<osulvl>(fs);
                    }
                    ac.lvls.Add(new lvlinfo(files[i1].Name.Substring(0, files[i1].Name.Length - 5), o.circles.Count));
                    fl[i1] = false;
                    marks[i1] = "-";
                    practicemarks[i1] = "-";
                }
                if (ac.nick == "admin") fl[i1] = true;
            }
            for (int i = 1; i < fl.Length / 3; i++)
            {
                if (fl[i * 3 - 1] || fl[i * 3 - 2] || fl[i * 3 - 3])
                {
                    fl[i * 3] = true;
                }
            }
        }
        public void DrawPoints(int i)
        {
            bmp = new Bitmap(PointsBox.Width,PointsBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush b;
            for (int j = 0; j < files.Length; j++)
            {
                if (i == j)
                    b = new SolidBrush(Color.Red);
                else
                    b = new SolidBrush(Color.Gray);
                g.FillEllipse(b, (int)(PointsBox.Width * ((double)(j + 1) / (files.Length + 1))) - 5, PointsBox.Height / 2 - 5, 10, 10);
            }
            PointsBox.Image = bmp;
        }
        public void SetBuutonsName(int i)
        {
            MarkLabel1.Text = marks[i];
            MarkLabel2.Text = practicemarks[i];
            if (LvlButton1.Location.X > LvlButton2.Location.X && LvlButton1.Location.X > LvlButton3.Location.X)
            {
                LvlButton3.Text = files[i].Name.Substring(0, files[i].Name.Length - 5);
                if (i == 0)
                    LvlButton2.Text = files[files.Length - 1].Name.Substring(0, files[files.Length - 1].Name.Length - 5);
                else
                    LvlButton2.Text = files[i - 1].Name.Substring(0, files[i - 1].Name.Length - 5);
                if (i == files.Length - 1)
                    LvlButton1.Text = files[0].Name.Substring(0, files[0].Name.Length - 5);
                else
                    LvlButton1.Text = files[i + 1].Name.Substring(0, files[i + 1].Name.Length - 5);
            }
            else if (LvlButton2.Location.X > LvlButton1.Location.X && LvlButton1.Location.X > LvlButton3.Location.X)
            {
                LvlButton1.Text = files[i].Name.Substring(0, files[i].Name.Length - 5);
                if (i == 0)
                    LvlButton3.Text = files[files.Length - 1].Name.Substring(0, files[files.Length - 1].Name.Length - 5);
                else
                    LvlButton3.Text = files[i - 1].Name.Substring(0, files[i - 1].Name.Length - 5);
                if (i == files.Length - 1)
                    LvlButton2.Text = files[0].Name.Substring(0, files[0].Name.Length - 5);
                else
                    LvlButton2.Text = files[i + 1].Name.Substring(0, files[i + 1].Name.Length - 5);
            }
            else
            {
                LvlButton2.Text = files[i].Name.Substring(0, files[i].Name.Length - 5);
                if (i == 0)
                    LvlButton1.Text = files[files.Length - 1].Name.Substring(0, files[files.Length - 1].Name.Length - 5);
                else
                    LvlButton1.Text = files[i - 1].Name.Substring(0, files[i - 1].Name.Length - 5);
                if (i == files.Length - 1)
                    LvlButton3.Text = files[0].Name.Substring(0, files[0].Name.Length - 5);
                else
                    LvlButton3.Text = files[i + 1].Name.Substring(0, files[i + 1].Name.Length - 5);
            }
            buton.GetBut(LvlButton1, osulvl.GetRarityLvl("MainLvls/" + LvlButton1.Text + ".json"), 20);
            buton.GetBut(LvlButton2, osulvl.GetRarityLvl("MainLvls/" + LvlButton2.Text + ".json"), 20);
            buton.GetBut(LvlButton3, osulvl.GetRarityLvl("MainLvls/" + LvlButton3.Text + ".json"), 20);
            LvlButton1 = SetLock(LvlButton1);
            LvlButton2 = SetLock(LvlButton2);
            LvlButton3 = SetLock(LvlButton3);
        }

        public void SetVisualButton(object button)
        {
            var but = (KryptonButton)button;
            
        }
        public KryptonButton SetLock(KryptonButton b)
        {
            for (int j = 0; j < files.Length; j++)
                if (files[j].Name == b.Text + ".json")
                {
                    if (j == 0)
                    {
                        if (b.BackgroundImage != null)
                        {
                            b.Click += LvlButtonClick;
                            b.Click -= LockButton_Click;
                        }
                        b.BackgroundImage = null;
                        return b;
                    }
                    bool fl1 = false;
                    for (int i = 0; i < j; i++)
                        if (!fl[i]) fl1 = true;
                    if (fl1)
                    {
                        if (b.BackgroundImage == null)
                        {
                            b.Click -= LvlButtonClick;
                            b.Click += LockButton_Click;
                        }
                        b.Text = "Закрито";
                        b.BackgroundImage = Properties.Resources._lock;
                        b.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else
                    {
                        if (b.BackgroundImage != null)
                        {
                            b.Click += LvlButtonClick;
                            b.Click -= LockButton_Click;
                        }
                        b.BackgroundImage = null;
                    }
                }
            return b;
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ви не пройшли попередній рівень!","Заблоковано!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MainLvlsMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                LeftClick();
            if (e.KeyCode == Keys.D)
                RightClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RightClick();
        }

        public void RightClick()
        {
            MarkLabel1.Visible = false;
            MarkLabel2.Visible = false;
            if (atime != 0)
            {
                atime = 23;
                AnimTimer_Tick(new object(), new EventArgs());
                AnimTimer_Tick(new object(), new EventArgs());
            }
            if (buti == files.Length - 1)
                buti = 0;
            else
                buti++;

            DrawPoints(buti);
            atime = 0;
            nap = true;
            floc1 = LvlButton1.Location.X;
            floc2 = LvlButton2.Location.X;
            floc3 = LvlButton3.Location.X;
            AnimTimer.Start();
        }

        private void MainLvlsMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeftClick();
        }
        public void LeftClick()
        {
            MarkLabel1.Visible = false;
            MarkLabel2.Visible = false;
            if (atime != 0)
            {
                atime = 23;
                AnimTimer_Tick(new object(), new EventArgs());
                AnimTimer_Tick(new object(), new EventArgs());
            }
            if (buti == 0)
                buti = files.Length - 1;
            else
                buti--;
            DrawPoints(buti);
            atime = 0;
            nap = false;
            floc1 = LvlButton1.Location.X;
            floc2 = LvlButton2.Location.X;
            floc3 = LvlButton3.Location.X;
            AnimTimer.Start();
        }
        private void LvlButtonClick(object sender, EventArgs e)
        {
            var but = (KryptonButton)sender;
            osulvl? olvl;
            using (FileStream fs = new FileStream(files[buti].FullName, FileMode.OpenOrCreate))
            {
                olvl = JsonSerializer.Deserialize<osulvl>(fs);
                FileInfo fi = new FileInfo(files[buti].FullName);
                olvl.path = fi.FullName;
            }
            
            LvlForm f = new LvlForm(olvl, false);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                closegame = true;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
            SetFl();
            SetBuutonsName(buti);
            DrawPoints(buti);
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            atime++;
            if (atime == 25)
            {
                MarkLabel1.Visible = true;
                MarkLabel2.Visible = true;
                if (floc1 > floc2 && floc1 > floc3)
                {
                    if (nap)
                        LvlButton2.Location = new Point(floc1, LvlButton2.Location.Y);
                    else
                        LvlButton1.Location = new Point(floc2, LvlButton2.Location.Y);
                }
                else if (floc2 > floc1 && floc2 > floc3)
                {
                    if (nap)
                        LvlButton3.Location = new Point(floc2, LvlButton2.Location.Y);
                    else
                        LvlButton2.Location = new Point(floc3, LvlButton2.Location.Y);
                }
                else
                {
                    if (nap)
                        LvlButton1.Location = new Point(floc3, LvlButton2.Location.Y);
                    else
                        LvlButton3.Location = new Point(floc1, LvlButton2.Location.Y);
                }
                atime = 0;
                SetBuutonsName(buti);
                AnimTimer.Stop();
                return;
            }
            if (nap)
            {
                LvlButton1.Location = new Point((int)(floc1 - ((atime + 1) * 700 / 25.0)), LvlButton2.Location.Y);
                LvlButton2.Location = new Point((int)(floc2 - ((atime + 1) * 700 / 25.0)), LvlButton2.Location.Y);
                LvlButton3.Location = new Point((int)(floc3 - ((atime + 1) * 700 / 25.0)), LvlButton2.Location.Y);
            }
            else
            {
                LvlButton1.Location = new Point((int)(floc1 + ((atime + 1) * 700 / 25.0)), LvlButton2.Location.Y);
                LvlButton2.Location = new Point((int)(floc2 + ((atime + 1) * 700 / 25.0)), LvlButton2.Location.Y);
                LvlButton3.Location = new Point((int)(floc3 + ((atime + 1) * 700 / 25.0)), LvlButton2.Location.Y);
            }
        }

    }
}
