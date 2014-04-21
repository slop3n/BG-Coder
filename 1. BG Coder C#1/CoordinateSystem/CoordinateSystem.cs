using System;

class CoordinateSystem
{

    //                  100/100

    static void Main()
    {
        decimal X = decimal.Parse(Console.ReadLine());
        decimal Y = decimal.Parse(Console.ReadLine());
        if (X > 0 && Y > 0)
        {
            Console.WriteLine("1");
        }

        if (X < 0 && Y > 0)
        {
            Console.WriteLine("2");
        }

        if (X < 0 && Y < 0)
        {
            Console.WriteLine("3");
        }

        if (X > 0 && Y < 0)
        {
            Console.WriteLine("4");
        }

        if (X == 0 && Y == 0)
        {
            Console.WriteLine("0");
        }

        if (X == 0 && Y != 0)
        {
            Console.WriteLine("5");
        }

        if (X != 0 && Y == 0)
        {
            Console.WriteLine("6");
        }
    }
}
