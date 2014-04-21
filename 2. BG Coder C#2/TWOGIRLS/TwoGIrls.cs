using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] path = new int[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            path[i] = int.Parse(input[i]);
        }

        int mollyStartIndex = 0;
        int mollyFlowers = 0;
        for (int step = 0; step < path.Length; step++)
        {
            mollyFlowers += path[step];
        }
        
        Console.WriteLine(mollyFlowers);

    }
}