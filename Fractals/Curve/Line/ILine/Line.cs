using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Curves.Line
{
    abstract class Line : ILine
    {
        protected Line(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
        }
        public Point Start { get; private set; }
        public Point End { get; private set; }
        public virtual void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, Start, End);
        }
        public abstract List<ILine> Split();
    }
}
