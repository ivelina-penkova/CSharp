using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    static class Storage
    {
                
        public static string[] LoadPath()
        {
            return System.IO.File.ReadAllLines(@"C:\Users\Ivka\Documents\GitHub\CSharp-Two\OOP_Homework2_Static Members and Namespaces\Paths\input.txt");
        }

        public static void SavePath(string[] lines)
        {
            System.IO.File.WriteAllLines(@"C:\Users\Ivka\Documents\GitHub\CSharp-Two\OOP_Homework2_Static Members and Namespaces\Paths\output.txt", lines);
        }
    }
}
