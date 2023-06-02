using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Levi_Click(object sender, EventArgs e)
        {
            new Fractal(15, Curves.CurveType.LeviCurve).Show();
            this.Hide();
        }

        private void Koch_Click(object sender, EventArgs e)
        {
            new Fractal(6, Curves.CurveType.KochCurve).Show();
            this.Hide();
        }


    }
}
