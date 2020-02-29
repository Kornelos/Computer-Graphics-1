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
        Image originalImg;
        Filters filters = new Filters();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string filename;

            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png *.bmp";

            filename = openFileDialog1.FileName;

            img = Image.FromFile(filename);
            originalImg = img;
            pictureBox1.Image = img;
            pictureBox2.Image = originalImg;
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

        private void revertButton_Click(object sender, EventArgs e)
        {
            img = originalImg;
            pictureBox1.Image = img;
        }
    }
}
