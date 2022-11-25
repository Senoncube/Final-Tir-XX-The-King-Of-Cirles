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
    public partial class MainForm : KryptonForm
    {
        settings sett;
        account ac;
        int x, y, hitbox = 90;
        bool isin = false, anim = false, circleanim = false,
            menu1 = false, menu2 = false, menu3 = false, rezh = false, back = false;
        int c1 = 0, c2 = 0;
        Random random = new Random();
        Color colormain1, colormain2, colorgoal1, colorgoal2, pastcolor1, pastcolor2;
        
        public MainForm()
        {
            InitializeComponent();
            colormain1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            colormain2 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            colorgoal1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            colorgoal2 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            pastcolor1 = colormain1;
            pastcolor2 = colormain2;
            OsuButton.Location = new Point(866, 17);
            MiniButton.Location = new Point(928, 100);
            StoreButton.Location = new Point(982, 182);
            SettingsButton.Location = new Point(928, 263);
            ExxitButton.Location = new Point(866, 346);
            CircleHitBox.Location = new Point(220, 115);
            OsuRecordBut.Location = new Point(893, 40);
            AIMbut.Location = new Point(949, 131);
            TestBut.Location = new Point(949, 220);
            MainLvlsBut.Location = new Point(866, 17);
            UserLvlsBut.Location = new Point(928, 100);
            MyLvlsBut.Location = new Point(982, 182);
            NewLvlBut.Location = new Point(928, 263);
            BackBut.Location = new Point(866, 346);
            BoxStoreBut.Location = new Point(893, 40);
            SkinStorBut.Location = new Point(949, 131);
            MySkinsBut.Location = new Point(949, 220);
            CircleHitBox.Size = new Size(500, CircleHitBox.Height);
            this.Palette = new KryptoPaleta().kryptonPalette1;
            Animator.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CircleAnimTimer.Stop();
            BackBut.Location = new Point(893, 312);
            menu1 = false;
            back = false;
            rezh = false;
            menu2 = true;
            SwapMenuTimer.Start();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            BackBut.Location = new Point(866, 346);
            CircleAnimTimer.Stop();
            back = false;
            menu2 = false;
            menu1 = true;
            rezh = false;
            SwapMenuTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowAcc(string name, bool canred)
        {
            AccountForm f = new AccountForm(name, canred);
            this.Hide();
            f.ShowDialog();
            if (f.closegme)
            {
                this.Close();
                return;
            }
            if (f.accexit)
            {
                sett.login = false;
                sett.SaveJson();
                LogInForm fr = new LogInForm();
                this.Hide();
                fr.ShowDialog();
                if (fr.closegame)
                {
                    fr.Close();
                    this.Close();
                    return;
                }
                this.Show();
                ac = new account();
                refresh();
            }
            this.Show();
        }
        public void refresh()
        {
            ac = new account();
            profileimg.BackgroundImage = Image.FromFile(ac.picpath);
            nickbutton.Text = ac.nick;
            CoinLabel.Text = ac.coins.ToString();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            sett = new settings();
            if (!sett.login)
            {
                LogInForm f = new LogInForm();
                this.Hide();
                f.ShowDialog();
                if (f.closegame)
                {
                    f.Close();
                    this.Close();
                    return;
                }
                this.Show();
            }
            ac = new account();
            profileimg.BackgroundImage = Image.FromFile(ac.picpath);
            nickbutton.Text = ac.nick;
            CoinLabel.Text = ac.coins.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CircleAnimTimer.Stop();
            BackBut.Location = new Point(893, 312);
            menu1 = false;
            back = false;
            rezh = false;
            menu3 = true;
            SwapMenuTimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                this.Close();
                return;
            }
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ac = new account();
            if (ac.nick == "admin")
            {
                if (ac.coins == 0) ac.coins = 999999;
                else ac.coins = 0;
                CoinLabel.Text = ac.coins.ToString();
                ac.SaveAccount();
            }
            ac.SetSkins();
            ac.GetSkins();
            ac.SaveAccount();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ShowAcc(ac.nick, true);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            sett.login = false;
            sett.SaveJson();
            LogInForm fr = new LogInForm();
            this.Hide();
            fr.ShowDialog();
            if (fr.closegame)
            {
                fr.Close();
                this.Close();
                return;
            }
            this.Show();
            ac = new account();
            refresh();
        }

        private void CircleAnimTimer_Tick(object sender, EventArgs e)
        {
            if (back) return;
            int p;
            if (circleanim)
            {
                p = 15;
                if (CircleHitBox.Location.X > 50)
                    CircleHitBox.Location = new Point(CircleHitBox.Location.X - p, CircleHitBox.Location.Y);
                if (menu1)
                {
                    if (MainLvlsBut.Location.X > 416)
                        MainLvlsBut.Location = new Point(MainLvlsBut.Location.X - 30, MainLvlsBut.Location.Y);
                    if (UserLvlsBut.Location.X > 478)
                        UserLvlsBut.Location = new Point(UserLvlsBut.Location.X - 30, UserLvlsBut.Location.Y);
                    if (MyLvlsBut.Location.X > 532)
                        MyLvlsBut.Location = new Point(MyLvlsBut.Location.X - 30, MyLvlsBut.Location.Y);
                    if (NewLvlBut.Location.X > 478)
                        NewLvlBut.Location = new Point(NewLvlBut.Location.X - 30, NewLvlBut.Location.Y);
                    if (BackBut.Location.X > 416)
                        BackBut.Location = new Point(BackBut.Location.X - 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 416)
                        SwapMenuTimer.Stop();
                }
                else
                if (menu2)
                {
                    if (OsuRecordBut.Location.X > 443)
                        OsuRecordBut.Location = new Point(OsuRecordBut.Location.X - 30, OsuRecordBut.Location.Y);
                    if (AIMbut.Location.X > 499)
                        AIMbut.Location = new Point(AIMbut.Location.X - 30, AIMbut.Location.Y);
                    if (TestBut.Location.X > 499)
                        TestBut.Location = new Point(TestBut.Location.X - 30, TestBut.Location.Y);
                    if (BackBut.Location.X > 443)
                        BackBut.Location = new Point(BackBut.Location.X - 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 443)
                        SwapMenuTimer.Stop();
                }
                else
                if (menu3)
                {
                    if (BoxStoreBut.Location.X > 443)
                        BoxStoreBut.Location = new Point(BoxStoreBut.Location.X - 30, BoxStoreBut.Location.Y);
                    if (SkinStorBut.Location.X > 499)
                        SkinStorBut.Location = new Point(SkinStorBut.Location.X - 30, SkinStorBut.Location.Y);
                    if (MySkinsBut.Location.X > 499)
                        MySkinsBut.Location = new Point(MySkinsBut.Location.X - 30, MySkinsBut.Location.Y);
                    if (BackBut.Location.X > 443)
                        BackBut.Location = new Point(BackBut.Location.X - 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 443)
                        SwapMenuTimer.Stop();
                }
                else
                {
                    if (OsuButton.Location.X > 416)
                        OsuButton.Location = new Point(OsuButton.Location.X - 30, OsuButton.Location.Y);
                    if (MiniButton.Location.X > 478)
                        MiniButton.Location = new Point(MiniButton.Location.X - 30, MiniButton.Location.Y);
                    if (StoreButton.Location.X > 532)
                        StoreButton.Location = new Point(StoreButton.Location.X - 30, StoreButton.Location.Y);
                    if (SettingsButton.Location.X > 478)
                        SettingsButton.Location = new Point(SettingsButton.Location.X - 30, SettingsButton.Location.Y);
                    if (ExxitButton.Location.X > 416)
                        ExxitButton.Location = new Point(ExxitButton.Location.X - 30, ExxitButton.Location.Y);
                }
            }
            else
            {
                p = -15;
                if (CircleHitBox.Location.X < 220)
                    CircleHitBox.Location = new Point(CircleHitBox.Location.X - p, CircleHitBox.Location.Y);
                if (menu1)
                {
                    if (MainLvlsBut.Location.X < 866)
                        MainLvlsBut.Location = new Point(MainLvlsBut.Location.X + 30, MainLvlsBut.Location.Y);
                    if (UserLvlsBut.Location.X < 928)
                        UserLvlsBut.Location = new Point(UserLvlsBut.Location.X + 30, UserLvlsBut.Location.Y);
                    if (MyLvlsBut.Location.X < 982)
                        MyLvlsBut.Location = new Point(MyLvlsBut.Location.X + 30, MyLvlsBut.Location.Y);
                    if (NewLvlBut.Location.X < 928)
                        NewLvlBut.Location = new Point(NewLvlBut.Location.X + 30, NewLvlBut.Location.Y);
                    if (BackBut.Location.X < 866)
                        BackBut.Location = new Point(BackBut.Location.X + 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 866)
                    {
                        CircleHitBox.Size = new Size(500, CircleHitBox.Height);
                        CircleAnimTimer.Stop();
                    }
                }
                else 
                if (menu2)
                {
                    if (OsuRecordBut.Location.X < 893)
                        OsuRecordBut.Location = new Point(OsuRecordBut.Location.X + 30, OsuRecordBut.Location.Y);
                    if (AIMbut.Location.X < 949)
                        AIMbut.Location = new Point(AIMbut.Location.X + 30, AIMbut.Location.Y);
                    if (TestBut.Location.X < 949)
                        TestBut.Location = new Point(TestBut.Location.X + 30, TestBut.Location.Y);
                    if (BackBut.Location.X < 893)
                        BackBut.Location = new Point(BackBut.Location.X + 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 893)
                    {
                        CircleHitBox.Size = new Size(500, CircleHitBox.Height);
                        CircleAnimTimer.Stop();
                    }
                }
                else
                if (menu3)
                {
                    if (BoxStoreBut.Location.X < 893)
                        BoxStoreBut.Location = new Point(BoxStoreBut.Location.X + 30, BoxStoreBut.Location.Y);
                    if (SkinStorBut.Location.X < 949)
                        SkinStorBut.Location = new Point(SkinStorBut.Location.X + 30, SkinStorBut.Location.Y);
                    if (MySkinsBut.Location.X < 949)
                        MySkinsBut.Location = new Point(MySkinsBut.Location.X + 30, MySkinsBut.Location.Y);
                    if (BackBut.Location.X < 893)
                        BackBut.Location = new Point(BackBut.Location.X + 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 893)
                    {
                        CircleHitBox.Size = new Size(500, CircleHitBox.Height);
                        CircleAnimTimer.Stop();
                    }
                }
                else
                {
                    if (OsuButton.Location.X < 866)
                        OsuButton.Location = new Point(OsuButton.Location.X + 30, OsuButton.Location.Y);
                    if (MiniButton.Location.X < 928)
                        MiniButton.Location = new Point(MiniButton.Location.X + 30, MiniButton.Location.Y);
                    if (StoreButton.Location.X < 982)
                        StoreButton.Location = new Point(StoreButton.Location.X + 30, StoreButton.Location.Y);
                    if (SettingsButton.Location.X < 928)
                        SettingsButton.Location = new Point(SettingsButton.Location.X + 30, SettingsButton.Location.Y);
                    if (ExxitButton.Location.X < 866)
                        ExxitButton.Location = new Point(ExxitButton.Location.X + 30, ExxitButton.Location.Y);
                    if (CircleHitBox.Location.X == 220)
                    {
                        CircleHitBox.Size = new Size(500, CircleHitBox.Height);
                        CircleAnimTimer.Stop();
                    }
                }
            }
        }

        private void CircleHitBox_MouseLeave(object sender, EventArgs e)
        {
            circleanim = false;
            CircleAnimTimer.Start();
        }

        private void MainLvlsBut_Click(object sender, EventArgs e)
        {
            MainLvlsMain f = new MainLvlsMain();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void UserLvlsBut_Click(object sender, EventArgs e)
        {
            MyLvlsMain f = new MyLvlsMain(1);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void MyLvlsBut_Click(object sender, EventArgs e)
        {
            MyLvlsMain f = new MyLvlsMain(0);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void NewLvlBut_Click(object sender, EventArgs e)
        {
            CreateMap f = new CreateMap();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void OsuRecordBut_Click(object sender, EventArgs e)
        {
            MiniGamesF f = new MiniGamesF(0);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void AIMbut_Click(object sender, EventArgs e)
        {
            MiniGamesF f = new MiniGamesF(1);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void TestBut_Click(object sender, EventArgs e)
        {
            MiniGamesF f = new MiniGamesF(2);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            this.Show();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            CircleAnimTimer.Stop();
            rezh = false;
            back = true;
            SwapMenuTimer.Start();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            BoxForm f = new BoxForm();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                this.Close();
                return;
            }
            this.Show();
        }

        private void SkinStorBut_Click(object sender, EventArgs e)
        {
            SkinStore f = new SkinStore();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                this.Close();
                return;
            }
            this.Show();
        }

        private void MySkinsBut_Click(object sender, EventArgs e)
        {
            MySkins f = new MySkins();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                this.Close();
                return;
            }
            this.Show();
        }

        private void SwapMenuTimer_Tick(object sender, EventArgs e)
        {
            CircleAnimTimer.Stop();
            if (back)
            {
                if (menu1)
                {
                    if (!rezh)
                    {
                        if (MainLvlsBut.Location.X < 866)
                            MainLvlsBut.Location = new Point(MainLvlsBut.Location.X + 30, MainLvlsBut.Location.Y);
                        if (UserLvlsBut.Location.X < 928)
                            UserLvlsBut.Location = new Point(UserLvlsBut.Location.X + 30, UserLvlsBut.Location.Y);
                        if (MyLvlsBut.Location.X < 982)
                            MyLvlsBut.Location = new Point(MyLvlsBut.Location.X + 30, MyLvlsBut.Location.Y);
                        if (NewLvlBut.Location.X < 928)
                            NewLvlBut.Location = new Point(NewLvlBut.Location.X + 30, NewLvlBut.Location.Y);
                        if (BackBut.Location.X < 866)
                            BackBut.Location = new Point(BackBut.Location.X + 30, BackBut.Location.Y);
                        if (BackBut.Location.X == 866)
                            rezh = true;
                    }
                }
                if (menu2)
                {
                    if (!rezh)
                    {
                        if (OsuRecordBut.Location.X < 893)
                            OsuRecordBut.Location = new Point(OsuRecordBut.Location.X + 30, OsuRecordBut.Location.Y);
                        if (AIMbut.Location.X < 949)
                            AIMbut.Location = new Point(AIMbut.Location.X + 30, AIMbut.Location.Y);
                        if (TestBut.Location.X < 949)
                            TestBut.Location = new Point(TestBut.Location.X + 30, TestBut.Location.Y);
                        if (BackBut.Location.X < 893)
                            BackBut.Location = new Point(BackBut.Location.X + 30, BackBut.Location.Y);
                        if (BackBut.Location.X == 893)
                            rezh = true;
                    }
                }
                if (menu3)
                {
                    if (!rezh)
                    {
                        if (BoxStoreBut.Location.X < 893)
                            BoxStoreBut.Location = new Point(BoxStoreBut.Location.X + 30, BoxStoreBut.Location.Y);
                        if (SkinStorBut.Location.X < 949)
                            SkinStorBut.Location = new Point(SkinStorBut.Location.X + 30, SkinStorBut.Location.Y);
                        if (MySkinsBut.Location.X < 949)
                            MySkinsBut.Location = new Point(MySkinsBut.Location.X + 30, MySkinsBut.Location.Y);
                        if (BackBut.Location.X < 893)
                            BackBut.Location = new Point(BackBut.Location.X + 30, BackBut.Location.Y);
                        if (BackBut.Location.X == 893)
                            rezh = true;
                    }
                }
                if (rezh)
                {
                    if (OsuButton.Location.X > 416)
                        OsuButton.Location = new Point(OsuButton.Location.X - 30, OsuButton.Location.Y);
                    if (MiniButton.Location.X > 478)
                        MiniButton.Location = new Point(MiniButton.Location.X - 30, MiniButton.Location.Y);
                    if (StoreButton.Location.X > 532)
                        StoreButton.Location = new Point(StoreButton.Location.X - 30, StoreButton.Location.Y);
                    if (SettingsButton.Location.X > 478)
                        SettingsButton.Location = new Point(SettingsButton.Location.X - 30, SettingsButton.Location.Y);
                    if (ExxitButton.Location.X > 416)
                        ExxitButton.Location = new Point(ExxitButton.Location.X - 30, ExxitButton.Location.Y);
                    if (ExxitButton.Location.X == 416)
                    {
                        back = false;
                        rezh = false;
                        menu1 = false;
                        menu2 = false;
                        menu3 = false;
                        SwapMenuTimer.Stop();
                    }
                }
                return;
            }
            if (menu1)
            {
                if (rezh)
                {
                    if (MainLvlsBut.Location.X > 416)
                        MainLvlsBut.Location = new Point(MainLvlsBut.Location.X - 30, MainLvlsBut.Location.Y);
                    if (UserLvlsBut.Location.X > 478)
                        UserLvlsBut.Location = new Point(UserLvlsBut.Location.X - 30, UserLvlsBut.Location.Y);
                    if (MyLvlsBut.Location.X > 532)
                        MyLvlsBut.Location = new Point(MyLvlsBut.Location.X - 30, MyLvlsBut.Location.Y);
                    if (NewLvlBut.Location.X > 478)
                        NewLvlBut.Location = new Point(NewLvlBut.Location.X - 30, NewLvlBut.Location.Y);
                    if (BackBut.Location.X > 416)
                        BackBut.Location = new Point(BackBut.Location.X - 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 416)
                        SwapMenuTimer.Stop();
                }
            }
            if (menu2)
            {
                if (rezh)
                {
                    if (OsuRecordBut.Location.X > 443)
                        OsuRecordBut.Location = new Point(OsuRecordBut.Location.X - 30, OsuRecordBut.Location.Y);
                    if (AIMbut.Location.X > 499)
                        AIMbut.Location = new Point(AIMbut.Location.X - 30, AIMbut.Location.Y);
                    if (TestBut.Location.X > 499)
                        TestBut.Location = new Point(TestBut.Location.X - 30, TestBut.Location.Y);
                    if (BackBut.Location.X > 443)
                        BackBut.Location = new Point(BackBut.Location.X - 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 443)
                        SwapMenuTimer.Stop();
                }
            }
            if (menu3)
            {
                if (rezh)
                {
                    if (BoxStoreBut.Location.X > 443)
                        BoxStoreBut.Location = new Point(BoxStoreBut.Location.X - 30, BoxStoreBut.Location.Y);
                    if (SkinStorBut.Location.X > 499)
                        SkinStorBut.Location = new Point(SkinStorBut.Location.X - 30, SkinStorBut.Location.Y);
                    if (MySkinsBut.Location.X > 499)
                        MySkinsBut.Location = new Point(MySkinsBut.Location.X - 30, MySkinsBut.Location.Y);
                    if (BackBut.Location.X > 443)
                        BackBut.Location = new Point(BackBut.Location.X - 30, BackBut.Location.Y);
                    if (BackBut.Location.X == 443)
                        SwapMenuTimer.Stop();
                }
            }
            if (!rezh)
            {
                if (OsuButton.Location.X < 866)
                    OsuButton.Location = new Point(OsuButton.Location.X + 30, OsuButton.Location.Y);
                if (MiniButton.Location.X < 928)
                    MiniButton.Location = new Point(MiniButton.Location.X + 30, MiniButton.Location.Y);
                if (StoreButton.Location.X < 982)
                    StoreButton.Location = new Point(StoreButton.Location.X + 30, StoreButton.Location.Y);
                if (SettingsButton.Location.X < 928)
                    SettingsButton.Location = new Point(SettingsButton.Location.X + 30, SettingsButton.Location.Y);
                if (ExxitButton.Location.X < 866)
                    ExxitButton.Location = new Point(ExxitButton.Location.X + 30, ExxitButton.Location.Y);
                if (ExxitButton.Location.X == 866)
                    rezh = true;
            }
        }

        private void CircleHitBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!circleanim)
                CircleHitBox.Size = new Size(820, CircleHitBox.Height);
            circleanim = true;
            CircleAnimTimer.Start();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {

        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            FriendsForm f = new FriendsForm();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                f.Close();
                this.Close();
                return;
            }
            this.Show();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            int p;
            if (anim)
            {
                p = 15;
                if (AccountButton.Location.Y < 105)
                    AccountButton.Location = new Point(AccountButton.Location.X, AccountButton.Location.Y + p);
                if (FriendsButton.Location.Y < 180)
                    FriendsButton.Location = new Point(FriendsButton.Location.X, FriendsButton.Location.Y + p);
                if (ExitButton.Location.Y < 255)
                    ExitButton.Location = new Point(ExitButton.Location.X, ExitButton.Location.Y + p);
                if (KryptoPanel.Height < 330)
                    KryptoPanel.Height += p;
            }
            else
            {
                p = -15;
                if (AccountButton.Location.Y > 20)
                    AccountButton.Location = new Point(AccountButton.Location.X, AccountButton.Location.Y + p);
                if (FriendsButton.Location.Y > 20)
                    FriendsButton.Location = new Point(FriendsButton.Location.X, FriendsButton.Location.Y + p);
                if (ExitButton.Location.Y > 20)
                    ExitButton.Location = new Point(ExitButton.Location.X, ExitButton.Location.Y + p);  anim = false;
                if (KryptoPanel.Height > 120)
                    KryptoPanel.Height += p;
            }
            
        }

        private void KryptoPanel_MouseLeave(object sender, EventArgs e)
        {
            anim = false;
            AnimTimer.Start();
        }
        void GenColor1()
        {
            colorgoal1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (Math.Abs(colormain1.R - colorgoal1.R) < 100 ||
                Math.Abs(colormain1.G - colorgoal1.G) < 100 ||
                Math.Abs(colormain1.B - colorgoal1.B) < 100)
                GenColor1();
        }

        void GenColor2()
        {
            colorgoal2 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            if (Math.Abs(colormain2.R - colorgoal2.R) < 100 ||
                Math.Abs(colormain2.G - colorgoal2.G) < 100 ||
                Math.Abs(colormain2.B - colorgoal2.B) < 100)
                GenColor2();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CircleButton.StateCommon.Back.ColorAngle++;
            CircleButton.StateTracking.Back.ColorAngle++;
            CircleButton.StatePressed.Back.ColorAngle++;
            CircleButton.OverrideDefault.Back.ColorAngle++;
            CircleButton.StateCommon.Border.ColorAngle++;
            /*OsuButton.StateCommon.Back.ColorAngle++;
            OsuButton.StateTracking.Back.ColorAngle++;
            OsuButton.StateCommon.Border.ColorAngle++;
            OsuButton.StateTracking.Border.ColorAngle++;
            OsuButton.StatePressed.Border.ColorAngle++;
            OsuButton.OverrideDefault.Border.ColorAngle++;*/
            c1++;
            colormain1 = Color.FromArgb(colormain1.R + (int)(c1 * ((double)pastcolor1.R - pastcolor1.R)/100),
                pastcolor1.G + (int)(c1 * ((double)colorgoal1.G - pastcolor1.G) / 100),
                pastcolor1.B + (int)(c1 * ((double)colorgoal1.B - pastcolor1.B) / 100));
            
            if (c1 == 100)
            {
                pastcolor1 = colormain1;
                c1 = 0;
                colorgoal1 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
            c2++;
            colormain2 = Color.FromArgb(pastcolor2.R + (int)(c2 * ((double)colorgoal2.R - pastcolor2.R) / 100),
                pastcolor2.G + (int)(c2 * ((double)colorgoal2.G - pastcolor2.G) / 100),
                pastcolor2.B + (int)(c2 * ((double)colorgoal2.B - pastcolor2.B) / 100));
            
            if (c2 == 100)
            {
                pastcolor2 = colormain2;
                c2 = 0;
                colorgoal2 = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
           Color colormain1dark1 = Color.FromArgb(
                (int)(colormain1.R * 0.75), (int)(colormain1.G * 0.75), (int)(colormain1.B * 0.75));
            Color colormain1dark2 = Color.FromArgb(
                (int)(colormain1.R * 0.5), (int)(colormain1.G * 0.5), (int)(colormain1.B * 0.5));
            Color colormain2dark1 = Color.FromArgb(
                (int)(colormain2.R * 0.75), (int)(colormain2.G * 0.75), (int)(colormain2.B * 0.75));
            Color colormain2dark2 = Color.FromArgb(
                (int)(colormain2.R * 0.5), (int)(colormain2.G * 0.5), (int)(colormain2.B * 0.5));
            CircleButton.StateCommon.Back.Color1 = colormain1;
            CircleButton.StateCommon.Back.Color2 = colormain2;
            CircleButton.StateTracking.Back.Color1 = colormain1;
            CircleButton.StateTracking.Back.Color2 = colormain2;
            CircleButton.StatePressed.Back.Color1 = colormain1;
            CircleButton.StatePressed.Back.Color2 = colormain2;
            CircleButton.OverrideDefault.Back.Color1 = colormain1;
            CircleButton.OverrideDefault.Back.Color2 = colormain2;
            CircleButton.StateCommon.Border.Color1 = colormain1;
            CircleButton.StateCommon.Border.Color2 = colormain2;
            /*OsuButton.StateCommon.Back.Color1 = colormain1;
            OsuButton.StateCommon.Back.Color2 = colormain2;
            OsuButton.StateCommon.Border.Color1 = colormain1;
            OsuButton.StateCommon.Border.Color2 = colormain2;
            OsuButton.StateTracking.Back.Color1 = colormain1dark1;
            OsuButton.StateTracking.Back.Color2 = colormain2dark1;
            OsuButton.StateTracking.Border.Color1 = colormain1dark1;
            OsuButton.StateTracking.Border.Color2 = colormain2dark1;
            OsuButton.StatePressed.Back.Color1 = colormain1dark2;
            OsuButton.StatePressed.Back.Color2 = colormain2dark2;
            OsuButton.StatePressed.Border.Color1 = colormain1dark2;
            OsuButton.StatePressed.Border.Color2 = colormain2dark2;
            OsuButton.OverrideDefault.Back.Color1 = colormain1;
            OsuButton.OverrideDefault.Back.Color2 = colormain2;
            OsuButton.OverrideDefault.Border.Color1 = colormain1;
            OsuButton.OverrideDefault.Border.Color2 = colormain2;*/
            SetMainButton(OsuButton);
            SetButton(MiniButton);
            SetButton(StoreButton);
            SetButton(SettingsButton);
            if (menu1)
            {
                SetMainButton(MainLvlsBut);
                SetButton(UserLvlsBut);
                SetButton(MyLvlsBut);
                SetButton(NewLvlBut);
                SetButton(BackBut);
            }
            if (menu2)
            {
                SetMainButton(OsuRecordBut);
                SetButton(AIMbut);
                SetButton(TestBut);
                SetButton(BackBut);
            }
            if (menu3)
            {
                SetMainButton(BoxStoreBut);
                SetButton(SkinStorBut);
                SetButton(MySkinsBut);
                SetButton(BackBut);
            }
        }
        public void SetMainButton(object button)
        {
            var but = (KryptonButton)button;
            but.StateCommon.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StateCommon.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StateTracking.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StateTracking.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StatePressed.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StatePressed.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.OverrideDefault.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.OverrideDefault.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;

            but.StateCommon.Back.Color1 = colormain1;
            but.StateCommon.Back.Color2 = colormain2;
            but.StateCommon.Border.Color1 = colormain1;
            but.StateCommon.Border.Color2 = colormain2;
            but.StateCommon.Border.Width = 1;
            but.StateCommon.Content.ShortText.Color1 = Color.White;

            Color colormain1dark1 = Color.FromArgb(
                (int)(colormain1.R * 0.75), (int)(colormain1.G * 0.75), (int)(colormain1.B * 0.75));
            Color colormain1dark2 = Color.FromArgb(
                (int)(colormain1.R * 0.5), (int)(colormain1.G * 0.5), (int)(colormain1.B * 0.5));
            Color colormain2dark1 = Color.FromArgb(
                (int)(colormain2.R * 0.75), (int)(colormain2.G * 0.75), (int)(colormain2.B * 0.75));
            Color colormain2dark2 = Color.FromArgb(
                (int)(colormain2.R * 0.5), (int)(colormain2.G * 0.5), (int)(colormain2.B * 0.5));

            but.StateTracking.Back.Color1 = colormain1dark1;
            but.StateTracking.Back.Color2 = colormain2dark1;
            but.StateTracking.Border.Color1 = colormain1dark1;
            but.StateTracking.Border.Color2 = colormain2dark1;
            but.StatePressed.Back.Color1 = colormain1dark2;
            but.StatePressed.Back.Color2 = colormain2dark2;
            but.StatePressed.Border.Color1 = colormain1dark2;
            but.StatePressed.Border.Color2 = colormain2dark2;
            but.OverrideDefault.Back.Color1 = colormain1;
            but.OverrideDefault.Back.Color2 = colormain2;
            but.OverrideDefault.Border.Color1 = colormain1;
            but.OverrideDefault.Border.Color2 = colormain2;
            but.OverrideDefault.Border.Width = 1;
            but.OverrideDefault.Content.ShortText.Color1 = Color.White;
        }

        public void SetButton(object button)
        {
            var but = (KryptonButton)button;
            but.StateCommon.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StateCommon.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StateTracking.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StateTracking.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StatePressed.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.StatePressed.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.OverrideDefault.Back.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;
            but.OverrideDefault.Border.ColorAngle = CircleButton.StateCommon.Back.ColorAngle;

            but.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            but.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            but.StateCommon.Border.Color1 = colormain1;
            but.StateCommon.Border.Color2 = colormain2;
            but.StateCommon.Border.Width = 3;
            but.StateCommon.Content.ShortText.Color1 = colormain1;
            
            Color colormain1dark1 = Color.FromArgb(
                (int)(colormain1.R * 0.75), (int)(colormain1.G * 0.75), (int)(colormain1.B * 0.75));
            Color colormain1dark2 = Color.FromArgb(
                (int)(colormain1.R * 0.5), (int)(colormain1.G * 0.5), (int)(colormain1.B * 0.5));
            Color colormain2dark1 = Color.FromArgb(
                (int)(colormain2.R * 0.75), (int)(colormain2.G * 0.75), (int)(colormain2.B * 0.75));
            Color colormain2dark2 = Color.FromArgb(
                (int)(colormain2.R * 0.5), (int)(colormain2.G * 0.5), (int)(colormain2.B * 0.5));

            but.StateTracking.Back.Color1 = colormain1dark1;
            but.StateTracking.Back.Color2 = colormain2dark1;
            but.StateTracking.Border.Color1 = colormain1dark1;
            but.StateTracking.Border.Color2 = colormain2dark1;
            but.StatePressed.Back.Color1 = colormain1dark2;
            but.StatePressed.Back.Color2 = colormain2dark2;
            but.StatePressed.Border.Color1 = colormain1dark2;
            but.StatePressed.Border.Color2 = colormain2dark2;
            but.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            but.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            but.OverrideDefault.Border.Color1 = colormain1;
            but.OverrideDefault.Border.Color2 = colormain2;
            but.OverrideDefault.Border.Width = 3;
            but.OverrideDefault.Content.ShortText.Color1 = colormain1;
        }

        private void KryptoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            anim = true;
            AnimTimer.Start();
        }

    }
}
