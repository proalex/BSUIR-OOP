using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Shapes
{
    [Serializable()]
    public class Square : Rectangle
    {
        public Square(int x, int y, int size) : base(x, y, size, size)
        {

        }

        public Square(Point start, Point end)
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
