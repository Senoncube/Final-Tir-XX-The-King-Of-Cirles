using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Tir1.@class
{
    public class account
    {
        public int id { get; set; }
        public string nick { set; get; }
        public string password { set; get; }
        public string picpath { set; get; }
        public int coins { set; get; }
        public List<lvlinfo> lvls { set; get; }
        public int coinscount { set; get; }
        public DateTime date { set; get; }
        public int rating { set; get; }
        public List<skin> skins { set; get; }
        public int skini { set; get; }
        public List<lvlinfo> mylvls { set; get; }
        public List<string> friends { set; get; }
        public int osurecord { set; get; }
        public int osuatt { set; get; }
        public int aimrecord { set; get; }
        public int aimatt { set; get; }
        public int testrecord { set; get; }
        public int testatt { set; get; }

        [JsonConstructor]
        public account(string nick, string password, string picpath)
        {
            id = new DirectoryInfo("accounts/").GetFiles().Length;
            this.nick = nick;
            this.password = password;
            this.picpath = picpath;
            coins = 0;
            lvls = new List<lvlinfo>();
            coinscount = 0;
            date = DateTime.Today;
            rating = 0;
            SetSkins();
            mylvls = new List<lvlinfo>();
            friends = new List<string>();
            osurecord = 0;
            osuatt = 0;
            aimrecord = 0;
            aimatt = 0;
            testrecord = 0;
            testatt = 0;
        }
        public void SetSkins()
        {
            skins = new List<skin>();
            skini = 0;
            skins.Add(new skin("circle", "Скін круга з відблиском", "skins/redcircle2.png", "Стандартний скін", true));
            skins.Add(new skin("leon", "Скін Леона", "skins/leon.png", "Рідкісний скін", false));
            skins.Add(new skin("kaguya", "Скін Шиномія Кагуя", "skins/kaguya.png", "Легендарний скін", false));
            skins.Add(new skin("leon_ghoul", "Скін Леон-Гуль", "skins/leon_ghoul.png", "Легендарний скін", false));
            skins.Add(new skin("billy", "Скін Біллі Херінгтон", "skins/billy.png", "Епічний скін", false));
            skins.Add(new skin("amogus", "Скін амогус", "skins/amogus.png", "Рідкісний скін", false));
            skins.Add(new skin("amogusspike", "Скін Спайк-Амогус", "skins/amogusspike.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("chicha", "Скін Чіча-дедінсайд", "skins/chicha.png", "Міфічний скін", false));
            skins.Add(new skin("chika", "Скін Чіка Фудзівара", "skins/chika.png", "Міфічний скін", false));
            skins.Add(new skin("dio", "Скін Діо Брандо", "skins/dio.png", "Епічний скін", false));
            skins.Add(new skin("gachiprimo", "Скін Гачі-Прімо", "skins/gachiprimo.png", "Міфічний скін", false));
            skins.Add(new skin("geometrydash", "Скін кубик із Геометрі Деш", "skins/geometrydash.png", "Стандартний скін", false));
            skins.Add(new skin("godusopp", "Скін Бог Усоп", "skins/godusopp.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("hayasaka", "Скін Ай Хаясака", "skins/hayasaka.png", "Легендарний скін", false));
            skins.Add(new skin("leon_ghoul2", "Скін Леон-Гуль 2", "skins/leon_ghoul2.png", "Епічний скін", false));
            skins.Add(new skin("leon2", "Скін Леон 2", "skins/leon2.png", "Міфічний скін", false));
            skins.Add(new skin("nazik", "Скін Назік", "skins/nazik.png", "Епічний скін", false));
            skins.Add(new skin("pudge", "Скін Падге", "skins/pudge.png", "Рідкісний скін", false));
            skins.Add(new skin("ricardo", "Скін Рікардо Мілос", "skins/ricardo.png", "Рідкісний скін", false));
            skins.Add(new skin("spidwagon", "Скін Роберт Едвард О. Спідвагон", "skins/spidwagon.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("steve", "Скін Стів з Майнкрафта", "skins/steve.png", "Стандартний скін", false));
            skins.Add(new skin("anonimus", "Скін анонімус", "skins/anonimus.png", "Стандартний скін", false));
            skins.Add(new skin("anonimus2", "Скін анонімус 2", "skins/anonimus2.png", "Стандартний скін", false));
            skins.Add(new skin("gigamouse", "Скін Гіга Мікі Маус", "skins/gigamouse.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("gigachad", "Скін Гігачад", "skins/gigachad.png", "Рідкісний скін", false));
            skins.Add(new skin("hayasaka2", "Скін Ай Хаясака 2", "skins/hayasaka2.png", "Епічний скін", false));
            skins.Add(new skin("hayasaka3", "Скін Ай Хаясака 3", "skins/hayasaka3.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("hayasaka4", "Скін Ай Хаясака 4", "skins/hayasaka4.png", "Епічний скін", false));
            skins.Add(new skin("hayasaka5", "Скін Ай Хаясака 5", "skins/hayasaka5.png", "Легендарний скін", false));
            skins.Add(new skin("hayasaka6", "Скін Ай Хаясака 6", "skins/hayasaka6.png", "Міфічний скін", false));
            skins.Add(new skin("hayasaka7", "Скін Ай Хаясака 7", "skins/hayasaka7.png", "Рідкісний скін", false));
            skins.Add(new skin("hayasaka8", "Скін Ай Хаясака 8", "skins/hayasaka8.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("hayasaka9", "Скін Ай Хаясака 9", "skins/hayasaka9.png", "Міфічний скін", false));
            skins.Add(new skin("hayasaka10", "Скін Ай Хаясака 10", "skins/hayasaka10.png", "Стандартний скін", false));
            skins.Add(new skin("isigami", "Скін Ю Ісігамі", "skins/isigami.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("kaguya2", "Скін Шиномія Кагуя 2", "skins/kaguya2.png", "Епічний скін", false));
            skins.Add(new skin("kaguya3", "Скін Шиномія Кагуя 3", "skins/kaguya3.png", "Легендарний скін", false));
            skins.Add(new skin("kaguya4", "Скін Шиномія Кагуя 4", "skins/kaguya4.png", "Міфічний скін", false));
            skins.Add(new skin("kaguya5", "Скін Шиномія Кагуя 5", "skins/kaguya5.png", "Міфічний скін", false));
            skins.Add(new skin("kaguyachica", "Скін Шиномія Кагуя і Чіка Фудзівара", "skins/kaguyachica.png", "Міфічний скін", false));
            skins.Add(new skin("kaguyahayasaka", "Скін Шиномія Кагуя і Ай Хаясака", "skins/kaguyahayasaka.png", "Легендарний скін", false));
            skins.Add(new skin("mishkfrede", "Скін Мішк Фреде", "skins/mishkfrede.png", "Епічний скін", false));
            skins.Add(new skin("miuki", "Скін Міюкі Широгане", "skins/miuki.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("negr", "Скін негр", "skins/negr.png", "Стандартний скін", false));
            skins.Add(new skin("negr2", "Скін негр 2", "skins/negr2.png", "Легендарний скін", false));
            skins.Add(new skin("pikblind", "Скін Томас Шелбі і Чіка Фудзівара", "skins/pikblind.png", "Епічний скін", false));
            skins.Add(new skin("pivo", "Скін Пивозавр", "skins/pivo.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("pon", "Скін пон", "skins/pon.png", "Стандартний скін", false));
            skins.Add(new skin("roxy", "Скін Роксі Мігурдія", "skins/roxy.png", "Стандартний скін", false));
            skins.Add(new skin("roxy2", "Скін Роксі Мігурдія 2", "skins/roxy2.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("roxy3", "Скін Роксі Мігурдія 3", "skins/roxy3.png", "Епічний скін", false));
            skins.Add(new skin("roxy4", "Скін Роксі Мігурдія 4", "skins/roxy4.png", "Легендарний скін", false));
            skins.Add(new skin("roxy5", "Скін Роксі Мігурдія 5", "skins/roxy5.png", "Міфічний скін", false));
            skins.Add(new skin("skala", "Скін Скала Дуейн Джонсон", "skins/skala.png", "Стандартний скін", false));
            skins.Add(new skin("superidol", "Скін Супер Айдол", "skins/superidol.png", "Міфічний скін", false));
            skins.Add(new skin("trollface", "Скін троллфейс", "skins/trollface.png", "Рідкісний скін", false));
            skins.Add(new skin("yes", "Скін Да.", "skins/yes.png", "Стандартний скін", false));
            skins.Add(new skin("extreme", "Скін екстрім демон", "skins/extreme.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("extreme2", "Скін екстрім демон 2", "skins/extreme2.png", "Епічний скін", false));
            skins.Add(new skin("extreme3", "Скін екстрім демон 3", "skins/extreme3.png", "Міфічний скін", false));
            skins.Add(new skin("billy2", "Скін Біллі Херінгтон", "skins/billy2.png", "Легендарний скін", false));
            skins.Add(new skin("ivan", "Скін ІVAN", "skins/ivan.png", "Міфічний скін", false));
            skins.Add(new skin("van1", "Скін Ван Даркхолм 2", "skins/van1.png", "Епічний скін", false));
            skins.Add(new skin("gachibrawl", "Скін Гачі старс", "skins/gachibrawl.png", "Епічний скін", false));
            skins.Add(new skin("gachi1", "Скін гачімучі", "skins/gachi1.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("gachi2", "Скін гачімучі 2", "skins/gachi2.png", "Супер-рідкісний скін", false));
            skins.Add(new skin("van", "Скін Ван Даркхолм", "skins/van.png", "Стандартний скін", false));
            skins.Add(new skin("negr3", "Скін негр 3", "skins/negr3.png", "Рідкісний скін", false));
        }
        public void GetSkins()
        {
            for (int i = 0; i < skins.Count; i++)
                skins[i].have = true;
        }
        public int GetLvl(osulvl lvl)
        {
            int j = 0;
            bool fl = false;
            for (j = 0; j < lvls.Count; j++)
                if (lvls[j].name == lvl.name)
                {
                    if (lvls[j].coinclick.Length != lvl.circles.Count)
                    {
                        lvls[j].coinclick = new bool[lvl.circles.Count];
                    }
                    fl = true;
                    break;
                }
            if (!fl)
            {
                j = lvls.Count();
                lvls.Add(new lvlinfo(lvl.name, lvl.circles.Count));
            }
            return j;
        }
        public account()
        {
            account? ac;
            string path = "account.json";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                ac = JsonSerializer.Deserialize<account>(fs);
            }
            nick = ac.nick;
            password = ac.password;
            picpath = ac.picpath;
            coins = ac.coins;
            lvls = ac.lvls;
            coinscount = ac.coinscount;
            date = ac.date;
            rating = ac.rating;
            skins = ac.skins;
            skini = ac.skini;
            mylvls = ac.mylvls;
            friends = ac.friends;
            osurecord = ac.osurecord;
            osuatt = ac.osuatt;
            aimrecord = ac.aimrecord;
            aimatt = ac.aimatt;
            testrecord = ac.testrecord;
            testatt = ac.testatt;
        }
        public int SkinId(skin s)
        {
            for (int i = 0; i < skins.Count; i++)
                if (skins[i].name == s.name)
                    return i;
            return -1;
        }
        public void AddSkin(skin s)
        {
            int i = SkinId(s);
            skins[i].have = true;
            SaveAccount();
        }
        public void DelAccount()
        {
            System.IO.File.Delete("accounts/" + nick + ".json");
        }
        public void SaveAccount()
        {
            SetAccount();
            SaveJson();
        }
        public void SetAccount()
        {
            string path = "account.json";
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, this);
            }
        }
        public void GetAccount(string name)
        {
            account? ac;
            string path = "accounts/" + name + ".json";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                ac = JsonSerializer.Deserialize<account>(fs);
            }
            nick = ac.nick;
            password = ac.password;
            picpath = ac.picpath;
            coins = ac.coins;
            lvls = ac.lvls;
            coinscount = ac.coinscount;
            date = ac.date;
            rating = ac.rating;
            skins = ac.skins;
            skini = ac.skini;
            mylvls = ac.mylvls;
            friends = ac.friends;
            osurecord = ac.osurecord;
            osuatt = ac.osuatt;
            aimrecord = ac.aimrecord;
            aimatt = ac.aimatt;
            testrecord = ac.testrecord;
            testatt = ac.testatt;
        }
        public void SaveJson()
        {
            string path = "accounts/" + nick + ".json";
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, this);
            }
        }
    }
}
