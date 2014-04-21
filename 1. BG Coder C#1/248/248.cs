using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        decimal first = decimal.Parse(Console.ReadLine());
        decimal second = decimal.Parse(Console.ReadLine());

        decimal third = decimal.Parse(Console.ReadLine());
        decimal result = 0;
        decimal resultNew = 0;
        if (second == 2)
        {
            result = first % third;
        }
        else if (second == 4)
        {
            result = first + third;
        }
        else if (second == 8)
        {
            result = first * third;
        }
        if (result % 4 == 0)
        {
            resultNew = result / 4;
        }
        else if (result % 4 != 0)
        {
            resultNew = result % 4;
        }
        Console.WriteLine(resultNew);
        Console.WriteLine(result);
    }
}
