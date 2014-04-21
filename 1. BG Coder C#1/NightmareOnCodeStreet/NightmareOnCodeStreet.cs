using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace nightmare
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger result = 0;
            BigInteger counter = 0;
            BigInteger val = 0;
            for (int i = 1; i < input.Length; i+=2)
            {

                val = (int)Char.GetNumericValue(input[i]);

                if (input[i] == '1' || input[i] == '2' || input[i] == '3' || input[i] == '4' || input[i] == '5' || input[i] == '6' || input[i] == '7' || input[i] == '8' || input[i] == '9' || input[i] == '0')
                {
                    result += val;
                    counter++;
                }                
            }
            Console.WriteLine(counter + " " + result);
        }
    }
}