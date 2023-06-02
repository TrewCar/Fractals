﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Curves.Line
{
    class KochLine : Line
    {
        public KochLine(Point start, Point end) : base(start, end) { }
        public override List<ILine> Split()
        {
            double len = (int)Math.Sqrt(Math.Pow(Start.X - End.X, 2) + Math.Pow(Start.Y - End.Y, 2));
            double segment = len / 3;

            Point posMiddle1 = new Point((int)(Start.X + (End.X - Start.X) / len * segment), (int)(Start.Y + (End.Y - Start.Y) / len * segment));
            Point posMiddle2 = new Point((int)(posMiddle1.X + (End.X - Start.X) / len * segment), (int)(posMiddle1.Y + (End.Y - Start.Y) / len * segment));

            Line ln1 = new KochLine(Start, posMiddle1);
            Line ln4 = new KochLine(posMiddle2, End);

            double Angle = ((60) * Math.PI) / 180;

            Point posUp = new Point(
                (int)((posMiddle1.X - posMiddle2.X) * Math.Cos(Angle) - ((posMiddle1.Y - posMiddle2.Y) * Math.Sin(Angle)) * Angle) + posMiddle2.X,
                (int)((posMiddle1.X - posMiddle2.X) * Math.Sin(Angle) - ((posMiddle1.Y - posMiddle2.Y) * Math.Cos(Angle)) * -Angle) + posMiddle2.Y
                );

            Line ln2 = new KochLine(posMiddle1, posUp);
            Line ln3 = new KochLine(posUp, posMiddle2);

            return new List<ILine>() { ln1, ln2, ln3, ln4 };
        }
    }
}
