using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egg
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char shell = '*';
            char blank = '.';
            char ribbon = '#';
            int height = input * 2;
            int width = (input * 3) - 1;
            int drawingArea = (input * 3) + 1;
            int eggTop = input - 1;
            int eggBot = input - 1;
            int halfDrawing = drawingArea / 2;

            StringBuilder result = new StringBuilder();
            //top
            result.Append(new string(blank, (drawingArea / 2) - (eggTop / 2)));
            result.Append(new string(shell, eggTop));
            result.AppendLine(new string(blank, (drawingArea / 2) - (eggTop / 2)));

            //top to ribbon
            for (int i = 0; i < input - 2; i++)
            {
                result.Append(new string(blank, eggTop));
                result.Append(new string(shell, 1));
                result.Append(new string(blank, width - (eggTop * 2)));
                result.Append(new string(shell, 1));
                result.AppendLine(new string(blank, eggTop));
                eggTop -= 2;
                if (eggTop < 0)
                {
                    eggTop = 1;
                }
            }

            //ribbon
            result.Append(new string(blank, 1));
            result.Append(new string(shell, 1));
            for (int i = 0; i < drawingArea - 4; i++)
            {
                if (i % 2 == 0)
                {
                    result.Append(new string(blank, 1));
                }
                else
                {
                    result.Append(new string(ribbon, 1));
                }
            }
            result.Append(new string(shell, 1));
            result.AppendLine(new string(blank, 1));
            result.Append(new string(blank, 1));
            result.Append(new string(shell, 1));
            for (int i = 0; i < drawingArea - 4; i++)
            {
                if (i % 2 != 0)
                {
                    result.Append(new string(blank, 1));
                }
                else
                {
                    result.Append(new string(ribbon, 1));
                }
            }
            result.Append(new string(shell, 1));
            result.AppendLine(new string(blank, 1));

            //ribbon to bottom
            for (int i = 0; i < (input - 2) / 2; i++)
            {
                result.Append(new string(blank, 1));
                result.Append(new string(shell, 1));
                result.Append(new string(blank, drawingArea - 4));
                result.Append(new string(shell, 1));
                result.AppendLine(new string(blank, 1));
            }
            for (int i = 1; i < input; i++)
            {
                result.Append(new string(blank, i));
                result.Append(new string(shell, 1));
                result.Append(new string(blank, width - (2 * i)));
                result.Append(new string(shell, 1));
                result.AppendLine(new string(blank, i));
                i += 1;
            }

            //bottom
            result.Append(new string(blank, (drawingArea / 2) - (eggBot / 2)));
            result.Append(new string(shell, eggBot));
            result.AppendLine(new string(blank, (drawingArea / 2) - (eggBot / 2)));

            Console.WriteLine(result);
        }
    }
}
