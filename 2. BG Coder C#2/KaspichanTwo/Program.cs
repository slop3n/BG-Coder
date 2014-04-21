using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            List<string> digits = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                digits.Add(i.ToString());
            }
            for (char j = 'a'; j <= 'i'; j++)
            {
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    digits.Add(j.ToString() + i.ToString());
                }
            }
            string result = string.Empty;
            while (n != 0)
            {
                result = digits[(int)(n % 256)] + result;
                n = n / 256;
            }
            Console.WriteLine(result);
        }
    }
}
