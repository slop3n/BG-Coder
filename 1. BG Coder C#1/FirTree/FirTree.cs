using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            char blank = '.';
            char tree = '*';
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int halfLenght = n - 1;
            int length = ((n - 2) * 2) + 1;

            result.Append(new string(blank, halfLenght-1));
            result.Append(new string(tree, 1));
            result.AppendLine(new string(blank, halfLenght-1));

            for (int i = 1; i < halfLenght; i++)
            {
                result.Append(new string(blank, (length / 2)  - i));
                result.Append(new string(tree, i + i + 1));
                result.AppendLine(new string(blank,(length / 2) -i));
            }

            result.Append(new string(blank, halfLenght-1));
            result.Append(new string(tree, 1));
            result.AppendLine(new string(blank, halfLenght-1));

            Console.WriteLine(result);

        }
    }
}
