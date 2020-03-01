using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CG1
{
    //class with the convolution applying function definition
    class Convolution
    {
        public Image applyKernel(Image img, double[,] kernel,int kernelRowSize=3, int kernelColSize = 3)
        {
            Bitmap bitmap = new Bitmap(img);
            Bitmap output = new Bitmap(img);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int sumR = 0;
                    int sumG = 0;
                    int sumB = 0;

                    for (int matrixY = -kernelRowSize/2; matrixY < kernelRowSize - 1; matrixY++)
                        for (int matrixX = -kernelColSize/2; matrixX < kernelColSize - 1; matrixX++)
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
                            sumR += (int)(color.R * kernel[matrixX + 1,matrixY + 1]);
                            sumG += (int)(color.G * kernel[matrixX + 1, matrixY + 1]);
                            sumB += (int)(color.B * kernel[matrixX + 1, matrixY + 1]);
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

                    output.SetPixel(x, y, Color.FromArgb(sumR,sumG,sumB));
                }
            }
            return output;
        }
    }
}
