using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    public class _287_FindDuplicateFromIntArray
    {
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();    
            for(int i = 0; i< nums.Length - 1; i++)
            {
                if (result.Contains(nums[i]))
                    return nums[i];
                result.Add(nums[i]);
            }
            return 0;   
        }
    }
}
