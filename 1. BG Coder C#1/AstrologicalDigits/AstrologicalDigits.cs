using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int sum = 0;
            while (true)
            {
                for (int i = 0; i < inputNum.Length; i++)
                {
                    if (!(inputNum[i]=='.' || inputNum[i] == '-'))
                    {
                        sum += int.Parse(inputNum[i].ToString());
                    }
                }
                if (sum < 10)
                {
                    break;  
                }
                inputNum = sum.ToString();
                sum = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
