using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tir1.@class
{
    public class result
    {
        public int sch;
        public double proc;
        public string name = "";
        public int coins { get; set; }

        public result(int sch, double proc, string name)
        {
            this.sch = sch;
            this.proc = proc;
            this.name = name;
            coins = 0;
        }
        public result(int sch, double proc)
        {
            this.sch = sch;
            this.proc = proc;
            coins = 0;
        }

        public result(int sch)
        {
            this.sch = sch;
            proc = 100;
            coins = 0;
        }

        public result()
        {
            sch = 1;
            proc = 100;
            coins = 0;
        }

        public string GetMark()
        {
            if (proc == 100) return "S";
            else if (proc >= 95) return "A";
            else if (proc >= 90) return "B";
            else if (proc >= 75) return "C";
            else if (proc >= 50) return "D";
            else if (proc >= 25) return "E";
            else return "F";
        }
    }
}
