using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG1
{
    // Model of the convolutional filter
    public class ConvFilter
    {
        public string Name { get; }
        public double[,] Kernel { get; }
        public int Rows {get;}
        public int Columns { get; }
        public int Offset { get; }
        public int KernelAnchorCol { get; }
        public int KernelAnchorRow { get; }

        public ConvFilter(string filterName, double[,] kernel, int offset, int columns, int rows,int anchorRow, int anchorCol)
        {
            Name = filterName;
            Kernel = kernel;
            Columns = columns;
            Rows = rows;
            Offset = offset;
            KernelAnchorCol = anchorCol;
            KernelAnchorRow = anchorRow;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
