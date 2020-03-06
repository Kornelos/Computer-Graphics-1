using System;
using System.Windows.Forms;

namespace CG1
{
    public partial class AddConvDialog : Form
    {
        public int rows = 0;
        public int columns = 0;
        double kernelSum = 0;
        public double[,] kernel { get; set; }
        public string name;
        public int offset;
        public int kernelAnchorCol;
        public int kernelAnchorRow;
        public ConvFilter editFilter;




        public AddConvDialog(ConvFilter editFilter)
        {
            InitializeComponent();
            this.editFilter = editFilter;
            
            
            if(editFilter != null)
            {
                fromExisting(editFilter);
            }

           
        }


        private void generateKernel_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(rowsTextBox.Text, out rows) && int.TryParse(columnsTextBox.Text, out columns))
            {
                if (rows <= 9 && rows >= 1 && (rows % 2 != 0) && columns <= 9 && columns >= 1 && (columns % 2 != 0))
                {
                    tableLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < columns; i++)
                        for(int j = 0; j < rows; j++)
                        {
                            tableLayoutPanel1.Controls.Add(new TextBox(), i, j);
                        }
                }
                else
                {
                    MessageBox.Show("Provide proper values!");
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
  
            for (int i = 0; i<columns; i++)
                for (int j = 0; j < rows; j++)
                {
                    TextBox value = (TextBox)tableLayoutPanel1.GetControlFromPosition(i, j);
                    if(double.TryParse(value.Text,out double num)){
                        kernel[i, j] = num;
                        kernelSum += num;
                    }
                    else
                    {
                        MessageBox.Show($"Provide proper value at col: {i} row: {j}");
                        return;
                    }
                }

            kernel = processKernel(kernel);
            name = nameTextBox.Text;

            try
            {
                offset = int.Parse(offsetTextBox.Text);
                kernelAnchorCol = int.Parse(anchorColTextBox.Text);
                kernelAnchorRow = int.Parse(anchorRowTextBox.Text);
                if (kernelAnchorCol > columns || kernelAnchorRow > rows)
                    throw new Exception("Kernel Anchor must be smaller than kernel size.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (kernel != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            
        }

        private double[,] processKernel(double[,] kernel)
        {
            double divisor;
            if (automaticDivisorCheckBox.Checked)
            {
                if (kernelSum != 0)
                    divisor = kernelSum;
                else
                    divisor = 1;

            }
            else
            {
                if(!double.TryParse(divisorTextBox.Text,out divisor))
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

        private void fromExisting(ConvFilter editFilter)
        {
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < editFilter.Columns; i++)
                for (int j = 0; j < editFilter.Rows; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = editFilter.Kernel[i, j].ToString();
                    tableLayoutPanel1.Controls.Add(textBox, i, j);

                }
            offsetTextBox.Text = editFilter.Offset.ToString();
            rowsTextBox.Text = editFilter.Rows.ToString();
            columnsTextBox.Text = editFilter.Columns.ToString();
            anchorColTextBox.Text = editFilter.KernelAnchorCol.ToString();
            anchorRowTextBox.Text = editFilter.KernelAnchorRow.ToString();
            nameTextBox.Text = editFilter.Name;
            columns = editFilter.Columns;
            rows = editFilter.Rows;
        }
    }
}
