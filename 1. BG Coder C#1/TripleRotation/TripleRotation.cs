using System;

class TripleRotation
{
    static void Main()
    {
        string input = Console.ReadLine();
        char firstLast = '0';
        char secondLast = '0';
        char thirdLast = '0';
        if (input.Length>0) 
        {
            firstLast = input[input.Length - 1];
        }
        if (input.Length>1)
        {
            secondLast = input[input.Length - 2];
        }
        if (input.Length>2)
        {
            thirdLast = input[input.Length - 3];
        }
        string output = thirdLast.ToString() + secondLast.ToString() + firstLast.ToString() + input.ToString();
        if (input.Length > 2)
        {
            Console.WriteLine(Convert.ToInt32(output) / 1000);
        }
        else if (input.Length == 2)
        {
            Console.WriteLine("{0}{1}",firstLast, secondLast);
        }
        else if (input.Length == 1)
        {
            Console.WriteLine(firstLast);
        }                       
    }
}