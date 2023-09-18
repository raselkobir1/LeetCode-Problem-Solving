using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Solutions
{
    internal class PalindromeCheck 
    {
        public bool IsPalindrome(int x )
        {
            try
            {
                var LeftToRight = x;
                var reverseData = x.ToString().ToCharArray().Reverse();
                string result = string.Empty;

                foreach (var item in reverseData)
                {
                    result += item; // Use += to concatenate characters to the result.
                }

                int RightToLeft = int.Parse(result); // Use int.Parse to convert the string to an integer.

                if (LeftToRight == RightToLeft)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;   
            }

        }
    }
}
