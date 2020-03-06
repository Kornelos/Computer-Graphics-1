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
        FilterService filters = new FilterService();
        
        public Form1()
        {
            InitializeComponent();
            filterCheckedListBox.Items.AddRange(filters.getFilterNames());
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string filename;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp;";
            var result = openFileDialog1.ShowDialog();
            

            filename = openFileDialog1.FileName;
            if(result == DialogResult.OK)
            {
                img = Image.FromFile(filename);
                originalImg = img;
                pictureBox1.Image = img;
            }
            
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img.Save(@"result.jpeg", ImageFormat.Jpeg);
                MessageBox.Show("Image saved to program location.");
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
            //Check if filter is selected for edit
            ConvFilter cf = null;
            List<string> selectedFields = new List<string>();
            selectedFields.AddRange(filterCheckedListBox.CheckedItems.OfType<string>());
            if (selectedFields.Count > 0)
            {
                cf = filters.GetConvFilter(selectedFields.First());
            }
                


            using (var convForm = new AddConvDialog(cf))
            {
                var result = convForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filters.addEditFilter(new ConvFilter(convForm.name, convForm.kernel,convForm.offset, convForm.columns, convForm.rows,
                                                         convForm.kernelAnchorRow, convForm.kernelAnchorCol));
                    
                    filterCheckedListBox.Items.Add(convForm.name);
                    filterCheckedListBox.Items.Clear();
                    filterCheckedListBox.Items.AddRange(filters.getFilterNames());
                }
            }

                
        }
    }
}
