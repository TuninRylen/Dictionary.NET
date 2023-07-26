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
    public partial class FormViewer : Form
    {

        public int Id;
        public string wordTr;
        public string wordEng;
        public string wordTrAc;
        public string wordEngAc;
        public string fileLocation;

        public FormViewer()
        {
            InitializeComponent();
        }

        private void FormViewer_Load(object sender, EventArgs e)
        {
            txt_WordTr.Text = wordTr;
            txt_WordTrAc.Text = wordTrAc;
            txt_WordEng.Text = wordEng;
            txt_WordEngAc.Text = wordEngAc;
            pictureBox1.ImageLocation = fileLocation;
        }
    }
}
