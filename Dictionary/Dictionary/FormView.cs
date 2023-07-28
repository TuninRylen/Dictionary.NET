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
    public partial class FormView : Form
    {
        ProductDal product = new ProductDal();
        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            
            dataGridCreater();

        }

        public void dataGridCreater()
        {
            dataGridView1.DataSource = product.GetAll();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["WordTrAc"].Visible = false;
            dataGridView1.Columns["WordEngAc"].Visible = false;
            dataGridView1.Columns["ImgFileLocation"].Visible = false;
            dataGridView1.Columns[0].Width = 70;

            ButtonEkle();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridCreater();
        }
        public void ButtonEkle()
        {
            DataGridViewLinkColumn EditLink = new DataGridViewLinkColumn();

            EditLink.UseColumnTextForLinkValue = true;
            EditLink.HeaderText = "Güncelle";
            EditLink.DataPropertyName = "edit";
            EditLink.LinkBehavior = LinkBehavior.SystemDefault;
            EditLink.Text = "Güncelle";

            DataGridViewLinkColumn DeleteLink = new DataGridViewLinkColumn();

            DeleteLink.UseColumnTextForLinkValue = true;
            DeleteLink.HeaderText = "Sil";
            DeleteLink.DataPropertyName = "delete";
            DeleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            DeleteLink.Text = "Sil";

            DataGridViewLinkColumn ViewLink = new DataGridViewLinkColumn();

            ViewLink.UseColumnTextForLinkValue = true;
            ViewLink.HeaderText = "Görüntüle";
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
                product.Delete(Id);

                refresh();

            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void FormView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
