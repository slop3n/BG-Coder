using System;
using System.Collections.Generic;
using System.Linq;
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

        int positon = nineSystemNumber.Length-1;
        int number = 0;
        for (int i = 0; i < nineSystemNumber.Length; i++)
        {
            int digit = int.Parse(nineSystemNumber[i].ToString());
            number += digit * PowerOfNine(positon);
            positon--;
        }
        Console.WriteLine(number);
    }

        static int PowerOfNine(int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
			{
			 result *= 9;
            }
            return result;
        }
    

    static string ConvertGagStringToNumber(string input)
    {
        switch (input)
        {
            case "-!": return "0"; break;
            case "**": return "1"; break;
            case "!!!": return "2"; break;
            case "&&": return "3"; break;
            case "&-": return "4"; break;
            case "!-": return "5"; break;
            case "*!!!": return "6"; break;
            case "&*!": return "7"; break;
            case "!!**!-": return "8"; break;
            default: return "Invalid Number"; break;
        }
    }
}
