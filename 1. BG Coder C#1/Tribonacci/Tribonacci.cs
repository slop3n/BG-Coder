using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {

            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger third = BigInteger.Parse(Console.ReadLine());
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = 0;
            BigInteger number1 = number - 3;
            for (int i = 0; i < number1; i++)
            {
                sum = first + second + third;
                first = second;
                second = third;
                third = sum;
                //Console.WriteLine("Num of element {0} --- Sum of elements {1}"  ,i, sum);
            }
            Console.WriteLine(sum);
        }
    }
}
