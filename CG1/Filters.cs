using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CG1
{
    public class Filters
    {
        //brightnessValue - from -1 to 1
        private double brightnessValue = 0.8;
        //Threshold values range from 100 to –100 inclusive
        private int contrastThreshold = 30;
        //gamma value
        private double gamma = 0.8;

        private Convolution convolution = new Convolution();

        // create basic filters
        private List<ConvFilter> convFilters = new List<ConvFilter>
        {
            new ConvFilter("Box blur",new double[3,3]{ { 1/9f, 1/9f, 1/9f }, { 1/9f, 1/9f, 1/9f }, { 1/9f, 1/9f, 1/9f } },3,3),
            new ConvFilter("Gaussian blur",new double[3,3]{ { 1/16f, 1/8f, 1/16f },{ 1/8f, 1/4f, 1/8f   }, { 1/16f, 1/8f, 1/16f } },3,3),
            new ConvFilter("Sharpen",new double[3,3]{ { 0, -1, 0  },{ -1, 5, -1 },{ 0, -1, 0  } },3,3),
            new ConvFilter("Edge detection",new double[3,3]{ { 0, -1, 0 },{ 0, 1, 0  }, { 0, 0, 0  } },3,3),
            new ConvFilter("Emboss",new double[3,3]{ { 0, -1, 0 },{ 0, 1, 0  }, { 0, 0, 0  } },3,3),
            
        };

        public Filters() { }

        public void addEditFilter(ConvFilter newConvFilter)
        {
            ConvFilter existingFilter = convFilters.FindLast(item => item.ToString() == newConvFilter.ToString());
            if (existingFilter != null)
                convFilters.Remove(existingFilter);
             
             convFilters.Add(newConvFilter);
            
        }

        public string[] getFilterNames()
        {
            List<string> filters = new List<string>
            {
                "Inversion","Brightness correction","Gamma correction","Contrast enhancement"
            };
            foreach(var filter in convFilters)
            {
                filters.Add(filter.ToString());
            }

            return filters.ToArray();
        }
        

        public Image ApplyFilterNamed(string filter, Image img)
        {
            // functional filters
            if (filter == "Inversion")
                return InversionFilter(img);
            if (filter == "Brightness correction")
                return BrightnessCorrection(img);
            if (filter == "Gamma correction")
                return GammaCorrection(img);
            if (filter == "Contrast enhancement")
                return ContrastEnhancement(img);
            else
            {
                //convolutional filters
                ConvFilter convFilter = convFilters.FindLast(item => item.ToString() == filter);
                if(convFilter != null)
                {
                    return convolution.applyKernel(img, convFilter.Kernel);
                }
                MessageBox.Show("Filter not implemented");
                return null;
            }
        }

        private Image InversionFilter(Image image)
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
                        double inv = (double)buffer[current + i];
                        result[current + i] = (byte)((255 - inv));
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

        private Image BrightnessCorrection(Image image)
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
                        if (brightnessValue >= 0)  
                            result[current + i] = (byte)((255 - channel) * brightnessValue + channel);
                        else
                        {
                            brightnessValue = 1 + brightnessValue;
                            result[current + i] = (byte)(brightnessValue * channel);
                        }
                            
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

        private Image ContrastEnhancement(Image image)
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
        //formula for gamma correction
        //encoded = ((original / 255) ^ (1 / gamma)) * 255
        private Image GammaCorrection(Image image)
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
                        result[current + i] = (byte)(Math.Pow((channel / 255.0), 1 / gamma) * 255.0); ;


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