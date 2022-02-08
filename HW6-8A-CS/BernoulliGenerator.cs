using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class BernoulliGenerator 
    {
        #region MEMBERS

        private Random Rnd;

        #endregion
        
        #region CONSTRUCTOR

        public BernoulliGenerator()
        {
            Rnd = new Random();
        }

        #endregion

        #region PUBLIC

        public List<BPath> CreatePathSet(int mode, int nbPaths, int nbPoints, double successProbability)
        {
            var paths = new List<BPath>();
    
            for (int i = 0; i < nbPaths; i++)
            {
                var path = CreateNewPath(mode, nbPoints, successProbability);
                paths.Add(path);
            }

            return paths;
        }

        public List<Cluster> CreateClusters(int mode, List<BPath> paths, int nbClusters, int T)
        {
            var tPoints = new List<double>();

            foreach (var path in paths)
            {
                var tPoint = path.Points.Where(f => f.X == T).FirstOrDefault();
                if (tPoint != null)
                    tPoints.Add(tPoint.Y);
            }

            List<Cluster> clusters = new List<Cluster>();
            double clusterSize = (1d / (double)nbClusters);

            for (int i = 0; i < nbClusters; i++)
            {
                // valori positivi
                var min = i * clusterSize;
                var max = (i + 1) * clusterSize;
                var occurs = tPoints.Where(d => d >= min && d < max).Count();
                clusters.Add(new Cluster() { MinValue = min, MaxValue = max, NbOccurrencies = occurs });
            }

            if (mode == 2)
            {
                // valori negativi
                for (int i = 0; i < nbClusters; i++)
                {
                    var max = i * -clusterSize;
                    var min = (i + 1) * -clusterSize;
                    var occurs = tPoints.Where(d => d >= min && d < max).Count();
                    clusters.Add(new Cluster() { MinValue = min, MaxValue = max, NbOccurrencies = occurs });
                }
            }

            return clusters;
        }

        #endregion

        #region PRIVATE

        private BPath CreateNewPath(int mode, int n, double p)
        {
            BPath path = new BPath();

            double k = 0.0;
            int s = 0;
            double f = 0.0;

            for (int i = 0; i < n; i++)
            {
                double r = Rnd.NextDouble();
                s += (r < p ? 1 : 0);

                switch (mode)
                {
                    case 1:
                        k = (double)s / (double)n;
                        break;

                    case 2:
                        f = (double)s / (double)(i + 1);
                        k = (f - p) / Math.Sqrt(p * (1 - p * 1) / (i + 1)) * 0.14;  // il fattore 0.14 (arbitrario) è necessario per aggiustare i valori in modo tale che siano plottati in modo ben visibile
                        break;

                    case 3:
                        f = (double)s / (double)n;
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
