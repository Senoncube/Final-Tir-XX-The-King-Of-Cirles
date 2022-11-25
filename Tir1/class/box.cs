using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tir1.@class
{
    public class box
    {
        public List<skin> skins { get; set; }
        public double[] rarity { set; get; }
        public box(List<skin> skins, double[] rarity)
        {
            this.skins = skins;
            this.rarity = rarity;
        }
        public box()
        {
            this.rarity = new double[5];
            rarity[0] = 0.3;
            rarity[1] = 0.2;
            rarity[2] = 0.1;
            rarity[3] = 0.04;
            rarity[4] = 0.01;
        }
        public skin OpenBox()
        {
            Random r = new Random();
            double res = r.NextDouble();
            string resstr;
            if (res < rarity[4])
                resstr = "Легендарний скін";
            else if (res < rarity[4] + rarity[3])
                resstr = "Міфічний скін";
            else if (res < rarity[4] + rarity[3] + rarity[2])
                resstr = "Епічний скін";
            else if (res < rarity[4] + rarity[3] + rarity[2] + rarity[1])
                resstr = "Супер-рідкісний скін";
            else if (res < rarity[4] + rarity[3] + rarity[2] + rarity[1] + rarity[0])
                resstr = "Рідкісний скін";
            else
                resstr = "Стандартний скін";
            int s = 0;
            for (int i = 0; i < skins.Count; i++)
                if (skins[i].rarity == resstr) s++;
            int rs = r.Next(s) + 1;
            s = 0;
            skin sk = new skin();
            sk.name = resstr;
            for (int i = 0; i < skins.Count; i++)
            {
                if (skins[i].rarity == resstr) s++;
                if (s == rs)
                {
                    sk = skins[i];
                    return sk;
                }
            }
            return sk;
        }
    }
}
