using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public class ImageManagament
    {

        private OpenFileDialog OpenOFD()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim dosyası seç";
            DialogResult result = openFileDialog.ShowDialog();

            return openFileDialog;  
        }
        

        public void AddImage(PictureBox pictureBox)
        {
            Guid guid = Guid.NewGuid();

            string fileLocationSource = OpenOFD().FileName; 
            string fileLocationTarget = @"C:\Users\ugrst\source\repos\Dictionary\Dictionary\Images\" + guid + ".png";

            try
            {
                File.Copy(fileLocationSource, fileLocationTarget, true);
                pictureBox.ImageLocation = fileLocationTarget;
            }
            catch
            {
                MessageBox.Show("LÜTFEN BİR RESİM SEÇİNİZ!! \n\nPLASE SELECT A PİCTURE!!");
            }
        }
    }
}
