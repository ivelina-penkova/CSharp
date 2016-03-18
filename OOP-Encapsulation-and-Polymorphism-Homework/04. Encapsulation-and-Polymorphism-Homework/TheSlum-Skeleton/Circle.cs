using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Circle :IShape
    {
        private double radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Radius cannot be negative!");

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
