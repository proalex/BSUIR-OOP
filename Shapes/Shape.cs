using System;
using System.Drawing;

namespace Shapes
{
    [Serializable()]
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics, Pen pen);
        public abstract void Update(Point start, Point end);
    }
}
