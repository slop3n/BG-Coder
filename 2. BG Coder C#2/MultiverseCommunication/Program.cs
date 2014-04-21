using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class Program
    {
        static int ConvertNumbers(string input)
        {
            switch (input)
            {
                case "CHU": return 0; break;
                case "TEL": return 1; break;
                case "OFT": return 2; break;
                case "IVA": return 3; break;
                case "EMY": return 4; break;
                case "VNB": return 5; break;
                case "POQ": return 6; break;
                case "ERI": return 7;break;
                case "CAD": return 8; break;
                case "K-A": return 9; break;
                case "IIA": return 10; break;
                case "YLO": return 11; break;
                case "PLA": return 12; break;
                default: throw new ArgumentException();

            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long position = input.Length / 3 - 1;
            long result = 0;
            for (int i = 0; i < input.Length; i+=3)
            {
                string currentDigit = input.Substring(i, 3);
                result += ConvertNumbers(currentDigit) * PowerOfMultiverse(position);
                position--;
            }
            Console.WriteLine(result);
        }

        static long PowerOfMultiverse(long power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 13; 
            }
            return result;
        }
    }
}