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
    public partial class SetMusic : KryptonForm
    {
        settings sett;
        public bool closegame = false;
        public string songname;
        FileInfo[] files;
        WaveStream MainStream;
        WaveOut MainOut;
        KryptonButton[] playbuttons, setbuttons;
        KryptonTrackBar[] TrackBars;
        Label[] NameLabels, TimeLabels, CTimeLabels;
        WaveStream[] Streams;
        KryptonGroupBox[] gbs;
        bool isplay = false, back = false;
        string playsong;
        public SetMusic()
        {
            sett = new settings();
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            files = new DirectoryInfo("music/").GetFiles();
            MainOut = new WaveOut();
            Menu("");
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            MainOut.Pause();
            if (NameBox.Text != "🔍")
                Menu(NameBox.Text);
            else
                Menu("");
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < playbuttons.Length; i++)
                if (playbuttons[i].Name == playsong && isplay)
                {
                    if (Streams[i].CurrentTime >= Streams[i].TotalTime - new TimeSpan(0, 0, 0, 0, 100))
                    {
                        Streams[i].CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                        MainOut.Pause();
                        isplay = false;
                        playbuttons[i].BackgroundImage = Properties.Resources._375;
                    }
                    CTimeLabels[i].Text = Streams[i].CurrentTime.Minutes.ToString() + ":";
                    if (Streams[i].CurrentTime.Seconds < 10)
                        CTimeLabels[i].Text += "0";
                    CTimeLabels[i].Text += Streams[i].CurrentTime.Seconds.ToString();
                    TrackBars[i].Value = (int)(Streams[i].CurrentTime.TotalMilliseconds / Streams[i].TotalTime.TotalMilliseconds * 1000);
                }
        }

        private void SetMusic_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainOut.Stop();
            if (!back) closegame = true;
        }

        public void Menu(string p)
        {
            if (NameLabels != null)
                for (int i = 0; i < NameLabels.Length; i++)
                {
                    setbuttons[i].Dispose();
                    NameLabels[i].Dispose();
                    playbuttons[i].Dispose();
                    TrackBars[i].Dispose();
                    Streams[i].Dispose();
                    TimeLabels[i].Dispose();
                    CTimeLabels[i].Dispose();
                    gbs[i].Dispose();
                }
            List<FileInfo> fs = new List<FileInfo>();
            for (int i = 0; i < files.Length; i++)
            {
                bool err = false;
                try
                {
                    MainStream = new AudioFileReader(files[i].FullName);
                }
                catch
                {
                    err = true;
                }
                if (files[i].Name.Contains(p) && !err)
                    fs.Add(files[i]);
            }
            nLabel.Text = "Знайдено мелодій: " + fs.Count.ToString();
            if (fs.Count == 0) nLabel.Text = "Не знайдено жодної мелодії :(";

            playbuttons = new KryptonButton[fs.Count];
            setbuttons = new KryptonButton[fs.Count];
            TrackBars = new KryptonTrackBar[fs.Count];
            NameLabels = new Label[fs.Count];
            Streams = new WaveStream[fs.Count];
            TimeLabels = new Label[fs.Count];
            CTimeLabels = new Label[fs.Count];
            gbs = new KryptonGroupBox[fs.Count];
            for (int i = 0; i < fs.Count; i++)
            {
                AudioFileReader audio = new AudioFileReader(fs[i].FullName);
                audio.Volume = (float)sett.musicvolume;
                Streams[i] = audio;

                NameLabels[i] = new Label();
                if (fs[i].Name.Length > 20)
                    NameLabels[i].Text = "Назва: " + fs[i].Name.Substring(0,20) + "...";
                else
                    NameLabels[i].Text = "Назва: " + fs[i].Name;
                NameLabels[i].Name = fs[i].Name;
                NameLabels[i].Left = 12;
                NameLabels[i].Top = 150 * i + 25;
                NameLabels[i].AutoSize = true;
                NameLabels[i].Font = new Font("Arial", 15);
                NameLabels[i].BringToFront();
                MusicPanel.Controls.Add(NameLabels[i]);

                setbuttons[i] = new KryptonButton();
                setbuttons[i].Left = 400;
                setbuttons[i].Top = 150 * i + 21;
                setbuttons[i].Size = new Size(136, 45);
                setbuttons[i].Name = fs[i].Name;
                setbuttons[i].Text = "Обрати";
                setbuttons[i].Click += SetButtonOnClick;
                setbuttons[i].BringToFront();
                buton.GetBut(setbuttons[i], 0, 20);
                setbuttons[i].StateCommon.Content.ShortText.Font = new Font("Arial", 13, FontStyle.Bold);
                MusicPanel.Controls.Add(setbuttons[i]);

                playbuttons[i] = new KryptonButton();
                buton.GetBut(playbuttons[i], 0, 10);
                playbuttons[i].Left = 12;
                playbuttons[i].Top = 150 * i + 70;
                playbuttons[i].Size = new Size(50, 45);
                playbuttons[i].Name = fs[i].Name;
                playbuttons[i].StateCommon.Content.ShortText.Font = new Font("Arial", 15, FontStyle.Bold);
                playbuttons[i].StateCommon.Content.Padding = new Padding(4, 4, 0, 0);
                playbuttons[i].Text = "▶";
                playbuttons[i].Click += PlayButtonOnClick;
                playbuttons[i].BringToFront();
                MusicPanel.Controls.Add(playbuttons[i]);

                TrackBars[i] = new KryptonTrackBar();
                TrackBars[i].Left = 110;
                TrackBars[i].Top = 150 * i + 75;
                TrackBars[i].Size = new Size(366, 56);
                TrackBars[i].Name = fs[i].Name;
                TrackBars[i].Maximum = 1000;
                TrackBars[i].Scroll += BarsScroll;
                TrackBars[i].BringToFront();
                TrackBars[i].PaletteMode = PaletteMode.ProfessionalSystem;
                TrackBars[i].TickStyle = TickStyle.Both;
                TrackBars[i].StateCommon.Position.Color1 = Color.Black;
                TrackBars[i].StateCommon.Position.Color2 = Color.Black;
                TrackBars[i].StateCommon.Position.Color3 = Color.Black;
                TrackBars[i].StateCommon.Position.Color4 = Color.Black;
                TrackBars[i].StateCommon.Position.Color5 = Color.Black;
                TrackBars[i].StateCommon.Tick.Color1 = Color.FromArgb(250, 252, 252);
                TrackBars[i].StateCommon.Tick.Color2 = Color.FromArgb(250, 252, 252);
                TrackBars[i].StateCommon.Track.Color1 = Color.Black;
                TrackBars[i].StateCommon.Track.Color2 = Color.Black;
                TrackBars[i].StateCommon.Track.Color3 = Color.Black;
                MusicPanel.Controls.Add(TrackBars[i]);

                TimeLabels[i] = new Label();
                TimeLabels[i].Text = Streams[i].TotalTime.Minutes.ToString() + ":";
                if (Streams[i].TotalTime.Seconds < 10)
                    TimeLabels[i].Text += "0";
                TimeLabels[i].Text += Streams[i].TotalTime.Seconds.ToString();
                TimeLabels[i].Name = fs[i].Name;
                TimeLabels[i].Left = 475;
                TimeLabels[i].Top = 150 * i + 85;
                TimeLabels[i].AutoSize = true;
                TimeLabels[i].Font = new Font("Arial", 12);
                TimeLabels[i].BringToFront();
                MusicPanel.Controls.Add(TimeLabels[i]);

                CTimeLabels[i] = new Label();
                CTimeLabels[i].Text = "0:00";
                CTimeLabels[i].Name = fs[i].Name;
                CTimeLabels[i].Left = 62;
                CTimeLabels[i].Top = 150 * i + 85;
                CTimeLabels[i].TextAlign = ContentAlignment.MiddleRight;
                CTimeLabels[i].Size = new Size(50,20);
                CTimeLabels[i].Font = new Font("Arial", 12);
                CTimeLabels[i].BringToFront();
                MusicPanel.Controls.Add(CTimeLabels[i]);

                gbs[i] = new KryptonGroupBox();
                gbs[i].Location = new System.Drawing.Point(4, 150 * i);
                gbs[i].Name = "kryptonGroupBox1";
                gbs[i].Size = new System.Drawing.Size(550, 140);
                gbs[i].StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                gbs[i].StateCommon.Border.Color1 = System.Drawing.Color.Black;
                gbs[i].StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
                gbs[i].StateCommon.Border.Rounding = 20;
                gbs[i].StateCommon.Border.Width = 3;
                gbs[i].Values.Heading = "";
                gbs[i].TabIndex = 1000;
                gbs[i].SendToBack();
                MusicPanel.Controls.Add(gbs[i]);

            }
            if (fs.Count > 0)
               MusicPanel.Size = new Size(560, gbs[gbs.Length - 1].Location.Y + gbs[gbs.Length - 1].Size.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMusic f = new AddMusic();
            f.ShowDialog();
            f.Close();
            this.Show();
            files = new DirectoryInfo("music/").GetFiles();
            if (NameBox.Text != "🔍")
                Menu(NameBox.Text);
            else
                Menu("");
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameBox.StateCommon.Content.Color1 = Color.Black;
            if (NameBox.Text == "🔍")
                NameBox.Text = "";
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.StateCommon.Content.Color1 = Color.Gray;
                NameBox.Text = "🔍";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void BarsScroll(object sender, EventArgs eventArgs)
        {
            var but = (KryptonTrackBar)sender;
            for (int i = 0; i < playbuttons.Length; i++)
                if (playbuttons[i].Name == but.Name)
                {
                    TimeSpan t = new TimeSpan(0, 0,
                        (int)(Streams[i].TotalTime.TotalMilliseconds / 60000 * (TrackBars[i].Value / 1000.0)),
                        (int)(Streams[i].TotalTime.TotalMilliseconds / 1000 * (TrackBars[i].Value / 1000.0) % 60),
                        (int)(Streams[i].TotalTime.TotalMilliseconds * (TrackBars[i].Value / 1000.0) % 1000));
                    Streams[i].CurrentTime = t;
                    CTimeLabels[i].Text = Streams[i].CurrentTime.Minutes.ToString() + ":";
                    if (Streams[i].CurrentTime.Seconds < 10)
                        CTimeLabels[i].Text += "0";
                    CTimeLabels[i].Text += Streams[i].CurrentTime.Seconds.ToString();
                    TrackBars[i].Value = (int)(Streams[i].CurrentTime.TotalMilliseconds / Streams[i].TotalTime.TotalMilliseconds * 1000);
                }
                    
        }
        private void SetButtonOnClick(object sender, EventArgs eventArgs)
        {
            var but = (KryptonButton)sender;
            songname = but.Name;
            back = true;
            this.Close();
        }

        private void PlayButtonOnClick(object sender, EventArgs eventArgs)
        {
            var but = (KryptonButton)sender;
            if (!isplay)
            {
                for (int i = 0; i < playbuttons.Length; i++)
                    if (playbuttons[i].Name == but.Name)
                        MainOut.Init(Streams[i]);
                MainOut.Play();
                but.StateCommon.Content.Padding = new Padding(0, 0, 0, 0);
                but.Text = "⏸";
                isplay = true;
                playsong = but.Name;
            }
            else
            {
                if (but.Name == playsong)
                {
                    MainOut.Pause();
                    but.StateCommon.Content.Padding = new Padding(4, 4, 0, 0);
                    but.Text = "▶";
                    isplay = false;
                }
                else
                {
                    for (int i = 0; i < playbuttons.Length; i++)
                        if (playbuttons[i].Name == playsong)
                        {
                            MainOut.Pause();
                            for (int j = 0; j < playbuttons.Length; j++)
                                if (playbuttons[j].Name == but.Name)
                                    MainOut.Init(Streams[j]);
                            MainOut.Play();
                            playbuttons[i].StateCommon.Content.Padding = new Padding(4, 4, 0, 0);
                            playbuttons[i].Text = "▶";
                            but.StateCommon.Content.Padding = new Padding(0, 0, 0, 0);
                            but.Text = "⏸";
                            playsong = but.Name;
                        }
                    
                }
            }
        }
    }
}
