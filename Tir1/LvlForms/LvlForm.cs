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
using System.Text.Json;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class LvlForm : KryptonForm
    {
        account ac;
        osulvl lvl;
        bool canred;
        public bool closegame = false;
        public bool menu = false;
        bool back = false;
        public LvlForm(osulvl lvl, bool canr)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            ac = new account();
            if (ac.nick != "admin")
                this.canred = canr;
            else
                this.canred = true;
            InitializeComponent();
            ac = new account();
            if (!canred)
            {
                redbutton.Visible = false;
                DeleteButton.Visible = false;
                Leaderbord.Visible = true;
            }
            this.lvl = lvl;
            refresh();
        }
        public void refresh()
        {
            int j = ac.GetLvl(lvl);   
            NameLabel.Text = lvl.name;
            if (lvl.autor != "admin")
                NameLabel.Text += "(Автор: " + lvl.autor + ")";
            if (ac.lvls[j].recordsct != 0)
                if (ac.lvls[j].recordmark == "-")
                    RecordLabel.Text = ac.lvls[j].recordsct.ToString();
                else
                    RecordLabel.Text = ac.lvls[j].recordmark + "(" + ac.lvls[j].recordsct.ToString() + ")";
            if (ac.lvls[j].practicerecord != 0)
                if (ac.lvls[j].practicemark == "-")
                    PracticeLabel.Text = ac.lvls[j].practicerecord.ToString();
                else
                    PracticeLabel.Text = ac.lvls[j].practicemark + "(" + ac.lvls[j].practicerecord.ToString() + ")";
            if (ac.lvls[j].complete && canred)
                UploadButton.Visible = true;
            CirclesLabel.Text = lvl.circles.Count.ToString();
            /*int s = 0, alls = 0;
            osulvl? o;
            using (FileStream fs = new FileStream(ac.lvls[j].path, FileMode.OpenOrCreate))
            {
                o = JsonSerializer.Deserialize<osulvl>(fs);
            }
            for (int i = 0; i < ac.lvls[j].coinclick.Length; i++)
            {
                if (ac.lvls[j].coinclick[i]) s += o.circles[i].skin == 1 ? 100 : 1;
                alls += o.circles[i].skin == 1 ? 100 : 1;
            }*/
            ac.lvls[j].coinscount = 0;
            ac.lvls[j].coinclickcout = 0;
            for (int i = 0; i < lvl.circles.Count; i++)
                if (lvl.circles[i].skin == 1)
                {
                    ac.lvls[j].coinscount++;
                    if (ac.lvls[j].coinclick[i]) ac.lvls[j].coinclickcout++;
                }
            int s = 0;
            for (int i = 0; i < ac.lvls[j].coinclick.Length; i++)
                if (ac.lvls[j].coinclick[i]) s++;
                RewardLabel.Text = (ac.lvls[j].coinclickcout*99 + s).ToString() + "/" + (ac.lvls[j].coinscount*99 + lvl.circles.Count).ToString();
            TimeSpan t = new TimeSpan(0, 0, 0, 0, lvl.LvlTIme() * 10);
            TimeLabel.Text = t.Minutes + ":";
            if (t.Seconds < 10)
                TimeLabel.Text += "0";
            TimeLabel.Text += t.Seconds.ToString();
            DifficultyLabel.Text = lvl.rating.ToString();
            CountAttLabel.Text = ac.lvls[j].attcount.ToString();
            CountClickLabel.Text = ac.lvls[j].clickcount.ToString();
            if (lvl.hp < 3)
                heart3.BackgroundImage = Properties.Resources.blackheart;
            if (lvl.hp < 2)
                heart2.BackgroundImage = Properties.Resources.blackheart;
            if (lvl.countgol > 2)
            {
                if (lvl.rating <= 400)
                    Difpb.Image = Properties.Resources.easydif;
                else if (lvl.rating <= 800)
                    Difpb.Image = Properties.Resources.normdif;
                else if (lvl.rating <= 1200)
                    Difpb.Image = Properties.Resources.harddif;
                else if (lvl.rating <= 1600)
                    Difpb.Image = Properties.Resources.harderdif;
                else if (lvl.rating <= 2000)
                    Difpb.Image = Properties.Resources.insanedif;
                else if (lvl.rating <= 2400)
                    Difpb.Image = Properties.Resources.mediumdemon;
                else if (lvl.rating <= 2800)
                    Difpb.Image = Properties.Resources.harddemondif;
                else if (lvl.rating <= 3200)
                    Difpb.Image = Properties.Resources.extremedif;
                else 
                    Difpb.Image = Properties.Resources.ultradif;
            }
            else
                Difpb.Image = Properties.Resources.nonedif;
            if (ac.lvls[j].complete && !ac.lvls[j].gol)
                DifBut.Visible = true;
            else
                DifBut.Visible = false;
            if (lvl.path.Contains("MainLvls") && ac.nick != "admin")
                DifBut.Visible = false;
            if (ac.nick == "admin")
                DifBut.Visible = true;
            ac.SetAccount();
            ac.SaveJson();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            osugame f = new osugame(lvl, 1);
            this.Hide();
            f.ShowDialog();
            if (f.menu || f.closegame)
            {
                closegame = f.closegame;
                menu = f.menu;
                f.Close();
                this.Close();
                return;
            }
            
            f.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapMaker f = new MapMaker(lvl);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                closegame = true;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            osugame f = new osugame(lvl, 2);
            this.Hide();
            f.ShowDialog();
            if (f.closegame || f.menu)
            {
                closegame = f.closegame;
                menu = f.menu;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
            refresh();
        }

        private void LvlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menu && !back) closegame = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ac.lvls.RemoveAt(ac.GetLvl(lvl));
            System.IO.File.Delete(lvl.path);
            back = true;
            this.Close();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (lvl.autor != "admin")
            {
                System.IO.File.Copy(lvl.path, "UsersLvls/" + lvl.name + ".json");
                File.Delete(lvl.path);
                lvl.path = "UsersLvls/" + lvl.name + ".json";
            }
            else
            {
                System.IO.File.Copy(lvl.path, "MainLvls/" + lvl.name + ".json");
                File.Delete(lvl.path);
                lvl.path = "MainLvls/" + lvl.name + ".json";
            }
            lvl.SaveJson();
            MessageBox.Show("Рівеень успішно викладено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            menu = true;
            this.Close();
        }

        private void Leaderbord_Click(object sender, EventArgs e)
        {
            LeaderbordForm f = new LeaderbordForm(lvl);
            this.Hide();
            f.ShowDialog();
            if (f.closegame )
            {
                closegame = f.closegame;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DifficultyForm f = new DifficultyForm();
            f.ShowDialog();
            if (f.dif == 0)
                return;
            if (ac.nick == "admin")
            {
                lvl.rating = f.dif;
                lvl.countgol = 3;
                lvl.SaveJson();
                refresh();
                return;
            }
            lvl.rating = (lvl.rating * lvl.countgol + f.dif) / (lvl.countgol + 1);
            lvl.countgol++;
            lvl.SaveJson();
            int j = ac.GetLvl(lvl);
            ac.lvls[j].gol = true;
            ac.SaveAccount();
            refresh();
        }
    }
}
