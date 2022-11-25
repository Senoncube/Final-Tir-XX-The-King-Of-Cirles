using System.Text.Json;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class GameForm : KryptonForm
    {
        account ac;
        Random rand = new Random();
        digitcircle[] c;
        int r = 40;
        int s = 0;
        int lvl = 1;
        int i = 0;
        bool mig = true;
        double time = 15.0;
        double gtime = 0;
        Bitmap bmp;
        public bool closegame = false;
        public bool menu = false;
        int reccount;

        public GameForm(int lvl)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            InitializeComponent();
            this.lvl = lvl;

            ac = new account();
            CoolStart();
        }
        private void VisLab(bool fl)
        {
            label1.Visible = fl; label2.Visible = fl;
            schet.Visible = fl; timer.Visible = fl;
            MainPic.Visible = fl;
            button1.Visible = fl;
        }
        public void Start()
        {
            ac.testatt++;
            ac.SaveAccount();
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            mig = true;
            schet.Text = lvl.ToString();
            time = 5.0 + 0.5 * lvl;
            r = 80 - lvl * 2;
            if (r < 10) r = 20;
            i = 0;
            timer.Text = time.ToString();
            timer.ForeColor = Color.Black;
            timer1.Start();
            GenMap();
        }

        public void GenMap()
        {
            c = new digitcircle[lvl];
            for (int i = 0; i < lvl; i++)
            {
                reccount = 0;
                NewCircle(i);
                if (reccount > 1000)
                {
                    GenMap();
                    return;
                }
            }
            DrawMap();
        }

        public void DrawMap()
        {
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < lvl; i++)
                if (!c[i].clic) c[i].drawd(g);
            MainPic.Image = bmp;
        }
        public void NewCircle(int i)
        {
            reccount++;
            if (reccount > 1000) return;
            bool fl1 = true;
            int x = rand.Next(958 - 2 * r) + r;
            int y = rand.Next(529 - 2 * r) + r;
            digitcircle dc = new digitcircle(x, y, r, i+1);
            for (int j = 0; j < lvl; j++)
                if (j != i && c[j] != null)
                    if (dc.Peresechenie(c[j]))
                    {
                        NewCircle(i);
                        fl1 = false;
                    }
            if (fl1) c[i] = new digitcircle(x, y, r, i+1);
        }
        /*public void NewCircle()
        {
            Graphics g = Graphics.FromImage(bmp);
            if (r > 10) r -= 2;
            c = new digitcircle(r,i);
            i++;
            c.drawd(g);
            MainPic.Image = bmp;
        }*/
        private void CoolStart()
        {
            VisLab(false);
            cslabel.Visible = true;
            time = 3;
            cslabel.Text = time.ToString("F0");
            cstimer.Start();
            gtime = 0;
            gtimer.Start();
        }
        private void cstimer_Tick(object sender, EventArgs e)
        {
            time -= 1;
            gtime = 0;
            gtimer.Start();
            cslabel.Text = time.ToString("F0");
            if (time == 0)
            {
                VisLab(true);
                cstimer.Stop();
                cslabel.Visible = false;
                time = 15;
                gtimer.Stop();
                Start();
            }
        }

        private void gtimer_Tick(object sender, EventArgs e)
        {
            gtime += 0.016;
            if (gtime >= 1) gtime = 0.99;
            cslabel.Font = new Font("Arial", (int)(350 - (350 * gtime)), FontStyle.Italic);
            cslabel.Location = new Point((int)(200 + 300 * gtime), (int)(9 + 270 * gtime));
            cslabel.ForeColor = Color.FromArgb(255, (int)(255 * gtime), (int)(255 * gtime), (int)(255 * gtime));
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            time -= 0.1;
            if (time < 0)
            {
                timer1.Stop();
                ResultForm f = new ResultForm(new result(lvl),2);
                f.ShowDialog();
                if (f.menu)
                {
                    menu = true;
                    f.Close();
                    this.Close();
                    return;
                }
                //SetSettings();
                VisLab(false);
                CoolStart();
            }
            timer.Text = time.ToString("F1");
            if (time < 5)
            {
                if (mig)
                {
                    timer.ForeColor = Color.Red;
                    mig = false;
                }
                else
                {
                    timer.ForeColor = Color.Black;
                    mig = true;
                }
            }
        }

        private void MainPic_MouseClick_1(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            if (c[i].isin(x, y))
            {
                c[i].clic = true;
                i++;
                bmp = new Bitmap(MainPic.Width, MainPic.Height);
                DrawMap();
                if (i == lvl)
                {
                    timer1.Stop();
                    ResultForm f = new ResultForm(new result(lvl), 1);
                    if (lvl > ac.testrecord) ac.testrecord = lvl;
                    ac.SaveAccount();
                    f.ShowDialog();
                    if (f.menu)
                    {
                        menu = true;
                        f.Close();
                        this.Close();
                        return;
                    }
                    //SetSettings();
                    lvl++;
                    VisLab(false);
                    CoolStart();
                }
            }
        }
        public void Pause()
        {
            timer1.Stop();
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
            this.Show();
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !gtimer.Enabled)
                Pause();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menu) closegame = true;
        }
    }
}