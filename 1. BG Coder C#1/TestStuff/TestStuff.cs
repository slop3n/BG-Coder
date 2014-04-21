using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3_2
{

    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row < n; row++)
            {
                for (int col = 1; col < row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }
    }
}