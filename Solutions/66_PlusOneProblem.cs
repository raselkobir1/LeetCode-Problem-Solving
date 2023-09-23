using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeProblem.Solutions
{
    public class _66_PlusOneProblem
    {
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            // If we reach here, it means all digits were 9, so we need to create a new array.
            int[] result = new int[n + 1];
            result[0] = 1;

            return result;
        }
    }
}
