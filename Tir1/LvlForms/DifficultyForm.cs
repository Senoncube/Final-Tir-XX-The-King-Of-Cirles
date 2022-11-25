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
    public partial class DifficultyForm : KryptonForm
    {
        public int dif = 0;
        public DifficultyForm()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dif = 400;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dif = 800;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dif = 1200;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dif = 1600;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dif = 2000;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dif = 2400;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dif = 2800;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dif = 3200;
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dif = 3600;
            this.Close();
        }
    }
}
