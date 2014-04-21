using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage
{
    class ShipDamage
    {
        static void Main(string[] args)
        {
            int shipX1 = int.Parse(Console.ReadLine());
            int shipY1 = int.Parse(Console.ReadLine());
            int shipX2 = int.Parse(Console.ReadLine());
            int shipY2 = int.Parse(Console.ReadLine());
            int horizont = int.Parse(Console.ReadLine());
            int cata1X = int.Parse(Console.ReadLine());
            int cata1Y = int.Parse(Console.ReadLine());
            int cata2X = int.Parse(Console.ReadLine());
            int cata2Y = int.Parse(Console.ReadLine());
            int cata3X = int.Parse(Console.ReadLine());
            int cata3Y = int.Parse(Console.ReadLine());
            int throwDistance1 = (horizont - cata1Y);
            int throwDistance2 = (horizont - cata2Y);
            int throwDistance3 = (horizont - cata3Y);
            int left;
            int right;
            int top;
            int bottom;
            int hitX1 = cata1X;
            int hitY1 = throwDistance1+horizont;
            int hitX2 = cata2X;
            int hitY2 = throwDistance2+horizont;
            int hitX3 = cata3X;
            int hitY3 = throwDistance3+horizont;
            int damage = 0;
            if (shipX1 > shipX2)
            {
                right = shipX1;
                left = shipX2;
            }
            else
            {
                right = shipX2;
                left = shipX1;
            }
            
            if (shipY1>shipY2)
            {
                top = shipY1;
                bottom = shipY2;
            }
            else
            {
                top = shipY2;
                bottom = shipY1;
            }

            
            if (bottom < hitY1 && hitY1 < top && left < hitX1 && hitX1 < right)
            {
                damage = damage + 100;
            }
            
            if ((bottom == hitY1 || top == hitY1) && left < hitX1 && hitX1 < right)
            {
                damage += 50;
            }

            if (bottom < hitY1 && hitY1 < top && (left == hitX1 || hitX1 == right))
            {
                damage += 50;
            }

            if ((top == hitY1 && left == hitX1) || (top == hitY1 && right == hitX1) || (bottom == hitY1 && left == hitX1) || (bottom == hitY1 && right == hitX1))
            {
                damage += 25;
            }


            if (bottom < hitY2 && hitY2 < top && left < hitX2 && hitX2 < right)
            {
                damage = damage + 100;
            }

            if ((bottom == hitY2 || top == hitY2) && left < hitX2 && hitX2 < right)
            {
                damage += 50;
            }

            if (bottom < hitY2 && hitY2 < top && (left == hitX2 || hitX2 == right))
            {
                damage += 50;
            }

            if ((top == hitY2 && left == hitX2) || (top == hitY2 && right == hitX2) || (bottom == hitY2 && left == hitX2) || (bottom == hitY2 && right == hitX2))
            {
                damage += 25;
            }


            if (bottom < hitY3 && hitY3 < top && left < hitX3 && hitX3 < right)
            {
                damage = damage + 100;
            }

            if ((bottom == hitY3 || top == hitY3) && left < hitX3 && hitX3 < right)
            {
                damage += 50;
            }

            if (bottom < hitY3 && hitY3 < top && (left == hitX3 || hitX3 == right))
            {
                damage += 50;
            }

            if ((top == hitY3 && left == hitX3) || (top == hitY3 && right == hitX3) || (bottom == hitY3 && left == hitX3) || (bottom == hitY3 && right == hitX3))
            {
                damage += 25;
            }

            Console.WriteLine(damage+"%");
        }
    }
}
