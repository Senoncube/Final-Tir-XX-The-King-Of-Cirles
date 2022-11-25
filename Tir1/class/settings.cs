using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Tir1.@class
{
    internal class settings
    {
        public bool login { set; get; }
        public int skinid { set; get; }
        public double musicvolume { set; get; }
        public double soundvolume { set; get; }
        public Keys click1 { set; get; }
        public Keys click2 { set; get; }

        [JsonConstructor]
        public settings(bool login, int skinid, double musicvolume, double soundvolume, Keys click1, Keys click2)
        {
            this.login = login;
            this.skinid = skinid;
            this.musicvolume = musicvolume;
            this.soundvolume = soundvolume;
            this.click1 = click1;
            this.click2 = click2;
        }
        public settings()
        {
            settings? sett;
            if (File.Exists("settings.json"))
                using (FileStream fs = new FileStream("settings.json", FileMode.Open))
                {
                    sett = JsonSerializer.Deserialize<settings>(fs);
                }
            else
            {
                sett = new settings(false, 0, 1, 1, Keys.Z, Keys.X);
                sett.SaveJson();
            }
            login = sett.login;
            skinid = sett.skinid;
            musicvolume = sett.musicvolume;
            soundvolume = sett.soundvolume;
            click1 = sett.click1;
            click2 = sett.click2;
        }
        public void SaveJson()
        {
            if (File.Exists("settings.json"))
                File.Delete("settings.json");
            using (FileStream fs = new FileStream("settings.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, this);
            }
        }
        public new object Clone()
        {
            return new settings(login, skinid, musicvolume, soundvolume, click1, click2);
        }
    }
}
