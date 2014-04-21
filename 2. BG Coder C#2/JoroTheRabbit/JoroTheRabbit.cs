using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[input.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int bestPath = 0;

        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int step = 1; step < numbers.Length; step++)
            {
                int index = startIndex;
                int currentPath = 1;
                int next = (index + step) % numbers.Length;
                while (numbers[index] < numbers[next])
                {
                    currentPath++;
                    index = next;
                    next = (index + step) % numbers.Length;
                }
                if (bestPath < currentPath)
                {
                    bestPath = currentPath;
                }
            }            
        }
        Console.WriteLine(bestPath);
    }
}