using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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
            int width = bitmap.Width;
            int height = bitmap.Height;
            //makes copy of bitmap to memory for fast processing.
            BitmapData srcData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            bitmap.UnlockBits(srcData);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int sumR = 0;
                    int sumG = 0;
                    int sumB = 0;

                    int current;
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
                            //current pixel for kernel
                            current = sourceY * srcData.Stride + sourceX * 4;
                            sumR += (int)(buffer[current] * Kernel[matrixX + KernelAnchorCol, matrixY + KernelAnchorRow]) + Offset;
                            sumG += (int)(buffer[current + 1] * Kernel[matrixX + KernelAnchorCol, matrixY + KernelAnchorRow]) + Offset;
                            sumB += (int)(buffer[current + 2] * Kernel[matrixX + KernelAnchorCol, matrixY + KernelAnchorRow]) + Offset;
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
                    // current in resulting bitmap
                    current = y * srcData.Stride + x * 4;
                    result[current] = (byte)sumR;
                    result[current + 1] = (byte)sumG;
                    result[current + 2] = (byte)sumB;
                    result[current + 3] = 255;
                }
            }
            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }
    }
}
