using Graphic.DataModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Main : Form
    {
        private GraphicData Data;

        public Main()
        {
            InitializeComponent();
        }

        public Main(GraphicData data) : this()
        {
            Data = data;
            WriteDataToControls();
        }

        private void WriteDataToControls()
        {
            tbX1.Text = Data.X1.ToString();
            tbX2.Text = Data.X2.ToString();
            tbPointCount.Text = Data.PointCount.ToString();
        }

        private List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            // i меняется от 0 до 199
            // x меняется от x1 до x2
            // y меняется в зависимости от функции
            // Размеры панели примерно 600x500
            for (int i = 0; i < Data.PointCount; i++)
            {
                var x = Data.X1 + (Data.X2 - Data.X1) * i / (Data.PointCount - 1);
                var y = Data.Fn(x);

                var point = new Point(
                    (int)(pnlGraphic.Width * (x - Data.X1)/(Data.X2 - Data.X1)), 
                    pnlGraphic.Height/2 - (int)(pnlGraphic.Height * y / (Data.X2 - Data.X1)));

                points.Add(point);
            }

            return points;
        }

        private void PnlGraphic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen linePen = new Pen(Color.Black);
            g.DrawLine(linePen, new Point(0, pnlGraphic.Height / 2), new Point(pnlGraphic.Width, pnlGraphic.Height / 2));
            g.DrawLine(linePen, new Point(pnlGraphic.Width / 2, 0), new Point(pnlGraphic.Width / 2, pnlGraphic.Height));

            Pen pen = new Pen(Color.Red);

            var points = GetPoints();

            for (int i = 1; i < points.Count; i++)
            {
                g.DrawLine(pen, points[i - 1], points[i]);
            }
        }

        private void btnDraw_Click(object sender, System.EventArgs e)
        {
            Data.X1 = double.Parse(tbX1.Text);
            Data.X2 = double.Parse(tbX2.Text);
            Data.PointCount = int.Parse(tbPointCount.Text);

            pnlGraphic.Refresh();
        }

        private void Main_Resize(object sender, System.EventArgs e)
        {
            pnlGraphic.Refresh();
        }
    }
}
