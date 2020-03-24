using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CG1 
{ 

    class KMeansQuantization : Filter
    {
        public int K { get; set; }
        public KMeansQuantization()
        {
            K = 32;
        }

        public string Name { get { return "K-Means quantization"; } }

        public Image applyFilter(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            
            

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
            // get color count
            var count = GetColorCount(buffer);
            if (K > count)
                K = count;
            // get colors
            var colors = GetKColors(K, buffer);
            

            for (int i=0; i < buffer.Length; i += 4)
            {
                Tuple<int, int, int> selectedColor = new Tuple<int, int, int>(buffer[i], buffer[i + 1], buffer[i + 2]);
                double currMinDist = double.MaxValue;
                foreach(var color in colors)
                {
                    
                    double euclideanDist = Math.Sqrt(Math.Pow(buffer[i] - color.Item1, 2) + 
                                           Math.Pow(buffer[i+1] - color.Item2, 2) + Math.Pow(buffer[i+2] - color.Item3, 2));
                    if (euclideanDist < currMinDist)
                    {
                        selectedColor = color;
                        currMinDist = euclideanDist;
                    }                     
                }
                result[i] = (byte)selectedColor.Item1;
                result[i+1] = (byte)selectedColor.Item2;
                result[i+2] = (byte)selectedColor.Item3;
                result[i+3] = 255;
            }

            //puts bytes into result Bitmap
            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }

        private HashSet<Tuple<int, int, int>> GetKColors(int k, byte[] buffer)
        {
           
            var colors = new HashSet<Tuple<int, int, int>>();
           
            Random r = new Random();
            while (colors.Count < k)
            {
                int rand = r.Next(0, buffer.Length / 4) * 4;
                colors.Add(new Tuple<int, int, int>(buffer[rand], buffer[rand + 1], buffer[rand + 2]));
            }
            return colors;
        }

        private int GetColorCount(byte[] buffer)
        {
            var colors = new HashSet<Tuple<int, int, int>>();
            for (int i = 0; i < buffer.Length; i += 4)
            {
                colors.Add(new Tuple<int,int,int>(buffer[i], buffer[i + 1], buffer[i + 2]));
            }
            return colors.Count;
        }
    }

}
