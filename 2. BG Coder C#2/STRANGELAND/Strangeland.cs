using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string partial = string.Empty;
        string nineSystemNumber = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            partial += input[i];

            string currentDigit = ConvertGagStringToNumber(partial);
            if (currentDigit != "Invalid Number")
            {
                nineSystemNumber += currentDigit;
                partial = string.Empty;
            }
        }

        decimal positon = nineSystemNumber.Length - 1;
        decimal number = 0;
        for (int i = 0; i < nineSystemNumber.Length; i++)
        {
            decimal digit = decimal.Parse(nineSystemNumber[i].ToString());
            number += digit * PowerOfNine(positon);
            positon--;
        }
        Console.WriteLine(number);
    }

    static decimal PowerOfNine(decimal power)
    {
        decimal result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 7;
        }
        return result;
    }


    static string ConvertGagStringToNumber(string input)
    {
        switch (input)
        {
            case "f": return "0"; break;
            case "bIN": return "1"; break;
            case "oBJEC": return "2"; break;
            case "mNTRAVL": return "3"; break;
            case "lPVKNQ": return "4"; break;
            case "pNWE": return "5"; break;
            case "hT": return "6"; break;
            default: return "Invalid Number"; break;
        }
    }
}
