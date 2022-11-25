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
    
    public partial class BoxForm : KryptonForm
    {
        box[] boxs;
        account ac;
        bool back = false;
        public bool closegame = false;
        PictureBox[] pbs;
        Label[] lbls;
        Image[,] imgs;
        public BoxForm()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            boxs = new box[4];
            imgs = new Image[4, 50];
            boxs[1] = new box();
            boxs[1].skins = new List<skin> 
            {
                new skin("kaguya3", "Скін Шиномія Кагуя 3", "skins/kaguya3.png", "Легендарний скін", false),
                new skin("kaguya5", "Скін Шиномія Кагуя 5", "skins/kaguya5.png", "Міфічний скін", false),
                new skin("chika", "Скін Чіка Фудзівара", "skins/chika.png", "Міфічний скін", false),
                new skin("leon_ghoul2", "Скін Леон-Гуль 2", "skins/leon_ghoul2.png", "Епічний скін", false),
                new skin("hayasaka4", "Скін Ай Хаясака 4", "skins/hayasaka4.png", "Епічний скін", false),
                new skin("gigamouse", "Скін Гіга Мікі Маус", "skins/gigamouse.png", "Супер-рідкісний скін", false),
                new skin("pivo", "Скін Пивозавр", "skins/pivo.png", "Супер-рідкісний скін", false),
                new skin("amogusspike", "Скін Спайк-Амогус", "skins/amogusspike.png", "Супер-рідкісний скін", false),
                new skin("leon", "Скін Леона", "skins/leon.png", "Рідкісний скін", false),
                new skin("pudge", "Скін Падге", "skins/pudge.png", "Рідкісний скін", false),
                new skin("pon", "Скін пон", "skins/pon.png", "Стандартний скін", false),
                new skin("skala", "Скін Скала Дуейн Джонсон", "skins/skala.png", "Стандартний скін", false),
                new skin("negr", "Скін негр", "skins/negr.png", "Стандартний скін", false),
                new skin("ricardo", "Скін Рікардо Мілос", "skins/ricardo.png", "Рідкісний скін", false),
                new skin("billy", "Скін Біллі Херінгтон", "skins/billy.png", "Епічний скін", false)
            };
            boxs[1].rarity = new double[5] { 0.3, 0.10, 0.06, 0.03, 0.01 };
            boxs[2] = new box();
            boxs[2].skins = new List<skin>
            {
                new skin("hayasaka", "Скін Ай Хаясака", "skins/hayasaka.png", "Легендарний скін", false),
                new skin("leon", "Скін Леона", "skins/leon.png", "Рідкісний скін", false),
                new skin("leon2", "Скін Леон 2", "skins/leon2.png", "Міфічний скін", false),
                new skin("gachiprimo", "Скін Гачі-Прімо", "skins/gachiprimo.png", "Міфічний скін", false),
                new skin("nazik", "Скін Назік", "skins/nazik.png", "Епічний скін", false),
                new skin("kaguya2", "Скін Шиномія Кагуя 2", "skins/kaguya2.png", "Епічний скін", false),
                new skin("hayasaka3", "Скін Ай Хаясака 3", "skins/hayasaka3.png", "Супер-рідкісний скін", false),
                new skin("roxy2", "Скін Роксі Мігурдія 2", "skins/roxy2.png", "Супер-рідкісний скін", false),
                new skin("godusopp", "Скін Бог Усоп", "skins/godusopp.png", "Супер-рідкісний скін", false),
                new skin("trollface", "Скін троллфейс", "skins/trollface.png", "Рідкісний скін", false),
                new skin("hayasaka7", "Скін Ай Хаясака 7", "skins/hayasaka7.png", "Рідкісний скін", false),
                new skin("negr", "Скін негр", "skins/negr.png", "Стандартний скін", false),
                new skin("anonimus", "Скін анонімус", "skins/anonimus.png", "Стандартний скін", false),
                new skin("hayasaka10", "Скін Ай Хаясака 10", "skins/hayasaka10.png", "Стандартний скін", false),
                new skin("hayasaka4", "Скін Ай Хаясака 4", "skins/hayasaka4.png", "Епічний скін", false)
            };
            boxs[2].rarity = new double[5] { 0.3, 0.10, 0.06, 0.03, 0.01 };
            boxs[3] = new box();
            boxs[3].skins = new List<skin>
            {
                new skin("kaguyahayasaka", "Скін Шиномія Кагуя і Ай Хаясака", "skins/kaguyahayasaka.png", "Легендарний скін", false),
                new skin("kaguyachica", "Скін Шиномія Кагуя і Чіка Фудзівара", "skins/kaguyachica.png", "Міфічний скін", false),
                new skin("roxy5", "Скін Роксі Мігурдія 5", "skins/roxy5.png", "Міфічний скін", false),
                new skin("pikblind", "Скін Томас Шелбі і Чіка Фудзівара", "skins/pikblind.png", "Епічний скін", false),
                new skin("billy", "Скін Біллі Херінгтон", "skins/billy.png", "Епічний скін", false),
                new skin("hayasaka8", "Скін Ай Хаясака 8", "skins/hayasaka8.png", "Супер-рідкісний скін", false),
                new skin("miuki", "Скін Міюкі Широгане", "skins/miuki.png", "Супер-рідкісний скін", false),
                new skin("isigami", "Скін Ю Ісігамі", "skins/isigami.png", "Супер-рідкісний скін", false),
                new skin("ricardo", "Скін Рікардо Мілос", "skins/ricardo.png", "Рідкісний скін", false),
                new skin("negr3", "Скін негр 3", "skins/negr3.png", "Рідкісний скін", false),
                new skin("hayasaka10", "Скін Ай Хаясака 10", "skins/hayasaka10.png", "Стандартний скін", false),
                new skin("roxy", "Скін Роксі Мігурдія", "skins/roxy.png", "Стандартний скін", false),
                new skin("pon", "Скін пон", "skins/pon.png", "Стандартний скін", false),
                new skin("hayasaka7", "Скін Ай Хаясака 7", "skins/hayasaka7.png", "Рідкісний скін", false),
                new skin("kaguya2", "Скін Шиномія Кагуя 2", "skins/kaguya2.png", "Епічний скін", false)
            };
            boxs[3].rarity = new double[5] {0.3, 0.10, 0.06, 0.03, 0.01 };
            for (int i = 0; i < boxs[1].skins.Count; i++) imgs[1, i] = Image.FromFile(boxs[1].skins[i].path);
            for (int i = 0; i < boxs[2].skins.Count; i++) imgs[2, i] = Image.FromFile(boxs[2].skins[i].path);
            for (int i = 0; i < boxs[3].skins.Count; i++) imgs[3, i] = Image.FromFile(boxs[3].skins[i].path);
            ac = new account();
            InitializeComponent();
            SetVis(false);
            CoinLabel.Text = ac.coins.ToString();
            button2.FlatAppearance.CheckedBackColor = Color.LightGray; 
            button2.FlatAppearance.MouseDownBackColor = Color.LightGray;
            button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button3.FlatAppearance.CheckedBackColor = Color.LightGray; 
            button3.FlatAppearance.MouseDownBackColor = Color.LightGray;
            button3.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button4.FlatAppearance.CheckedBackColor = Color.LightGray; 
            button4.FlatAppearance.MouseDownBackColor = Color.LightGray;
            button4.FlatAppearance.MouseOverBackColor = Color.LightGray;
            csgoboxlabel.ForeColor = Color.Black;
            supermagiclabel.ForeColor = Color.Black;
            megaboxlabel.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void BoxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        public void SetVis(bool fl)
        {
            commonpb.Visible = fl;
            commonlbl.Visible = fl;
            rarepb.Visible = fl;
            rarelbl.Visible = fl;
            superrarepb.Visible = fl;
            superrarelbl.Visible = fl;
            epicpb.Visible = fl;
            epiclbl.Visible = fl;
            mythicpb.Visible = fl;
            mythiclbl.Visible = fl;
            legendarylbl.Visible = fl;
            legendarypb.Visible = fl;
        }
        public void SetDesc(int i1)
        {
            box b = boxs[i1];
            commonlbl.Text = "— " + ((1 - b.rarity[0] - b.rarity[1] - b.rarity[2] - b.rarity[3] - b.rarity[4]) * 100).ToString("F2") + "%";
            rarelbl.Text = "— " + (b.rarity[0] * 100).ToString("F2") + "%";
            superrarelbl.Text = "— " + (b.rarity[1] * 100).ToString("F2") + "%";
            epiclbl.Text = "— " + (b.rarity[2] * 100).ToString("F2") + "%";
            mythiclbl.Text = "— " + (b.rarity[3] * 100).ToString("F2") + "%";
            legendarylbl.Text = "— " + (b.rarity[4] * 100).ToString("F2") + "%";
            int[] j = new int[6] { 0, 0, 0, 0, 0, 0 };
            Graphics[] g = new Graphics[6];
            Bitmap[] bmp = new Bitmap[6] 
            { 
                new Bitmap(commonpb.Width, commonpb.Height),
                new Bitmap(rarepb.Width, rarepb.Height),
                new Bitmap(superrarepb.Width, superrarepb.Height),
                new Bitmap(epicpb.Width, epicpb.Height),
                new Bitmap(mythicpb.Width, mythicpb.Height),
                new Bitmap(legendarypb.Width, legendarypb.Height),
            };
            for (int i = 0; i < 6; i++) g[i] = Graphics.FromImage(bmp[i]);
            for (int i = 0; i < b.skins.Count; i++)
                if (b.skins[i].GetRarityInt() == 0)
                {
                    g[0].FillRectangle(new SolidBrush(b.skins[i].GetRarityColor()), commonpb.Width - (46 * (j[0] + 1)), 0, 40, 40);
                    g[0].DrawImage(imgs[i1, i], commonpb.Width - (46 * (j[0] + 1)), 0, 40, 40);
                    j[0]++;
                }
                else if (b.skins[i].GetRarityInt() == 1)
                {
                    g[1].FillRectangle(new SolidBrush(b.skins[i].GetRarityColor()), commonpb.Width - (46 * (j[1] + 1)), 0, 40, 40);
                    g[1].DrawImage(imgs[i1, i], commonpb.Width - (46 * (j[1] + 1)), 0, 40, 40);
                    j[1]++;
                }
                else if (b.skins[i].GetRarityInt() == 2)
                {
                    g[2].FillRectangle(new SolidBrush(b.skins[i].GetRarityColor()), commonpb.Width - (46 * (j[2] + 1)), 0, 40, 40);
                    g[2].DrawImage(imgs[i1, i], commonpb.Width - (46 * (j[2] + 1)), 0, 40, 40);
                    j[2]++;
                }
                else if (b.skins[i].GetRarityInt() == 3)
                {
                    g[3].FillRectangle(new SolidBrush(b.skins[i].GetRarityColor()), commonpb.Width - (46 * (j[3] + 1)), 0, 40, 40);
                    g[3].DrawImage(imgs[i1, i], commonpb.Width - (46 * (j[3] + 1)), 0, 40, 40);
                    j[3]++;
                }
                else if (b.skins[i].GetRarityInt() == 4)
                {
                    g[4].FillRectangle(new SolidBrush(b.skins[i].GetRarityColor()), commonpb.Width - (46 * (j[4] + 1)), 0, 40, 40);
                    g[4].DrawImage(imgs[i1, i], commonpb.Width - (46 * (j[4] + 1)), 0, 40, 40);
                    j[4]++;
                }
                else if (b.skins[i].GetRarityInt() == 5)
                {
                    g[5].FillRectangle(new SolidBrush(b.skins[i].GetRarityColor()), commonpb.Width - (46 * (j[5] + 1)), 0, 40, 40);
                    g[5].DrawImage(imgs[i1, i], commonpb.Width - (46 * (j[5] + 1)), 0, 40, 40);
                    j[5]++;
                }
            commonpb.Image = bmp[0];
            rarepb.Image = bmp[1];
            superrarepb.Image = bmp[2];
            epicpb.Image = bmp[3];
            mythicpb.Image = bmp[4];
            legendarypb.Image = bmp[5];
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            csgoboxcoin.BackColor = Color.LightGray;
            csgoboxlabel.BackColor = Color.LightGray;
            csgoboxpic.BackColor = Color.LightGray;
            SetDesc(1);
            SetVis(true);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            csgoboxcoin.BackColor = button2.BackColor;
            csgoboxlabel.BackColor = button2.BackColor;
            csgoboxpic.BackColor = button2.BackColor;
            SetVis(false);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            supermagiccoin.BackColor = Color.LightGray;
            supermagiclabel.BackColor = Color.LightGray;
            supermagicpic.BackColor = Color.LightGray;
            SetDesc(2);
            SetVis(true);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            supermagiccoin.BackColor = button3.BackColor;
            supermagiclabel.BackColor = button3.BackColor;
            supermagicpic.BackColor = button3.BackColor;
            SetVis(false);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            megaboxlabel.BackColor = Color.LightGray;
            megaboxpic.BackColor = Color.LightGray;
            megaboxcoin.BackColor = Color.LightGray;
            SetDesc(3);
            SetVis(true);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            megaboxcoin.BackColor = button4.BackColor;
            megaboxlabel.BackColor = button4.BackColor;
            megaboxpic.BackColor = button4.BackColor;
            SetVis(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ac.coins < 50)
            {
                MessageBox.Show("У вас не достатньо монет!","Помилка",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            ac.coins -= 50;
            ac.SaveAccount();
            CoinLabel.Text = ac.coins.ToString();
            OpenBox f = new OpenBox(boxs[1]);
            f.ShowDialog();
            ac = new account();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ac.coins < 50)
            {
                MessageBox.Show("У вас не достатньо монет!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            ac.coins -= 50;
            ac.SaveAccount();
            CoinLabel.Text = ac.coins.ToString();
            OpenBox f = new OpenBox(boxs[3]);
            f.ShowDialog();
            ac = new account();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ac.coins < 50)
            {
                MessageBox.Show("У вас не достатньо монет!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            ac.coins -= 50;
            ac.SaveAccount();
            CoinLabel.Text = ac.coins.ToString();
            OpenBox f = new OpenBox(boxs[2]);
            f.ShowDialog();
            ac = new account();
        }

        private void BoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
