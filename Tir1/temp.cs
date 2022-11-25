using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Tir1.@class;

namespace Tir1
{
    public partial class temp : KryptonForm
    {
        public temp()
        {
            Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
        }
    }
}
