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
    public partial class MySkins : KryptonForm
    {
        Button[] buttons;
        account ac;
        public bool closegame = false;
        bool back = false;
        int pastbut;
        int bmaxcount, pastbutpos = -1;
        int pos = 0, bh = 4, bw = 4;
        public MySkins()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
        }

        private void MySkins_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void MySkins_Load(object sender, EventArgs e)
        {
            buttons = new Button[bh * bw];
            for (int i = 0; i < bh * bw; i++)
            {
                buttons[i] = new Button();
                buttons[i].Location = new Point(150 + 121 * (i % bw), 12 + 121 * (i / bw + 1));
                buttons[i].Size = new Size(100, 100);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 1;
                buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
                buttons[i].Click += SkinClick;
                this.Controls.Add(buttons[i]);
            }
            bmaxcount = (this.Size.Width - 12) / 121;
            ac = new account();
            SortBox.SelectedIndex = 0;
            SetButtons();
        }
        public void SortSkinsByRarity()
        {
            for (int i = 0; i < ac.skins.Count; i++)
                for (int j = i + 1; j < ac.skins.Count; j++)
                    if (ac.skins[i].GetRarityInt() > ac.skins[j].GetRarityInt())
                    {
                        if (ac.skini == i)
                            ac.skini = j;
                        else if (ac.skini == j)
                            ac.skini = i;
                        skin s = (skin)ac.skins[i].Clone();
                        ac.skins[i] = (skin)ac.skins[j].Clone();
                        ac.skins[j] = (skin)s.Clone();
                    }
        }
        public void SortSkinsByHave()
        {
            List<skin> news = new List<skin>();
            int j = -1;
            for (int i = 0; i < ac.skins.Count; i++)
                if (ac.skins[i].have)
                {
                    if (ac.skini == i) ac.skini = news.Count;
                    news.Add((skin)ac.skins[i].Clone());
                }
            for (int i = 0; i < ac.skins.Count; i++)
                if (!ac.skins[i].have)
                {
                    if (ac.skini == i) ac.skini = news.Count;
                    news.Add((skin)ac.skins[i].Clone());
                }
            ac.skins = news;
        }
        public int RaritySrav(skin s1, skin s2)
        {
            if (s1.GetRarityInt() > s2.GetRarityInt()) return 1;
            else if (s1.GetRarityInt() < s2.GetRarityInt()) return -1;
            else return 0;
        }
        public void SetButtons()
        {
            label1.Text = (pos + 1).ToString() + "/" + (ac.skins.Count / (bw * bh) + 1).ToString();
            if (ac.skins == null || buttons == null)
                return;
            bmaxcount = bw;
            int n;
            if (ac.skins.Count - bh * bw * pos > 16) n = bh * bw;
            else
                n = ac.skins.Count - bh * bw * pos;
            for (int i = 0; i < n; i++)
            {
                int j = bh * bw * pos + i;
                buttons[i].Visible = true;
                buttons[i].Name = (j).ToString();
                buttons[i].BackgroundImage = Image.FromFile(ac.skins[j].path);
                
                if (!ac.skins[j].have)
                    buttons[i].BackColor = Color.Gray;
                else
                    if (ac.skins[j].GetRarityColor() != Color.White)
                        buttons[i].BackColor = ac.skins[j].GetRarityColor();
                if (j == ac.skini)
                {
                    pastbut = j;
                    buttons[i].FlatAppearance.BorderSize = 5;
                    buttons[i].FlatAppearance.BorderColor = Color.DarkRed;
                    pastbutpos = pos;
                }
                else
                {
                    buttons[i].FlatAppearance.BorderSize = 1;
                    buttons[i].FlatAppearance.BorderColor = Color.Black;
                }
            }
            for (int i = 0; i < bw * bh - n; i++)
                buttons[i + n].Visible = false;
        }
        private void SkinClick(object sender, EventArgs e)
        {
            var but = (Button)sender;
            int i = int.Parse(but.Name);
            if (!ac.skins[i].have)
            {
                MessageBox.Show(ac.skins[i].description,"Заблоковано!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            ac.skini = i;
            ac.SetAccount();
            ac.SaveJson();
            if (pastbutpos == pos)
            {
                buttons[pastbut % 16].FlatAppearance.BorderSize = 1;
                buttons[pastbut % 16].FlatAppearance.BorderColor = Color.Black;
            }
            but.FlatAppearance.BorderSize = 5;
            but.FlatAppearance.BorderColor = Color.DarkRed;
            pastbut = i % (bw * bh);
            pastbutpos = pos;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (pos > 0) pos--;
            else
                pos = ac.skins.Count / (bw * bh);
            SetButtons();
        }

        private void SortBox_DropDownClosed(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (pos < ac.skins.Count / (bw * bh))
                pos++;
            else
                pos = 0;
            SetButtons();
        }

        private void MySkins_SizeChanged(object sender, EventArgs e)
        {

        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortBox.SelectedIndex == 0)
                SortSkinsByRarity();
            if (SortBox.SelectedIndex == 1)
            {
                SortSkinsByRarity();
                ac.skins.Reverse();
                int j = ac.skins.Count - 1;
                for (int i = 0; i < ac.skins.Count / 2; i++)
                {
                    if (i == ac.skini)
                    {
                        ac.skini = j;
                        break;
                    }
                    else if (j == ac.skini)
                    {
                        ac.skini = i;
                        break;
                    }
                    j--;
                }
            }
            if (SortBox.SelectedIndex == 2)
                SortSkinsByHave();
            SetButtons();
            ac.SaveAccount();
        }
    }
}
