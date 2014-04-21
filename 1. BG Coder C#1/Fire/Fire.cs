using System;
using System.Text;
class Fire
{

    static void Main()
    {
        char fire = '#';
        char torchTop = '-';
        char torchLeft = '\\';
        char torchRight = '/';
        char blank = '.';
        int N = int.Parse(Console.ReadLine());
        var halfN = N >> 1;
        int quarterN = N >> 2;

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < halfN; i++)
        {
            result.Append(new string(blank, halfN - (i + 1)));
            result.Append(fire);
            result.Append(new string(blank, i << 1));
            result.Append(fire);
            result.AppendLine(new string(blank, halfN - (i + 1)));

        }
        for (int i = 0; i < quarterN; i++)
        {
            result.Append(new string(blank, i));
            result.Append(fire);
            result.Append(new string(blank, (halfN - (i + 1)) << 1));
            result.Append(fire);
            result.AppendLine(new string(blank, i));

        }

        result.AppendLine(new string(torchTop, N));
        for (int i = 0; i < halfN; i++)
        {
            result.Append(new string(blank, i));
            result.Append(new string(torchLeft, halfN - i));
            result.Append(new string(torchRight, halfN - i));
            result.AppendLine(new string(blank, i));
        }
        Console.WriteLine(result.ToString());

    }
}