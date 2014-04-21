using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {

            decimal tomatoSeed = decimal.Parse(Console.ReadLine());
            decimal tomatoArea = decimal.Parse(Console.ReadLine());
            decimal cucumberSeed = decimal.Parse(Console.ReadLine());
            decimal cucumberArea = decimal.Parse(Console.ReadLine());
            decimal potatoSeed = decimal.Parse(Console.ReadLine());
            decimal potatoArea = decimal.Parse(Console.ReadLine());
            decimal carrotSeed = decimal.Parse(Console.ReadLine());
            decimal carrotArea = decimal.Parse(Console.ReadLine());
            decimal cabbageSeed = decimal.Parse(Console.ReadLine());
            decimal cabbageArea = decimal.Parse(Console.ReadLine());
            decimal beansSeed = decimal.Parse(Console.ReadLine());
            decimal tomatoCost = tomatoSeed * 0.5m;
            decimal cucumberCost = cucumberSeed * 0.4m;
            decimal potatoCost = potatoSeed * 0.25m;
            decimal carrotCost = carrotSeed * 0.6m;
            decimal cabbageCost = cabbageSeed * 0.3m;
            decimal beansCost = beansSeed * 0.4m;
            decimal totalCost = tomatoCost + cucumberCost + potatoCost + cabbageCost + carrotCost + beansCost;
            decimal totalArea = 250-(tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
            Console.WriteLine("Total costs: " + totalCost);
            if (totalArea>0)
            {
                Console.WriteLine("Beans area: " + totalArea);
            }
            else if (totalArea<0)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea==0)
            {
                Console.WriteLine("No area for beans");
            }

        }
    }
}
