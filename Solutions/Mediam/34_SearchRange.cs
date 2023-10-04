using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions.Mediam
{
    internal static class _34_SearchRange
    {
        public static void SearchRanges()
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            //int[] nums = { 1 };
            int target = 1;
            var res = SearchRange(nums, target);

        }

            public static int[] SearchRange(int[] nums, int target)
            {
                int[] result = new int[2];
                result[0] = FindFirstOccurrence(nums, target);
                result[1] = FindLastOccurrence(nums, target);
                return result;
            }
            private static int FindFirstOccurrence(int[] nums, int target)
            {
                int left = 0, right = nums.Length - 1;
                int firstOccurrence = -1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] == target)
                    {
                        firstOccurrence = mid;
                        right = mid - 1; // Continue searching in the left half.
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return firstOccurrence;
            }

            private static int FindLastOccurrence(int[] nums, int target)
            {
                int left = 0, right = nums.Length - 1;
                int lastOccurrence = -1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] == target)
                    {
                        lastOccurrence = mid;
                        left = mid + 1; // Continue searching in the right half.
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return lastOccurrence;
            }
    }
}
