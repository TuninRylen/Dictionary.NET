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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormView formView = new FormView();
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
            Add add = new Add();
            this.Hide();

            add.FormClosed += (s, args) => this.Close();
            add.Show();
            add.Focus();
        }
    }
}
