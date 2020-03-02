using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG1
{
    // Model of the convolutional filter
    public class ConvFilter : Filter
    {
        public string Name { get; }
        public double[,] Kernel { get; }
        public int Rows {get;}
        public int Columns { get; }
        public int Offset { get; }
        public int KernelAnchorCol { get; }
        public int KernelAnchorRow { get; }

        public ConvFilter(string filterName, double[,] kernel, int offset, int columns, int rows,int anchorRow, int anchorCol)
        {
            Name = filterName;
            Kernel = kernel;
            Columns = columns;
            Rows = rows;
            Offset = offset;
            KernelAnchorCol = anchorCol;
            KernelAnchorRow = anchorRow;
        }

        public override string ToString()
        {
            return Name;
        }

        public Image applyFilter(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            Bitmap output = new Bitmap(image);


            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int sumR = 0;
                    int sumG = 0;
                    int sumB = 0;

                    for (int matrixY = -KernelAnchorRow; matrixY < Rows - KernelAnchorRow; matrixY++)
                        for (int matrixX = -KernelAnchorCol; matrixX < Columns - KernelAnchorCol; matrixX++)
                        {
                            // these coordinates will be outside the bitmap near all edges
                            int sourceX = x + matrixX;
                            int sourceY = y + matrixY;

                            if (sourceX < 0)
                                sourceX = 0;

                            if (sourceX >= bitmap.Width)
                                sourceX = bitmap.Width - 1;

                            if (sourceY < 0)
                                sourceY = 0;

                            if (sourceY >= bitmap.Height)
                                sourceY = bitmap.Height - 1;

                            Color color = bitmap.GetPixel(sourceX, sourceY);
                            sumR += (int)(color.R * Kernel[matrixX + KernelAnchorCol, matrixY + KernelAnchorRow]) + Offset;
                            sumG += (int)(color.G * Kernel[matrixX + KernelAnchorCol, matrixY + KernelAnchorRow]) + Offset;
                            sumB += (int)(color.B * Kernel[matrixX + KernelAnchorCol, matrixY + KernelAnchorRow]) + Offset;
                        }
                    // filter bad pixels 
                    if (sumR > 255)
                        sumR = 255;
                    else if (sumR < 0)
                        sumR = 0;
                    if (sumG > 255)
                        sumG = 255;
                    else if (sumG < 0)
                        sumG = 0;
                    if (sumB > 255)
                        sumB = 255;
                    else if (sumB < 0)
                        sumB = 0;

                    output.SetPixel(x, y, Color.FromArgb(sumR, sumG, sumB));
                }
            }
            return output;
        }
    }
}
