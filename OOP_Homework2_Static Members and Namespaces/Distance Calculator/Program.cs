/*
Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. 
Search in Internet how to calculate distance in the 3D Euclidian space.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Distance_Calculator.Point3D;

namespace Distance_Calculator
{
    static class DistanceCalculator
    {
               
        static DistanceCalculator()
        {
        }


        public static double CalcDistance(Point3D A, Point3D B)
        {
            double res = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2) + Math.Pow((A.Z - B.Z), 2));
            return res;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Point3D A = new Point3D(2, 6, 8.6);
            Point3D B = new Point3D(9, 7, 4.5);
            Console.WriteLine(DistanceCalculator.CalcDistance(A,B));
        }
    }
}
