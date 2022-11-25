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
    public partial class EditAcc : KryptonForm
    {
        string path;
        bool openfile = false;
        account ac;
        public bool back = false, accdel = false, closegame = false;

        private void EditAcc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back && !accdel) closegame = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }


        private void pasteye_MouseMove(object sender, MouseEventArgs e)
        {
            pastpassTB.PasswordChar = (char)0;
            pasteye.Image = Properties.Resources.eye;
        }

        private void pasteye_MouseLeave(object sender, EventArgs e)
        {
            if (pastpassTB.Text != "Введіть пароль")
                pastpassTB.PasswordChar = '•';
            pasteye.Image = Properties.Resources.closed_eyes;
        }

        private void neweye_MouseMove(object sender, MouseEventArgs e)
        {
            newpassTB.PasswordChar = (char)0;
            neweye.Image = Properties.Resources.eye;
        }

        private void neweye_MouseLeave(object sender, EventArgs e)
        {
            if (newpassTB.Text != "Введіть новий пароль")
                newpassTB.PasswordChar = '•';
            neweye.Image = Properties.Resources.closed_eyes;
        }


        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddPic f = new AddPic();
            f.ShowDialog();
            if (f.openfile)
            {
                openfile = true;
                ProfilePic.Image = Image.FromFile(f.path);
                path = f.path;
            }
        }

        private void pastpassTB_Enter(object sender, EventArgs e)
        {
            pastpassTB.StateCommon.Content.Color1 = Color.Black;
            if (pastpassTB.Text == "Введіть пароль")
            {
                pastpassTB.Text = "";
                pastpassTB.PasswordChar = '•';
            }
        }

        private void pastpassTB_Leave(object sender, EventArgs e)
        {
            if (pastpassTB.Text == "")
            {
                pastpassTB.Text = "Введіть пароль";
                pastpassTB.PasswordChar = (char)0;
                pastpassTB.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void newpassTB_Enter(object sender, EventArgs e)
        {
            newpassTB.StateCommon.Content.Color1 = Color.Black;
            if (newpassTB.Text == "Введіть новий пароль")
            {
                newpassTB.Text = "";
                newpassTB.PasswordChar = '•';
            }
        }

        private void newpassTB_Leave(object sender, EventArgs e)
        {
            if (newpassTB.Text == "")
            {
                newpassTB.Text = "Введіть новий пароль";
                newpassTB.PasswordChar = (char)0;
                newpassTB.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (nickTB.Text != ac.nick)
            {
                FileInfo[] files = new DirectoryInfo("accounts/").GetFiles();
                for (int i = 0; i < files.Length; i++)
                    if (files[i].Name.Substring(0, files[i].Name.Length - 5) == nickTB.Text)
                    {
                        MessageBox.Show("Аккаунт з таким ім'ям уже існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nickTB.Text = ac.nick;
                        return;
                    }
                if (newpassTB.Text.Length < 8)
                {
                    MessageBox.Show("Пароль має бути мінімум 8 символів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newpassTB.Text = "Введіть новий пароль";
                    newpassTB.PasswordChar = (char)0;
                    newpassTB.StateCommon.Content.Color1 = Color.Gray;
                    return;
                }
                ac.nick = nickTB.Text;
                ac.SaveJson();
                ac.SetAccount();
            }
            if (openfile)
            {
                ac.picpath = path;
                ac.SaveJson();
                ac.SetAccount();
            }
            if (pastpassTB.Text != "Введіть пароль" || newpassTB.Text != "Введіть новий пароль")
                if (ac.password != pastpassTB.Text)
                {
                    MessageBox.Show("Щоб встановити новий пароль введіть правильно минулий!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newpassTB.Text = "Введіть новий пароль";
                    newpassTB.PasswordChar = (char)0;
                    newpassTB.StateCommon.Content.Color1 = Color.Gray;
                    pastpassTB.Text = "Введіть пароль";
                    pastpassTB.PasswordChar = (char)0;
                    pastpassTB.StateCommon.Content.Color1 = Color.Gray;
                    return;
                }
                else
                {
                    ac.password = newpassTB.Text;
                    ac.SaveJson();
                    ac.SetAccount();
                }
            back = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ac.DelAccount();
            accdel = true;
            this.Close();
        }

        public EditAcc()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            ac = new account();
            nickTB.Text = ac.nick;
            ProfilePic.Image = Image.FromFile(ac.picpath);
        }
    }
}
