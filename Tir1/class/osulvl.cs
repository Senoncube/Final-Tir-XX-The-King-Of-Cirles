using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using Tir1.@class;

namespace Tir1.@class
{
    public class osulvl
    {
        public List<osucircle> circles { set; get; }
        public string name { set; get; }
        public double speed { set; get; }
        public double sc { set; get; }
        public double res1 { set; get; }
        public double res2 { set; get; }
        public int r { set; get; }
        public string SongName { set; get; }
        public TimeSpan timestart { set; get; }
        public int rating { set; get; }
        public int countgol { set; get; }
        public int recordsct { set; get; }
        public string recordmark { set; get; }
        public int practicerecord { set; get; }
        public string practicemark { set; get; }
        public int attcount { set; get; }
        public string path { set; get; }
        public string autor { set; get; }
        public int reward { set; get; }
        public int clickcount { set; get; }
        public skin rewardskin { set; get; }
        public int hp { set; get; }
        [JsonConstructor]
        public osulvl(List<osucircle> circles, string name, double speed, double sc, double res1, double res2, int r, string songName, string autor, int rating, int countgol)
        {
            this.circles = circles;
            this.name = name;
            this.speed = speed;
            this.sc = sc;
            this.res1 = res1;
            this.res2 = res2;
            this.r = r;
            SongName = songName;
            timestart = new TimeSpan(0, 0, 0, 0, 0);
            this.rating = rating;
            recordsct = 0;
            recordmark = "-";
            attcount = 0;
            practicerecord = 0;
            practicemark = "-";
            path = "levels/" + name + ".json";
            this.autor = autor;
            reward = 100;
            clickcount = 0;
            hp = 3;
            rewardskin = null;
            this.countgol = countgol;
        }

        public osulvl(string name)
        {
            this.name = name;
            circles = new List<osucircle>();
            speed = 0.01;
            sc = 3;
            res1 = 0.25;
            res2 = 0.5;
            r = 50;
            SongName = "";
            timestart = new TimeSpan(0, 0, 0, 0, 0);
            rating = 0;
            recordsct = 0;
            recordmark = "-";
            attcount = 0;
            practicerecord = 0;
            practicemark = "-";
            path = "levels/" + name + ".json";
            autor = "unknown";
            reward = 100;
            clickcount = 0;
            hp = 3;
            rewardskin = null;
            countgol = 0;
        }

        public static int GetRarityLvl(string path)
        {
            osulvl? lvl;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                lvl = JsonSerializer.Deserialize<osulvl>(fs);
            }
            if (lvl.countgol < 3)
                return 10;
            else if (lvl.rating <= 400)
                return 11;
            else if (lvl.rating <= 800)
                return 12;
            else if (lvl.rating <= 1200)
                return 13;
            else if (lvl.rating <= 1600)
                return 14;
            else if (lvl.rating <= 2000)
                return 15;
            else if (lvl.rating <= 2400)
                return 16;
            else if (lvl.rating <= 2800)
                return 17;
            else if (lvl.rating <= 3200)
                return 18;
            else
                return 19;
        }
        public void NewCirc(int x, int y, int vrem, byte skin = 0)
        {
            circles.Add(new osucircle(r, x, y, sc, speed, res1, res2, vrem, skin));
        }

        public void DelCirc(int i)
        {
            circles.RemoveAt(i);
            for (int j = i; j < circles.Count; j++)
                circles[j].i--;
        }
        public int LvlTIme()
        {
            int max = 0;
            for (int i = 0; i < circles.Count; i++)
                if (circles[i].GetEndTime() > max)
                    max = circles[i].GetEndTime();
            return max;
        }
        public void SaveJson()
        {
            if (path == null)
                path = "levels/" + name + ".json";
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, this);
            }
        }
    }
}
