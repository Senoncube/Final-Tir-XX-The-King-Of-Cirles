using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Tir1.@class;

namespace Tir1.@class
{
    public class digitcircle : circle
    {
        public int i { set; get; }

        public digitcircle()
        {
            r = 50;
            i = 0;
            clic = false;
            Random rand = new Random();
            x = rand.Next(958 - 2 * r) + r;
            y = rand.Next(529 - 2 * r) + r;
        }
        public digitcircle(int r, int i)
        {
            this.r = r;
            this.i = i;
            clic = false;
            Random rand = new Random();
            x = rand.Next(958 - 2 * r) + r;
            y = rand.Next(529 - 2 * r) + r;
        }
        [JsonConstructor]
        public digitcircle(int x, int y, int r, int i)
        {
            this.r = r;
            this.i = i;
            clic = false;
            this.x = x;
            this.y = y;
        }

        public void drawd(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(x - r, y - r, 2 * r, 2 * r));
            Font f;
            PointF p;
            if (i > 99)
            {
                f = new Font("Arial", (float)(r * 0.5));
                p = new PointF((float)(x - r + 5 * (r / 50.0)), (float)(y - r + 25 * (r / 50.0)));
            }
            else if (i > 9)
            {
                f = new Font("Arial", (float)(r * 0.75));
                p = new PointF((float)(x - r + 5 * (r / 50.0)), (float)(y - r + 15 * (r / 50.0)));
            }
            else
            {
                f = new Font("Arial", r);
                p = new PointF((float)(x - r + 13 * (r / 50.0)), (float)(y - r + 5 * (r / 50.0)));
            }
            Brush b = new SolidBrush(Color.Black);

            g.DrawString(i.ToString(), f, b, p);
        }

        public bool Peresechenie(digitcircle c)
        {
            double rast = Math.Sqrt((c.x - x) * (c.x - x) + (c.y - y) * (c.y - y));
            if (rast < r + c.r) return true;
            else return false;
        }
    }
}
