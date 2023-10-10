using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class ContainsDuplicate
    {
        public static void ContainsDuplicates()
        {
            int[] input = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
            var res =  ContainsDuplicatee(input);
            Console.WriteLine(res);
        }
        public static bool ContainsDuplicatee(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
