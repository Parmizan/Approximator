using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximator
{
    class Lagrange
    {
        private List<Point> Points;
        public Lagrange(List<Point> Points)
        {
            this.Points = Points;
        }
        public double getResult(double x)
        {
            double lagrangeCount = 0;
            for (int i = 0; i < Points.Count; i++)
            {
                double basicsPol = 1;
                for (int j = 0; j < Points.Count; j++)
                {
                    if (j != i)
                    {
                        basicsPol *= (x - Points[j].GetX()) / (Points[i].GetX() - Points[j].GetX());
                    }
                }
                lagrangeCount += basicsPol * Points[i].GetY();
            }
            return lagrangeCount;
        }
    }
}
