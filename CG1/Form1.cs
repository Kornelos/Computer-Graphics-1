using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG1
{
    public partial class Form1 : Form
    {

        Image img;
        Filters filters = new Filters();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string filename;

            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "&quot; JPEG files| *.jpg | PNG files | *.png | GIF Files | *.gif | TIFF Files | *.tif | BMP Files | *.bmp & quot" ;

            filename = openFileDialog1.FileName;

            img = Image.FromFile(filename);
            pictureBox1.Image = img;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.Save(@"result.jpeg", ImageFormat.Jpeg);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(img == null)
            {
                MessageBox.Show("Load image first!");
                return;
            }

          foreach (var filter in filterCheckedListBox.CheckedItems)
            {
               img = filters.ApplyFilterNamed(filter.ToString(), img);
               pictureBox1.Image = img;
            }  
            
        }
    }
}
