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
            filterCheckedListBox.Items.AddRange(filters.getFilterNames());
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

        private void addConvolutionFilter_Click(object sender, EventArgs e)
        {
            
            using (var convForm = new AddConvDialog())
            {
                var result = convForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filters.addEditFilter(new ConvFilter(convForm.name, convForm.kernel,convForm.offset, convForm.columns, convForm.rows,
                                                         convForm.kernelAnchorRow, convForm.kernelAnchorCol));
                    filterCheckedListBox.Items.Add(convForm.name);
                }
            }

                
        }
    }
}
