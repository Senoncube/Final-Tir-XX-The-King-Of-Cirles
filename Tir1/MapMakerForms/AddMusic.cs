using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class AddMusic : KryptonForm
    {
        public bool closegame = false;
        bool openfile;
        string fname, filepath;
        WaveStream ws;
        public AddMusic()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            ofd.Filter = "Music (*.mp3, *.wav)|*.mp3;*.wav|All (*.*)|*.*";
            openfile = false;
        }

        private void OFDbutton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SetFile(ofd.FileName);
            }
        }
        public void SetFile(string s)
        {
            try
            {
                ws = new AudioFileReader(s);
            }
            catch
            {
                openfile = false;
                FileNameLabel.ForeColor = Color.Red;
                FileNameLabel.Text = "Файл не вибрано";
                MessageBox.Show("Файл неправильного формату!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            filepath = s;
            openfile = true;
            FileNameLabel.ForeColor = Color.Black;
            for (int i = s.Length - 1; i >= 0; i--)
                if (s[i] == '\\')
                {
                    fname = s.Substring(i + 1, s.Length - i - 1);
                    break;
                }
            if (fname.Length > 30)
                FileNameLabel.Text = fname.Substring(0, 30) + "...";
            else
                FileNameLabel.Text = fname;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (openfile)
            {
                System.IO.File.Copy(filepath, "music/" + fname, true);
                this.Close();
            }
            else
                MessageBox.Show("Файл не обрано!","Помилка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void AddMusic_FormClosed(object sender, FormClosedEventArgs e)
        {
            closegame = true;
        }

        private void AddMusic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void AddMusic_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (s.Length > 1)
            {
                MessageBox.Show("Ви перенесли більше чім один файл!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetFile(s[0]);
        }
    }
}
