using Fractals.Curves.Line   ;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Curves
{
    class KochCurve : Curve
    {
        public KochCurve(Point start, Point end)
        {
            Lines.Add(new KochLine(start, end));
        }
        protected override void SplitDown()
        {
            List<ILine> newLines = new List<ILine>();
            for (int i = 0; i < Lines.Count; i += 4)
            {
                newLines.Add(new KochLine(Lines[i].Start, Lines[i + 3].End));
            }
            Lines = newLines;
        }
    }
}
