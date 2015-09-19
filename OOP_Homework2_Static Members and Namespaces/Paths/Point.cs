using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    class Point
    {
        
        private double x;
        private double y;
        private double z;
        private static readonly Point startingPoint = new Point(0, 0, 0);

        public static Point StartingPoint
        {
            get
            {
                return Point.startingPoint;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            string res = this.X + ", " + this.Y + ", " + this.Z;
            return res;
        }
        
    }
}
