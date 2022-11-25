using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization;
using Tir1.@class;

namespace Tir1.@class
{
    public class osucircle : digitcircle
    {

        public double sc { set; get; }
        public double speed { set; get; }

        public double res1 { set; get; }
        public double res2 { set; get; }
        public int vrem { set; get; }
        private double fsc;
        public bool Videl { set; get; }
        public int maini { set; get; }
        public byte skin { set; get; }
        [JsonConstructor]
        public osucircle(int r, int x, int y, double sc, double speed, double res1, double res2, int vrem, byte skin)
        {
            this.r = r;
            this.x = x;
            this.y = y;
            this.sc = sc;
            this.speed = speed;
            this.res1 = res1;
            this.res2 = res2;
            this.vrem = vrem;
            fsc = sc;
            this.skin = skin;
        }
        public osucircle(int r)
        {
            this.r = r;
            Random rand = new Random();
            x = rand.Next(958 - 2 * r) + r;
            y = rand.Next(529 - 2 * r) + r;
            sc = 3;
            speed = 0.01;
            skin = 0;
        }
        public osucircle(int r, double sc, double speed, double res1, double res2)
        {
            this.sc = sc;
            this.speed = speed;
            this.res1 = res1;
            this.res2 = res2;
            this.r = r;
            Random rand = new Random();
            x = rand.Next(958 - 2 * r) + r;
            y = rand.Next(529 - 2 * r) + r;
            sc = 3;
            fsc = 3;
            speed = 0.01;
            skin = 0;
        }

        public int GetRes()
        {
            if (sc < 1 + res1 * 2 && sc > 1 - res1)
                return 5;
            else if (sc < 1 + res2 * 2 && sc > 1 - res2)
                return 3;
            else return 1;
        }
        public int GetEndTime()
        {
            return vrem + (int)(1 / speed);
        }

        public void SetSc(int time)
        {
            sc = fsc - (time - vrem) * fsc * speed;
        }

        public bool IsTImeIn(int t)
        {
            if (GetEndTime() >= t && vrem <= t)
                return true;
            else
                return false;
        }
        public void obnov()
        {
            sc -= fsc * speed;
        }
        public void drawfirstcircle(Graphics g, Image img)
        {
            if (skin == 0)
            {
                account ac = new account();
                g.DrawImage(img, x - r, y - r, 2 * r, 2 * r);
            }
            if (skin == 1)
                g.DrawImage(Properties.Resources.coin, x - r, y - r, 2 * r, 2 * r);
            if (skin == 2)
                g.DrawImage(Properties.Resources.heartskin2, x - r, y - r, 2 * r, 2 * r);
            if (skin == 3)
                g.DrawImage(Properties.Resources.shiel2, x - r, y - r, 2 * r, 2 * r);
        }
        public void drawsecondcircle(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            g.DrawEllipse(p, new Rectangle(
                (int)(x - r * sc), (int)(y - r * sc), (int)(2 * r * sc), (int)(2 * r * sc)));
            g.DrawEllipse(p, new Rectangle(
                (int)(x - r * sc) + 2, (int)(y - r * sc) + 2, (int)(2 * r * sc) - 4, (int)(2 * r * sc) - 4));
            g.DrawEllipse(p, new Rectangle(
                (int)(x - r * sc) + 1, (int)(y - r * sc) + 1, (int)(2 * r * sc) - 2, (int)(2 * r * sc) - 2));
            if (Videl == true)
            {
                p = new Pen(Color.Black, 5);
                g.DrawLine(p, x, (int)(y + r * sc), x, (int)(y - r * sc));
                g.DrawLine(p, (int)(x - r * sc), y, (int)(x + r * sc), y);
            }
            
        }
        public new object Clone()
        {
            osucircle c = new osucircle(r, x, y, sc, speed, res1, res2, vrem,skin);
            c.clic = clic;
            c.Videl = Videl;
            c.maini = maini;
            return c;
        }
    }
}
