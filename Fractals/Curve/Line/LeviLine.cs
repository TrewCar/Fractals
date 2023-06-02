using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Curves.Line
{
    class LeviLine : Line
    {
        public LeviLine(Point start, Point end) : base(start, end) { }
        public override List<ILine> Split()
        {
            double Angle = ((90) * Math.PI) / 180;
            Point posSR = new Point((Start.X + End.X) / 2, (Start.Y + End.Y) / 2);
            Point posUP = new Point(
                (int)((Start.X - posSR.X) * Math.Cos(Angle) - ((Start.Y - posSR.Y) * Math.Sin(Angle))) + posSR.X,
                (int)((Start.X - posSR.X) * Math.Sin(Angle) - ((Start.Y - posSR.Y) * Math.Cos(Angle))) + posSR.Y
                );
            return new List<ILine> { new LeviLine(Start, posUP), new LeviLine(posUP, End) };
        }
    }
}
