using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class FindValueWithBinarySearch
    {
        public int BinarySearch(int[] nums, int target) 
        {
            int start = nums[0];
            int end = nums[nums.Length - 1];


            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (target == mid)
                    return mid;

                if (target > mid)
                    start = mid + 1;
                else if (target < mid)
                {
                    end = mid - 1;
                }
            }

            return -1;
        }
    }
}
