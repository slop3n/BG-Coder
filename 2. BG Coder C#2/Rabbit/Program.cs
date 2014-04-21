using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = new List<string>();
        string endCondition = "END";
        for (int i = 0; i < 42; i++)
        {
            input.Add(Console.ReadLine());
            if (input[i] == endCondition)
            {
                break;
            }
        }
        Console.WriteLine("dsa");
    }
}