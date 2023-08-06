using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{

    public partial class Add : Form
    {

        Words Word = new Words();
        WordsDal WordsDal = new WordsDal();
        ImageManagament ImageManagament = new ImageManagament();

        public Point LocationPoint;
        public string wordTr;
        public string wordEng;
        public string wordTrAc;
        public string wordEngAc;
        public string fileLocation;

        public Add()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.LocationPoint = this.Location;
            this.Hide();

            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
            form1.Focus();
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
                Word.WordEng = txt_WordEng.Text;
                Word.WordTr = txt_WordTr.Text;
                Word.WordEngAc = txt_WordEngAc.Text;
                Word.WordTrAc = txt_WordTrAc.Text;
                Word.ImgFileLocation = pictureBox1.ImageLocation;
                WordsDal.Add(Word);

                MessageBox.Show("BAŞARIYLA EKLENDİ !! \n\nADD SUCCESSFULLY!!");
            }
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.Location = LocationPoint;
        }
    }
}
