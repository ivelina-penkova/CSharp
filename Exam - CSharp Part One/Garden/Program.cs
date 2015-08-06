using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InstalledUICulture;

            Console.WriteLine("Please enter:");

            Console.WriteLine("tomato seeds amount:");
            int tomatoSeedsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("tomato area:");
            int tomatoArea = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("cucumber seeds amount:");
            int cucumberSeedsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("cucumber area:");
            int cucumberArea = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("potato seeds amount:");
            int potatoSeedsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("potato area:");
            int potatoArea = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("carrot seeds amount:");
            int carrotSeedsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("carrot area:");
            int carrotArea = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("cabbage seeds amount:");
            int cabbageSeedsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("cabbage area:");
            int cabbageArea = int.Parse(Console.ReadLine());
            //
            Console.WriteLine("beans seeds amount:");
            int beansSeedsAmount = int.Parse(Console.ReadLine());

            //Seeds Costs
            double tomatoCost = 0.5;
            double cucumberCost = 0.4;
            double potatoCost = 0.25;
            double carrotCost = 0.6;
            double cabbageCost = 0.3;
            double beansCost = 0.4;
            //
            int totalArea = 250;

            double totalCost = tomatoSeedsAmount * tomatoCost + cucumberSeedsAmount * cucumberCost + potatoSeedsAmount * potatoCost + carrotSeedsAmount * carrotCost + cabbageSeedsAmount * cabbageCost + beansSeedsAmount * beansCost;
            Console.WriteLine("Total cost:{0:F2}",totalCost);

            int beansArea=totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);

            if (beansArea > 0) 
            {
                Console.WriteLine("Beans area:{0}",beansArea);
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else 
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
