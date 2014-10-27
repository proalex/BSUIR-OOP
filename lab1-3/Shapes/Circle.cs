using System;
using System.Drawing;

namespace Shapes
{
    [Serializable()]
    public class Circle : Ellipse
    {
        public Circle(int x, int y, int size) : base (x, y, size, size)
        {

        }

        public Circle(Point start, Point end)
            : base(start.X, start.Y, end.Y - start.Y, end.Y - start.Y)
        {

        }

        public override void Update(Point start, Point end)
        {
            end.X = start.X + (end.Y - start.Y);
            base.Update(start, end);
        }
    }
}
