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
    public partial class AccountForm : KryptonForm
    {
        public bool closegme = false, back = false, accexit = false;
        account ac;
        public AccountForm(string name, bool canred)
        {
            ac = new account("","","");
            InitializeComponent();
            this.Palette = new KryptoPaleta().kryptonPalette1;
            ac.GetAccount(name);
            if (canred) button2.Visible = true;
            else
            {
                account mainac = new account();
                bool fl = false;
                for (int i = 0; i < mainac.friends.Count; i++)
                    if (mainac.friends[i] == name)
                    {
                        label11.Visible = true;
                        fl = true; 
                        break;
                    }
                if (!fl)
                    kryptonButton1.Visible = true;
            }
            refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back && !accexit) closegme = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAcc f = new EditAcc();
            this.Hide();
            f.ShowDialog();
            if (f.accdel)
            {
                accexit = true;
                this.Close();
                return;
            }
            if (f.closegame)
            {
                closegme = true;
                this.Close();
                return;
            }
            this.Show();
            refresh();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            account mainac = new account();
            mainac.friends.Add(ac.nick);
            ac.friends.Add(mainac.nick);
            ac.SaveJson();
            mainac.SaveAccount();
            kryptonButton1.Visible = false;
            label11.Visible = true;
            MessageBox.Show(ac.nick + " додано в друзі!", "Новий друг", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void refresh()
        {
            namelbl.Text = ac.nick;
            ProfilePic.BackgroundImage = Image.FromFile(ac.picpath);
            ratinglbl.Text = ac.rating.ToString();
            coincountlbl.Text = ac.coinscount.ToString();
            datelbl.Text = ac.date.Day.ToString() + "." + ac.date.Month.ToString() + "." + ac.date.Year.ToString();
            int lvlscount = 0, attcount = 0, clickcount = 0;
            for (int i = 0; i < ac.lvls.Count; i++)
            {
                attcount += ac.lvls[i].attcount;
                clickcount += ac.lvls[i].clickcount;
                if (ac.lvls[i].complete)
                    lvlscount++;
            }
            attcount += ac.osuatt + ac.aimatt + ac.testatt;
            lvlslbl.Text = lvlscount.ToString();
            attcountlbl.Text = attcount.ToString();
            clickcountlbl.Text = clickcount.ToString();
            int s = 0;
            for (int i = 0; i < ac.skins.Count; i++)
                if (ac.skins[i].have) s++;
            SkinCount.Text = s.ToString() + "/" + ac.skins.Count.ToString();
        }
    }
}
