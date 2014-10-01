using System;
using System.Drawing;

namespace Shapes
{
    [Serializable()]
    public class Rectangle : Shape
    {
        private int _x, _y, _width, _height;

        public Rectangle(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public Rectangle(Point start, Point end)
        {
            _x = start.X;
            _y = start.Y;
            _width = end.X - _x;
            _height = end.Y - _y;
        }

        public override void Update(Point start, Point end)
        {
            _x = start.X;
            _y = start.Y;
            _width = end.X - _x;
            _height = end.Y - _y;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, _x, _y, _width, _height);
        }
    }
}
