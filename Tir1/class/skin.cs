using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Tir1.@class
{
    public class skin
    {
        public string name { set; get; }
        public string description { set; get; }
        public string path { set; get; }
        public string rarity { set; get; }
        public bool have { set; get; }
        [JsonConstructor]
        public skin(string name, string description, string path, string rarity, bool have)
        {
            this.name = name;
            this.path = path;
            this.rarity = rarity;
            this.have = have;
            this.description = description;
        }
        public skin()
        {

        }
        public int GetRarityInt()
        {
            int i = -1;
            if (rarity == "Стандартний скін")
                i = 0;
            if (rarity == "Рідкісний скін")
                i = 1;
            if (rarity == "Супер-рідкісний скін")
                i = 2;
            if (rarity == "Епічний скін")
                i = 3;
            if (rarity == "Міфічний скін")
                i = 4;
            if (rarity == "Легендарний скін")
                i = 5;
            return i;
        }
        public Color GetRarityColor()
        {
            Color c = Color.White;
            if (rarity == "Стандартний скін")
                c = Color.Empty;
            if (rarity == "Рідкісний скін")
                c = Color.LightGreen;
            if (rarity == "Супер-рідкісний скін")
                c = Color.LightBlue;
            if (rarity == "Епічний скін")
                c = Color.MediumPurple;
            if (rarity == "Міфічний скін")
                c = Color.Red;
            if (rarity == "Легендарний скін")
                c = Color.Yellow;
            return c;
        }
        public Image GetImg()
        {
            return Image.FromFile(path);
        }
        public new object Clone()
        {
            return new skin(name, description, path, rarity, have);
        }
    }
}
