using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public static class _27_RemoveElement
    {
        public static void RemoveElements()
        {
            int[] nums = { 3, 2, 2, 3};
            int val = 3;
            int res = RemoveElement(nums, val);
            Console.WriteLine(res);
        }
        private static int RemoveElement(int[] nums, int val)
        {
            int left = 0; // Pointer for elements to keep

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != val)
                {
                    // If the current element is not equal to val, keep it
                    nums[left] = nums[right];
                    left++;
                }
            }

            return left;
        }

    }

}
