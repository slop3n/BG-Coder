using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAttack
{
    class FighterAttack
    {
        static void Main(string[] args)
        {
            int pX1 = int.Parse(Console.ReadLine());
            int pY1 = int.Parse(Console.ReadLine());
            int pX2 = int.Parse(Console.ReadLine());
            int pY2 = int.Parse(Console.ReadLine());
            int fighterX = int.Parse(Console.ReadLine());
            int fighterY = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());
            int hitX = fighterX + range;
            int hitY = fighterY;
            int left;
            int right;
            int bottom;
            int top;
            if (pX1>pX2)
            {
                right = pX1;
                left = pX2;
            }
            else
            {
                right = pX2;
                left = pX1;
            }
            if (pY1>pY2)
            {
                top = pY1;
                bottom = pY2;
            }
            else
            {
                top = pY2;
                bottom = pY1;
            }
            int damage = 0;
            
            if (left <= hitX && hitX <= right && bottom <= hitY && hitY <= top)
            {
                damage = damage + 100;
            }
            
            if (left <= (hitX+1) && (hitX+1) <= right && bottom <= hitY && hitY <= top)
            {
                damage = damage + 75;
            }
            
            if (left <= hitX && hitX <= right && bottom <= (hitY+1) && (hitY+1) <= top)
            {
                damage = damage + 50;
            }
            
            if (left <= hitX && hitX <= right && bottom <= (hitY - 1) && (hitY - 1) <= top)
            {
                damage = damage + 50;
            }
            Console.WriteLine(damage + "%");
        }
    }
}
