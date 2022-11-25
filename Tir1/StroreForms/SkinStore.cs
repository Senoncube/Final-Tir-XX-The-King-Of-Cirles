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
    public partial class SkinStore : KryptonForm
    {
        account ac;
        List<skin> skins;
        List<int> prices;
        int i = 0, timeri, naprav;
        public bool closegame = false;
        bool back = false;
        public SkinStore()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            ac = new account();
            InitializeComponent();
            skins = new List<skin>();
            skins.Add(new skin("steve", "Скін Стів з Майнкрафта", "skins/steve.png", "Стандартний скін", true));
            skins.Add(new skin("yes", "Скін Да.", "skins/yes.png", "Стандартний скін", false));
            skins.Add(new skin("roxy", "Скін Роксі Мігурдія", "skins/roxy.png", "Стандартний скін", false));
            skins.Add(new skin("van", "Скін Ван Даркхолм", "skins/van.png", "Стандартний скін", false));
            skins.Add(new skin("pudge", "Скін Падге", "skins/pudge.png", "Рідкісний скін", false));
            skins.Add(new skin("ricardo", "Скін Рікардо Мілос", "skins/ricardo.png", "Рідкісний скін", false));
            skins.Add(new skin("spidwagon", "Скін Роберт Едвард О. Спідвагон", "skins/spidwagon.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("extreme", "Скін екстрім демон", "skins/extreme.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("gachi1", "Скін гачімучі", "skins/gachi1.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("hayasaka2", "Скін Ай Хаясака 2", "skins/hayasaka2.png", "Епічний скін", false));
            skins.Add(new skin("extreme2", "Скін екстрім демон 2", "skins/extreme2.png", "Епічний скін", false));
            skins.Add(new skin("hayasaka6", "Скін Ай Хаясака 6", "skins/hayasaka6.png", "Міфічний скін", false));
            skins.Add(new skin("kaguya4", "Скін Шиномія Кагуя 4", "skins/kaguya4.png", "Міфічний скін", false));
            skins.Add(new skin("negr2", "Скін Шиномія Кагуя 2", "skins/negr2.png", "Легендарний скін", false));
            prices = new List<int> { 100, 100, 100, 100, 500, 500, 1000, 1000, 1000, 2500, 2500, 5000, 5000, 10000};
            i = 0;
            proverka();
            SetSkin();
            CoinLabel.Text = ac.coins.ToString();
        }
        public void proverka()
        {
            List<int> l = new List<int>();
            for (int j = 0; j < skins.Count; j++)
                if (ac.skins[ac.SkinId(skins[j])].have)
                    l.Add(j);
            for (int j = l.Count - 1; j >= 0; j--)
            {
                skins.RemoveAt(l[j]);
                prices.RemoveAt(l[j]);
            }
            if (i >= skins.Count) i = 0;
        }
        public void SetSkin()
        {
            
            countlabel.Text = (i + 1).ToString() + "/" + skins.Count.ToString();
            if (skins.Count == 0)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                skinpic.Visible = false;
                pricelabel.Visible = false;
                coinpb.Visible = false;
                countlabel.Visible = false;
                label1.Visible = true;
                return;
            }
            if (prices[i] > ac.coins)
                buton.GetBut(kryptonButton3, 1, 20);
            else
                buton.GetBut(kryptonButton3, 0, 20);
            gb1.Values.Heading = skins[i].name;
            skinpic.Image = new Bitmap(skinpic.Width, skinpic.Height);
            skinpic.Image = Image.FromFile(skins[i].path);
            if (skins[i].GetRarityColor() != Color.White)
                skinpic.BackColor = skins[i].GetRarityColor();
            pricelabel.Text = prices[i].ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (skins.Count == 0) return;
            if (prices[i] > ac.coins)
            {
                MessageBox.Show("Недостаньо монет!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            ac.coins -= prices[i];
            ac.skins[ac.SkinId(skins[i])].have = true;
            CoinLabel.Text = ac.coins.ToString();
            ac.SaveAccount();
            NewSkin f = new NewSkin(ac.SkinId(skins[i]));
            f.ShowDialog();
            proverka();
            SetSkin();
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            if (skins.Count == 0) return;
            i++;
            if (i == skins.Count) i = 0;
            if (timer1.Enabled)
            {
                while (timeri != 25)
                    timer1_Tick(sender, e);
            }
            skinpic2.Image = (Image)skinpic.Image.Clone();
            skinpic2.BackColor = skinpic.BackColor;
            pricelabel2.Text = pricelabel.Text;
            panel2.Location = panel1.Location;
            gb2.Values.Heading = gb1.Values.Heading;
            panel1.Location = new Point(872, panel2.Location.Y);
            SetSkin();
            timeri = 0;
            naprav = -1;
            timer1.Start();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (skins.Count == 0) return;
            i--;
            if (i == -1) i = skins.Count - 1;
            if (timer1.Enabled)
            {
                while (timeri != 25)
                    timer1_Tick(sender, e);
            }
            skinpic2.Image = (Image)skinpic.Image.Clone();
            skinpic2.BackColor = skinpic.BackColor;
            pricelabel2.Text = pricelabel.Text;
            panel2.Location = panel1.Location;
            panel1.Location = new Point(-328, panel2.Location.Y);
            SetSkin();
            timeri = 0;
            naprav = 1;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void SkinStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point((int)(panel1.Location.X + 600 * (1 / 25.0) * naprav), panel1.Location.Y);
            panel2.Location = new Point((int)(panel2.Location.X + 600 * (1 / 25.0) * naprav), panel2.Location.Y);
            timeri++;
            if (timeri == 25) timer1.Stop();
        }
    }
}
