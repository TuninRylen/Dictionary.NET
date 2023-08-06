using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class FormView : Form
    {
        WordsDal WordsDal = new WordsDal();

        public Point LocationPoint;

        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            this.Location = LocationPoint;
            dataGridView1.DataSource = WordsDal.GetAll();
            dataGridCreater();
        }

        public void dataGridCreater()
        {
            dataGridView1.Columns["WordTr"].Width = 200;
            dataGridView1.Columns["WordEng"].Width = 200;
            dataGridView1.Columns["WordTr"].HeaderText = "Türkçe Kelime";
            dataGridView1.Columns["WordEng"].HeaderText = "English Word";
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["WordTrAc"].Visible = false;
            dataGridView1.Columns["WordEngAc"].Visible = false;
            dataGridView1.Columns["ImgFileLocation"].Visible = false;
            dataGridView1.Columns[0].Width = 70;

            ButtonEkle();
        }

        public void dataClear()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();  
        }
        public void ButtonEkle()
        {
            DataGridViewLinkColumn EditLink = new DataGridViewLinkColumn();

            EditLink.UseColumnTextForLinkValue = true;
            EditLink.DataPropertyName = "edit";
            EditLink.LinkBehavior = LinkBehavior.SystemDefault;
            EditLink.Text = "Güncelle";

            DataGridViewLinkColumn DeleteLink = new DataGridViewLinkColumn();

            DeleteLink.UseColumnTextForLinkValue = true;     
            DeleteLink.DataPropertyName = "delete";
            DeleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            DeleteLink.Text = "Sil";

            DataGridViewLinkColumn ViewLink = new DataGridViewLinkColumn();

            ViewLink.UseColumnTextForLinkValue = true;    
            ViewLink.DataPropertyName = "view";
            ViewLink.LinkBehavior = LinkBehavior.SystemDefault;
            ViewLink.Text = "Görüntüle";

            dataGridView1.Columns.Add(ViewLink);
            dataGridView1.Columns.Add(EditLink);
            dataGridView1.Columns.Add(DeleteLink);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                FormViewer formVieweer = new FormViewer();
                formVieweer.LocationPoint = this.Location;
                formVieweer.WhichForm = "FormView";

                formVieweer.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                formVieweer.wordTr = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordTr"].Value);
                formVieweer.wordEng = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordEng"].Value);
                formVieweer.wordTrAc = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordTrAc"].Value); 
                formVieweer.wordEngAc = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordEngAc"].Value);
                formVieweer.fileLocation = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ImgFileLocation"].Value);

                formVieweer.Show();
                this.Hide();
            }
            else if (e.ColumnIndex == 7)
            {
                SaveMenu saveMenu = new SaveMenu();
                saveMenu.LocationPoint = this.Location;
                saveMenu.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                saveMenu.wordTr = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordTr"].Value);
                saveMenu.wordEng = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordEng"].Value);
                saveMenu.wordTrAc = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordTrAc"].Value);
                saveMenu.wordEngAc = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordEngAc"].Value);
                saveMenu.fileLocation = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ImgFileLocation"].Value);

                saveMenu.Show();
                this.Hide();
            }
            else if (e.ColumnIndex == 8)
            {
                int Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                string WordTr = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordTr"].Value);
                string WordEng = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["WordEng"].Value);
                string ImageFileLocation = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ImgFileLocation"].Value);

                DialogResult dialogResult = MessageBox.Show($"{WordTr} Kelimesini silmek istiyor musunuz?\n\nDo you want to delete the word {WordEng}?", "Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    WordsDal.Delete(Id);

                    File.Delete(ImageFileLocation);
                    dataClear();
                    dataGridView1.DataSource = WordsDal.GetAll();
                    dataGridCreater();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

                

            }
        }

        private void FormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.LocationPoint = this.Location;
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                dataClear();
                dataGridView1.DataSource = WordsDal.Search(textBox1, "WordTr");
                dataGridCreater();
            }
            else
            {
                dataClear();
                dataGridView1.DataSource = WordsDal.Search(textBox1, "WordEng");
                dataGridCreater();
            }
            
        }
    }
}
