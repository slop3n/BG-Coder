using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                sum = first + second + third;
                first = second;
                second = third;
                third = sum;
            }
            Console.WriteLine("{0}---{1}", i, sum);
        }
    }
}
