using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointGraf
{
    public partial class graf : Form
    {
        double from;
        double before;
        double countPoint;
        string func;
        public graf()
        {
            InitializeComponent();
        }

        private void graf_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(from.ToString());
            double step = (before - from) / countPoint;
            for (double x = from; x <= before; x += step)
            {
                double y = 2 * x;
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
        public void installParam(string from, string before, string countPoint, string func)
        {
            this.from = Double.Parse(from);
            this.before = Double.Parse(before);
            this.countPoint = Double.Parse(countPoint);
            this.func = func;
        }
    }
}
