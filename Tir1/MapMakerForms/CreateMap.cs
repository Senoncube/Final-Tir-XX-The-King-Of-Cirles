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
    public partial class CreateMap : KryptonForm
    {
        account ac;
        public bool closegame = false;
        public bool menu = false;
        bool back = false, opendod = false;
        string song;
        int hp = 3;
        bool fl = false;
        osulvl lvl;
        public CreateMap()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            InitializeComponent();
            ac = new account();
            if (ac.nick == "admin")
            {
                label3.Visible = false;
                label10.Visible = true;
                skinTB.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fl)
            {
                MessageBox.Show("Заповніть усі поля правильно!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NameTB.Text == "Введіть назву" || NameTB.Text == "" || song == null)
            {
                MessageBox.Show("Заповніть усі поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*label1.Visible = false; label2.Visible = false;
            label3.Visible = false; label4.Visible = false;
            label5.Visible = false; label6.Visible = false;
            label7.Visible = false; label8.Visible = false;
            NameTB.Visible = false; MusicTB.Visible = false;
            rTB.Visible = false; speedTB.Visible = false;
            scTB.Visible = false; res1TB.Visible = false;
            res2TB.Visible = false; button1.Visible = false;*/
            lvlinfo mylvl = new lvlinfo(NameTB.Text, 0);
            ac.mylvls.Add(mylvl);
            ac.SaveAccount();
            lvl = new osulvl(NameTB.Text);
            lvl.SongName = "music/" + song;
            lvl.r = int.Parse(rTB.Text);
            lvl.speed = double.Parse(speedTB.Text);
            lvl.sc = double.Parse(scTB.Text);
            lvl.res1 = double.Parse(res1TB.Text);
            lvl.res2 = double.Parse(res2TB.Text);
            lvl.autor = ac.nick;
            lvl.hp = hp;
            if (ac.nick == "admin")
                lvl.rewardskin = (skin)ac.skins[ac.SkinId(new skin(skinTB.Text, "", "", "", false))].Clone();
            lvl.SaveJson();
            MapMaker f = new MapMaker(lvl);
            this.Hide();
            f.ShowDialog();
            if (f.closegame || f.menu || f.back)
            {
                closegame = f.closegame;
                menu = f.menu;
                back = f.back;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetMusic f = new SetMusic();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                closegame = true;
                this.Close();
            }
            if (f.songname != null)
            {
                song = f.songname;
                markPB.Image = Properties.Resources.green_check_icon_png_13;
            }
            f.Close();
            this.Show();
            
        }

        private void CreateMap_FormClosed(object sender, FormClosedEventArgs e)
        {
           if (!menu && !back) closegame = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void heart1_Click(object sender, EventArgs e)
        {
            heart2.BackgroundImage = Properties.Resources.blackheart;
            heart3.BackgroundImage = Properties.Resources.blackheart;
            hp = 1;
        }

        private void heart2_Click(object sender, EventArgs e)
        {
            heart2.BackgroundImage = Properties.Resources.heart;
            heart3.BackgroundImage = Properties.Resources.blackheart;
            hp = 2;
        }

        private void heart3_Click(object sender, EventArgs e)
        {
            heart2.BackgroundImage = Properties.Resources.heart;
            heart3.BackgroundImage = Properties.Resources.heart;
            hp = 3;
        }

        private void NameTB_Enter(object sender, EventArgs e)
        {
            NameTB.StateCommon.Content.Color1 = Color.Black;
            if (NameTB.Text == "Введіть назву")
                NameTB.Text = "";
        }

        private void NameTB_Leave(object sender, EventArgs e)
        {
            if (NameTB.Text == "")
            {
                NameTB.StateCommon.Content.Color1 = Color.Gray;
                NameTB.Text = "Введіть назву";
            }
        }

        private void res1TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double i;
                i = double.Parse(res1TB.Text);
                i = double.Parse(res2TB.Text);
                i = double.Parse(scTB.Text);
                i = int.Parse(rTB.Text);
                i = double.Parse(speedTB.Text);
                fl = false;
                ErrorLabel.Visible = false;
            }
            catch
            {
                fl = true;
                ErrorLabel.Visible = true;
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (!opendod)
            {
                this.MaximumSize = new Size(774, 374);
                this.Size = new Size(774, 374);
                this.MinimumSize = new Size(774, 374);
                this.CenterToParent();
                opendod = true;
            }
            else
            {
                this.Size = new Size(387, 374);
                this.MaximumSize = new Size(387, 374);
                this.MinimumSize = new Size(387, 374);
                this.CenterToParent();
                opendod = false;
            }

        }
    }
}
