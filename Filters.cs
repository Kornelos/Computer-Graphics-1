using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CG1
{
    public class Filters
    {
        public Filters()
        {
        }

        public Image applyFilterNamed(string filter, Image img)
        {
            if (filter == "Inversion")
            {
                return InversionFilter(img);
            }

            else
            {
                MessageBox.show("Filter not implemented");
            }
        }

        private Image InversionFilter(Image image)
        {
            Bitmap pic = new Bitmap(image);
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }
            return new Image(pic);
        }

    }
}