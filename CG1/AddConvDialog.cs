using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG1
{
    public partial class AddConvDialog : Form
    {
        public int rows = 0;
        public int columns = 0;
        int kernelSum = 0;
        public double[,] kernel { get; set; }
        public string name;
        public AddConvDialog()
        {
            InitializeComponent();
        }

        private void generateKernel_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(rowsTextBox.Text, out rows) && int.TryParse(columnsTextBox.Text, out columns))
            {
                if (rows <= 9 || rows >= 1 || (rows % 2 != 0) || columns <= 9 || columns >= 1 || (columns % 2 != 0))
                {
                    tableLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < columns; i++)
                        for(int j = 0; j < rows; j++)
                        {
                            tableLayoutPanel1.Controls.Add(new TextBox(), i, j);
                        }
                }
            }
            else
            {
                MessageBox.Show("Provide proper values!");
            }
                    
        }

        private void saveKernelButton_Click(object sender, EventArgs e)
        {
            kernel = new double[columns, rows];

            for(int i = 0; i<columns; i++)
                for (int j = 0; j < rows; j++)
                {
                    TextBox value = (TextBox)tableLayoutPanel1.GetControlFromPosition(i, j);
                    if(int.TryParse(value.Text,out int num)){
                        kernel[i, j] = num;
                        kernelSum += num;
                    }
                    else
                    {
                        MessageBox.Show("Provide proper values!");
                    }
                }

            kernel = processKernel(kernel);
            name = nameTextBox.Text;
            if(kernel != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            
        }

        private double[,] processKernel(double[,] kernel)
        {
            int divisor;
            if (autoDivisorRadioButton.Checked)
            {
                if (kernelSum != 0)
                    divisor = kernelSum;
                else
                    divisor = 1;

            }
            else
            {
                if(!int.TryParse(divisorTextBox.Text, out divisor))
                {
                    MessageBox.Show("Provide proper divisor!");
                    return null;
                }
                    
                if(divisor == 0)
                {
                    MessageBox.Show("Provide proper divisor!");
                    return null;
                }
                   
            }

            for (int i = 0; i < columns; i++)
                for (int j = 0; j < rows; j++)
                {
                    kernel[i, j] /= divisor;
                }

            return kernel;
        }
    }
}
