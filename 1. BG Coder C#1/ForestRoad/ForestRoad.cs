using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            char path = '*';
            char blank = '.';
            int n = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                result.Append(new string(blank, i));
                result.Append(new string(path,1));
                result.AppendLine(new string(blank, n-i-1));
            }
            for (int i = 2; i <= n; i++)
            {
                result.Append(new string(blank, n-i));
                result.Append(new string(path, 1));
                result.AppendLine(new string(blank, i-1));
            }

                Console.WriteLine(result.ToString());

        }
    }
}