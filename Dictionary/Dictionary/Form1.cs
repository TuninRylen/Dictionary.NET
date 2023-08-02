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
    public partial class Form1 : Form
    {
        public Point LocationPoint;
        FormView formView = new FormView();
        Add add = new Add();

        public int Id;
        public string wordTr;
        public string wordEng;
        public string wordTrAc;
        public string wordEngAc;
        public string fileLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            WordsDal productDal = new WordsDal();
            
            List<Words> words = new List<Words>();
            words = productDal.GetAll();

           
            int sayı = random.Next(words.Count);

            Id = words[sayı].Id;
            wordEng = words[sayı].WordEng;
            wordTr = words[sayı].WordTr;
            wordEngAc = words[sayı].WordEngAc;
            wordTrAc = words[sayı].WordTrAc;
            fileLocation = words[sayı].ImgFileLocation;

            textBox1.Text = $"{words[sayı].WordTr}-{words[sayı].WordEng}";
            this.Location = LocationPoint;
        }   

        private void button1_Click(object sender, EventArgs e)
        {          
            formView.LocationPoint = this.Location;
            this.Hide();

            formView.FormClosed += (s, args) => this.Close();
            formView.Show();
            formView.Focus();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            add.LocationPoint = this.Location;
            this.Hide();

            add.FormClosed += (s, args) => this.Close();
            add.Show();
            add.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormViewer formViewer = new FormViewer();
            formViewer.LocationPoint = this.Location;
            formViewer.WhichForm = "Menu";

            formViewer.Id = Id;
            formViewer.wordEng= wordEng;
            formViewer.wordTrAc = wordTrAc;
            formViewer.wordTr = wordTr;
            formViewer.wordEngAc = wordEngAc;   
            formViewer.fileLocation = fileLocation;

            formViewer.LocationPoint = this.Location;
            this.Hide();

            formViewer.FormClosed += (s, args) => this.Close();
            formViewer.Show();
            formViewer.Focus();

        }
    }
}
