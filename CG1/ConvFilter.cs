using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG1
{
    public class ConvFilter
    {
        public string Name { get; }
        public double[,] Kernel { get; }
        public int Rows {get;}
        public int Columns { get; }

        public ConvFilter(string filterName, double[,] kernel, int columns, int rows)
        {
            Name = filterName;
            this.Kernel = kernel;
            this.Columns = columns;
            this.Rows = rows;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
