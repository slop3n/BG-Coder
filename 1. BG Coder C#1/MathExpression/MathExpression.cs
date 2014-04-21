using System;

class MathExpression
{

    //                 100/100

    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal nSq = n * n;
        decimal exp1 = 1 / (m * p);
        decimal nominator = nSq + exp1 + 1337;
        decimal denominator = n - (decimal)128.523123123 * p;
        decimal expression = nominator / denominator;
        decimal mod = (int)m % (decimal)180;
        double sin = Math.Sin((double)mod);
        decimal final = expression + (decimal)sin;
        Console.WriteLine("{0:F6}", final);

    }
}
