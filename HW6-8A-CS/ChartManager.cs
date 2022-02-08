using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomework
{
    public class ChartManager
    {
        #region Members

        private Panel container;
        private ggPictureBox ggPictBox;
        private Bitmap bmp;
        private Rectangle viewPort;
        private Graphics G;

        private int _nbPoints;         // number of points for each path
        private int _tPoint;           // point in time

        private Random R;
        private Bernoulli B;

        int _pixelAdj;

        #endregion

        #region Constructor

        public ChartManager(Bernoulli b, ggPictureBox pictureBox, Panel Container, int pixelAdj)
        {
            R = new Random();

            container = Container;
            ggPictBox = pictureBox;
            bmp = new Bitmap(ggPictBox.Width, ggPictBox.Height);
            G = Graphics.FromImage(bmp);

            B = b;

            _nbPoints = B.Paths[0].Points.Count;
            _tPoint = B.TValue;
            _pixelAdj = pixelAdj;
        }

        #endregion
        
        #region Public

        public void DrawChart()
        {
            viewPort = new Rectangle(0, 0, (ggPictBox.Width * 3 / 4) - 1, ggPictBox.Height - 1);
            G.FillRectangle(Brushes.Black, viewPort);

            DrawPaths();

            var tClusters = B.Clusters_T;
            var nClusters = B.Clusters_N;
            DrawHistogram(tClusters, _tPoint);
            DrawHistogram(nClusters, _nbPoints);

            ggPictBox.Image = bmp;
        }

        #endregion

        #region Private

        private void DrawPaths()
        {
            double rangeX = _nbPoints;
            double rangeY = 1;

            //double minY = 0;
            //double maxY = 0;
            //foreach (BPath path in B.Paths)
            //{
            //    var min = Math.Round(path.Points.Min(p => p.Y));
            //    if (minY < min)
            //        minY = min;
            //    var max = Math.Round(path.Points.Max(p => p.Y));
            //    if (max > maxY)
            //        maxY = max;
            //}

            //rangeY = maxY > minY ? maxY - minY : 1;

            foreach (BPath path in B.Paths)
            {
                var red = R.Next(1, 254);
                var green = R.Next(1, 254);
                var blue = R.Next(1, 254);
                Pen pen = new Pen(Color.FromArgb(red, green, blue));

                var adjustedPoints = GetAdjustedPoints(path.Points, 0, 0, rangeX, rangeY);
                for (int j = 0; j < adjustedPoints.Count - 1; j++)
                {
                    G.DrawLine(pen, (float)adjustedPoints[j].X, (float)adjustedPoints[j].Y - _pixelAdj, (float)adjustedPoints[j + 1].X, (float)adjustedPoints[j + 1].Y - _pixelAdj);
                }
            }
        }

        private List<PointF> GetAdjustedPoints(List<BPoint> points, double startX, double startY, double rangeX, double rangeY)
        {
            // Adjusts the point to viewport area
            List<PointF> adjustedPoints = new List<PointF>();

            foreach (BPoint point in points)
            {
                var X = AdjustX(point.X, startX, rangeX);
                var Y = AdjustY(point.Y, startY, rangeY);
                var adjPoint = new PointF((float)X, (float)Y);
                adjustedPoints.Add(adjPoint);
            }

            return adjustedPoints;
        }

        private void DrawHistogram(List<Cluster> cluster, int T)
        {
            int x = (int)AdjustX(T, 0, _nbPoints);
            int h = ggPictBox.Height / cluster.Count;
            double y;
            int w;
            int maxOccurs = 0;

            for (int i = 0; i < cluster.Count; i++)
            {
                y = (100 - cluster[i].MaxValue * 100);
                var yAdjusted = (int)(viewPort.Top + viewPort.Height * ((y - 0) / 100)) - _pixelAdj;

                w = cluster[i].NbOccurrencies;
                if (w > maxOccurs)
                    maxOccurs = w;

                Rectangle rectangle = new Rectangle(x, yAdjusted - 1, w, h);
                G.DrawRectangle(Pens.Black, rectangle);

                rectangle = new Rectangle(x, yAdjusted, w, h - 1);
                G.FillRectangle(Brushes.Gold, rectangle);
            }

            w = maxOccurs;
            var frame = new Rectangle(x, 0, w, ggPictBox.Height - 3);
            var pen = T == _nbPoints ? Pens.Red : Pens.LightBlue;
            G.DrawRectangle(pen, frame);
        }

        private double AdjustX(double x, double startX, double rangeX)
        {
            return viewPort.Left + viewPort.Width * ((x - startX) / rangeX);
        }

        private double AdjustY(double y, double startY, double rangeY)
        {
            return viewPort.Top + viewPort.Height - (viewPort.Height * ((y - startY) / rangeY));
        }

        #endregion
    }
}
