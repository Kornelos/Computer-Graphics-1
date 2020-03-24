using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CG1
{
    public class FilterService
    {

        // create basic filters
        private List<Filter> filters = new List<Filter>
        {
            // functional filters
            new InversionFilter(),
            //brightnessValue - from -1 to 1
            new BrightnessCorrection(0.8),
            //Threshold values range from 100 to –100 inclusive
            new ContrastEnhancement(30),
            new GammaCorrection(0.8),
            //convolutional filters
            new ConvFilter("Box blur",new double[3,3]{ { 1/9f, 1/9f, 1/9f }, { 1/9f, 1/9f, 1/9f }, { 1/9f, 1/9f, 1/9f } },0,3,3,1,1),
            new ConvFilter("Gaussian blur",new double[3,3]{ { 1/16f, 1/8f, 1/16f },{ 1/8f, 1/4f, 1/8f   }, { 1/16f, 1/8f, 1/16f } },0,3,3,1,1),
            new ConvFilter("Sharpen",new double[3,3]{ { 0, -1, 0  },{ -1, 5, -1 },{ 0, -1, 0  } },0,3,3,1,1),
            new ConvFilter("Edge detection",new double[3,3]{ { 0, -1, 0 },{ 0, 1, 0  }, { 0, 0, 0  } },0,3,3,1,1),
            new ConvFilter("Emboss",new double[3, 3] { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } },0,3,3,1,1),
            
            //filter from lab task
            new LabFilter(),

            //lab2 filters
            new AverageDithering(),
            new KMeansQuantization(),
        };

        public FilterService() { }

        public void addEditFilter(ConvFilter newConvFilter)
        {
            Filter existingFilter = filters.FindLast(item => item.Name == newConvFilter.Name);
            if (existingFilter != null && existingFilter.GetType() == newConvFilter.GetType())
                filters.Remove(existingFilter);
             
             filters.Add(newConvFilter);
            
        }

        public string[] getFilterNames()
        {
            List<string> names = new List<string>();
            foreach(var filter in filters)
                names.Add(filter.Name);
            return names.ToArray();

        }
        

        public Image ApplyFilterNamed(string filterName, Image img)
        {
            Filter existingFilter = filters.FindLast(item => item.Name == filterName);
            if(existingFilter == null)
            {
                MessageBox.Show("Filter not implemented!");
                    return img;
            }
            else
            {
                return existingFilter.applyFilter(img);
            }
        }

        public ConvFilter GetConvFilter(string filterName)
        {
                ConvFilter filter = (ConvFilter)filters.FindLast(item => item.Name == filterName && item.GetType() == typeof(ConvFilter));
                return filter;

        }

        public Filter GetFilterNamed(string filterName)
        {
            return filters.FindLast(item => item.Name == filterName);
            
        }
    
    }
}