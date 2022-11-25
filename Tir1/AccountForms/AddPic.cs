using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tir1.@class;
using ComponentFactory.Krypton.Toolkit;

namespace Tir1
{
    public partial class AddPic : KryptonForm
    {
        public bool openfile;
        string fname;
        public string path;
        Image ing;
        bool back = false;
        public AddPic()
        {
            this.Palette = new KryptoPaleta().kryptonPalette1;
            InitializeComponent();
            ofd.Filter = "Image (*.jpg, *.png)|*.jpg;*.png|All (*.*)|*.*";
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
                ing = Image.FromFile(s);
            }
            catch
            {
                openfile = false;
                FileNameLabel.ForeColor = Color.Red;
                FileNameLabel.Visible = true;
                pictureBox1.Visible = false;
                FileNameLabel.Text = "Файл не вибрано";
                button2.Text = "Обрати";
                MessageBox.Show("Файл неправильного формату!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            openfile = true;
            FileNameLabel.ForeColor = Color.Black;
            for (int i = s.Length - 1; i >= 0; i--)
                if (s[i] == '\\')
                {
                    fname = s.Substring(i + 1, s.Length - i - 1);
                    break;
                }
            FileNameLabel.Visible = false;
            pictureBox1.Visible = true;
            pictureBox1.Image = ing;
            button2.Text = "Змінити";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (openfile)
            {
                if (!File.Exists("pictures/" + fname))
                    System.IO.File.Copy(ofd.FileName, "pictures/" + fname, true);
                path = "pictures/" + fname;
                back = true;
                this.Close();
            }
            else
                MessageBox.Show("Файл не обрано!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddPic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!back) openfile = false;
        }

        private void AddPic_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (s.Length > 1)
            {
                MessageBox.Show("Ви перенесли більше чім один файл!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetFile(s[0]);
        }

        private void AddPic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
