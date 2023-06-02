using Fractals.Curves.Line;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Curves
{
    class LeviCurve : Curve
    {
        public LeviCurve(Point start, Point end)
        {
            Lines.Add(new LeviLine(start, end));
        }
        protected override void SplitDown()
        {
            List<ILine> newLines = new List<ILine>();
            for (int i = 0; i < Lines.Count; i += 2)
            {
                newLines.Add(new LeviLine(Lines[i].Start, Lines[i + 1].End));
            }
            Lines = newLines;
        }
    }
}
