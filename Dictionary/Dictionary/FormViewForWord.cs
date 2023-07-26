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
    public partial class SaveMenu : Form
    {
        FormView view = new FormView();
        Words Word = new Words();
        ProductDal ProductDal = new ProductDal();
        ImageManagament ImageManagament = new ImageManagament();

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
            Word.Id = Id;
            Word.WordEng = txt_WordEng.Text;
            Word.WordTr = txt_WordTr.Text;
            Word.WordEngAc = txt_WordEngAc.Text;
            Word.WordTrAc = txt_WordTrAc.Text;
            Word.ImgFileLocation = pictureBox1.ImageLocation;

            ProductDal.Update(Word);

            MessageBox.Show("BAŞARIYLA KAYDEDİLDİ !!");

            this.Close();

            view.refresh();
        }

        private void SaveMenu_Load(object sender, EventArgs e)
        {
            txt_WordTr.Text = wordTr;
            txt_WordTrAc.Text = wordTrAc;
            txt_WordEng.Text = wordEng;
            txt_WordEngAc.Text = wordEngAc;
            pictureBox1.ImageLocation = fileLocation;
        }
    }
}
