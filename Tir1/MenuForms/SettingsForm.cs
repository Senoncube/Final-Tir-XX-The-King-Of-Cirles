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
    public partial class SettingsForm : KryptonForm
    {
        public bool closegame = false;
        bool back = false, isin1 = false, isin2 = false;
        int past1, past2;
        settings sett;
        public SettingsForm()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            sett = new settings();
            trackBar1.Value = (int)(sett.musicvolume * 1000);
            trackBar2.Value = (int)(sett.soundvolume * 1000);
            past1 = trackBar1.Value;
            past2 = trackBar2.Value;
            textBox1.Text = sett.click1.ToString();
            textBox2.Text = sett.click2.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sett.musicvolume = trackBar1.Value / 1000.0;
            sett.SaveJson();
            if (trackBar1.Value == 0)
                pictureBox1.Image = Properties.Resources.nomusic;
            else
            if (past1 == 0)
                pictureBox1.Image = Properties.Resources.Itunes_music_app_icon;
            past1 = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            sett.soundvolume = trackBar2.Value / 1000.0;
            sett.SaveJson();
            if (trackBar2.Value == 0)
                pictureBox2.Image = Properties.Resources.no_sound;
            else
            if (past2 == 0)
                pictureBox2.Image = Properties.Resources.sound_PNG30;
            past2 = trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            isin2 = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            isin1 = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                trackBar1.Value = 1000;
                sett.musicvolume = 1;
                pictureBox1.Image = Properties.Resources.Itunes_music_app_icon;
            }
            else
            {
                trackBar1.Value = 0;
                sett.musicvolume = 0;
                pictureBox1.Image = Properties.Resources.nomusic;
            }
            sett.SaveJson();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (trackBar2.Value == 0)
            {
                trackBar2.Value = 1000;
                sett.soundvolume = 1;
                pictureBox2.Image = Properties.Resources.sound_PNG30;
            }
            else
            {
                trackBar2.Value = 0;
                sett.soundvolume = 0;
                pictureBox2.Image = Properties.Resources.no_sound;
            }
            sett.SaveJson();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isin1) 
            {
                textBox1.Text = e.KeyCode.ToString();
                sett.click1 = e.KeyCode;
                sett.SaveJson();
            }
            if (isin2) 
            {
                textBox2.Text = e.KeyCode.ToString();
                sett.click2 = e.KeyCode;
                sett.SaveJson();
            }
        }


        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            isin2 = false;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            isin1 = true;
        }
    }
}
