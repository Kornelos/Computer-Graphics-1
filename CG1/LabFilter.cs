using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG1
{
    class LabFilter
    {
        public Image applyFilter(Image img, int matrixSize=3)
        {
            Bitmap bitmap = new Bitmap(img);
            Bitmap output = new Bitmap(img);
            
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    int maxR = 0;
                    int maxG = 0;
                    int maxB = 0;

                    int minR = 255;
                    int minG = 255;
                    int minB = 255;

                    for (int matrixY = -matrixSize / 2; matrixY < matrixSize - 1; matrixY++)
                        for (int matrixX = -matrixSize / 2; matrixX < matrixSize - 1; matrixX++)
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

                            if (maxR < color.R)
                                maxR = color.R;
                            if (maxG < color.G)
                                maxG = color.G;
                            if (maxB < color.B)
                                maxB = color.B;


                            if (minR > color.R)
                                minR = color.R;
                            if (minG > color.G)
                                minG = color.G;
                            if (minB > color.B)
                                minB = color.B;

                        }
      
                    output.SetPixel(x, y, Color.FromArgb(maxR - minR, maxG - minG, maxB - minB));
                }
            }
            return output;
        }
    }
}
