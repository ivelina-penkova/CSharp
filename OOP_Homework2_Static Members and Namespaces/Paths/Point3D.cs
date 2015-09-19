/*Create a static class Path3D to hold a sequence of points in 3D space. Create a static class Storage with static methods to save
and load paths from a text file. Use a file format of your choice. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    static class Point3D
    {
        public static Point[] CreatePath(string[] coords)
        {
            Point[] path = new Point[coords.Length/3];
            for (int i = 0,count=0; i < coords.Length; i+=3,count++)
            {
                path[count] = new Point(double.Parse(coords[i]), double.Parse(coords[i + 1]), double.Parse(coords[i + 2]));
            }
            return path;
        }

        public static string[] ToStringArray(Point[] path)
        {
            string[] res = new string[path.Length*3];
            for (int i = 0,count=0; i < res.Length; i+=3,count++)
            {
                res[i] = path[count].X.ToString();
                res[i + 1] = path[count].Y.ToString();
                res[i + 2] = path[count].Z.ToString();
            }
            return res;
        }
    
    }
}
