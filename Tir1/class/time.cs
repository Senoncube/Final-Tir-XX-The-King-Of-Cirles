using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tir1.@class
{
    internal class time
    {
        public int m { get; set; }
        public int s { set; get; }
        public int ms { set; get; }
        public time(int m, int s, int ms)
        {
            this.m = m;
            this.s = s;
            this.ms = ms;
        }

        public time(int s, int ms = 0)
        {
            m = s / 60;
            this.s = s % 60;
            this.ms = ms;
        }

        public time(double t)
        {
            m = (int)t / 60;
            s = (int)t % 60;
            ms = (int)((t - (int)t) * 1000);
        }

        public time(TimeSpan t)
        {
            m = t.Minutes;
            s = t.Seconds;
            ms = t.Milliseconds;
        }

        public static explicit operator TimeSpan(time t)
        {
            return new TimeSpan(0, 0, t.m, t.s, t.ms);
        }
        public int GetSeconds()
        {
            return m * 60 + s;
        }

        public int GetMSeconds()
        {
            return GetSeconds() * 1000 + ms;
        }
        public string ToString()
        {
            if (m == 0)
                return s.ToString();
            else
                return m.ToString() + ':' + s.ToString();
        }
        public string ToStringMS()
        {
            if (m == 0)
                return s.ToString() + "." + ms.ToString();
            else
                return m.ToString() + ':' + s.ToString() + "." + ms.ToString();
        }
    }
}
