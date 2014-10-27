using System;
using System.Drawing;

namespace Shapes
{
    [Serializable()]
    public class Triangle : Shape
    {
        private int _x, _y, _x2, _y2, _x3, _y3;

        public Triangle(int x, int y, int x2, int y2, int x3, int y3)
        {
            _x = x;
            _y = y;
            _x2 = x2;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;
        }

        public Triangle(Point start, Point end)
        {
            _x = start.X;
            _y = start.Y;
            _x2 = end.X;
            _y2 = end.Y;
            _x3 = _x2 - 2 *(_x2 - _x);
            _y3 = _y2;
        }

        public override void Update(Point start, Point end)
        {
            _x = start.X;
            _y = start.Y;
            _x2 = end.X;
            _y2 = end.Y;
            _x3 = _x2 - 2 * (_x2 - _x);
            _y3 = _y2;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, _x, _y, _x2, _y2);
            graphics.DrawLine(pen, _x2, _y2, _x3, _y3);
            graphics.DrawLine(pen, _x3, _y3, _x, _y);
        }
    }
}
