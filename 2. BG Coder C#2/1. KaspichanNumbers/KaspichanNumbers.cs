using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class KaspichanNumbers
{

    static void printKaspichan(List<BigInteger> arr)
    {
        foreach (var num in arr)
        {
            if (num < 26)
            {
                Console.Write((char)('A' + num));
            }
            else
            {
               Console.Write((char)('`' + num / 26));
               Console.Write((char)('A' + num % 26));
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        List<BigInteger> test = new List<BigInteger>();
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        do
        {
            test.Add(number % 256);
            number /= 256;
        }
        while (number != 0);

        test.Reverse();
        printKaspichan(test);
    }
}