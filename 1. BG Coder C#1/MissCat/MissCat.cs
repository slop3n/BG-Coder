using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int[] cats = new int[11];

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;
            int counter10 = 0;
            for (int i = 0; i < n; i++)
            {

                int gradeForCat = int.Parse(Console.ReadLine());
                switch (gradeForCat)
                {
                    case 1: counter1++; break;
                    case 2: counter2++; break;
                    case 3: counter3++; break;
                    case 4: counter4++; break;
                    case 5: counter5++; break;
                    case 6: counter6++; break;
                    case 7: counter7++; break;
                    case 8: counter8++; break;
                    case 9: counter9++; break;
                    case 10: counter10++; break;
                }
                //cats[gradeForCat]++;

            }

            //if (counter1 > counter2 && counter1 > counter3 && counter1 > counter4 && counter1 > counter5 && counter1 > counter6 && counter1 > counter7 && counter1 > counter8 && counter1 > counter9 && counter1 > counter10)
            //{
            //    Console.WriteLine(1);
            //}

            //else if (counter2 > counter1 && counter2 > counter3 && counter2 > counter4 && counter2 > counter5 && counter2 > counter6 && counter2 > counter7 && counter2 > counter8 && counter2 > counter9 && counter2 > counter10)
            //{
            //    Console.WriteLine(2);
            //}

            int[] counters = {counter1, counter2, counter3, counter4, counter5, counter6, counter7, counter8, counter9, counter10 };
            int highestCounter = counters.Max();
            //Console.WriteLine(highestCounter);
            Console.WriteLine(counters.ToList().IndexOf(highestCounter)+1);
        }
    }
}
