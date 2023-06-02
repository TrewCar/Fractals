using System.Collections.Generic;
using System.Drawing;

interface ILine
{
    Point Start { get; }
    Point End { get; }
    void Draw(Graphics g, Pen pen);
    List<ILine> Split();
}

