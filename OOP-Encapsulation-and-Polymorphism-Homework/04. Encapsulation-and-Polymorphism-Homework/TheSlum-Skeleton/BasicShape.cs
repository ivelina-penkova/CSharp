using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double heigth;

        protected BasicShape(double width, double heigth) {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative!");
                }
                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Heigth cannot be negative!");
                }
                this.heigth = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
