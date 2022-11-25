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
    public partial class SingInForm : KryptonForm
    {
        FileInfo[] files;
        string path;
        public bool closegame = false;
        public bool menu = false;
        bool back = false, openfile = false;
        public SingInForm()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            files = new DirectoryInfo("accounts/").GetFiles();
        }

        private void SingInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back && !menu) closegame = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openfile && nickTB.Text != "" && passwordTB.Text != "")
            {
                for (int i = 0; i < files.Length; i++)
                    if (files[i].Name.Substring(0, files[i].Name.Length - 5) == nickTB.Text)
                    {
                        MessageBox.Show("Аккаунт з таким ім'ям уже існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nickTB.Text = "Введіть нікнейм";
                        nickTB.StateCommon.Content.Color1 = Color.Gray;
                        return;
                    }
                if (passwordTB.Text.Length < 8)
                {
                    MessageBox.Show("Пароль має бути мінімум 8 символів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTB.Text = "Введіть пароль";
                    passwordTB.PasswordChar = (char)0;
                    passwordTB.StateCommon.Content.Color1 = Color.Gray;
                    return;
                }
                account ac = new account(nickTB.Text, passwordTB.Text, path);
                ac.SetAccount();
                ac.SaveJson();
                menu = true;
                this.Close();
                return;
            }
            MessageBox.Show("Заповніть всі поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void nickTB_Leave(object sender, EventArgs e)
        {
            if (nickTB.Text == "")
            {
                nickTB.StateCommon.Content.Color1 = Color.Gray;
                nickTB.Text = "Введіть нікнейм";
            }
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

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Введіть пароль";
                passwordTB.PasswordChar = (char)0;
                passwordTB.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPic f = new AddPic();
            f.ShowDialog();
            if (f.openfile)
            {
                openfile = true;
                button2.Size = new Size(234, 53);
                button2.Location = new Point(114, 274);
                button2.Text = "Змінити";
                ProfilePic.Visible = true;
                ProfilePic.BackgroundImage = Image.FromFile(f.path);
                path = f.path;
            }
        }
    }
}
