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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            label1.Text = this.Location.ToString();
        }
    }
}
