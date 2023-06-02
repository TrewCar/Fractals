using Fractals.Curves;
using System.Drawing;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Fractal : Form
    {
        public Fractal(int MaxValue, CurveType type)
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            ControlN.Maximum = MaxValue;
            curve = Curve.Inicialize(type, new Point(50, pictureBox1.Height - 60), new Point(pictureBox1.Width - 50, pictureBox1.Height - 60),170);
            Draw(0);
        }
        Pen pen = new Pen(Brushes.Black, 2);
        Graphics g;
        Curve curve;
        private void ControlN_Scroll(object sender, System.EventArgs e)
        {
            Draw(ControlN.Value);
        }
        private void Draw(int n)
        {
            LabelN.Text = "N = " + n;
            curve.SetN(n);

            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            curve.DrawLines(g, pen);
            pictureBox1.Invalidate();
        }

        private void Fractal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Program.main.Show();
        }
    }
}
