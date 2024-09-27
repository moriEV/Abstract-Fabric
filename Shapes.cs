using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.Xml;

namespace Abstract_Fabric
{

    public interface IShape
    {
        void Draw(Graphics g);
        int X { get; }
        int Y { get; }
    }

    public class Circle : IShape
    {
        public Size Size { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        private Brush _brush;

        public Circle(Brush brush, int size, int x, int y)
        {
            _brush = brush;
            Size = new Size(size, size);
            X = x;
            Y = y;
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(_brush, X, Y, Size.Width, Size.Height);
        }
    }

    public class Square : IShape
    {
        public Size Size { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        private Brush _brush;

        public Square(Brush brush, int size, int x,int y)
        {
            _brush = brush;
            Size = new Size(size, size); // Квадрат тоже имеет одинаковую ширину и высоту
            X = x;
            Y = y;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(_brush, X, Y, Size.Width, Size.Height);
        }
    }

    public class Triangle : IShape
    {
        public Size Size { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        private Brush _brush;

        public Triangle(Brush brush, int size,int x,int y)
        {
            _brush = brush;
            Size = new Size(size, size); // Для простоты равносторонний треугольник
            X = x;
            Y = y;
        }

        public void Draw(Graphics g)
        {
            Point[] points = {
            new Point(X + Size.Width / 2, Y),
            new Point(X + Size.Width, Y + Size.Height),
            new Point(X, Y + Size.Height)
        };

            g.FillPolygon(_brush, points);
        }

    }
}
