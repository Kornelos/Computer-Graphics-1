using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CG1
{
    public class Filters
    {
        private struct Gamma
        {
            public double r, g, b;
            public Gamma(double r, double g, double b)
            {
                this.r = r;
                this.b = b;
                this.g = g;
            }
        }

        //brightnessValue - from -1 to 1
        private double brightnessValue = 0.8;
        //Threshold values range from 100 to –100 inclusive
        private int contrastThreshold = -30;
        //gamma value
        private Gamma gamma = new Gamma(2,1,0.5);
        
        public Filters()
        {

        }

        public Image ApplyFilterNamed(string filter, Image img)
        {
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
                MessageBox.Show("Filter not implemented");
                return null;
            }
        }

        private Image InversionFilter(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color inv = bmp.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    bmp.SetPixel(x, y, inv);
                }
            }
            return bmp;
        }

        private Image BrightnessCorrection(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            int red, green, blue;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);

                    if (brightnessValue >= 0)
                    {
                         red = (int)((255 - color.R) * brightnessValue + color.R);
                         green = (int)((255 - color.G) * brightnessValue + color.G);
                         blue = (int)((255 - color.B) * brightnessValue + color.B);
                    }
                    else
                    {
                        brightnessValue = 1 + brightnessValue;
                         red = (int)(brightnessValue * color.R);
                         green = (int)(brightnessValue * color.R);
                         blue = (int)(brightnessValue * color.R);
                    }

                    color = Color.FromArgb(255,red,green,blue);
                    bmp.SetPixel(x, y, color);
                }
            }

            return bmp;
        }
        private Image ContrastEnhancement(Image image)
        {
            int red, green, blue;
            Bitmap bmp = new Bitmap(image);
            double calculatedTreshold = Math.Pow((100.0 + contrastThreshold)/100.0,2);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);

                    red = (int)(((((color.R / 255.0) - 0.5) * calculatedTreshold) + 0.5) * 255.0);
                    green = (int)(((((color.G / 255.0) - 0.5) * calculatedTreshold) + 0.5) * 255.0);
                    blue = (int)(((((color.B / 255.0) - 0.5) * calculatedTreshold) + 0.5) * 255.0);

                    if (blue > 255)
                        blue = 255; 
                    else if (blue < 0)
                        blue = 0; 


                    if (green > 255)
                        green = 255; 
                    else if (green < 0)
                        green = 0; 


                    if (red > 255)
                        red = 255; 
                    else if (red < 0)
                        red = 0; 

                    color = Color.FromArgb(255, red, green, blue);
                    bmp.SetPixel(x, y, color);
                }
            }
            return bmp;
        }
        //encoded = ((original / 255) ^ (1 / gamma)) * 255
        private Image GammaCorrection(Image image)
        {
            int red, green, blue;
            Bitmap bmp = new Bitmap(image);
            double calculatedTreshold = Math.Pow((100.0 + contrastThreshold) / 100.0, 2);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);

                    red = (int)(Math.Pow((color.R / 255.0),1/gamma.r) * 255.0);
                    green = (int)(Math.Pow((color.R / 255.0), 1 / gamma.g) * 255.0);
                    blue = (int)(Math.Pow((color.R / 255.0), 1 / gamma.b) * 255.0);

                    color = Color.FromArgb(255, red, green, blue);
                    bmp.SetPixel(x, y, color);
                }
            }
            return bmp;
        }

    }
}