using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public static class _26_RemoveDuplicatesFromSortedArray
    {
        public static void RemoveDuplicate() 
        {
            //int[] nums = { 1, 1, 2 };
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var res = RemoveDuplicates(nums);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        private static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int uniqueCount = 1; // Initialize with 1 since the first element is always unique
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueCount] = nums[i]; // Move the unique element to the next position
                    uniqueCount++;
                }
            }

            return uniqueCount;
        }
    }
}
