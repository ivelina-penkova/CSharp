using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Storage.LoadPath();
            Point[] path = Point3D.CreatePath(input);
            Storage.SavePath(Point3D.ToStringArray(path));
        }
    }
}
