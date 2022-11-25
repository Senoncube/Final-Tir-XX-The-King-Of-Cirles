using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Tir1.@class
{
    public class circle : ICloneable
    {
        public int x { set; get; }
        public int y { set; get; }
        public int r { set; get; }
        public bool clic { set; get; }
        public circle()
        {
            clic = false;
            r = 50;
            Random rand = new Random();
            x = rand.Next(958 - 2 * r) + r;
            y = rand.Next(529 - 2 * r) + r;
            r = r;
        }
        [JsonConstructor]
        public circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public circle(int r)
        {
            clic = false;
            Random rand = new Random();
            x = rand.Next(958 - 2 * r) + r;
            y = rand.Next(529 - 2 * r) + r;
            this.r = r;
        }

        public void draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(x - r, y - r, 2 * r, 2 * r));
        }
        public bool isin(int x, int y)
        {
            if (Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2) <= r * r)
            {
                return true;
                clic = true;
            }
            else return false;
        }

        public object Clone()
        {
            return new circle(x, y, r);
        }
    }
}
