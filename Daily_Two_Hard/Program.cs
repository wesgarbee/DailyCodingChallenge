/* Given an array of integers, return a new array such that each element at index i 
of the new array is the product of all the numbers in the original array except the one at i.
For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
If our input was [3, 2, 1], the expected output would be [2, 3, 6]. Follow-up: what if you can't use division? */

using System;

namespace Daily_Two_Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Instatiate a ne array to be passed to the method
            int[] theNums = new int[]{ 1, 2, 3, 4, 5 };

            // Passes the array to the method and stores the return value in a new array
            // Could use the theNums array but this introduces low-level SOC
            int[] newArray = ProductsAreFun(theNums);

            // Loops through the array and consoles out the int
            foreach (int num in newArray)
            {
                Console.WriteLine(num);
            }
        }

        // Method to loop through the array passed in and calculates the product per requirements
        static int[] ProductsAreFun(int[] nums)
        {
            int[] prodNums = new int[nums.Length];
            int product;

            for (int i = 0; i < nums.Length; i++)
            {
                product = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        product = product * nums[j];
                    }
                }

                prodNums[i] = product;
            }

            return prodNums;
        }
    }
}
