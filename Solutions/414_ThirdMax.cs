using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _414_ThirdMax
    {
        public static void ThirdMaxs()
        {
            int[] input = { 3, 2, 1 }; 
            var res = ThirdMax(input);
        }

        private static int ThirdMax(int[] nums)
        {
            int res = 0;
            List<int> x = nums.Distinct().ToList();
            x = x.OrderBy(item => item).ToList();
            if(x.Count >= 3)
            {
                var sk = x.SkipLast(2);
                res = sk.TakeLast(1).First();
            }
            else
            {
                res = x.Max();
            }
            return res;
        }
    }
}
