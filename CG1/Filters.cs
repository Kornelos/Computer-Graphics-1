using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CG1
{
    public class Filters
    {
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
            else
            {
                MessageBox.Show("Filter not implemented");
                return null;
            }
        }

        private Image InversionFilter(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            for (int y = 0; y <= (bmp.Height - 1); y++)
            {
                for (int x = 0; x <= (bmp.Width - 1); x++)
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

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    //  color = ChangeColorBrightness(color, 0.80f);
                    color = Color.FromArgb(color.A, (int)(color.R * 0.8), (int)(color.G * 0.8), (int)(color.B * 0.8));
                    bmp.SetPixel(x, y, color);
                }
            }

            return bmp;
        }

        private Image GammaCorrection(Image image)
        {
            Bitmap bmp = new Bitmap(image);

            return bmp;
        }

    }
}