using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class LogInForm : KryptonForm
    {
        public bool closegame = false;
        bool back = false;
        FileInfo[] files;
        public LogInForm()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            files = new DirectoryInfo("accounts/").GetFiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Length; i++)
                if (files[i].Name.Substring(0, files[i].Name.Length - 5) == nickTB.Text)
                {
                    account ac = new account();
                    ac.GetAccount(nickTB.Text);
                    if (ac.password == passwordTB.Text)
                    {
                        if (logincheck.Checked)
                        {
                            settings sett = new settings();
                            sett.login = true;
                            sett.SaveJson();
                        }
                        ac.SetAccount();
                        back = true;
                        this.Close();
                        return;
                    }
                }
            MessageBox.Show("Неправильний логін або пароль!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            nickTB.Text = "Введіть нікнейм";
            nickTB.StateCommon.Content.Color1 = Color.Gray;
            passwordTB.Text = "Введіть пароль";
            passwordTB.PasswordChar = (char)0;
            passwordTB.StateCommon.Content.Color1 = Color.Gray;
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingInForm f = new SingInForm();
            this.Hide();
            f.ShowDialog();
            if (f.closegame || f.menu)
            {
                closegame = f.closegame;
                back = f.menu;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void eyepb_MouseMove(object sender, MouseEventArgs e)
        {
            eyepb.Image = Properties.Resources.eye;
            passwordTB.PasswordChar = (char)0;
        }

        private void eyepb_MouseLeave(object sender, EventArgs e)
        {
            eyepb.Image = Properties.Resources.closed_eyes;

            if (passwordTB.Text != "Введіть пароль")
                passwordTB.PasswordChar = '•';
        }

        private void nickTB_Enter(object sender, EventArgs e)
        {
            nickTB.StateCommon.Content.Color1 = Color.Black;
            if (nickTB.Text == "Введіть нікнейм")
                nickTB.Text = "";
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            passwordTB.StateCommon.Content.Color1 = Color.Black;
            if (passwordTB.Text == "Введіть пароль")
            {
                passwordTB.Text = "";
                passwordTB.PasswordChar = '•';
            }
        }

        private void nickTB_Leave(object sender, EventArgs e)
        {
            if (nickTB.Text == "")
            {
                nickTB.StateCommon.Content.Color1 = Color.Gray;
                nickTB.Text = "Введіть нікнейм";
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Введіть пароль";
                passwordTB.PasswordChar = (char)0;
                passwordTB.StateCommon.Content.Color1 = Color.Gray;
            }
        }
    }
}
