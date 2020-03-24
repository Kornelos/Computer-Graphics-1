using System.Drawing;


namespace CG1
{
    public interface Filter
    {
        string Name { get; }
        Image applyFilter(Image image);

    }

}
