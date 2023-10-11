using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal static class _258_AddDigits
    {
        public static void AddDigitsTest()
        {
            int input = 38;
            var res = AddDigits(input);
            Console.WriteLine(res);
        }
        public static int AddDigits(int value)
        {
            var ch =Convert.ToString(value); 
            int sum = 0;
            foreach (var c in ch)
            {
                int val = Convert.ToInt32(c.ToString());
                sum += val;
            }
            if(sum < 10)
            {
                return sum;
            }
            return AddDigits(sum);
        }
    }
}
