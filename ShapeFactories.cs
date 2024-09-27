using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Fabric
{
    public interface ShapeFactories
    {
        Color color { get; set; }
        IShape CreateCircle(int size, int x, int y);
        IShape CreateSquare(int size, int x, int y);
        IShape CreateTriangle(int size, int x, int y);
    }

    public class BlueFactory : ShapeFactories
    {
        public Color color { get; set; } = Color.Blue;
        public IShape CreateCircle(int size, int x, int y) => new Circle(Brushes.Blue, size, x, y);
        public IShape CreateSquare(int size, int x, int y) => new Square(Brushes.Blue, size, x, y);
        public IShape CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Blue, size, x, y);
    }

    public class RedFactory : ShapeFactories
    {
        public Color color { get; set; } = Color.Red;
        public IShape CreateCircle(int size, int x, int y) => new Circle(Brushes.Red, size, x, y);
        public IShape CreateSquare(int size, int x, int y) => new Square(Brushes.Red, size, x, y);
        public IShape CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Red, size, x, y);
    }

}
