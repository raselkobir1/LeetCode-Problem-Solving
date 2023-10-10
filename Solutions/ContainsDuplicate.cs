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
            //var res =  ContainsDuplicatee(input);
            var res = ContainsDuplicatee1(input);
            Console.WriteLine(res);
        }
        public static bool ContainsDuplicatee1(int[] nums) 
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>(); 
            foreach (int i in nums) 
            {
                if (dictionary.ContainsKey(i))
                {
                    return true;
                }
                else
                {
                    dictionary.Add(i, i);
                }
            }
            return false;
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
