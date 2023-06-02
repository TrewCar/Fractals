using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractals.Curves
{
    abstract class Curve
    {
        protected List<ILine> Lines = new List<ILine>();
        public int N { get; private set; }
        public void DrawLines(Graphics g, Pen pen)
        {
            foreach (var line in Lines)
            {
                line.Draw(g, pen);
            }
        }
        public void SetN(int n)
        {
            if (n < 0)
            {
                throw new Exception("N не может быть отрицательным");
            }
            if (n > N)
            {
                for (int i = 0; i < n - N; i++)
                {
                    SplitUp();
                }
                N = n;
            }
            else
            {
                for (int i = 0; i < N - n; i++)
                {
                    SplitDown();
                }
                N = n;
            }
        }
        private void SplitUp()
        {
            var newLines = new List<ILine>();
            foreach (var line in Lines)
            {
                newLines.AddRange(line.Split());
            }
            Lines = newLines;
        }
        protected abstract void SplitDown();
        public static Curve Inicialize(CurveType type, Point start, Point end, int SetXInCenter = 0)
        {
            switch (type)
            {
                case CurveType.LeviCurve:
                    return new LeviCurve(SetX(SetXInCenter, start), SetX(-SetXInCenter, end));
                case CurveType.KochCurve:
                    return new KochCurve(start, end);
                default:
                    throw new Exception("Not found type");
            }
        }
        private static Point SetX(int SetValue, Point SetPoint)
        {
            return new Point(SetPoint.X + SetValue, SetPoint.Y);
        }
    }
}
