using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        char blank = '.';
        char boat = '*';
        int n = int.Parse(Console.ReadLine());
        int height = 6 + (((n - 3) / 2) * 3);
        int sail = (2 / 3) * height;
        int core = (height / 3);
        int width = (n * 2) + 1;

        StringBuilder result = new StringBuilder();

        result.Append(new string(blank, n));
        result.Append(new string(boat, 1));
        result.AppendLine(new string(blank, n));

        result.Append(new string(blank, n - 1));
        result.Append(new string(boat, 3));
        result.AppendLine(new string(blank, n - 1));

        for (int i = n - 2, j = 1; i > 0; i--, j++)
        {
            result.Append(new string(blank, i));
            result.Append(new string(boat, 1));
            result.Append(new string(blank, j));
            result.Append(new string(boat, 1));
            result.Append(new string(blank, j));
            result.Append(new string(boat, 1));
            result.AppendLine(new string(blank, i));
        }

        result.AppendLine(new string(boat, width));

        for (int i = 1; i < core; i++)
        {
            result.Append(new string(blank, i));
            result.Append(new string(boat, 1));
            result.Append(new string(blank, (width / 2) - i - 1));
            result.Append(new string(boat, 1));
            result.Append(new string(blank, (width / 2) - i - 1));
            result.Append(new string(boat, 1));
            result.AppendLine(new string(blank, i));
        }

        result.Append(new string(blank, (n / 2) + 1));
        result.Append(new string(boat, n));
        result.AppendLine(new string(blank, (n / 2) + 1));

        Console.WriteLine(result.ToString());

    }
}


