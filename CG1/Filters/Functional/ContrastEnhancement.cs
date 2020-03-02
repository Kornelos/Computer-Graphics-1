﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace CG1
{
    class ContrastEnhancement : Filter
    {
        public string Name { get { return "Contrast enhancement"; } }
        private int contrastThreshold;

        public ContrastEnhancement(int contrast)
        {
            contrastThreshold = contrast;
        }
        public Image applyFilter(Image image)
        {
            double calculatedTreshold = Math.Pow((100.0 + contrastThreshold) / 100.0, 2);

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
            int current = 0;
            int cChannels = 3;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    current = y * srcData.Stride + x * 4;
                    for (int i = 0; i < cChannels; i++)
                    {
                        //processing of single color channel
                        double channel = (double)buffer[current + i];
                        int newValue = (int)(((((channel / 255.0) - 0.5) * calculatedTreshold) + 0.5) * 255.0);
                        //handle bad values
                        if (newValue > 255)
                            newValue = 255;
                        else if (newValue < 0)
                            newValue = 0;
                        result[current + i] = (byte)newValue;


                    }
                    //set alphas channel to 255
                    result[current + 3] = 255;
                }
            }
            //puts bytes into result Bitmap
            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }
    }
}
