using System.Text.Json;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class Form1 : KryptonForm
    {
        account ac;
        circle c;
        int r;
        int s;
        bool mig;
        double time;
        double gtime;
        public bool closegame = false;
        public bool menu = false;
        Bitmap bmp;
        public Form1()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
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
            ac.aimatt++;
            ac.SaveAccount();
            bmp = new Bitmap(MainPic.Width, MainPic.Height);
            r = 80;
            s = 0;
            mig = true;
            time = 15.0;
            timer.Text = time.ToString();
            timer.ForeColor = Color.Black;
            schet.Text = s.ToString();
            timer1.Start();
            NewCircle();
        }

        private void VisLab()
        {
            label1.Visible = false; label2.Visible = false;
            schet.Visible = false; timer.Visible = false;
            MainPic.Visible = false;
            button1.Visible = false;
        }
        public void CoolStart()
        {
            VisLab();
            cslabel.Visible = true;
            time = 3;
            cslabel.Text = time.ToString("F0");
            cstimer.Start();
            gtime = 0;
            gtimer.Start();
        }

        public void NewCircle()
        {
            Graphics g = Graphics.FromImage(bmp);
            if (r > 10) r -= 2;
            c = new circle(r);
            c.draw(g);
            MainPic.Image = bmp;
        }
        private void MainPic_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            if (c.isin(x, y))
            {
                bmp = new Bitmap(MainPic.Width, MainPic.Height);
                s++;
                schet.Text = s.ToString();
                NewCircle();
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            time -= 0.1;
            if (time < 0)
            {
                timer1.Stop();
                if (s > ac.aimrecord)
                {
                    ac.aimrecord = s;
                    ac.SaveAccount();
                }
                ResultForm f = new ResultForm(new result(s), 0);
                f.ShowDialog();
                if (f.menu)
                {
                    menu = true;
                    f.Close();
                    this.Close();
                    return;
                }
                VisLab();
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

        public void cstimer_Tick(object sender, EventArgs e)
        {
            time -= 1;
            gtime = 0;
            gtimer.Start();
            cslabel.Text = time.ToString("F0");
            if (time == 0)
            {
                cstimer.Stop();
                label1.Visible = true; label2.Visible = true;
                schet.Visible = true; timer.Visible = true;
                MainPic.Visible = true; button1.Visible = true;
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
            cslabel.Font = new Font("Arial", (int)(350 - (350*gtime)), FontStyle.Italic);
            cslabel.Location = new Point((int)(200 + 300 * gtime), (int)(9 + 270 * gtime));
            cslabel.ForeColor = Color.FromArgb(255, (int)(255 * gtime), (int)(255 * gtime), (int)(255 * gtime));
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !gtimer.Enabled)
                Pause();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menu) closegame = true;
        }
    }
}