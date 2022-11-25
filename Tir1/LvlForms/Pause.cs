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
    public partial class Pause : KryptonForm
    {
        bool back = false;
        public bool NewAtt = false;
        public bool CloseGame = false;
        public bool menu = false;
        public Pause()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewAtt = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                CloseGame = true;
                this.Close();
                return;
            }
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu = true;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseGame = true;
            this.Close();
        }

        private void Pause_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menu && !back && !NewAtt) CloseGame = true;
        }
    }
}
