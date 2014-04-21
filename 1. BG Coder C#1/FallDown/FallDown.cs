using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDown
{
    class FallDown
    {
        static void Main(string[] args)
        {
            //Input
            int[] nums = new int[8];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //Solution
            for (int i = 0; i < 7; i++)
            {
                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                    for (int j = 7; j > 0; j--)
                    {
                        if ((nums[j] >> bitPosition & 1) == 0 && (nums[j - 1] >> bitPosition & 1) == 1)
                        {
                            nums[j] |= (1 << bitPosition);
                            nums[j - 1] &= ~(1 << bitPosition);
                        }
                    }
                }
            }
            //Output
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}