using System;
using System.Linq;
using System.Collections.Generic;

namespace MyHomework
{
    public class BPoint
    {
        public int X { get; set; }
        public double Y { get; set; }

        public BPoint()
        {
            X = 0;
            Y = 0;
        }

        public BPoint(int x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class BPath
    {
        public List<BPoint> Points { get; set; }

        public BPath()
        {
            Points = new List<BPoint>();
        }
    }

    public class Cluster
    {
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public int NbOccurrencies { get; set; }

        public Cluster()
        {
        }
    }

    public class Bernoulli
    {
        #region MEMBERS

        public List<BPath> Paths { get; set; }
        public List<Cluster> Clusters_T { get; set; }
        public List<Cluster> Clusters_N { get; set; }
        public int TValue { get; set; }

        private Random Rnd = new Random();

        private int _freqType;
        private int _nbPaths;
        private int _nbPoints;
        private double _successProbability;
        private int _nbClusters;

        #endregion

        #region CONSTRUCTOR

        public Bernoulli(int freqType, int nbPaths, int nbPoints, double successProbability, int T)
        {
            _freqType = freqType;
           _nbPaths = nbPaths;
           _nbPoints = nbPoints;
           _successProbability = successProbability;

            _nbClusters = 0;
            if (nbPaths > 10)
                _nbClusters = (int)Math.Truncate(_nbPaths * 0.1);

            TValue = T;

            CreatePathSet();
            this.Clusters_T = CreateClusters(T);
            this.Clusters_N = CreateClusters(_nbPoints);
        }

        #endregion

        #region PUBLIC

        #endregion

        #region PRIVATE

        private void CreatePathSet()
        {
            this.Paths = new List<BPath>();

            for (int i = 0; i < _nbPaths; i++)
            {
                var path = CreateNewPath();
                Paths.Add(path);
            }

        }

        private List<Cluster> CreateClusters(int T)
        {
            var tPoints = new List<double>();

            foreach (var path in this.Paths)
            {
                var tPoint = path.Points.Where(f => f.X == T).FirstOrDefault();
                if (tPoint != null)
                    tPoints.Add(tPoint.Y);
            }

            List<Cluster> clusters = new List<Cluster>();
            double clusterSize = (1d / (double)_nbClusters);

            for (int i = 0; i < _nbClusters; i++)
            {
                // valori positivi
                var min = i * clusterSize;
                var max = (i + 1) * clusterSize;
                var occurs = tPoints.Where(d => d >= min && d < max).Count();
                clusters.Add(new Cluster() { MinValue = min, MaxValue = max, NbOccurrencies = occurs });
            }

            if (_freqType == 2)
            {
                // valori negativi
                for (int i = 0; i < _nbClusters; i++)
                {
                    var max = i * -clusterSize;
                    var min = (i + 1) * -clusterSize;
                    var occurs = tPoints.Where(d => d >= min && d < max).Count();
                    clusters.Add(new Cluster() { MinValue = min, MaxValue = max, NbOccurrencies = occurs });
                }
            }

            return clusters;
        }

        private BPath CreateNewPath()
        {
            BPath path = new BPath();

            double k = 0.0;
            int s = 0;
            double f = 0.0;
            double q = 1 - _successProbability;

            for (int i = 0; i < _nbPoints; i++)
            {
                double r = Rnd.NextDouble();
                s += (r < _successProbability ? 1 : 0);

                switch (_freqType)
                {
                    case 1:
                        k = (double)s / (double)_nbPoints;
                        break;

                    case 2:
                        f = (double)s / (double)(i + 1);
                        k = (f - _successProbability) / Math.Sqrt(_successProbability * q / (i + 1)) * 0.14;  // il fattore 0.14 (arbitrario) è necessario per aggiustare i valori in modo tale che siano plottati in modo ben visibile
                        break;

                    case 3:
                        f = (double)s / (double)_nbPoints;
                        k = f / (Math.Sqrt(i + 1)) * 17;    // il fattore 17 (arbitrario) è necessario per aggiustare i valori in modo tale che siano plottati in modo ben visibile
                        break;

                    default:
                        k = (double)s / (double)(i + 1);
                        break;
                }

                path.Points.Add(new BPoint(i + 1, k));
            }

            return path;
        }

        #endregion
    }
}
