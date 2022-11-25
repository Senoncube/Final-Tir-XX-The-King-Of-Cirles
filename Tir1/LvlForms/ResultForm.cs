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
    public partial class ResultForm : KryptonForm
    {
        public bool back = false;
        public bool closegame = false;
        public bool menu = false;
        bool fl = false;
        public ResultForm(result res, byte type)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            if (type == 0)
            {
                label2.Visible = true;
                CoinsLabel.Visible = true;
                ResL.Text = res.sch.ToString();
                CoinsLabel.Text = res.coins.ToString();
            }
            else if (type == 1)
            {
                ResL.Visible = false;
                label1.Text = $"Ви пройшли рівень {res.name}!";
                button1.Text = "Наступний рівень";
                button1.Font = new Font("Arial", 12);
            }
            else if (type == 2)
            {
                ResL.Visible = false;
                label1.Text = $"Ви не пройшли рівень {res.name}!";
                button1.Text = "Спробувати ще раз";
                button1.Font = new Font("Arial", 10);
            }
            else if (type == 3) OsuLvlRes(res);
        }

        public void OsuLvlRes(result res)
        {
            //label1.Location = new Point(12, 68);
            //ResL.Location = new Point(258, 64);
            label2.Visible = true;
            CoinsLabel.Visible = true;
            CoinsLabel.Text = res.coins.ToString();
            ResL.Text = res.sch.ToString();
            NameLabel.Visible = true; NameLabel.Text = "Ви пройшли рівень \"" + res.name + "\"!";
            MarkLabel.Visible = true; MarkLabel.Text = res.GetMark();
            //ResL.Text = res.sch.ToString()+"("+res.proc.ToString()+"%)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            //CloseWin(false);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CloseWin(true);
            menu = true;
            this.Close();
        }
        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (!fl)
                CloseWin(true);*/
            if (!menu && !back) closegame = true;
        }

    }
}
