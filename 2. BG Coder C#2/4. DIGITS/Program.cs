﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string currentRow = Console.ReadLine();
            string[] rowAsArray = currentRow.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(rowAsArray[j]);
            }            
        }

        long sum = 0;

        for (int row = 0; row < n -4; row++)
        {
            for (int col = 0; col < n - 2; col++)
            {
                if (matrix[row+2,col] == 1 && matrix[row+1, col+1]== 1 && matrix[row, col+2]==1 && matrix[row+1,col+2] == 1 && 
                    matrix[row+2,col+2] == 1 && matrix[row+3,col+2] == 1&& matrix[row+4,col+2] == 1)
                {
                    sum += 1;   
                }
                if (matrix[row+1, col] == 2 && matrix[row, col+1] == 2 && matrix[row+1,col+2] == 2 && matrix[row+2,col+2] == 2 && matrix[row+3,col+1] == 2 && matrix[row+4,col] == 2 && matrix[row+4,col+1] == 2 && matrix[row+4,col+2]==2)
                {
                    sum += 2;
                }
                if (matrix[row,col] == 3 && matrix [row, col+1] == 3 && matrix[row,col+2]==3 && matrix[row+1,col+2]==3 && matrix[row+2,col+1]==3 && matrix[row+2,col+2]==3 && matrix[row+3,col+2] ==3 && matrix[row+4,col] == 3 && matrix[row+4,col+1]==3 && matrix[row+4,col+2]==3)
                {
                    sum += 3;
                }
                if (matrix[row,col]==4 && matrix[row,col+2]==4 && matrix[row+1,col]==4 && matrix[row+1,col+2]==4 && matrix[row+2,col]==4 && matrix[row+2,col+1]==4 && matrix[row+2,col+2]==4 && matrix[row+3,col+2]==4 && matrix[row+4,col+2]==4)
                {
                    sum += 4;
                }
                if (matrix[row,col]==5 && matrix[row,col+1]==5 && matrix[row,col+2]==5 && 
                    matrix[row+1,col]==5 && matrix[row+2,col]==5 && matrix[row+2,col+1]==5 && 
                    matrix[row+2,col+2]==5 && matrix[row+3,col+2]==5 && matrix[row+4,col]==5 && 
                    matrix[row+4,col+1]==5 && matrix[row+4,col+2]==5)
                {
                    sum += 5;
                }
                if (matrix[row,col]==6 && matrix[row,col+1]==6 && matrix[row,col+2]==6 && 
                    matrix[row+1,col]==6 && matrix[row+2,col]==6 && matrix[row+2,col+1]==6 && 
                    matrix[row+2,col+2]==6 && matrix[row+3,col]==6 && matrix[row+3,col+2]==6 && 
                    matrix[row+4,col]==6 && matrix[row+4,col+1]==6 && matrix[row+4,col+2]==6 )
                {
                    sum += 6;
                }
                if (matrix[row,col] == 7 && matrix[row,col+1] == 7 && matrix[row,col+2] == 7 &&
                    matrix[row+1,col+2] == 7 && matrix[row+2,col+1] == 7 && matrix[row+3,col+1] == 7 && matrix[row+4,col+1] == 7)
                {
                    sum += 7;
                }
                if (matrix[row,col]==8 && matrix[row,col+1]==8 && matrix[row,col+2]==8 && matrix[row+1,col]==8 && matrix[row+1,col+2]==8 && matrix[row+2,col+1]==8 && matrix[row+3,col]==8 && matrix[row+3,col+2]==8 && matrix[row+4,col]==8 && matrix[row+4,col+1]==8 && matrix[row+4,col+2]==8)
                {
                    sum += 8;
                }
                if (matrix[row,col]==9 && matrix[row,col+1]==9 && matrix[row,col+2]==9 && matrix[row+1,col]==9 && matrix[row+1,col+2]==9 && matrix[row+2,col+1]==9 && matrix[row+2,col+2]==9 && matrix[row+3,col+2]==9 && matrix[row+4,col]==9 && matrix[row+4,col+1]==9 && matrix[row+4,col+2]==9 )
                {
                    sum += 9;
                }
            }
        }
        Console.WriteLine(sum);
    }
}