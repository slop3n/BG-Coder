using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaspichania
{
    class Program
    {
        static void Main(string[] args)
        {
            char blank = '.';
            char wood = '*';
            StringBuilder result = new StringBuilder();
            int input = int.Parse(Console.ReadLine());
            int drawingAreaWidth = (input * 2) + 1;
            int drawingAreaHeight = 6 + (((input - 3) / 2) * 3);
            int sailHeight = (drawingAreaHeight / 3) * 2;
            int boatHeight = (drawingAreaHeight / 3);

            //top
            result.Append(new string(blank, input));
            result.Append(new string(wood, 1));
            result.AppendLine(new string(blank, input));

            //top to sail
            for (int i = sailHeight; i > 2; i--)
            {
                result.Append(new string(blank, i - 2));
                result.Append(new string(wood, 1));
                result.Append(new string(blank, sailHeight - i));
                result.Append(new string(wood, 1));
                result.Append(new string(blank, sailHeight - i));
                result.Append(new string(wood, 1));
                result.AppendLine(new string(blank, i - 2));
            }

            //sail
            result.AppendLine(new string(wood, drawingAreaWidth));

            //sail to bot
            for (int i = 1; i < boatHeight; i++)
            {
                result.Append(new string(blank, i));
                result.Append(new string(wood, 1));
                result.Append(new string(blank, (drawingAreaWidth / 2) - i - 1));
                result.Append(new string(wood, 1));
                result.Append(new string(blank, (drawingAreaWidth / 2) - i - 1));
                result.Append(new string(wood, 1));
                result.AppendLine(new string(blank, i));
            }

            //bottom
            result.Append(new string(blank, (drawingAreaWidth / 2) - (input / 2)));
            result.Append(new string(wood, input));
            result.Append(new string(blank, (drawingAreaWidth / 2) - (input / 2)));

            Console.WriteLine(result);
        }
    }
}
