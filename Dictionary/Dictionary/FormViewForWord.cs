using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class SaveMenu : Form
    {
        Words Word = new Words();
        WordsDal WordsDal = new WordsDal();
        ImageManagament ImageManagament = new ImageManagament();

        public Point LocationPoint;
        public int Id;
        public string wordTr;
        public string wordEng;
        public string wordTrAc;
        public string wordEngAc;
        public string fileLocation;

        public SaveMenu()
        {
            InitializeComponent();
        }

        private void btn_FileLoad_Click(object sender, EventArgs e)
        {
            ImageManagament.AddImage(pictureBox1);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_WordEng.Text == "" || txt_WordTr.Text == "")
            {
                MessageBox.Show("BOŞ KUTUCUK BIRAKMAYINIZ !! \n\nDO NOT LEAVE EMPTY BOXES!!");
            }
            else
            {
                Word.Id = Id;
                Word.WordEng = txt_WordEng.Text;
                Word.WordTr = txt_WordTr.Text;      
                Word.WordEngAc = txt_WordEngAc.Text;
                Word.WordTrAc = txt_WordTrAc.Text;
                Word.ImgFileLocation = pictureBox1.ImageLocation;
                WordsDal.Update(Word);
                MessageBox.Show("BAŞARIYLA KAYDEDİLDİ !! \n\nSAVE SUCCESSFULLY!!");
            }
        }


        private void SaveMenu_Load(object sender, EventArgs e)
        {
            this.Location = LocationPoint;
            txt_WordTr.Text = wordTr;
            txt_WordTrAc.Text = wordTrAc;
            txt_WordEng.Text = wordEng;
            txt_WordEngAc.Text = wordEngAc;
            pictureBox1.ImageLocation = fileLocation;
        }

        private void SaveMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormView formView = new FormView();
            formView.LocationPoint = this.Location;
            this.Hide();

            formView.FormClosed += (s, args) => this.Close();
            formView.Show();
            formView.Focus();
        }

        private void SaveMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
