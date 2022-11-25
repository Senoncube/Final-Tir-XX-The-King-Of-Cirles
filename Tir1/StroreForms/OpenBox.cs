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
using NAudio.Wave;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class OpenBox : KryptonForm
    {
        box b;
        double speed = 1, speedconst1 = 0.08, speedconst2 = 0.993;
        int soundconst = 1500;
        AudioFileReader audio;
        skin main;
        public OpenBox(box b)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            this.b = b;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenBox_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(skinpic.Width, skinpic.Height);
            Graphics g = Graphics.FromImage(bmp);
            main = b.OpenBox();
            if (main.GetRarityInt() == 5) soundconst = 2000;
            for (int i = 0; i < 37; i++)
            {
                skin s;
                if (i == 34) 
                    s = main;
                else 
                    s = b.OpenBox();
                g.FillRectangle(new SolidBrush(s.GetRarityColor()), i * 200, 0, 200, 200);
                g.DrawImage(Image.FromFile(s.path), i * 200, 0, 200, 200);
                g.DrawRectangle(new Pen(Color.Black,5), i * 200, 0, 200, 200);
            }
            skinpic.Image = bmp;
           
            if (main.GetRarityInt() == 5)
                audio = new AudioFileReader("sounds/csgoknifesound.mp3");
            else
                audio = new AudioFileReader("sounds/csgoopencase.mp3");
            settings sett = new settings();
            audio.Volume = (float)sett.musicvolume;
            WaveOut MainOut = new WaveOut();
            
            WaveStream ws = audio;
            MainOut.Init(ws);
            MainOut.Play();
            maintimer.Start();
        }

        private void maintimer_Tick(object sender, EventArgs e)
        {
            if (audio.CurrentTime < new TimeSpan(0, 0, 0, 0, soundconst)) return;
            if (speed < speedconst1)
            {
                if (audio.CurrentTime >= audio.TotalTime - new TimeSpan(0, 0, 0, 0, 100))
                {
                    account ac = new account();
                    int i1 = ac.SkinId(main);
                    if (i1 == -1)
                    {
                        MessageBox.Show(main.name);
                        return;
                    }
                    else
                    {
                        if (!ac.skins[i1].have)
                        {
                            ac.skins[i1].have = true;
                            ac.SaveAccount();
                            NewSkin f = new NewSkin(i1);
                            f.ShowDialog();
                            this.Close();
                        }
                    }
                    button1.Visible = true;
                    maintimer.Stop();
                }
                return;
            }
            skinpic.Location = new Point((int)(skinpic.Location.X - 50 * speed), 106);
            speed *= speedconst2;
        }
    }
}
