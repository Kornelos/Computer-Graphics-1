using System.Drawing;


namespace CG1
{
    interface Filter
    {
        string Name { get; }
        Image applyFilter(Image image);

    }

}
