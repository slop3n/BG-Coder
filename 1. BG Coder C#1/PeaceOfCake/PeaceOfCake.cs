using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pies
{
    class Program
    {
        static void Main(string[] args)
        {
            double nominatorA = double.Parse(Console.ReadLine());
            double denominatorA = double.Parse(Console.ReadLine());
            double nominatorB = double.Parse(Console.ReadLine());
            double denominatorB = double.Parse(Console.ReadLine());
            double nominatorPie = (denominatorA * nominatorB) + (denominatorB * nominatorA);
            double denominatorPie = denominatorA * denominatorB;
            double pie = nominatorPie / denominatorPie;
            if (pie >= 1)
            {
                Console.WriteLine("{0:0}", pie);
            }
            else
            {
                Console.WriteLine("{0:0.00000000000000000000}", pie);
            }
            Console.WriteLine("{0}/{1}", nominatorPie, denominatorPie);

        }
    }
}
