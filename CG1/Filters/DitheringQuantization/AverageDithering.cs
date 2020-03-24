using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CG1
{
    class AverageDithering : Filter
    {
        public bool ToGreyscale { get; set; }
        public AverageDithering()
        {
            ToGreyscale = false;
        }

        public string Name { get { return "Average dithering"; } }

        public Image applyFilter(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            if (ToGreyscale)
                bmp = toGreyscale(bmp);

            int width = bmp.Width;
            int height = bmp.Height;
            //makes copy of bitmap to memory for fast processing.
            BitmapData srcData = bmp.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            bmp.UnlockBits(srcData);
            /*/byte[] result = new byte[buffer.Length];*/
            int[] sums = new int[3] { 0,0,0 };

             for (int i = 0; i<buffer.Length; i+=4)
             {
                 sums[0] += buffer[i];
                 sums[1] += buffer[i+1];
                 sums[2] += buffer[i+2];
            }
            int pixelSum = bytes / 4;
            int[] avgs = new int[3];

             for (int i = 0; i< 3; i++)
                 avgs[i] = sums[i] / pixelSum;

             for (int i = 0; i<buffer.Length; i+=4)
            {
                result[i] = (byte)(avgs[0] >= buffer[i] ? 0 : 255);
                result[i+1] = (byte)(avgs[1] >= buffer[i] ? 0 : 255);
                result[i+2] = (byte)(avgs[2] >= buffer[i] ? 0 : 255);
                result[i + 3] = 255;
            }
                 

            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;


        }

        private Bitmap toGreyscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);
            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
              {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
              });
            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();
            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);
            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }
    }
}
