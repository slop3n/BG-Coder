using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int powerCounter = 0;
            int decimalNumber = 0;

            while (inputNumber !=0)
            {
                int lastNumber = inputNumber % 10;
                decimalNumber += lastNumber *(int) Math.Pow(7, powerCounter);
                powerCounter++;
                inputNumber /= 10;
            }
            decimalNumber++;
            string result="";
            while (decimalNumber!=0)
            {
                int lastNumber = decimalNumber % 7;
                result = lastNumber+result;
                decimalNumber /= 7;
            }
            Console.WriteLine(result);
        }
    }
}
