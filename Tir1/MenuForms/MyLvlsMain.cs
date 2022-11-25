using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class MyLvlsMain : KryptonForm
    {
        account ac;
        public bool closegame = false;
        bool back = false;
        int type;
        FileInfo[] files;
        KryptonButton[] buttons;
        public MyLvlsMain(int type)
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            this.type = type;
            ac = new account();
            InitializeComponent();
            Buttons("");
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text == "🔍")
                Buttons("");
            else
                Buttons(NameBox.Text);

        }

        public void Buttons(string p)
        {
            if (p == "🔍") p = "";
            if (type == 0)
                files = new DirectoryInfo("levels/").GetFiles();
            else
                files = new DirectoryInfo("UsersLvls/").GetFiles();
            ac = new account();
            if (buttons != null)
                for (int i = buttons.Length - 1; i >= 0 ; i--)
                    buttons[i].Dispose();
            List<FileInfo> fs = new List<FileInfo>();
            if (type == 0)
                for (int i = 0; i < ac.mylvls.Count; i++)
                {
                    if (ac.mylvls[i].name.Contains(p))
                        for (int i1 = 0; i1 < files.Length; i1++)
                            if (files[i1].Name.Substring(0, files[i1].Name.Length - 5) == ac.mylvls[i].name)
                            {
                                fs.Add(files[i1]);
                                break;
                            }
                }
            else if (type == 1)
                for (int i1 = 0; i1 < files.Length; i1++)
                    if (files[i1].Name.Contains(p) && files[i1].Name.Contains(".json"))
                        fs.Add(files[i1]);
            if (type == 0)
                buttons = new KryptonButton[fs.Count + 1];
            else
                buttons = new KryptonButton[fs.Count];
            int top = 120;
            nLabel.Text = "Знайдено рівнів: " + fs.Count.ToString();
            if (fs.Count == 0) nLabel.Text = "Не знайдено жодного рівня :(";
            for (int i = 0; i < fs.Count; i++)
            {
                buttons[i] = new KryptonButton();
                buttons[i].Left = 10;
                buttons[i].Top = 120 + i * 90;
                buttons[i].Size = new Size(460,80);
                buttons[i].Name = fs[i].Name;
                buttons[i].Click += ButtonOnClick;
                buttons[i].Text = fs[i].Name.Substring(0, fs[i].Name.Length - 5);
                buttons[i].StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                buton.GetBut(buttons[i], osulvl.GetRarityLvl(fs[i].FullName), 20);
                this.Controls.Add(buttons[i]);
                top += buttons[i].Height + 10;
            }
            if (type == 0)
            {
                int i = fs.Count;
                buttons[i] = new KryptonButton();
                buttons[i].Left = 10;
                buttons[i].Top = 120 + i * 90;
                buttons[i].Size = new Size(460, 80);
                buttons[i].Name = "create";
                buttons[i].Click += CreateButtonOnClick;
                buttons[i].Text = "Створити новий рівень";
                buttons[i].OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                buttons[i].OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
                buttons[i].OverrideDefault.Border.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].OverrideDefault.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                buttons[i].OverrideDefault.Border.Rounding = 20;
                buttons[i].OverrideDefault.Border.Width = 1;
                buttons[i].OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                buttons[i].PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
                buttons[i].StateCommon.Back.Color1 = System.Drawing.Color.White;
                buttons[i].StateCommon.Back.Color2 = System.Drawing.Color.White;
                buttons[i].StateCommon.Border.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].StateCommon.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                buttons[i].StateCommon.Border.Rounding = 20;
                buttons[i].StateCommon.Border.Width = 1;
                buttons[i].StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                buttons[i].StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
                buttons[i].StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
                buttons[i].StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                buttons[i].StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateDisabled.Border.Rounding = 20;
                buttons[i].StateDisabled.Border.Width = 1;
                buttons[i].StateDisabled.Content.Padding = new System.Windows.Forms.Padding(-1, 1, -1, -1);
                buttons[i].StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateNormal.Border.Rounding = 20;
                buttons[i].StateNormal.Border.Width = 1;
                buttons[i].StateNormal.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                buttons[i].StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                buttons[i].StatePressed.Back.ColorAngle = 135F;
                buttons[i].StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
                buttons[i].StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
                buttons[i].StatePressed.Border.ColorAngle = 135F;
                buttons[i].StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StatePressed.Border.Rounding = 20;
                buttons[i].StatePressed.Border.Width = 1;
                buttons[i].StatePressed.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -1);
                buttons[i].StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
                buttons[i].StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
                buttons[i].StateTracking.Back.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].StateTracking.Back.ColorAngle = 135F;
                buttons[i].StateTracking.Border.Color1 = System.Drawing.Color.SkyBlue;
                buttons[i].StateTracking.Border.Color2 = System.Drawing.Color.CornflowerBlue;
                buttons[i].StateTracking.Border.ColorAngle = 135F;
                buttons[i].StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
                buttons[i].StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
                buttons[i].StateTracking.Border.Rounding = 20;
                buttons[i].StateTracking.Border.Width = 1;
                buttons[i].StateTracking.Content.Padding = new System.Windows.Forms.Padding(5, 2, -1, -1);
                buttons[i].StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
                buttons[i].StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
                this.Controls.Add(buttons[i]);
                top += buttons[i].Height + 10;
            }
        }
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var but = (KryptonButton)sender;
            osulvl? olvl;
            string path;
            if (type == 0) path = "levels/" + but.Name;
            else path = "UsersLvls/" + but.Name;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                olvl = JsonSerializer.Deserialize<osulvl>(fs);
            }
            bool fl = false;
            if (type == 0) fl = true;
            LvlForm f = new LvlForm(olvl, fl);
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                closegame = true;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            Buttons(NameBox.Text);
            this.Show();
        }

        private void CreateButtonOnClick(object sender, EventArgs eventArgs)
        {
            CreateMap f = new CreateMap();
            this.Hide();
            f.ShowDialog();
            if (f.closegame)
            {
                closegame = true;
                f.Close();
                this.Close();
                return;
            }
            f.Close();
            Buttons(NameBox.Text);
            this.Show();
        }

        private void MyLvlsMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) closegame = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameBox.StateCommon.Content.Color1 = Color.Black;
            if (NameBox.Text == "🔍")
                NameBox.Text = "";
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.StateCommon.Content.Color1 = Color.Gray;
                NameBox.Text = "🔍";
            }
        }
    }
}
