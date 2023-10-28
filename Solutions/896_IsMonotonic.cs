using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class IsMonotonic
    {
        public static void IsMonotonicArray() 
        {
            //int[] input = { 1, 2, 2, 3 };
            //int[] input = { 1, 3, 2 };
            int[] input = { 6, 5, 4, 4 };
            var result = IsMonotonics(input);
            Console.WriteLine(result);
        }
        private static bool IsMonotonics(int[] nums)
        {
            bool increasing = true;
            bool decreasing = true;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    decreasing = false;
                }
                if (nums[i - 1] > nums[i])
                {
                    increasing = false;
                }
            }

            return increasing || decreasing;
        }
    }
}
