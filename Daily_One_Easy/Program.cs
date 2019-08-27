/* Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
Bonus: Can you do this in one pass? */

using System;

namespace Daily_One_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{1, 2, 3, 4};
            Console.WriteLine(AddUp(nums, 34));
        }
        
        static bool AddUp(int[] nums, int sumNum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if ((nums[i] + nums[j]) == sumNum) { return true; }
                    }
                }
            }

            return false;
        }
    }
}
