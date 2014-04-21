using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string result = Convert.ToString(input, 2);
            string newString = result.PadLeft(16, '0');
            Console.WriteLine(newString);
            Console.WriteLine(newString.Length);
            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i]>0 && newString[i] <newString.Length)
                {
                    Console.Write(".");
                }
                if (newString[i] == '0')
                {
                    Console.Write("###");
                }
                if (newString[i] == '1')
                {
                    Console.Write(".#.");
                }
            }

        }
    }
}