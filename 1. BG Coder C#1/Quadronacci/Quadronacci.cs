using System;
using System.Numerics;
class Quadronacci
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger fourth = BigInteger.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        BigInteger sum = 0;
        if (cols == 4)
        {
            Console.WriteLine("{0} {1} {2} {3}", first, second, third, fourth);
        }
        else
        {
            Console.Write("{0} {1} {2} {3} ", first, second, third, fourth);
        }
        for (int row = 0; row < rows; row++)
        {
            int currentCols = 0;
            if (row == 0)
            {
                currentCols = 4;
            }
            for (int col = currentCols; col < cols; col++)
            {
                sum = first + second + third + fourth;
                first = second;
                second = third;
                third = fourth;
                fourth = sum;
                if (col + 1 == cols)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.Write(sum + " ");
                }
            }
        }
    }
}