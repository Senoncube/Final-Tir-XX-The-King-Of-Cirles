using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tir1.@class
{
    internal class warning
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int i { set; get; }

        public warning(int x, int y, int i)
        {
            this.x = x - 50;
            this.y = y - 50;
            width = 100;
            height = 100;
            this.i = i;
            /*if (i == 1) img = Properties.Resources.redcross;
            if (i == 2) img = Properties.Resources.redsign;
            if (i == 3) img = Properties.Resources.yellowsign;
            if (i == 4) img = Properties.Resources.heartskin;
            if (i == 5) img = Properties.Resources.Shield;
            if (i == 6) img = Properties.Resources.manycoins;*/
        }

        public bool obnov()
        {
            x += 4;
            y += 4;
            width -= 8;
            height -= 8;
            if (width <= 0 || height <= 0) return true;
            else return false;
        }

        public void draw(Graphics g, Image img)
        {
            g.DrawImage(img, x, y, width, height);
        }

    }
}
