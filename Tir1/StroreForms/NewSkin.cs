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
    public partial class NewSkin : KryptonForm
    {
        account ac;
        int i;
        public NewSkin(int i)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            this.i = i;
            InitializeComponent();
            ac = new account();
            SkinPic.Image = Image.FromFile(ac.skins[i].path);
            if (ac.skins[i].GetRarityColor() != Color.White)
                SkinPic.BackColor = ac.skins[i].GetRarityColor();
        }

        private void SetSkin_Click(object sender, EventArgs e)
        {
            ac.skini = i;
            ac.SaveAccount();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
