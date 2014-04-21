using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static int[][] ReadData(int[][] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            field[i] = new int[currentLine.Length];
            for (int j = 0; j < currentLine.Length; j++)
            {
                field[i][j] = int.Parse(currentLine[j]);
            }


        }
        return field;
    }

    static long FindCurrentSpecialValue(int[][] field, int column, bool[][] used)
    {
        long result = 0;
        int currentRow = 0;

        while (true)
        {
            result++;

            if (used[currentRow][column])
            {
                return long.MinValue;
            }

            if (field[currentRow][column] < 0)
            {
                result -= field[currentRow][column];
                return result;
            }

            int nextColumn = field[currentRow][column];
            used[currentRow][column] = true;
            column = nextColumn;

            if (currentRow == field.GetLength(0))
            {
                currentRow = 0;
            }

            currentRow++;
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[][] field = new int[n][];
        ReadData(field);
        bool[][] used = new bool[n][];
        long max = long.MinValue;
        
        for (int i = 0; i < n; i++)
        {
            used[i] = new bool[field[i].Length];        
        }
        
        for (int i = 0; i < field[0].Length; i++)
        {
            long specialValue = FindCurrentSpecialValue(field, i, used);

            if (max < specialValue)
            {
                max = specialValue;
            }
        }

        Console.WriteLine(max);
    }
}