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
            int left = 0;
            int right = nums.Length - 1; 

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midVal = nums[mid];     
                if (target == midVal)
                    return mid;

                if (target > midVal)
                    left = mid + 1;
                else if (target < midVal)
                {
                    right = mid - 1;
                }
            }
            return left;
        }
    }
}
