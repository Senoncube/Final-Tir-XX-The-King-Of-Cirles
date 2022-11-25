using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Tir1.@class
{
    public class lvlinfo
    {
        public string name { get; set; }
        public int attcount { get; set; }
        public int clickcount { set; get; }
        public int recordsct { set; get; }
        public string recordmark { set; get; }
        public int practicerecord { set; get; }
        public string practicemark { set; get; }
        public bool complete { set; get; }
        public bool[] coinclick { set; get; }
        public int coinscount{ set; get; }
        public int coinclickcout { set; get; }
        public bool gol { set; get; }

        [JsonConstructor]
        public lvlinfo(string name, int attcount, int clickcount, int recordsct, string recordmark, int practicerecord, string practicemark, bool complete, bool[] coinclick, bool gol)
        {
            this.name = name;
            this.attcount = attcount;
            this.clickcount = clickcount;
            this.recordsct = recordsct;
            this.recordmark = recordmark;
            this.practicerecord = practicerecord;
            this.practicemark = practicemark;
            this.complete = complete;
            this.coinclick = coinclick;
            this.gol = gol;
        }
        public lvlinfo(string name, int ncircles)
        {
            this.name = name;
            attcount = 0;
            clickcount = 0;
            recordsct = 0;
            recordmark = "-";
            practicerecord = 0;
            practicemark = "-";
            complete = false;
            coinclick = new bool[ncircles];
            for (int i = 0; i < ncircles; i++) coinclick[i] = false;
            coinscount = 0;
            coinclickcout = 0;
            gol = false;
        }
        public new object Clone()
        {
            lvlinfo lvl = new lvlinfo(this.name, this.attcount, this.clickcount, this.recordsct,
                this.recordmark, this.practicerecord, this.practicemark, this.complete, (bool[])this.coinclick.Clone(), this.gol);
            lvl.coinscount = this.coinscount;
            lvl.coinclickcout = this.coinclickcout;
            return lvl;
        }
    }
}
