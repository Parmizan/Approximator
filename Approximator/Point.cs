using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximator
{
    class Point
    {
        double X;
        double Y;
        public Point (double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point(Point point)
        {
            this.X = point.GetX();
            this.Y = point.GetY();
        }
        public double GetX()
        {
            return this.X;
        }
        public double GetY()
        {
            return this.Y;
        }
        public void SetX(double X)
        {
            this.X = X;
        }
        public void SetY(double Y)
        {
            this.Y = Y;
        }
    }
}
