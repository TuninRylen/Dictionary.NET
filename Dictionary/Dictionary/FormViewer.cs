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
        public string WhichForm;

        public Point LocationPoint;
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
            this.Location = LocationPoint;
            txt_WordTr.Text = wordTr;
            txt_WordTrAc.Text = wordTrAc;
            txt_WordEng.Text = wordEng;
            txt_WordEngAc.Text = wordEngAc;
            pictureBox1.ImageLocation = fileLocation;
        }

        private void FormViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(WhichForm == "Menu")
            {
                Form1 form1 = new Form1();
                form1.LocationPoint = this.Location;
                this.Hide();

                form1.FormClosed += (s, args) => this.Close();
                form1.Show();
                form1.Focus();
            }
            else if(WhichForm == "FormView")
            {
                FormView formView = new FormView();
                formView.LocationPoint = this.Location;
                this.Hide();

                formView.FormClosed += (s, args) => this.Close();
                formView.Show();
                formView.Focus();
            }
            
        }
    }
}
