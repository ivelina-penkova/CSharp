﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigth) : base(width, heigth) { }

        public override double CalculateArea()
        {
            return this.Width * this.Heigth;
        }
        public override double CalculatePerimeter()
        {
            return 2 * this.Width + 2 * this.Heigth;
        }
    }
}
