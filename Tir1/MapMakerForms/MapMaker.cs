using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class MapMaker : KryptonForm
    {
        account ac;
        public bool closegame = false;
        public bool menu = false;
        public bool back = false;
        osulvl lvl;
        List<osucircle> cs;
        time t, TotalT;
        WaveOut MainOut;
        WaveStream MainStream;
        AudioFileReader audio;
        Bitmap bmp;
        bool isplay,textchangefl,isclick;
        int nowcircle;
        Point mouse,dobav;
        TimeSpan ltime,ctime;
        System.Windows.Forms.Timer ClickTimer;
        byte skin = 0;
        int coinscount = 0, heartcount = 0, shieldcount = 0;
        Image img;

        public MapMaker(osulvl lvl)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            this.lvl = lvl;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            InitializeComponent();
            buton.GetBut(PlayGameButton, -1, 10);
            buton.GetBut(DeleteButton, 0, 10);
            buton.GetBut(SetStandartButton, 0, 10);
            MainPic.MouseWheel += new MouseEventHandler(mousewheel);
            ac = new account();
            img = Image.FromFile(ac.skins[ac.skini].path);
            ClickTimer = new System.Windows.Forms.Timer(this.components);
            ClickTimer.Interval = 10;
            ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            MenuVis(false);
            SetZn();
        }
        public void mousewheel(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].isin(e.X, e.Y))
                {
                    SetNowCircle(cs[i].i);
                    lvl.circles[nowcircle].r += e.Delta / 10;
                    break;
                }
            DrawMoment((int)(ctime.TotalMilliseconds / 10));
            SetMenu(lvl.circles[nowcircle]);
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!isplay)
            {
                NullVidel();
                isplay = true;
                PlayButton.BackgroundImage = Properties.Resources.pause;
                if (audio.CurrentTime >= audio.TotalTime - new TimeSpan(0, 0, 0, 0, 100))
                {
                    audio = new AudioFileReader(lvl.SongName);
                    SetVolume();
                    MainOut.Init(audio);
                }
                MainOut.Play();
                MainTimer.Start();
            }
            else
            {
                isplay = false;
                PlayButton.BackgroundImage = Properties.Resources._375;
                MainOut.Pause();
                MainTimer.Stop();
            }
            MenuVis(false);
        }

        public void SetVolume()
        {
            settings sett = new settings();
            audio.Volume = (float)sett.musicvolume;
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {

            if (ltime != audio.CurrentTime)
            {
                ltime = audio.CurrentTime;
                ctime = audio.CurrentTime;
            }
            else
                ctime += new TimeSpan(0, 0, 0, 0, 10);
            //TimeSpan t = audio.CurrentTime;
            //t = new time(audio.CurrentTime);
            TimeLabel.Text = StringTime(ctime);
            if (audio.CurrentTime < audio.TotalTime - new TimeSpan(0, 0, 0, 0, 100))
                SongTrackBar.Value = (int)(ctime.TotalMilliseconds * 1000 / audio.TotalTime.TotalMilliseconds);
            if (audio.CurrentTime >= audio.TotalTime - new TimeSpan(0, 0, 0, 0, 10))
            {
                isplay = false;
                PlayButton.Text = "▶";
                MainOut.Pause();
                MainTimer.Stop();
            }
            DrawMoment((int)(ctime.TotalMilliseconds / 10));
        }

        private void MapMaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainOut.Stop();
            if (!menu && !back) closegame = true;
        }

        private void SongTrackBar_Scroll(object sender, EventArgs e)
        {
            audio.CurrentTime = new TimeSpan(0,0,
                (int)(audio.TotalTime.TotalMilliseconds/60000 * (SongTrackBar.Value / 1000.0)),
                (int)(audio.TotalTime.TotalMilliseconds / 1000  * (SongTrackBar.Value / 1000.0) % 60),
                (int)(audio.TotalTime.TotalMilliseconds  * (SongTrackBar.Value / 1000.0) % 1000));
            ctime = audio.CurrentTime;
            TimeLabel.Text = StringTime(ctime);
            DrawMoment((int)(ctime.TotalMilliseconds / 10));
        }

        public string StringTime(TimeSpan t)
        {
            if (ctime.Minutes == 0)
                return ctime.Seconds.ToString() + "." + ctime.Milliseconds.ToString();
            else
                return ctime.Minutes.ToString() + ":" + ctime.Seconds.ToString() + "." + ctime.Milliseconds.ToString();
        }



        public void SetZn()
        {
            cs = new List<osucircle>();
            MainOut = new WaveOut();
            audio = new AudioFileReader(lvl.SongName);
            MainOut.Init(audio);
            TotalT = new time(audio.TotalTime);
            TotalTimeLabel.Text = TotalT.ToString();
            isplay = false;
            textchangefl = true;
            isclick = false;
            dobav = new Point(0, 0);
            nowcircle = -1;
        }

        public void DrawMoment(int t)
        {
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            Graphics g = Graphics.FromImage(bmp);
            cs = new List<osucircle>();
            for (int i = 0; i < lvl.circles.Count; i++)
            {
                if (lvl.circles[i].IsTImeIn(t))
                {
                    cs.Add((osucircle)lvl.circles[i].Clone());
                    cs[cs.Count - 1].i = i;
                }
            }
            for (int i = 0; i < cs.Count; i++)
            {
                cs[i].SetSc(t);
                if (!cs[i].Videl)
                {
                    cs[i].drawfirstcircle(g, img);
                    cs[i].drawsecondcircle(g);
                }
            }
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Videl)
                {
                    cs[i].SetSc(t);
                    cs[i].drawfirstcircle(g, img);
                    cs[i].drawsecondcircle(g);
                }
            MainPic.Image = bmp;
        }

        private void SetStandartButton_Click(object sender, EventArgs e)
        {
            lvl.r = int.Parse(rTB.Text);
            lvl.sc = double.Parse(scTB.Text);
            lvl.res1 = double.Parse(res1TB.Text);
            lvl.res2 = double.Parse(res2TB.Text);
            lvl.speed = double.Parse(speedTB.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            lvl.DelCirc(nowcircle);
            nowcircle = -1;
            MenuVis(false);
            DrawMoment((int)(ctime.TotalMilliseconds / 10));
            lvl.SaveJson();
        }

        private void xTB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void MainPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isplay)
            {
                for (int i = 0; i < cs.Count; i++)
                    if (cs[i].isin(e.X, e.Y))
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            dobav.X = e.X - cs[i].x;
                            dobav.Y = e.Y - cs[i].y;
                            SetNowCircle(cs[i].i);
                            ClickTimer.Start();
                        }
                        else
                        {
                            lvl.DelCirc(cs[i].i);
                            NullVidel();
                            DrawMoment((int)(ctime.TotalMilliseconds / 10));
                            lvl.SaveJson();
                        }
                        return;
                    }
            }
            if (e.Button == MouseButtons.Left)
            {
                lvl.NewCirc(e.X, e.Y, (int)(ctime.TotalMilliseconds / 10 - (1 / lvl.speed) * (2 / lvl.sc)), skin);
                if (skin != 0)
                {
                    if (skin == 1)
                        coinscount++;
                    if (skin == 2)
                        heartcount++;
                    if (skin == 3)
                        shieldcount++;
                    skin = 0;
                }
                DrawMoment((int)(ctime.TotalMilliseconds / 10));
                SetNowCircle(lvl.circles.Count - 1);
                ClickTimer.Start();
            }
            else
            {
                for (int i = 0; i < cs.Count; i++)
                    if (cs[i].isin(e.X, e.Y))
                        {
                            if (lvl.circles[cs[i].i].skin == 1)
                                coinscount--;
                            if (lvl.circles[cs[i].i].skin == 2)
                                heartcount--;
                            if (lvl.circles[cs[i].i].skin == 1)
                                shieldcount--;
                            lvl.DelCirc(cs[i].i);
                                lvl.SaveJson();
                        }
                NullVidel();
                DrawMoment((int)(ctime.TotalMilliseconds / 10));
            }
        }

        public void SetNowCircle(int i)
        {
            NullVidel();
            nowcircle = i;
            lvl.circles[nowcircle].Videl = true;
            lvl.SaveJson();
            MenuVis(true);
            SetMenu(lvl.circles[i]);
        }

        public void NullVidel()
        {
            for (int i = 0; i < lvl.circles.Count; i++)
                lvl.circles[i].Videl = false;
            MenuVis(false);
        }
        private void MainPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickTimer.Stop();
                DrawMoment((int)(ctime.TotalMilliseconds / 10));
                lvl.SaveJson();
                SetMenu(lvl.circles[nowcircle]);
            }
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            NullVidel();
            MainOut.Stop();
            lvl.timestart = new TimeSpan(0, 0, 0, 0, 0);
            osugame f = new osugame(lvl,3);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                closegame = f.closegame;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            SetVolume();
            lvl.timestart = new TimeSpan(0, 0, 0, 0, 0);
            this.Show();
        }

        private void yTB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void rTB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void scTB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void res1TB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void res2TB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void speedTB_TextChanged(object sender, EventArgs e)
        {
            SetHark();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (coinscount == 3)
            {
                MainOut.Pause();
                MessageBox.Show("У рівня не може бути більше 3 монет!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (isplay) MainOut.Play();
            }
            else 
                skin = 1;
        }

        private void skinb2_Click(object sender, EventArgs e)
        {
            skin = 2;
        }

        private void skinb3_Click(object sender, EventArgs e)
        {
            skin = 3;
        }

        private void MainPic_MouseMove(object sender, MouseEventArgs e)
        {
            mouse.X = e.X;
            mouse.Y = e.Y;
        }

        public void MenuVis(bool fl)
        {
            label1.Visible = fl;
            label2.Visible = fl;
            label3.Visible = fl;
            label4.Visible = fl;
            label5.Visible = fl;
            label6.Visible = fl;
            label7.Visible = fl;
            xTB.Visible = fl;
            yTB.Visible = fl;
            rTB.Visible = fl;
            scTB.Visible = fl;
            res1TB.Visible = fl;
            res2TB.Visible = fl;
            speedTB.Visible = fl;
            DeleteButton.Visible = fl;
            SetStandartButton.Visible = fl;
            skinb1.Visible = !fl;
            skinb2.Visible = !fl;
            skinb3.Visible = !fl;
        }

        public void SetMenu(osucircle c)
        {
            textchangefl = false;
            xTB.Text = c.x.ToString();
            yTB.Text = c.y.ToString();
            rTB.Text = c.r.ToString();
            scTB.Text = c.sc.ToString();
            res1TB.Text = c.res1.ToString();
            res2TB.Text = c.res2.ToString();
            speedTB.Text = c.speed.ToString();
            textchangefl = true;
            SetHark();
        }

        public void SetHark()
        {
            if (textchangefl)
            {
                try 
                {
                    ErrorLabel.Visible = false;
                    lvl.circles[nowcircle].x = int.Parse(xTB.Text);
                    lvl.circles[nowcircle].y = int.Parse(yTB.Text);
                    lvl.circles[nowcircle].r = int.Parse(rTB.Text);
                    lvl.circles[nowcircle].sc = double.Parse(scTB.Text);
                    lvl.circles[nowcircle].res1 = double.Parse(res1TB.Text);
                    lvl.circles[nowcircle].res2 = double.Parse(res2TB.Text);
                    lvl.circles[nowcircle].speed = double.Parse(speedTB.Text);
                    DrawMoment((int)(ctime.TotalMilliseconds / 10));
                }
                catch
                {
                    ErrorLabel.Visible = true;
                }
                
                lvl.SaveJson();
            }
        }
        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            lvl.circles[nowcircle].x = mouse.X - dobav.X;
            lvl.circles[nowcircle].y = mouse.Y - dobav.Y;
            DrawMoment((int)(ctime.TotalMilliseconds / 10));
            SetMenu(lvl.circles[nowcircle]);
        }
    }
}
