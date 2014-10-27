using System;
using System.Drawing;

namespace Shapes
{
    [Serializable()]
    public class Line : Shape
    {
        private int _x, _y, _x2, _y2;

        public Line(int x, int y, int x2, int y2)
        {
            _x = x;
            _y = y;
            _x2 = x2;
            _y2 = y2;
        }

        public Line(Point start, Point end)
        {
            _x = start.X;
            _y = start.Y;
            _x2 = end.X;
            _y2 = end.Y;
        }

        public override void Update(Point start, Point end)
        {
            _x = start.X;
            _y = start.Y;
            _x2 = end.X;
            _y2 = end.Y;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, _x, _y, _x2, _y2);
        }
    }
}
