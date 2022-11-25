using System.Text.Json;
using NAudio.Wave;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class osugame : KryptonForm
    {
        account ac;
        settings sett;
        lvlinfo lvli, past;
        osulvl olvl;
        List<osucircle> circles;
        osucircle c;
        List<osucircle> cs;
        List<warning> WarList;
        Image img, redcross, redsign, yellowsign,
            manycoins, Shield, heartskin, heartskin2, heart, razb, coinskin, shieldskin;
        int r = 80;
        int s = 0;
        int hp = 3;
        int combo, kc, kcc, ctime, chastota, ltime, kolc, koln;
        double sc = 3;
        double speed = 0.005;
        double res1 = 0.25;
        double res2 = 0.75;
        double time = 15.0;
        double gtime = 0;
        bool prikol = false;
        public bool flcl = false;
        bool shield = false;
        byte type;
        int x, y;
        int coins;
        bool newskin = false;
        int pastskin;
        WaveOut MusicOut;
        AudioFileReader audio;
        //AudioFileReader[] a;
        WaveStream MainStream;
        Bitmap bmp, bmpbar;
        Random rand = new Random();

        public bool menu = false;
        public bool closegame = false;
        TimeSpan cctime, lltime, lvltime;
        public osugame(osulvl olvl, byte type)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            MusicOut = new WaveOut();
            //MainOut = new WaveOut();
            ac = new account();
            if (type != 0)
                if (olvl.rewardskin != null)
                {
                    newskin = true;
                    pastskin = ac.skini;
                    ac.skini = ac.SkinId(olvl.rewardskin);
                    ac.SaveAccount();
                }
            img = Image.FromFile(ac.skins[ac.skini].path);
            redcross = Properties.Resources.redcross;
            redsign = Properties.Resources.redsign;
            yellowsign = Properties.Resources.yellowsign;
            manycoins = Properties.Resources.manycoins;
            Shield = Properties.Resources.Shield;
            heartskin = Properties.Resources.heartskin;
            heartskin2 = Properties.Resources.heartskin2;
            heart = Properties.Resources.mainheart;
            razb = Properties.Resources.razb;
            coinskin = Properties.Resources.coin;
            shieldskin = Properties.Resources.shiel2;
            /*a = new AudioFileReader[9];
            a[0] = new AudioFileReader("sounds/badsound.mp3");
            a[1] = new AudioFileReader("sounds/coinsound.mp3");
            a[2] = new AudioFileReader("sounds/goodclick (1).mp3");
            a[3] = new AudioFileReader("sounds/hpsound.mp3");
            a[4] = new AudioFileReader("sounds/redcross (1).mp3");
            a[5] = new AudioFileReader("sounds/redsign (1).mp3");
            a[6] = new AudioFileReader("sounds/shielddown.mp3");
            a[7] = new AudioFileReader("sounds/shieldup.mp3");
            a[8] = new AudioFileReader("sounds/yellowsign (1).mp3");*/
            sett = new settings();

            this.olvl = olvl;
            this.type = type;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            InitializeComponent();
            CoolStart();
        }
        public void Start()
        {
            ac = new account();
            if (type != 0) olvl.attcount++;
            if (type == 0) ac.osuatt++;
            ac.SaveAccount();
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            gtime = 0;
            fps.Start();
            r = 80;
            s = 0;
            schet.Text = s.ToString();
            SetZn();
            gtime = 1;
            NewCircle();
            CoinLabel.Text = "0";
            shieldpb.Visible = false;
            if (type != 0)
                if (File.Exists(olvl.SongName))
                {
                    lvltime = new TimeSpan(0,0,0,0,olvl.LvlTIme()*10);
                    audio = new AudioFileReader(olvl.SongName);
                    audio.CurrentTime = new TimeSpan(0,0,0,0,0);
                    MainStream = audio;
                    MusicOut.Init(MainStream);
                    MusicOut.Play();
                }
            if (MainStream == null || type == 0)
            {
                audio = new AudioFileReader("music/fonmusic1.mp3");
                MainStream = audio;

                MusicOut.Init(MainStream); 
                MusicOut.Play();
            }
            if (type == 2)
            {
                hp = 999999;
                heart1.Visible = false;
                heart2.Visible = false;
                heart3.Visible = false;
                coinpb.Visible = false;
                CoinLabel.Visible = false;
            }
            audio.Volume = (float)sett.musicvolume;
        }

        public void RisBar()
        {
            Graphics g = Graphics.FromImage(bmpbar);
            int pos1 = (int)(179);
            int pos2 = (int)(400 * (1 - res2));
            g.FillRectangle(new SolidBrush(Color.Red), pos1, 10, pos2, 20);
            pos1 += pos2;
            pos2 = (int)(400 * res2 - 400 * res1);
            g.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(pos1, 10, pos2, 20));
            pos1 += pos2;
            pos2 = (int)(400 * res1);
            g.FillRectangle(new SolidBrush(Color.Green), pos1, 10, pos2, 20);
            pos1 += pos2;
            pos2 = (int)(200 * res1);
            g.FillRectangle(new SolidBrush(Color.Green), pos1, 10, pos2, 20);
            pos1 += pos2;
            pos2 = (int)(200 * res2 - 200 * res1);
            g.FillRectangle(new SolidBrush(Color.Yellow), pos1, 10, pos2, 20);
            pos1 += pos2;
            pos2 = (int)(200 * (1 - res2));
            g.FillRectangle(new SolidBrush(Color.Red), pos1, 10, pos2, 20);
            g.FillRectangle(new SolidBrush(Color.Black), 575, 10, 8, 20);
            PicBar.Image = bmpbar;
        }

        public void RisRis()
        {
            if (cs.Count > 0)
            {
                bmpbar = new Bitmap(PicBar.Width, PicBar.Height);
                RisBar();
                Graphics g = Graphics.FromImage(bmpbar);
                int p = (int)(600 - 200 * cs[0].sc) + 179;
                g.FillRectangle(new SolidBrush(Color.Black), p - 4, 5, 8, 30);
                PicBar.Image = bmpbar;
                RisProgresBar();
            }
        }

        public void SetZn()
        {
            if (type != 0)
            {
                
                int j = 0;
                bool fl = false;
                for (j = 0; j < ac.lvls.Count; j++)
                    if (ac.lvls[j].name == olvl.name)
                    {
                        fl = true;
                        break;
                    }
                if (!fl)
                {
                    j = ac.lvls.Count();
                    ac.lvls.Add(new lvlinfo(olvl.name,olvl.circles.Count));
                }
                lvli = (lvlinfo)ac.lvls[j].Clone();
                lvli.attcount += 1;
                past = (lvlinfo)lvli.Clone();
                
                /*olvl = new osulvl("aboba");
                olvl.NewCirc(100, 100, 100);
                olvl.NewCirc(150, 100, 125);
                olvl.NewCirc(200, 200, 150);
                olvl.NewCirc(250, 100, 175);
                olvl.NewCirc(300, 100, 200);*/
                circles = new List<osucircle>();
                for (int i =0; i < olvl.circles.Count; i++)
                {
                    if (olvl.circles[i].skin == 1)
                        lvli.coinscount++;
                    if (olvl.timestart < new TimeSpan(0, 0, 0, 0, olvl.circles[i].GetEndTime()*10))
                    {
                        circles.Add((osucircle)olvl.circles[i].Clone());
                        circles[circles.Count - 1].Videl = false;
                        circles[circles.Count - 1].maini = circles.Count - 1;
                    }
                }
                koln = circles.Count;
            }

            heart1.Image = heart;
            heart2.Image = heart;
            heart3.Image = heart;
            r = 80;
            s = 0;
            if (type != 0)
            {
                hp = olvl.hp;
                if (hp < 3)
                    heart3.Image = razb;
                if (hp < 2)
                    heart2.Image = razb;
            }
            else
                hp = 3;
            sc = 3;
            combo = 1;
            kc = 0;
            kcc = 0;
            ctime = 0;
            speed = 0.005;
            res1 = 0.25;
            res2 = 0.5;
            time = 0;
            gtime = 0;
            chastota = 100;
            ltime = 0;
            kolc = 0;
            coins = 0;
            cs = new List<osucircle>();
            WarList = new List<warning>();
            bmpbar = new Bitmap(PicBar.Width, PicBar.Height);
        }
        private void VisLab(bool fl)
        {
            label1.Visible = fl;
            schet.Visible = fl;
            MainPic.Visible = fl;
            PicBar.Visible = fl;
            label2.Visible = fl;
            combolabel.Visible = fl;
            heart1.Visible = fl;
            heart2.Visible = fl;
            heart3.Visible = fl;
            PauseBuuton.Visible = fl;
            coinpb.Visible = fl;
            CoinLabel.Visible = fl;
            shieldpb.Visible = fl;
        }
        public void SetHP()
        {
            if (hp == 3)
            {
                heart1.Image = heart;
                heart2.Image = heart;
                heart3.Image = heart;
            }
            if (hp == 2)
            {
                heart1.Image = heart;
                heart2.Image = heart;
                heart3.Image = razb;
            }
            if (hp == 1)
            {
                heart1.Image = heart;
                heart2.Image = razb;
                heart3.Image = razb;
            }
        }
        public void CoolStart()
        {
            VisLab(false);
            cslabel.Visible = true;
            time = 3;
            cslabel.Text = time.ToString("F0");
            cstimer.Start();
            gtime = 0;
            gtimer.Start();
        }

        public void DrawFCircle()
        {
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            Graphics g = Graphics.FromImage(bmp);
            int n = cs.Count;
            for (int i = 0; i < n; i++)
            {
                if (cs[i].skin == 0)
                    cs[i].drawfirstcircle(g, img);
                if (cs[i].skin == 1)
                    cs[i].drawfirstcircle(g, coinskin);
                if (cs[i].skin == 2)
                    cs[i].drawfirstcircle(g, heartskin2);
                if (cs[i].skin == 3)
                    cs[i].drawfirstcircle(g, shieldskin);
            }
            MainPic.BackgroundImage = bmp;
        }
        public void DrawCircle()
        {
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            Graphics g = Graphics.FromImage(bmp);
            int n = cs.Count;
            for (int i = 0; i < n; i++)
            {
                cs[i].drawsecondcircle(g);
            }
            for (int i = 0; i < WarList.Count; i++)
                if (WarList[i].i == 1)
                    WarList[i].draw(g, redcross);
                else if (WarList[i].i == 2)
                    WarList[i].draw(g, redsign);
                else if (WarList[i].i == 3)
                    WarList[i].draw(g, yellowsign);
                else if (WarList[i].i == 4)
                    WarList[i].draw(g, heartskin);
                else if (WarList[i].i == 5)
                    WarList[i].draw(g, Shield);
                else if (WarList[i].i == 6)
                    WarList[i].draw(g, manycoins);
            MainPic.Image = bmp;
        }
        public void NewCircle()
        {
            if (olvl == null)
            {
                if (chastota > 50) chastota--;
                if (r > 50) r -= 2;
                if (speed < 0.02) speed += 0.0001;
                if (res1 > 0.05) res1 -= 0.002;
                if (res2 > 0.2) res2 -= 0.004;
                double skincir = rand.NextDouble();
                NewNewCircle();
                if (skincir < 0.01) c.skin = 1;
                else if (skincir < 0.02) c.skin = 2;
                else if (skincir < 0.03) c.skin = 3;
                cs.Add(c);
                DrawFCircle();
                DrawCircle();
            }
        }


        public void NewNewCircle()
        {
            c = new osucircle(r, sc, speed, res1, res2);
            for (int i = 0; i < cs.Count; i++)
                if (c.Peresechenie(cs[i]))
                    NewNewCircle();
        }

        private void osugame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !gtimer.Enabled) Pause();
            if ((e.KeyCode == sett.click2 || e.KeyCode == sett.click2) && !gtimer.Enabled) click(x,y);
        }

        public void Pause()
        {
            MusicOut.Pause();
            fps.Stop();
            Pause f = new Pause();
            this.Hide();
            f.ShowDialog();
            if (f.NewAtt)
            {
                CoolStart();
                this.Show();
                return;
            }
            if (f.menu)
            {
                menu = true;
                this.Close();
                return;
            }
            if (f.CloseGame)
            {
                closegame = true;
                this.Close();
                return;
            }
            f.Close();
            sett = new settings();
            audio.Volume = (float)sett.musicvolume;
            this.Show();
            MusicOut.Play();
            fps.Start();
        }

        private void MainPic_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void osugame_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void MainPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gtimer.Enabled) click(e.X,e.Y);
        }

        private void MainPic_MouseClick(object sender, MouseEventArgs e)
        {
            //click(e);
        }

        private void osugame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (newskin)
            {
                ac.skini = pastskin;
                ac.SaveAccount();
            }
            if (!gtimer.Enabled) MusicOut.Stop();
            if (!menu) closegame = true;
        }

        public void RisProgresBar()
        {
            Graphics g = Graphics.FromImage(bmpbar);
            g.FillRectangle(new SolidBrush(Color.Blue), 0, 41, 958 - (int)(958*cctime.TotalMilliseconds/lvltime.TotalMilliseconds), 10);
            PicBar.Image = bmpbar;
        }
        public void click(int x, int y)
        {
            bool drawf = false;
            if (type != 0)
            {
                olvl.clickcount++;
                lvli.clickcount++;
            }
            int n = cs.Count();
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (cs[i].isin(x, y))
                {
                    if (olvl != null)
                    {
                        try
                        {
                            circles.RemoveAt(cs[i].i);
                        }
                        catch
                        {

                        }
                    }
                    kolc++;
                    RisRis();
                    kc++;
                    gtime = 0;
                    bmp = new Bitmap(MainPic.Width, MainPic.Height);
                    int res = cs[i].GetRes();
                    if (res == 1)
                    {
                        if (cs[i].skin == 1)
                        {
                            kcc++;
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }

                        else if (cs[i].skin == 2)
                        {
                            kcc++;
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else if (cs[i].skin == 3)
                        {
                            kcc++;
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else if (shield)
                        {
                            shield = false;
                            shieldpb.Visible = false;
                            kcc++;
                            WarList.Add(new warning(cs[i].x, cs[i].y, 5));
                            /*a[6].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[6]);
                            MainOut.Play();*/
                        }
                        else
                        {
                            /*a[5].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[5]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 2));
                            combo = 1;
                            s += cs[i].GetRes() * combo;
                        }
                    }
                    else if (res == 3)
                    {
                        if (cs[i].skin == 1)
                        {
                            kcc++;
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else if (cs[i].skin == 2)
                        {
                            kcc++;
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else if (cs[i].skin == 3)
                        {
                            kcc++;
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else
                        {
                            /*a[8].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[8]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 3));
                            s += cs[i].GetRes() * combo;
                        }
                    }
                    else
                    {
                        if (cs[i].skin == 1)
                        {
                            if (type == 0)
                            {
                                coins += 100;
                                CoinLabel.Text = coins.ToString();
                                WarList.Add(new warning(cs[i].x, cs[i].y, 6));
                                /*a[1].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                                MainOut.Init(a[1]);
                                MainOut.Play();*/
                            }
                            else
                            if (!lvli.coinclick[cs[i].maini])
                            {
                                
                                lvli.coinclickcout++;
                                lvli.coinclick[cs[i].maini] = true;
                                coins += 100;
                                CoinLabel.Text = coins.ToString();
                                WarList.Add(new warning(cs[i].x, cs[i].y, 6));
                                /*a[1].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                                MainOut.Init(a[1]);
                                MainOut.Play();*/
                            }
                            kcc++;
                        }
                        else if (cs[i].skin == 2)
                        {
                            if (hp != 3) hp++;
                            SetHP();
                            kcc++;
                            WarList.Add(new warning(cs[i].x, cs[i].y, 4));
                            /*a[3].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[3]);
                            MainOut.Play();*/
                        }
                        else if (cs[i].skin == 3)
                        {
                            shield = true;
                            shieldpb.Visible = true;
                            kcc++;
                            WarList.Add(new warning(cs[i].x, cs[i].y, 5));
                            /*a[7].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[7]);
                            MainOut.Play();*/
                        }
                        else
                        {
                            if (type == 0)
                            {
                                coins++;
                                CoinLabel.Text = coins.ToString();
                            }
                            else
                            if (!lvli.coinclick[cs[i].maini])
                            {
                                lvli.coinclick[cs[i].maini] = true;
                                coins++;
                                CoinLabel.Text = coins.ToString();
                            }
                           /* a[2].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[2]);
                            MainOut.Play();*/
                            kcc++;
                            s += cs[i].GetRes() * combo;
                            combo++;
                        }
                    }
                    combolabel.Text = $"{combo}x ({((float)kcc / kc * 100):F1}%)";
                    schet.Text = s.ToString();
                    l.Add(i);
                    if (olvl != null)
                        if (kolc == koln)
                        {
                            end(i, 3);
                            return;
                        }
                    drawf = true;
                    break;
                }
            }
            for (int i = 0; i < l.Count; i++)
                cs.RemoveAt(l[i]);
            if (drawf) DrawFCircle();
        }
        public void cstimer_Tick(object sender, EventArgs e)
        {
            time -= 1;
            gtime = 0;
            gtimer.Start();
            cslabel.Text = time.ToString("F0");
            if (time == 0)
            {
                cstimer.Stop();
                VisLab(true);
                cslabel.Visible = false;
                time = 15;
                gtimer.Stop();
                Start();
            }
        }

        public void gtimer_Tick(object sender, EventArgs e)
        {
            gtime += 0.016;
            if (gtime >= 1) gtime = 0.99;
            cslabel.Font = new Font("Arial", (int)(350 - (350 * gtime)), FontStyle.Italic);
            cslabel.Location = new Point((int)(200 + 300 * gtime), (int)(9 + 270 * gtime));
            cslabel.ForeColor = Color.FromArgb(255, (int)(255 * gtime), (int)(255 * gtime), (int)(255 * gtime));
        }

        private void fps_Tick(object sender, EventArgs e)
        {
            bool drawf = false;
            RisProgresBar();
            //schet.Text = audio.CurrentTime.ToString();
            if (olvl != null)
            {
                if (lltime != audio.CurrentTime)
                {
                    lltime = audio.CurrentTime;
                    cctime = audio.CurrentTime;
                }
                else
                    cctime += new TimeSpan(0, 0, 0, 0, 10);
                ltime = (int)(cctime.TotalMilliseconds / 10);
                cs = new List<osucircle>();
                for (int i = 0; i < circles.Count; i++)
                {
                    if (ltime > circles[i].vrem)
                    {
                        cs.Add((osucircle)circles[i].Clone());
                        cs[cs.Count-1].SetSc(ltime);
                        
                        cs[cs.Count - 1].i = i;
                    }
                }
                DrawFCircle();
                    /*if (ltime == circles[i].vrem)
                    {
                        if (i == circles.Length - 1)
                            circles[i].clic = true;
                        cs.Add(circles[i]);
                    }*/
            }
            List<int> l = new List<int>();
            if (prikol)
            {
                for (int i = 0; i < WarList.Count; i++)
                    if (WarList[i].obnov())
                        l.Add(i);
                for (int i = 0; i < l.Count; i++)
                    WarList.RemoveAt(l[i]);
                prikol = false;
            }
            else prikol = true;
            gtime += 0.01;
            ctime += 1;
            if (ctime == chastota)
            {
                ctime = 0;
                NewCircle();
            }
            int n = cs.Count;
            l = new List<int>();
            for (int i = 0; i < n; i++)
            {
                cs[i].obnov();
                if (cs[i].sc <= 0)
                {
                    kolc++;
                    if (cs[i].skin != 0 || shield)
                    {
                        kcc++;
                        if (cs[i].skin == 2)
                        {
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else if (cs[i].skin == 3)
                        {
                            /*a[0].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[0]);
                            MainOut.Play();*/
                            WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                        }
                        else if (shield)
                        {
                            shield = false;
                            shieldpb.Visible = false;
                            WarList.Add(new warning(cs[i].x, cs[i].y, 5));
                            /*a[6].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                            MainOut.Init(a[6]);
                            MainOut.Play();*/
                        }
                        if (type != 0) circles.RemoveAt(cs[i].i);
                        l.Add(i);
                        kc++;
                        if (type != 0)
                            if (kolc == koln)
                            {
                                end(i, 3);
                                return;
                            }
                        break;
                    }
                    /*a[4].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                    MainOut.Init(a[4]);
                    MainOut.Play();*/
                    WarList.Add(new warning(cs[i].x, cs[i].y, 1));
                    combo = 1; kc++;
                    combolabel.Text = $"{combo}x ({((float)kcc / kc * 100):F1}%)";
                    hp--;
                    //Bitmap b = new Bitmap("razb.jpg");
                    if (hp == 2) heart3.Image = Properties.Resources.razb;
                    else if (hp == 1) heart2.Image = Properties.Resources.razb;
                    else heart1.Image = Properties.Resources.razb;
                    if (hp == 0) 
                    {
                        if (type == 0) end(i, 0);
                        else end(i, 2);
                        return;
                    }
                    if (type != 0)
                        if (kolc == koln)
                        {
                            end(i, 3);
                            return;
                        }
                    if (type != 0) circles.RemoveAt(cs[i].i);
                    l.Add(i);
                    drawf = true;
                    break;
                }
            }
            for (int i = l.Count - 1; i >= 0; i--)
                cs.RemoveAt(l[i]);
            if (gtime>0.5) RisRis();
            if (drawf) DrawFCircle();
            DrawCircle();
        }
        public void end(int i, byte t)
        {
            if (type != 2 && type != 3)
            {
                if (t == 3)
                {
                    ac.coins += coins;
                    ac.coinscount += coins;
                }
            }
            int j = 0;
            bool fl = false;
            if (type != 0)
            {
                for (j = 0; j < ac.lvls.Count; j++)
                    if (ac.lvls[j].name == lvli.name)
                    {
                        if (type != 1 || t != 3)
                        {
                            past.clickcount = lvli.clickcount;
                            ac.lvls[j] = past;
                        }
                        fl = true;
                        break;
                    }
                if (!fl)
                {
                    j = ac.lvls.Count();
                    if (type != 1 && t != 3)
                    {
                        past.clickcount = lvli.clickcount;
                        ac.lvls[j] = past;
                    }
                }
            }
            if (type != 0)
            {
                for (j = 0; j < ac.lvls.Count; j++)
                    if (ac.lvls[j].name == lvli.name)
                    {
                        if (type == 1 && t == 3) ac.lvls[j] = (lvlinfo)lvli.Clone();
                        fl = true;
                        break;
                    }
                if (!fl)
                {
                    j = ac.lvls.Count();
                    if (type == 1 && t == 3) ac.lvls.Add(lvli);
                    else
                        ac.lvls.Add(new lvlinfo(olvl.name, olvl.circles.Count));
                }
                if (t == 3 && type == 1) ac.lvls[j].complete = true;
            }
            cs.RemoveAt(i);
            DrawFCircle();
            DrawCircle();
            fps.Stop();
            if ((type == 1 || type == 3) && newskin)
            {
                if (!ac.skins[ac.skini].have && t == 3)
                {
                    ac.skins[ac.skini].have = true;
                    NewSkin f1 = new NewSkin(ac.skini);
                    ac.skini = pastskin;
                    f1.ShowDialog();
                }
                else
                {
                    ac.skini = pastskin;
                }
            }
            else if (type == 2 && newskin)
            {
                ac.skini = pastskin;
            }
            ResultForm f;
            if (t == 0)
            {
                if (s > ac.osurecord) ac.osurecord = s;
                ac.SaveAccount();
                ac.coins += coins;
                ac.coinscount += coins;
                result res = new result(s);
                res.coins = coins;
                f = new ResultForm(res, 0);
            }
            else if (hp != 0)
            {
                result res = new result(s, (double)kcc / kc * 100, olvl.name);
                if (t == 3) res.coins = coins;
                f = new ResultForm(res, t);
                if (type == 1)
                {
                    if (res.sch > ac.lvls[j].recordsct)
                    {
                        if (ac.rating < olvl.rating) ac.rating = olvl.rating;
                        ac.lvls[j].recordsct = res.sch;
                        ac.lvls[j].recordmark = res.GetMark();
                        olvl.SaveJson();
                    }
                }
                if (type == 2)
                {
                    if (res.sch > ac.lvls[j].practicerecord)
                    {
                        ac.lvls[j].practicerecord = res.sch;
                        ac.lvls[j].practicemark = res.GetMark();
                        olvl.SaveJson();
                    }
                }
            }
            else f = new ResultForm(new result(0, 0, olvl.name), 2);
            ac.SetAccount();
            ac.SaveJson();
            f.ShowDialog();
            if (f.menu || f.closegame)
            {
                closegame = f.closegame;
                menu = f.menu;
                f.Close();
                this.Close();
                return;
            }
            MusicOut.Stop();
            VisLab(false);
            CoolStart();
        }
    }
}