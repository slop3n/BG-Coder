using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesOrOranges
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int tempNum = (int)char.GetNumericValue(input[i]);
                if (tempNum % 2 == 0)
                {
                    sumEven += tempNum;
                }
                else
                {
                    sumOdd += tempNum;
                }
            }
            if (sumEven > sumOdd)
            {
                Console.WriteLine("apples " + sumEven);
            }
            else if (sumOdd > sumEven)
            {
                Console.WriteLine("oranges " + sumOdd);
            }
            else
            {
                Console.WriteLine("both " + sumOdd);
            }
        }
    }
}